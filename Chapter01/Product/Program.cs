using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductSample {

    //商品クラス
    class Program {
        static void Main(string[] args) {
            //インスタンスの生成
            Product karinto = new Product(123,"かりんとう",180);
            Product daihuku = new Product(235,"大福もち",160);

            Console.WriteLine("かりんとうの税込み" + karinto.GetPriceIncludingTax() + "円");
            Console.WriteLine("大福もちの税込み" + daihuku.GetPriceIncludingTax() + "円");
        }
    }
}
