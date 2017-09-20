using System;

namespace InventoryCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory<Product> waterBalloons = new Inventory<Product>
            {
                new Product("Blue") { ItemSize = Size.Small },
                new Product("Green") { ItemSize = Size.Medium },
                new Product("Yellow") { ItemSize = Size.Large },
                new Product("Orange") { ItemSize = Size.XL },
                new Product("Purple") { ItemSize = Size.Medium },
                new Product("Red") { ItemSize = Size.Large },
                new Product("Indigo") { ItemSize = Size.XL },
                new Product("Neon Blue") { ItemSize = Size.Large },
                new Product("Neon Green") { ItemSize = Size.Small },
                new Product("Neon Yellow") { ItemSize = Size.Small }
            };

            waterBalloons.View();

            Console.Read();
        }
    }
}
