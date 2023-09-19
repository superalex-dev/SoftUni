using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Store
{
    public abstract class Product : IProduct
    {
        private int id;
        private string model;
        private decimal price;
        private int overallPerformance;

        public int Id
        {
            get => id;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The Id is not allowed to be zero or less.");
                }
                id = value;
            }
        }

        public string Model
        {
            get => model;
            private set => model = value;
        }

        public virtual decimal Price
        {
            get => price;
            private set => price = value;
        }

        public virtual int OverallPerformance
        {
            get => overallPerformance;
            private set => overallPerformance = value;
        }

        protected Product(int id, string model, decimal price, int overallPerformance)
        {
            Id = id;
            Model = model;
            Price = price;
            OverallPerformance = overallPerformance;
        }

        public override string ToString()
        {
            return $"Overall Performance: {OverallPerformance}. Price: {Price}: (Id: {Id})";
        }
    }

}
