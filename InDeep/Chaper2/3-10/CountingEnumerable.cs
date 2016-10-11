using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaper2._3_10
{
    class CountingEnumerable : IEnumerable<int>
    {
        public IEnumerator<int> GetEnumerator()
        {
            return new CountingEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    class CountingEnumerator : IEnumerator<int>
    {
        int current = -1;
        public int Current
        {
            get
            {
                return current;
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            current++;
            return current < 10;
        }

        public void Reset()
        {
            current = -1;
        }
    }

    public class C_3_10
    {
        public static void Test()
        {
            CountingEnumerable counter = new _3_10.CountingEnumerable();
            foreach (var item in counter)
            {
                Console.WriteLine(item);
            }
        }
    }
}
