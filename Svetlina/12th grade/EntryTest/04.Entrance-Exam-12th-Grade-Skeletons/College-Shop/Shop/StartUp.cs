//using Shop.InterfacesAndClasses;
using Shop.InterfacesAndClasses;
using System;

namespace Shop
{
   public class StartUp
    {
        static void Main()
        {
            Basket basket = new Basket();
            basket.AddItem("Cup", "Blue", 2, "250");
            basket.AddItem("Shirt", "Green", 3, "Long sleeve");
            decimal basketTotal = basket.GetTotalPrice();
            Console.WriteLine($"Total price: {basketTotal:F2}");
            Console.WriteLine(basket);
        }
    }
}
