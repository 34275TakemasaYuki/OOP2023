using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
            var numbers = new List<int> { 9,7,5,4,2,5,4,0,4,1,0,4, };
            Console.WriteLine(numbers.Average());

            var books = Books.GetBooks();

            //500円以上の本のタイトルをすべて出力
            var booksObj = books.Where(x => x.Title.Contains("物語"))
                .OrderByDescending(x => x.Price);

            foreach (var book in booksObj)
            {
                Console.WriteLine("{0},{1}円", book.Title, book.Price);
            }

            //平均ページ数
            Console.WriteLine(booksObj.Average(x => x.Pages) + "枚");

            //タイトルが長い順
            var longTitleBooks = books.OrderByDescending(x => x.Title.Length);
            foreach (var longBook in longTitleBooks)
            {
                Console.WriteLine("{0},{1}円", longBook.Title, longBook.Price);
            }
            
        }
    }
}
