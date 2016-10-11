using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chaper3
{
    public class _5_13
    {
        public static void Test()
        {
            List<MethodInvoker> list = new List<MethodInvoker>();

            for (int i = 0; i < 5; i++)
            {
                int counter = i * 5;
                list.Add(delegate {
                    Console.WriteLine(counter);
                    counter++;
                });
            }

            foreach (MethodInvoker t in list)
            {
                t();
            }

            list[0]();
            list[0]();
            list[0]();

            list[1]();
        }
    }
}
