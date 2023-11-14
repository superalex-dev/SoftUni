using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using static CarRentalSystem.Data.DataConstants.Dealer;

namespace CarRentalSystem.Data.Entities
{
    public class Dealer
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(PhoneNumberMaxLenght)]
        public string PhoneNumber { get; set; }

        [Required]
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

    }
}
