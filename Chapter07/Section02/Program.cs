﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section02 {
    class Program {
        static void Main(string[] args) {
            string pref;
            string city;
            string prefCheck;
            string ans;
            int population;
            var prefDict = new Dictionary<string, List<CityInfo>>();

            Console.WriteLine("都市の登録");
            while (true)
            {
                Console.Write("県名:");
                pref = Console.ReadLine();
                if (pref == "999")
                    break;  //999入力で繰り返し終了

                Console.Write("市町村:");
                city = Console.ReadLine();
                Console.Write("人口:");
                population = int.Parse(Console.ReadLine());

                var ci = new CityInfo(city, population);    //CityInfoインスタンス生成


                if (!prefDict.ContainsKey(pref))
                {
                    prefDict[pref] = new List<CityInfo>();  //県名が未登録なのでリスト作成
                }
                prefDict[pref].Add(ci); //リストにCityInfoインスタンスの要素を格納
            }

            if (prefDict.Count() != 0)
            {
                Console.Write("1:一覧表示,2:県名指定→");
                ans = Console.ReadLine();
                if (ans == "1")
                {
                    var popularOrder = prefDict.OrderByDescending(n => n.Value);//人口順に並べ替えてみる
                    foreach (var item in prefDict)
                    {
                        foreach (var term in item.Value)
                        {
                            Console.WriteLine("{0}【{1},(人口:{2})】", item.Key, term.City, term.Population);
                        }
                    }
                }
                else if (ans == "2")
                {
                    Console.Write("確認する県名を入力:");
                    prefCheck = Console.ReadLine();

                    var prefPic = prefDict.Where(x => x.Key == prefCheck);
                    if (prefPic.Count() != 0)
                    {
                        foreach (var item in prefPic)
                        {
                            foreach (var term in item.Value)
                            {
                                Console.WriteLine("{0}(人口:{1}人)です。", term.City, term.Population);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("指定した県名が存在しません。");
                    }
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

        public CityInfo(string city,int poplation) {
            City = city;
            Population = poplation;
        }
    }
}
