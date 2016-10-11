using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chaper3
{
    public class _5_12
    {
        static MethodInvoker CreateDelegateInstance()
        {
            int counter = 5;

            MethodInvoker ret = delegate
            {
                Console.WriteLine(counter);
                counter++;
            };

            Console.WriteLine(counter);

            ret();
            return ret;
        }

        public static void Test()
        {
            MethodInvoker x = CreateDelegateInstance();
            x();
            x();
        }
    }
}
