using CarRentalSystem.Services.Home;
using Microsoft.AspNetCore.Mvc;

namespace CarRentalSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHomeService cars;
        public HomeController(IHomeService cars)
            => this.cars = cars;
        public IActionResult Index()
        {
            var carsIndex = this.cars.LastThreeCars();

            return View(carsIndex);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error(int statusCode)
        {
            if (statusCode == 400)
            {
                return View("Error400");
            }

            if (statusCode == 401)
            {
                return View("Error401");
            }

            return View();
        }

    }
}
