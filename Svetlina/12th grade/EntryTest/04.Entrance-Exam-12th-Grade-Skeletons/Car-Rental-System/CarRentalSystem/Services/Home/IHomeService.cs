using CarRentalSystem.Services.Home.Models;
using System.Collections.Generic;

namespace CarRentalSystem.Services.Home
{
    public interface IHomeService
    {
        IEnumerable<CarIndexServiceModel> LastThreeCars();
    }
}
