using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeightUnitConverter {
    //グラム単位を表すクラス
    public class GramUnit :WeightUnit {
        private static List<GramUnit> units = new List<GramUnit>
        {
            new GramUnit{Name="g",Coefficient=1,},
            new GramUnit{Name="kg",Coefficient=1000,},
        };
        public static ICollection<GramUnit> Units { get { return units; } }

        /// <summary>
        /// ポンド単位からグラム単位に変換します
        /// </summary>
        /// <param name="unit">ポンド単位</param>
        /// <param name="value"></param>
        /// <returns>グラム単位</returns>
        public double FromPondUnit(PondUnit unit, double value) {
            return (value * unit.Coefficient) * 453.6 / this.Coefficient;
        }
    }
}
