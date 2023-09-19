using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Store
{
    public interface IProduct
    {
        int Id { get; }
        string Model { get; }
        decimal Price { get; }
        int OverallPerformance { get; }
    }
}
