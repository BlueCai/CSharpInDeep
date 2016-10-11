using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chaper3
{
    public class _5_11
    {
        public static void Test()
        {
            string captured = "before x is created";

            MethodInvoker x = delegate ()
            {
                Console.WriteLine(captured);
                captured = "changed by x";
            };

            captured = "directly before x is invoked";

            x();

            Console.WriteLine(captured);

            captured = "before second invocation";

            x();

            Console.WriteLine(captured);


        }
    }
}
