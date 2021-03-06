﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaper6
{
    public class _6_5
    {
        static readonly string Padding = new string(' ', 30);
        static IEnumerable<int> CreateEnumerable()
        {
            Console.WriteLine("{0} Start of CreateEnumberable() ", Padding);

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("{0} About to yeild {1}", Padding, i);
                yield return i;
                Console.WriteLine("{0} After yield", Padding);
            }

            Console.WriteLine("{0} Yielding final value", Padding);

            yield return -1;

            Console.WriteLine("{0} End of CreateEnumerable()", Padding);
        }

        public static void Test()
        {
            IEnumerable<int> iterable = CreateEnumerable();
            IEnumerator<int> iterator = iterable.GetEnumerator();

            Console.WriteLine("Starting to iterate");

            while (true)
            {
                Console.WriteLine("Calling MoveNext()...");

                bool result = iterator.MoveNext();

                Console.WriteLine("... MoveNext result = {0}", result);
                if (!result)
                {
                    break;
                }

                Console.WriteLine("Fetching Current...");
                Console.WriteLine("... Current result = {0}", iterator.Current);
            }
        }
    }
}
