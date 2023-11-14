using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.InterfacesAndClasses
{
    public class Cup : Item
    {
        public int Volume { get; set; }

        public Cup(decimal price, string color, int count, int volume)
            : base(price, color, count)
        {
            this.Volume = volume;
        }
    }
}
