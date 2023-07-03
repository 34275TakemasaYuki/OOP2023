using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            var date = DateTime.Today;
            var today = date.ToString("yy/MM/dd");
            foreach (DayOfWeek dayofweek in Enum.GetValues(typeof(DayOfWeek)))
            {
                Console.WriteLine("{0}の次週の{1}: {2}",today,dayofweek, NextWeek(date,dayofweek).ToString("yy/MM/dd(ddd)"));
            }
        }

        public static DateTime NextWeek(DateTime date,DayOfWeek dayOfWeek) {
            var days = (int)dayOfWeek - (int)(date.DayOfWeek);
            days += 7;
            return date.AddDays(days);
        }
    }
}
