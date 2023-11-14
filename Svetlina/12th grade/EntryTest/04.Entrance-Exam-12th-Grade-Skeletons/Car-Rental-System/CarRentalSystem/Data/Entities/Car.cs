using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static CarRentalSystem.Data.DataConstants.Car;

namespace CarRentalSystem.Data.Entities
{
    public class Car
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(MakeMaxLenght)]
        public string Make { get; set; }

        [Required]
        [MaxLength(ModelMaxLenght)]
        public string Model { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [Column(TypeName = "decimal(12,3)")]
        public decimal PricePerDay { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        [Required]
        public int DealerId { get; set; }
        public Dealer Dealer { get; set; }
        public string RenterId { get; set; }

    }
}
