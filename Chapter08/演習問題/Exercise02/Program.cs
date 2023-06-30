using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            var dateTime = DateTime.Now;
            DisplayDatePattern1(dateTime);
            DisplayDatePattern2(dateTime);
            DisplayDatePattern3(dateTime);
            DisplayDatePattern3_2(dateTime);
        }

        private static void DisplayDatePattern1(DateTime dateTime) {
            //2019/1/15 19:48
            Console.WriteLine(dateTime.ToString("yyyy/M/dd HH:mm"));
        }

        private static void DisplayDatePattern2(DateTime dateTime) {
            //2019年01月15日 19時48分32秒
            Console.WriteLine(dateTime.ToString("yyyy年MM月dd日 HH時mm分ss秒"));
        }

        private static void DisplayDatePattern3(DateTime dateTime) {
            //平成31年 1月15日(火曜日)
            var culture = new CultureInfo("ja-JP");
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();

            Console.WriteLine(dateTime.ToString("ggyy年 M月d日", culture));
        }

        private static void DisplayDatePattern3_2(DateTime dateTime) {

        }
    }
}
