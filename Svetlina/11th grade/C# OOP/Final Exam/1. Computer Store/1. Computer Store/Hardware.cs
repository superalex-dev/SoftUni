using Computer_Store;
using System.Diagnostics;
using System.Reflection;

namespace Computer_Store
{

    public class Hardware : Product, IHardware
    {
        private int generation;

        public int Generation
        {
            get => generation;
            private set => generation = value;
        }

        public Hardware(int id, string model, decimal price, int overallPerformance, int generation)
            : base(id, model, price, overallPerformance)
        {
            if (id <= 0)
            {
                throw new ArgumentException("The Id is not allowed to be zero or less.");
            }

            Generation = generation;
        }

        public override string ToString()
        {
            return $"Model: {Model} with: Overall Performance: {OverallPerformance}. Price: {Price} (Id: {Id}) Generation: {Generation}";
        }
    }
}