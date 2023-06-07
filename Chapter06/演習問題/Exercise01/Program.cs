using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {

            var numbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35 };

            Exercise1_1(numbers);
            Console.WriteLine("-----");

            Exercise1_2(numbers);
            Console.WriteLine("-----");

            Exercise1_3(numbers);
            Console.WriteLine("-----");

            Exercise1_4(numbers);
            Console.WriteLine("-----");

            Exercise1_5(numbers);
        }

        private static void Exercise1_1(int[] numbers) {
            Console.WriteLine("最大値は" + numbers.Max());
        }

        private static void Exercise1_2(int[] numbers) {
            Console.WriteLine(numbers.ElementAt(numbers.Count()-2) + "," + numbers.Last());
        }

        private static void Exercise1_3(int[] numbers) {
            foreach (var number in numbers)
            {
                Console.WriteLine(number.ToString());
            }
        }

        private static void Exercise1_4(int[] numbers) {
            var orderNums = numbers.OrderBy(n => n);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(orderNums.ElementAt(i));
            }
        }

        private static void Exercise1_5(int[] numbers) {
            var distinctNums = numbers.Distinct();
            Console.WriteLine(distinctNums.Where(n => n > 10).Count());
        }
    }
}
