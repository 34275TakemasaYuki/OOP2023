using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise04 {
    class Program {
        static void Main(string[] args) {
            var line = "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886";
            var words = line.Split('=', ';');

            Console.WriteLine("作家　：" + words[1]);
            Console.WriteLine("代表作：" + words[3]);
            Console.WriteLine("誕生年：" + words[5]);
        }
    }
}
