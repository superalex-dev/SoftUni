using Computer_Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Store
{
    public class ComputerStore
    {
        private List<IProduct> products;

        public ComputerStore()
        {
            products = new List<IProduct>();
        }

        public void AddLaptop(ILaptop laptop)
        {
            products.Add(laptop);
        }

        public void AddHardware(int laptopId, IHardware hardware)
        {
            ILaptop laptop = (ILaptop)products.FirstOrDefault(p => p.Id == laptopId);
            if (laptop == null)
            {
                throw new ArgumentException($"Laptop with Id {laptopId} does not exist.");
            }

            laptop.AddHardware(hardware);
        }

        public string Buy()
        {
            string result = string.Join(Environment.NewLine, products);
            products.Clear();
            return result;
        }
    }
}
