using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace InventoryCollection
{
    class Inventory<Product> : IEnumerable<Product>
    {
        Product[] products = new Product[10];
        int count = 0;

        public void Add(Product item)
        {
            Product[] temp = new Product[(count + 1)];
            int tempCount = 0;
            foreach (Product product in products)
            {
                temp[tempCount] = product;
                tempCount++;
            }
            products = temp;
            products[count] = item;
            count++;
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
                Console.WriteLine(item);
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
