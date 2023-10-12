using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {
            Exercise1_2();
            Console.WriteLine();
            Exercise1_3();
            Console.WriteLine();
            Exercise1_4();
            Console.WriteLine();
            Exercise1_5();
            Console.WriteLine();
            Exercise1_6();
            Console.WriteLine();
            Exercise1_7();
            Console.WriteLine();
            Exercise1_8();

            Console.ReadLine();
        }

        private static void Exercise1_2() {
            var maxPrice = Library.Books.Max(b => b.Price);
            var books = Library.Books.Where(b => b.Price == maxPrice);
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
        }

        private static void Exercise1_3() {
            var groups = Library.Books.GroupBy(b => b.PublishedYear).OrderBy(g => g.Key);

            foreach (var g in groups)
            {
                Console.WriteLine("{0}年:{1}冊", g.Key, g.Count());
            }
        }

        private static void Exercise1_4() {
            var books = Library.Books.OrderByDescending(b => b.PublishedYear)
                                      .ThenByDescending(b => b.Price)
                                      .Join(Library.Categories, book => book.CategoryId, category => category.Id,
                                           (book, category) => new {
                                               Title = book.Title,
                                               Category = category.Name,
                                               Price = book.Price,
                                               PublishedYear = book.PublishedYear
                                           }
                                      );

            foreach (var book in books)
            {
                Console.WriteLine("{0}年 {1}円 {2} ({3})", book.PublishedYear, book.Price, book.Title,book.Category);
            }
        }

        private static void Exercise1_5() {
            var names = Library.Books.Where(b => b.PublishedYear == 2016)
                                     .Join(Library.Categories, book => book.CategoryId, category => category.Id,
                                     (book, category) => category.Name).Distinct();
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }

        private static void Exercise1_6() {
            var groups = Library.Categories.GroupJoin(Library.Books, c => c.Id, b => b.CategoryId,
                                           (c, books) => new { Category = c.Name, Books = books }).OrderBy(b => b.Category);
            foreach (var group in groups)
            {
                Console.WriteLine("#{0}", group.Category);
                foreach (var book in group.Books)
                {
                    Console.WriteLine(" {0}",book.Title);
                }
            }
        }

        private static void Exercise1_7() {
            
        }

        private static void Exercise1_8() {
            
        }
    }
}
