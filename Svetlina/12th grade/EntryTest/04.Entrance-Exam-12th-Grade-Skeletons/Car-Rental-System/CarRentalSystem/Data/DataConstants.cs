
namespace CarRentalSystem.Data
{
    public class DataConstants
    {
        public class Car
        {
            public const int MakeMaxLenght = 50;
            public const int MakeMinLenght = 2;

            public const int ModelMaxLenght = 50;
            public const int ModelMinLenght = 2;
        }
        public class Category
        {
            public const int NameMaxLenght = 50;
        }
        public class Dealer
        {
            public const int PhoneNumberMaxLenght = 15;
            public const int PhoneNumberMinLenght = 10;
        }
        public class Price
        {
            public const int PriceMax = 200000;
        }
    }
}
