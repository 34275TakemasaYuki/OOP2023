using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {
    class Program {
        static void Main(string[] args) {

            var text = "Jackdaws love my big sphinx of quartz";

            Exercise3_1(text);
            Console.WriteLine("-----");

            Exercise3_2(text);
            Console.WriteLine("-----");

            Exercise3_3(text);
            Console.WriteLine("-----");

            Exercise3_4(text);
            Console.WriteLine("-----");

            Exercise3_5(text);
            //{\rtf1}
        }

        private static void Exercise3_1(string text) {
            var count = text.Count(s => s.ToString().Contains(" "));
            Console.WriteLine("空白は" + count + "回");
        }

        private static void Exercise3_2(string text) {
            var replaced = text.Replace("big", "small");
            Console.WriteLine(replaced);
        }

        private static void Exercise3_3(string text) {
            string[] words = text.Split(' ');
            var count = 0;
            foreach (var word in words)
            {
                count++;
                Console.WriteLine(word);
            }
            Console.WriteLine("単語の個数：" + count);
        }

        private static void Exercise3_4(string text) {
            string[] words = text.Split(' ');
            var check = words.Where(s => s.Length <= 4);
            foreach (var s in check)
            {
                Console.WriteLine(s);
            }

        }

        private static void Exercise3_5(string text) {
            string[] words = text.Split(' ');
            var sb = new StringBuilder();
            foreach (var word in words)
            {
                if (word == words.Last())
                {
                    sb.Append(word);
                    break;
                }
                sb.Append(word).Append(" ");
            }
            var newText = sb.ToString();
            Console.WriteLine(newText);
        }
    }
}
