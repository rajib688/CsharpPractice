using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threading
{
    public class Processing
    {
        public async Task<int> Sum(int a, int b )
        {
            //using var fs = File.Open("Hello.txt", FileMode.OpenOrCreate);
            //fs.WriteAsync(new byte[] { });
            await LoopAsync();
            return a + b;
        }

        public async Task LoopAsync()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine(i);
                }
            });
        }
    }
}
