using CarRentalSystem.Data;
using CarRentalSystem.Data.Entities;
using CarRentalSystem.Models;
using CarRentalSystem.Services.Cars.Models;
using CarRentalSystem.Services.Dealers.Models;
using System.Collections.Generic;
using System.Linq;

namespace CarRentalSystem.Services.Cars
{
    public class CarService : ICarService
    {
        private readonly CarRentalDbContext data;
        public CarService(CarRentalDbContext data)
            => this.data = data;
        public CarQueryServiceModel All(string category = null, string searchTerm = null, CarSorting sorting = CarSorting.Newest, int currentPage = 1, int carsPerPage = 1)
        {
            var carsQuery = this.data.Cars.AsQueryable();

            if (!string.IsNullOrWhiteSpace(category))
            {
                carsQuery = this.data.Cars
                    .Where(c => c.Category.Name == category);
            }
            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                carsQuery = carsQuery.Where(c =>
                    c.Make.ToLower().Contains(searchTerm.ToLower()) ||
                    c.Model.ToLower().Contains(searchTerm.ToLower()) ||
                    c.Description.ToLower().Contains(searchTerm.ToLower()));
            }

            carsQuery = sorting switch
            {
                CarSorting.Price => carsQuery.OrderBy(c => c.PricePerDay),
                CarSorting.NotRenedFirst => carsQuery.OrderBy(c => c.RenterId != null)
                .ThenByDescending(c => c.Id),
                _ => carsQuery.OrderByDescending(c => c.Id)
            };

            var cars = carsQuery
                .Skip((currentPage - 1) * carsPerPage)
                .Take(carsPerPage)
                .Select(c => new CarServiceModel
                {
                    Id = c.Id,
                    Make = c.Make,
                    Model = c.Model,
                    PricePerDay = c.PricePerDay,
                    ImageUrl = c.ImageUrl,
                    IsRented = c.RenterId != null,

                })
                .ToList();

            var totalCars = carsQuery.Count();
            return new CarQueryServiceModel
            {
                TotalCarsCount = totalCars,
                Cars = cars
            };
        }

        public IEnumerable<CarServiceModel> AllCarsByDealerId(int dealerId)
        {
            var cars = this.data.Cars
                .Where(c => c.DealerId == dealerId).ToList();

            return ProjectToModel(cars);
        }

        public IEnumerable<CarServiceModel> AllCarsByUserId(string userId)
        {
            var cars = this.data.Cars
                .Where(c => c.RenterId == userId).ToList();

            return ProjectToModel(cars);
        }

        public IEnumerable<CarCategoryServiceModel> AllCategories()
            => this.data.Categories.Select(c => new CarCategoryServiceModel
            {
                Id = c.Id,
                Name = c.Name
            });

        public IEnumerable<string> AllCategoriesNames()
            => this.data.Categories
            .Select(c => c.Name)
            .Distinct()
            .OrderBy(c => c)
            .ToList();

        public CarDetailsServiceModel CarDetailsById(int id)
            => this.data.Cars
            .Where(c => c.Id == id)
            .Select(c => new CarDetailsServiceModel()
            {
                Id = c.Id,
                Make = c.Make,
                Model = c.Model,
                PricePerDay = c.PricePerDay,
                Description = c.Description,
                ImageUrl = c.ImageUrl,
                IsRented = c.RenterId != null,
                Category = c.Category.Name,
                Dealer = new DealerServiceModel
                {
                    Email = c.Dealer.User.Email,
                    PhoneNumber = c.Dealer.PhoneNumber
                }
            }).FirstOrDefault();


        public bool CarExist(int carId)
            => this.data.Cars.Any(c => c.Id == carId);

        public bool CategoryExist(int categoryId)
            => this.data.Categories.Any(c => c.Id == categoryId);

        public int Create(string make, string model, string description, decimal pricePerDay,
            string imageUrl, int categoryId, int dealerId)
        {
            var newCar = new Car
            {
                Make = make,
                Model = model,
                Description = description,
                PricePerDay = pricePerDay,
                ImageUrl = imageUrl,
                CategoryId = categoryId,
                DealerId = dealerId
            };

            this.data.Cars.Add(newCar);
            this.data.SaveChanges();

            return newCar.Id;
        }

        public void Detete(int carId)
        {
            var car = this.data.Cars.Find(carId);
            this.data.Cars.Remove(car);
            this.data.SaveChanges();
        }

        public void Edit(int carId, string make, string model, string description, decimal pricePerDay,
            string imageUrl, int categoryId)
        {
            var car = this.data.Cars.Find(carId);

            car.Make = make;
            car.Model = model;
            car.Description = description;
            car.PricePerDay = pricePerDay;
            car.ImageUrl = imageUrl;
            car.CategoryId = categoryId;

            this.data.SaveChanges();
        }

        public int GetCategoryById(int carId)
            => this.data.Cars.Find(carId).Id;


        public bool HasDealerWithThisId(int carId, string currentUserId)
        {
            var car = this.data.Cars.FirstOrDefault(c => c.Id == carId);
            var dealer = this.data.Dealers.FirstOrDefault(d => d.Id == car.DealerId);

            if (dealer == null)
            {
                return false;
            }
            if (dealer.UserId != currentUserId)
            {
                return false;
            }

            return true;
        }

        public bool IsRented(int carId)
            => this.data.Cars.Find(carId).RenterId != null;


        public bool IsRentedByUserWithId(int carId, string userId)
        {
            var car = this.data.Cars.FirstOrDefault(c => c.Id == carId);

            if (car == null || car.RenterId != userId)
            {
                return false;
            }

            return true;
        }

        public void Leave(int carId)
        {
            var car = this.data.Cars.FirstOrDefault(c => c.Id == carId);
            car.RenterId = null;
            this.data.SaveChanges();
        }

        public void Rent(int carId, string userId)
        {
            var car = this.data.Cars.FirstOrDefault(c => c.Id == carId);
            car.RenterId = userId;
            this.data.SaveChanges();
        }

        private List<CarServiceModel> ProjectToModel(List<Car> cars)
        {
            var resultCars = cars.Select(c => new CarServiceModel()
            {
                Id = c.Id,
                Make = c.Make,
                Model = c.Model,
                PricePerDay = c.PricePerDay,
                ImageUrl = c.ImageUrl,
                IsRented = c.RenterId != null
            }).ToList();

            return resultCars;
        }
    }
}
