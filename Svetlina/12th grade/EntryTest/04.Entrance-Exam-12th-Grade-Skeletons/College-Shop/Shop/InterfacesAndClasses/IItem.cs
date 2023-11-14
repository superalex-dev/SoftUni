using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.InterfacesAndClasses
{
    public interface IItem
    {
        int Count { get; }
        decimal Price { get; }
        string Color { get; }
    }
}
