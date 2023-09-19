using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Store
{
    public class HybridLaptop : Laptop
    {
        public HybridLaptop(int id, string model, decimal price)
            : base(id, model, price, 15)
        {
        }
    }
}
