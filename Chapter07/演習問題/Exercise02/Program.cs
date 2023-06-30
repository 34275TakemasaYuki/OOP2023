using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            var abbrs = new Abbreviations();

            //7.2.3
            Console.Write("削除したい要素の省略語:");
            var removeWord = Console.ReadLine();
            abbrs.Remove(removeWord);
            Console.WriteLine(abbrs.Count);

            //7.2.4
            abbrs.SortAbb();
        }
    }
}
