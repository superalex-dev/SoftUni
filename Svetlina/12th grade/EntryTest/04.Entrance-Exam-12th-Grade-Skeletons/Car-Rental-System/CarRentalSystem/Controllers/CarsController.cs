using CarRentalSystem.Models.Cars;
using CarRentalSystem.Infrastructure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CarRentalSystem.Services.Cars;
using CarRentalSystem.Services.Dealers;
using CarRentalSystem.Services.Cars.Models;

namespace CarRentalSystem.Controllers
{
    public class CarsController : Controller
    {

        private readonly ICarService cars;
        private readonly IDealerService dealers;
        public CarsController(ICarService cars, IDealerService dealers)
        {

            this.cars = cars;
            this.dealers = dealers;
        }
        public IActionResult All([FromQuery] AllCarsQueryModel query)
        {
            var queryResult = this.cars.All(
                query.Category,
                query.SearchTerm,
                query.Sorting,
                query.CurrentPage,
                AllCarsQueryModel.CarsPerPage
                );

            query.Categories = this.cars.AllCategoriesNames();
            query.TotalCarsCount = queryResult.TotalCarsCount;
            query.Cars = queryResult.Cars;

            return View(query);

        }

        // Should return a view with current user's cars as a model. 
        // Method should be accessible for authorized users only.
        [Authorize]
        public IActionResult Mine()
        {
            IEnumerable<CarServiceModel> myCars = null;
            var userId = this.User.Id();

            if (this.dealers.ExistsById(userId))
            {
                var thisDealerId = this.dealers.GetDealerId(userId);
                myCars = this.cars.AllCarsByDealerId(thisDealerId);
            }
            else
            {
                myCars = this.cars.AllCarsByUserId(userId);
            }

            return View(myCars);
        }
        public IActionResult Details(int id)
        {

            if (!this.cars.CarExist(id))
            {
                return BadRequest();
            }

            var carModel = this.cars.CarDetailsById(id);

            return View(carModel);
        }

        // Should return a view with a form for adding a car  
        // Should be accessible to authorized users only
        [Authorize]
        public IActionResult Add()
        {
            var userId = this.User.Id();
            if (!this.dealers.ExistsById(userId))
            {
                return RedirectToAction(nameof(DealersController.Become), "Dealers");
            }

            return View(new CarFormModel
            {
                Categories = this.cars.AllCategories()
            });
        }


        // Should accept a model and add a car to the database. 
        // Then, it should redirect to the "Car Details" page of the created car. 
        // It should be invoked on a "POST" request to "/Cars/Add"  
        // Should be accessible to authorized users only
        [HttpPost]
        [Authorize]
        public IActionResult Add(CarFormModel car)
        {
            var userId = this.User.Id();
            if (!this.dealers.ExistsById(userId))
            {
                return RedirectToAction(nameof(DealersController.Become), "Dealers");
            }
            if (!this.cars.CategoryExist(car.CategoryId))
            {
                this.ModelState.AddModelError(nameof(car.CategoryId), "Category does not exist.");
            }
            if (!ModelState.IsValid)
            {
                car.Categories = this.cars.AllCategories();

                return View(car);
            }

            var dealerId = this.dealers.GetDealerId(userId);

            var newCarId = this.cars.Create(car.Make, car.Model, car.Description, car.PricePerDay,
                car.ImageUrl, car.CategoryId, dealerId);



            return RedirectToAction(nameof(Details), new { id = newCarId });
        }

        // Should accept a model and edit a car with a given id.
        // Then, it should redirect to the "Car Details" page of the created car.
        // It should be invoked on a "POST" request to "/Cars/Edit/{id}"  
        // Should be accessible to authorized users only

