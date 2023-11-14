using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.InterfacesAndClasses
{
    public class Basket
    {
        public ICollection<IItem> items = new List<IItem>();


        public void AddItem(string type, string color, int count, string sleeveOrVolume)
        {
            switch (type)
            {
                case "Cup":
                    items.Add(new Cup((decimal)Prices.Cup, color, count, int.Parse(sleeveOrVolume)));
                    break;

                case "Shirt":
                    items.Add(new Shirt((decimal)Prices.Shirt, color, count, sleeveOrVolume));
                    break;

                default:
                    throw new ArgumentException($"Invalid item type: {type}");
            }
        }

        public decimal GetTotalPrice()
        {
            return items.Sum(item => item.Price * item.Count);
        }

        public override string ToString()
        {
            var output = "Your basket contains:\n";
            foreach (var item in items)
            {
                output += $" Item: {item.GetType().Name}. Count: {item.Count}. Total Price - {item.Price * item.Count:F2} lv.\n";
            }

            return output;
        }
    }
}
