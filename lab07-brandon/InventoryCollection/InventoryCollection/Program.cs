using System;

namespace InventoryCollection
{
    class Program
    {
        static void Main(string[] args)
        {

            Product blue = new Product("Blue") { ItemSize = Size.Small };
            Product green = new Product("Green") { ItemSize = Size.Medium };
            Product yellow = new Product("Yellow") { ItemSize = Size.Large };
            Product orange = new Product("Orange") { ItemSize = Size.XL };
            Product purple = new Product("Purple") { ItemSize = Size.Medium };
            Product red = new Product("Red") { ItemSize = Size.Large };
            Product indigo = new Product("Indigo") { ItemSize = Size.XL };
            Product neonBlue = new Product("Neon Blue") { ItemSize = Size.Large };
            Product neonGreen = new Product("Neon Green") { ItemSize = Size.Small };
            Product neonYellow = new Product("Neon Yellow") { ItemSize = Size.Small };

            Inventory<Product> waterBalloons = new Inventory<Product>
            {
                blue,
                green,
                yellow
            };
            
            waterBalloons.Add(orange);
            waterBalloons.Add(purple);
            waterBalloons.Add(red);
            waterBalloons.Add(indigo);
            waterBalloons.Add(neonBlue);
            waterBalloons.Add(neonGreen);
            waterBalloons.Add(neonYellow);

            waterBalloons.View();
            Console.WriteLine();
            waterBalloons.Remove(purple);
            waterBalloons.View();
            Console.WriteLine();
            Product neonOrange = new Product("Neon Orange") { ItemSize = Size.XL };
            waterBalloons.Add(neonOrange);
            waterBalloons.View();

            Console.Read();
        }
    }
}
