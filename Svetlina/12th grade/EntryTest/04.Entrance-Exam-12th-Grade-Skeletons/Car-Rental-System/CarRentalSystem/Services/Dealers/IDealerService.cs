
namespace CarRentalSystem.Services.Dealers
{
    public interface IDealerService
    {
        int GetDealerId(string userId);
        bool ExistsById(string userId);
        bool DealerWithPhoneNumberExists(string phoneNumber);
        bool DealerHasRents(string userId);
        void Create(string userId, string phoneNumber);
    }
}
