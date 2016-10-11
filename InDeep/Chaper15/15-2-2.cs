using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Chaper15
{
    public class _15_2_2
    {
        static async Task<int> GetPageLengthAsync(string url)
        {
            using (HttpClient clinet = new HttpClient())
            {
                Task<string> fetchTextTask = clinet.GetStringAsync(url);
                int length = (await fetchTextTask).Length;
                return length;
            }
        }

        public static void Test()
        {
            Task<int> lengthTask = GetPageLengthAsync("http://csharpindepth.com/");
            Console.WriteLine(lengthTask.Result);
        }
    }
}
