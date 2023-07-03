using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {
    class Program {
        static void Main(string[] args) {
            var tw = new TimeWatch();
            var startTime = tw.Start();

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("test");
            }
            TimeSpan duration = tw.Stop(startTime);
            Console.WriteLine("処理時間は{0}ミリ秒でした", duration.TotalMilliseconds);
        }
    }
}
