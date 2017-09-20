using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace InventoryCollection
{
    class Inventory<T> : IEnumerable<T>
    {
        T[] products = new T[10];
        int count = 0;

        public void Add(T item)
        {
            if (count == products.Length)
            {
                Array.Resize(ref products, products.Length * 2);
            }
            products[count++] = item;
        }

        public void Remove(T item)
        {
            T[] temporary = new T[(count - 1)];
            int tempCount = 0;
            foreach (T product in products)
            {
                if (product != null)
                {
                    if (!product.Equals(item))
                    {
                        temporary[tempCount] = product;
                        tempCount++;
                    } 
                }
            }
            products = temporary;
            count--;
        }

        public void View()
        {
            foreach (T item in products)
            {
                if (item != null)
                {
                    PropertyInfo property = typeof(Product).GetProperty("Name");
                    Console.WriteLine(property.GetValue(item)); 
                }
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return products[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
