using static CarRentalSystem.Data.DataConstants.Car;
using static CarRentalSystem.Data.DataConstants.Price;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel;
using CarRentalSystem.Services.Cars.Models;

namespace CarRentalSystem.Models.Cars
{
    public class CarFormModel
    {
        [Required]
        [StringLength(MakeMaxLenght, MinimumLength = MakeMinLenght)]
        public string Make { get; set; }

        [Required]
        [StringLength(ModelMaxLenght, MinimumLength = ModelMinLenght)]
        public string Model { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [DisplayName("Price Per Day")]
        [Range(00.00, PriceMax,
            ErrorMessage = "Price must be a posotive number and less than {2} leva.")]
        public decimal PricePerDay { get; set; }

        [Required]
        [DisplayName("Image Url")]
        public string ImageUrl { get; set; }

        [DisplayName("Category")]
        public int CategoryId { get; set; }

        public IEnumerable<CarCategoryServiceModel> Categories = new List<CarCategoryServiceModel>();
    }
}
