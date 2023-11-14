using static CarRentalSystem.Data.DataConstants.Dealer;
using System.ComponentModel.DataAnnotations;

namespace CarRentalSystem.Models.Dealers
{
    public class BecomeDealerFormModel
    {
        [Required]
        [Phone]
        [StringLength(PhoneNumberMaxLenght, MinimumLength = PhoneNumberMinLenght)]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
    }
}
