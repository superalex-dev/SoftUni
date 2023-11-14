using CarRentalSystem.Services.Dealers.Models;

namespace CarRentalSystem.Services.Cars.Models
{
    public class CarDetailsServiceModel : CarServiceModel
    {
        public string Description { get; set; }
        public string Category { get; set; }
        public DealerServiceModel Dealer { get; set; }
    }
}
