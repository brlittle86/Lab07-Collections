using System;

namespace InventoryCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate a bunch of Products
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

            //instantiate an Inventory and fill it with some Products
            Inventory<Product> waterBalloons = new Inventory<Product>
            {
                blue,
                green,
                yellow
            };
            
            //use Add() to put the rest of the Products in the Inventory
            waterBalloons.Add(orange);
            waterBalloons.Add(purple);
            waterBalloons.Add(red);
            waterBalloons.Add(indigo);
            waterBalloons.Add(neonBlue);
            waterBalloons.Add(neonGreen);
            waterBalloons.Add(neonYellow);

            //Display the contents of waterBalloons in the Console
            waterBalloons.View();
            Console.WriteLine();

            //Effectively deletes a Product from the Inventory
            waterBalloons.Remove(purple);
            waterBalloons.View();
            Console.WriteLine();

            //Instantiate a new Product and add it to the Inventory before displaying the Inventory's contents again
            Product neonOrange = new Product("Neon Orange") { ItemSize = Size.XL };
            waterBalloons.Add(neonOrange);
            waterBalloons.View();

            Console.Read();
        }
    }
}
