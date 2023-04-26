using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallApp {
    class SoccerBall :Obj{
        //フィールド
        Random random = new Random();   //乱数インスタンス
        private static int ballCnt = 0;

        //コンストラクタ
        public SoccerBall( double xp, double yp) : base(xp, yp,@"pic\soccer_ball.png") {
        
            int rndX = random.Next(-25, 25);
            MoveX = (rndX != 0 ? rndX : 1); //乱数で移動量を設定

            int rndY = random.Next(-25, 25);
            MoveY = (rndY != 0 ? rndY : 1); //乱数で移動量を設定
            BallCnt++;
        }

        public static int BallCnt { get => ballCnt; set => ballCnt = value; }

        //メソッド
        public override void Move() {

            Console.WriteLine("Ｘ座標 = {0}, Ｙ座標 = {1}", PosX, PosY);
            
            if(PosY > 520 || PosY < 0)
            {
                MoveY = -MoveY;
            }

            if (PosX > 730 || PosX < 0)
            {
                MoveX = -MoveX;
            }
            PosX += MoveX;
            PosY += MoveY;
        }
        public override void Move(Keys direction) {
            ;
        }
    }
}
