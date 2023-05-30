using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            var names = new List<string> {
                 "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong",
            };
            Exercise2_1(names);
            Console.WriteLine();
            Exercise2_2(names);
            Console.WriteLine();
            Exercise2_3(names);
            Console.WriteLine();
            Exercise2_4(names);
        }

        private static void Exercise2_1(List<string> names) {
            Console.WriteLine("*****3-1*****");
            int index = -1;
            Console.WriteLine("都市名を入力。空行で終了");
            var line = Console.ReadLine();
            while (line != "")
            {
                index = names.FindIndex(s => s == line);
                Console.WriteLine(index);
                line = Console.ReadLine();
            }
        }

        private static void Exercise2_2(List<string> names) {
            Console.WriteLine("*****3-2*****");
            var count = names.Count(s => s.Contains("o"));
            Console.WriteLine(count);
        }

        private static void Exercise2_3(List<string> names) {
            Console.WriteLine("*****3-3*****");
            var array = names.Where(s => s.Contains("o")).ToArray();
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

        private static void Exercise2_4(List<string> names) {
            Console.WriteLine("*****3-4*****");
            var city = names.Where(s => s.StartsWith("B")).Select(s => new { s, s.Length });
            foreach (var item in city)
            {
                Console.WriteLine("{0},{1}", item.s, item.Length);
            }
        }
    }
}
