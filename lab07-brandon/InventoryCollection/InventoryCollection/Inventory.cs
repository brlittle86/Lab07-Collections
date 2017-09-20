using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace InventoryCollection
{
    class Inventory<Product> : IEnumerable<Product>
    {
        Product[] products = new Product[10];
        int count = 0;

        public void Add(Product item)
        {
            if (count == products.Length)
            {
                Array.Resize(ref products, products.Length * 2);
            }
            products[count++] = item;
        }

        public void Remove(Product item)
        {
            Product[] temporary = new Product[(count - 1)];
            int tempCount = 0;
            foreach (Product product in products)
            {
                if (!product.Equals(item))
                {
                    temporary[tempCount] = product;
                    tempCount++;
                }
            }
            products = temporary;
            count--;
        }

        public void View()
        {
            foreach (Product item in products)
            {
                PropertyInfo property = typeof(Product).GetProperty("Name");
                Console.WriteLine(property.GetValue(item));
            }
        }

        public IEnumerator<Product> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return products[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
