using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaper1
{
    public class Product3
    {
        public string Name { get; private set; }
        public decimal Price { get; private set; }

        public Product3(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public Product3() { }

        public static List<Product3> GetSampleProducts()
        {
            return new List<Product3>
            {
                // 基于属性的初始化
                new Product3 { Name="12", Price=12m },
                new Product3 { Name="12", Price=12m },
                new Product3 { Name="12", Price=12m },
            };
        }

        public override string ToString()
        {
            return string.Format("{0}: {1}", Name, Price);
        }
    }
}
