using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaper1
{
    public class Product4
    {
        readonly string name;
        public string Name { get { return name; } }

        readonly decimal price;
        public decimal Price { get { return price; } }

        public Product4(string name, decimal price)
        {
            this.name = name;
            this.price = price;
        }

        public List<Product4> GetSampleProducts()
        {
            return new List<Product4>
            {
                new Product4(name: "12", price: 12m),
                new Product4(name: "12", price: 12m),
                new Product4(name: "12", price: 12m),
            };
        }

        public override string ToString()
        {
            return string.Format("{0}: {1}", name, price);
        }
    }
}
