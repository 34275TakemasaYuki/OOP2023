using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Exercise03 {
    class Program {
        static void Main(string[] args) {
            var tw = new TimeWatch();
            Console.Write("スタート？");
            Console.ReadLine();
            var startTime = tw.Start();
            //Thread.Sleep(1000);

            Console.Write("ストップ？");
            Console.ReadLine();

            TimeSpan duration = tw.Stop(startTime);
            Console.WriteLine("処理時間は{0}秒でした", duration.TotalSeconds);
        }
    }
}
