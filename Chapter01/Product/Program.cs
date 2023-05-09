using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductSample {

    //商品クラス
    class Program {
        static void Main(string[] args) {
            #region P26のサンプルプログラム
            //インスタンスの生成
            //Product karinto = new Product(123,"かりんとう",180);
            //Product daihuku = new Product(235,"大福もち",160);

            //Console.WriteLine("かりんとうの税込み" + karinto.GetPriceIncludingTax() + "円");
            //Console.WriteLine("大福もちの税込み" + daihuku.GetPriceIncludingTax() + "円");
            #endregion

            DateTime date = DateTime.Today;

            //10日後を求める
            DateTime daysAfter10 = date.AddDays(10);

            Console.WriteLine("今日の日付" + date.Year + "年" + date.Month + "月" + date.Day + "日");
            Console.WriteLine("10日後：" + date.AddDays(10).Year + "年" + date.AddDays(10).Month + "月" + date.AddDays(10).Day + "日");
            Console.WriteLine("10日前：" + date.AddDays(-10).Year + "年" + date.AddDays(-10).Month + "月" + date.AddDays(-10).Day + "日");

            Console.WriteLine("誕生日を入力");

            Console.Write("西暦：");
            int year = int.Parse(Console.ReadLine());

            Console.Write("月：");
            int month = int.Parse(Console.ReadLine());

            Console.Write("日：");
            int day = int.Parse(Console.ReadLine());

            DateTime baseDay = new DateTime(year, month, day);
            TimeSpan span = date - baseDay;
            Console.WriteLine("あなたは生まれてから今日まで" + span.TotalDays + "日目です");

            DayOfWeek result = baseDay.DayOfWeek;
            string[] weeks = { "日", "月", "火", "水", "木", "金", "土" };
            string week = weeks[(int)result];

            Console.WriteLine("あなたは" + week + "曜日に生まれました");

        }
    }
}
