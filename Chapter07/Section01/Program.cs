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
            string ans;
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
                if (!cityDict.ContainsKey(city))
                {
                    cityDict[city] = capital;
                }
                else if(!cityDict.ContainsValue(capital))
                {
                    Console.Write("{0}の情報を上書きしますか？(y/n):", city);
                    ans = Console.ReadLine();
                    if(ans == "y")
                        cityDict[city] = capital;
                }
                else
                {
                    Console.WriteLine("この情報はすでに登録されています。");
                }
            }

            if (cityDict.Count() != 0)
            {
                Console.Write("確認する県名を入力:");
                cityCheck = Console.ReadLine();
                Console.WriteLine("{0}です。", cityDict[cityCheck]);
            }
        }
    }
}
