using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryCollection
{
    class Product
    {
        public string Name { get; set; }
        public string ItemSize { get; set; }

        public Product(string name)
        {
            Name = name;
        }
    }

    enum Size
    {
        Small,
        Medium,
        Large,
        XL
    }
}
