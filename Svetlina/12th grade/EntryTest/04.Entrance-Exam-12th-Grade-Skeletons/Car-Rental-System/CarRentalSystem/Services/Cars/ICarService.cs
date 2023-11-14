using CarRentalSystem.Models;
using CarRentalSystem.Services.Cars.Models;
using System.Collections.Generic;

namespace CarRentalSystem.Services.Cars
{
    public interface ICarService
    {
        CarQueryServiceModel All(
            string category = null,
            string searchTerm = null,
            CarSorting sorting = CarSorting.Newest,
            int currentPage = 1,
            int carsPerPage = 1);
        IEnumerable<string> AllCategoriesNames();
        IEnumerable<CarServiceModel> AllCarsByDealerId(int dealerId);
        IEnumerable<CarServiceModel> AllCarsByUserId(string userId);
        bool CarExist(int carId);
        CarDetailsServiceModel CarDetailsById(int id);
        IEnumerable<CarCategoryServiceModel> AllCategories();
        bool CategoryExist(int categoryId);
        int Create(string make, string model, string description, decimal pricePerDay, string imageUrl,
            int categoryId, int dealerId);
        bool HasDealerWithThisId(int carId, string currentUserId);
        int GetCategoryById(int carId);
        void Edit(int carId, string make, string model, string description, decimal pricePerDay,
            string imageUrl, int categoryId);
        void Detete(int carId);

        bool IsRented(int carId);
        bool IsRentedByUserWithId(int carId, string userId);
        void Rent(int carId, string userId);
        void Leave(int carId);
    }
}