        [Authorize]
        public IActionResult Edit(int id)
        {
            var userId = this.User.Id();

            if (!this.cars.CarExist(id))
            {
                return BadRequest();
            }

            if (!this.cars.HasDealerWithThisId(id, userId))
            {
                return Unauthorized();
            }

            var car = this.cars.CarDetailsById(id);
            var categoryId = this.cars.GetCategoryById(id);

            var carToEdit = new CarFormModel
            {
                Make = car.Make,
                Model = car.Model,
                Description = car.Description,
                PricePerDay = car.PricePerDay,
                ImageUrl = car.ImageUrl,
                CategoryId = categoryId,
                Categories = this.cars.AllCategories()
            };

            return View(carToEdit);
        }

        [HttpPost]
        [Authorize]
        public IActionResult Edit(int id, CarFormModel car)
        {
            var userId = this.User.Id();

            if (!this.cars.CarExist(id))
            {
                return BadRequest();
            }

            if (!this.dealers.ExistsById(userId) && !this.cars.HasDealerWithThisId(id, userId))
            {
                return Unauthorized();
            }

            var carCategory = this.cars.GetCategoryById(id);

            if (!this.cars.CategoryExist(carCategory))
            {
                this.ModelState.AddModelError(nameof(car.CategoryId), "Category does not exist.");
            }

            if (!ModelState.IsValid)
            {
                car.Categories = this.cars.AllCategories();
                return View(car);
            }

            this.cars.Edit(id, car.Make, car.Model, car.Description, car.PricePerDay,
                car.ImageUrl, car.CategoryId);

            return RedirectToAction(nameof(Details), new { id = id });
        }

        // Should return a view with the details of the car for deleting. 
        // Should be accessible to authorized users only.
        [Authorize]
        public IActionResult Delete(int id)
        {
            var userId = this.User.Id();

            if (!this.cars.CarExist(id))
            {
                return BadRequest();
            }

            if (!this.dealers.ExistsById(userId) || !this.cars.HasDealerWithThisId(id, userId))
            {
                return Unauthorized();
            }
            var car = this.cars.CarDetailsById(id);

            var model = new CarViewModel()
            {
                Make = car.Make,
                Model = car.Model,
                ImageUrl = car.ImageUrl
            };

            return View(model);
        }

        // Should accept a model and delete the model car. 
        // Then, it should redirect to the "All" page with all user's rented cars. 
        // It should be invoked on a "POST" request to "/Cars/Delete/{id}". 
        // Should be accessible to authorized users only.
        [HttpPost]
        [Authorize]
        public IActionResult Delete(CarViewModel car)
        {
            var userId = this.User.Id();

            if (!this.cars.CarExist(car.Id))
            {
                return BadRequest();
            }

            if (!this.dealers.ExistsById(userId) || !this.cars.HasDealerWithThisId(car.Id, userId))
            {
                return Unauthorized();
            }

            this.cars.Detete(car.Id);

            return RedirectToAction(nameof(All));
        }

        // Should add a car rent to the database.
        // It should be invoked on a "POST" request to "/Cars/Rent/{id}" 
        // Should be accessible to authorized users only
        [HttpPost]
        [Authorize]
        public IActionResult Rent(int id)
        {
            var userId = this.User.Id();

            if (!cars.CarExist(id))
            {
                return BadRequest();
            }

            if (this.dealers.ExistsById(userId))
            {
                return Unauthorized();
            }

            if (this.cars.IsRented(id))
            {
                return BadRequest();
            }

            this.cars.Rent(id, userId);

            return RedirectToAction(nameof(Mine));
        }

        // Should delete a car rent.
        // It should be invoked on a "POST" request to "/Cars/Leave/{id}" 
        // Should be accessible to authorized users only
        [HttpPost]
        [Authorize]
        public IActionResult Leave(int id)
        {
            var userId = this.User.Id();

            if (!this.cars.CarExist(id))
            {
                return BadRequest();
            }

            if (!this.cars.IsRentedByUserWithId(id, userId))
            {
                return Unauthorized();
            }

            this.cars.Leave(id);

            return RedirectToAction(nameof(Mine));
        }
    }
}
