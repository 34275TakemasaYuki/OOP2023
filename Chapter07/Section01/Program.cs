using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
            string pref;
            string city;
            string prefCheck;
            string ans;
            int population;
            var prefDict = new Dictionary<string, CityInfo>();

            Console.WriteLine("県庁所在地の登録");
            while (true)
            {
                Console.Write("県名:");
                pref = Console.ReadLine();
                if (pref == "999")
                    break;

                Console.Write("県庁所在地:");
                city = Console.ReadLine();
                Console.Write("人口:");
                population = int.Parse(Console.ReadLine());

                if (!prefDict.ContainsKey(pref))
                {
                    prefDict[pref] = new CityInfo
                    {
                        City = city,
                        Population = population,
                    };
                }
                else
                {
                    Console.Write("{0}の情報を上書きしますか？(y/n):", pref);
                    ans = Console.ReadLine();
                    if(ans == "y")
                        prefDict[pref] = new CityInfo
                        {
                            City = city,
                            Population = population,
                        };
                }
            }

            if (prefDict.Count() != 0)
            {
                Console.Write("1:一覧表示,2:県名検索→");
                ans = Console.ReadLine();
                if (ans == "1")
                {
                    var popularOrder = prefDict.OrderByDescending(n => n.Value.Population);
                    foreach (var prefData in popularOrder)
                    {
                        Console.WriteLine("{0}【{1},(人口:{2})】",prefData.Key,prefData.Value.City,prefData.Value.Population);
                    }
                }
                else if(ans == "2")
                {
                    Console.Write("確認する県名を入力:");
                    prefCheck = Console.ReadLine();
                    Console.WriteLine("{0}(人口:{1}人)です。", prefDict[prefCheck].City,prefDict[prefCheck].Population);
                }
                else
                {
                    Console.WriteLine("入力した値が違います。");
                }
            }
        }
    }

    class CityInfo {
       public string City { get; set; }
       public int Population { get; set; }
    }
}
