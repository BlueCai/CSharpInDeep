using System.Collections;

namespace Chaper1
{
    public class Product1
    {
        private string name;
        public string Name { get { return name; } }

        private decimal price;
        public decimal Price { get { return price; } }

        public Product1(string name, decimal price)
        {
            this.name = name;
            this.price = price;
        }

        public static ArrayList GetSampleProducts()
        {
            ArrayList list = new ArrayList();
            list.Add(new Product1("test1", 12m));
            list.Add(new Product1("test2", 12m));
            list.Add(new Product1("test3", 12m));

            return list;
        }

        public override string ToString()
        {
            return string.Format("{0}:{1}", name, price);
        }
    }
}