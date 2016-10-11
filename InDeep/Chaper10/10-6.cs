using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaper10
{
    public class _10_6
    {
        public static void Test()
        {
            var collection = Enumerable.Range(0, 10);

            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
