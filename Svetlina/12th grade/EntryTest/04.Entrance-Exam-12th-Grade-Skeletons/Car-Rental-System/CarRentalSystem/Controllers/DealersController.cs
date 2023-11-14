using CarRentalSystem.Infrastructure;
using CarRentalSystem.Models.Dealers;
using CarRentalSystem.Services.Dealers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CarRentalSystem.Controllers
{
    public class DealersController : Controller
    {
        private readonly IDealerService dealers;
        public DealersController(IDealerService dealers)
            => this.dealers = dealers;


        [Authorize]
        public IActionResult Become()
        {
            if (this.dealers.ExistsById(this.User.Id()))
            {
                return BadRequest();
            }

            return View();
        }

        [HttpPost]
        [Authorize]
        public IActionResult Become(BecomeDealerFormModel dealer)
        {
            var uderId = this.User.Id();

            if (this.dealers.ExistsById(uderId))
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return View(dealer);
            }

            if (this.dealers.DealerWithPhoneNumberExists(dealer.PhoneNumber))
            {
                ModelState.AddModelError(nameof(dealer.PhoneNumber),
                    "Phone number already exists. Enter another one.");
            }

            if (this.dealers.DealerHasRents(uderId))
            {
                ModelState.AddModelError("Error",
                    "You should have no rents to become a dealer!");
            }

            this.dealers.Create(uderId, dealer.PhoneNumber);

            return RedirectToAction(nameof(CarsController.All), "Cars");
        }
    }
}
