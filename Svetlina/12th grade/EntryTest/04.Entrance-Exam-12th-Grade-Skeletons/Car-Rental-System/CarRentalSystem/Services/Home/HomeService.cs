using CarRentalSystem.Data;
using CarRentalSystem.Services.Home.Models;
using System.Collections.Generic;
using System.Linq;

namespace CarRentalSystem.Services.Home
{
    public class HomeService : IHomeService
    {
        private readonly CarRentalDbContext data;
        public HomeService(CarRentalDbContext data) 
            => this.data = data;
        public IEnumerable<CarIndexServiceModel> LastThreeCars() 
            => this.data.Cars
            .OrderByDescending(c => c.Id)
            .Select(c => new CarIndexServiceModel
            {
                Id = c.Id,
                Make = c.Make,
                Model = c.Model,
                ImageUrl = c.ImageUrl
            })
            .Take(3);

    }
}
