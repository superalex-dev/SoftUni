using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using static CarRentalSystem.Data.DataConstants.Category;

namespace CarRentalSystem.Data.Entities
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLenght)]
        public string Name { get; set; }

        public IEnumerable<Car> Cars { get; init; } = new List<Car>();
    }
}
