using CarRentalSystem.Data;
using CarRentalSystem.Data.Entities;
using System.Linq;

namespace CarRentalSystem.Services.Dealers
{
    public class DealerService : IDealerService
    {
        private readonly CarRentalDbContext data;
        public DealerService(CarRentalDbContext data)
            => this.data = data;

        public void Create(string userId, string phoneNumber)
        {
            var dealer = new Dealer
            {
                UserId = userId,
                PhoneNumber = phoneNumber
            };

            this.data.Dealers.Add(dealer);
            this.data.SaveChanges();
        }

        public bool DealerHasRents(string userId)
            => this.data.Cars.Any(c => c.RenterId == userId);

        public bool DealerWithPhoneNumberExists(string phoneNumber)
            => this.data.Dealers.Any(d => d.PhoneNumber == phoneNumber);

        public bool ExistsById(string userId)
            => this.data.Dealers.Any(d => d.UserId == userId);

        public int GetDealerId(string userId)
            => this.data.Dealers.FirstOrDefault(d => d.UserId == userId).Id;
    }
}
