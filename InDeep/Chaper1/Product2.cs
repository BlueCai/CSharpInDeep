using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaper1
{
    /// <summary>
    /// 注意：
    /// 1. 在C# 2 中最重要的新功能就是泛型的引入
    /// 2. 引入泛型解决了ArrayList中的类型安全问题
    /// 3. 添加了私有的属性赋值方法
    /// </summary>
    public class Product2
    {
        string name;
        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        decimal price;
        public decimal Price
        {
            get { return price; }
            private set { price = value; }
        }

        public Product2(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public List<Product2> GetSampleProducts()
        {
            List<Product2> list = new List<Chaper1.Product2>();
            list.Add(new Product2("test1", 12m));
            list.Add(new Product2("test1", 12m));
            list.Add(new Product2("test1", 12m));

            return list;
        }

        public override string ToString()
        {
            return string.Format("{0}: {1}", name, price);
        }
    }
}
