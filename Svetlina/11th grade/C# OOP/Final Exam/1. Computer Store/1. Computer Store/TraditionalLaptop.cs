using Computer_Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Store
{

    public class TraditionalLaptop : Laptop
    {
        public TraditionalLaptop(int id, string model, decimal price)
             : base(id, model, price, 20)
        {
        }
    }
}
