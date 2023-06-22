using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
            string city;
            string capital;
            string cityCheck;
            int flag = 0;
            var cityDict = new Dictionary<string, string>();

            Console.WriteLine("県庁所在地の登録");
            while (true)
            {
                Console.Write("県名:");
                city = Console.ReadLine();
                if (city == "999")
                    break;

                Console.Write("県庁所在地:");
                capital = Console.ReadLine();
                if (!cityDict.ContainsKey(city) || !cityDict.ContainsKey(capital))
                {
                    cityDict[city] = capital;
                }
                else
                {
                    Console.WriteLine("この情報はすでに登録されています。");
                }
                flag = 1;
            }

            if (flag == 1)
            {
                Console.Write("確認する県名を入力:");
                cityCheck = Console.ReadLine();
                Console.WriteLine("{0}です。", cityDict[cityCheck]);
            }
        }
    }
}
