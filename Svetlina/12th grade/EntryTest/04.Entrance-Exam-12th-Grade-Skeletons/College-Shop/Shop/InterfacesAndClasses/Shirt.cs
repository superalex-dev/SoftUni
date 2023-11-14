using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.InterfacesAndClasses
{
    public class Shirt : Item
    {
        public string Sleeve { get; set; }

        public Shirt(decimal price, string color, int count, string sleeve)
            : base(price, color, count)
        {
            this.Sleeve = sleeve;
        }
    }
}
