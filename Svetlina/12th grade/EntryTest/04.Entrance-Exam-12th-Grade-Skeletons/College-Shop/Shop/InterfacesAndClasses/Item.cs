using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.InterfacesAndClasses
{
    public class Item : IItem
    {   
        public int Count { get; set; }
        public decimal Price { get; set; }
        public string Color { get; set; }

        public Item(decimal price, string color, int count)
        {
            this.Price = price;
            this.Color = color;
            this.Count = count;
        }
    }
}
