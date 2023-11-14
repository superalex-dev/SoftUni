using System.Collections.Generic;

namespace CarRentalSystem.Services.Cars.Models
{
    public class CarQueryServiceModel
    {
        public int TotalCarsCount { get; set; }

        public IEnumerable<CarServiceModel> Cars { get; set; } 
            = new List<CarServiceModel>();
    }
}
