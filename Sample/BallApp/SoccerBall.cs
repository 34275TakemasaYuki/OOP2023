using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallApp {
    class SoccerBall {
        //フィールド
        private Image image;    //画像データ

        private double posX;    //ｘ座標
        private double posY;    //ｙ座標

        private double moveX;   //移動量（ｘ方向）
        private double moveY;   //移動量（ｙ方向）

        Random random = new Random();   //乱数インスタンス

        //コンストラクタ
        public SoccerBall( double xp, double yp ) {
            Image = Image.FromFile(@"pic\soccer_ball.png");
            PosX = xp;
            PosY = yp;

            int rndX = random.Next(-25, 25);
            moveX = (rndX != 0 ? rndX : 1); //乱数で移動量を設定

            int rndY = random.Next(-25, 25);
            moveY = (rndY != 0 ? rndY : 1); //乱数で移動量を設定
        }

        //プロパティ
        public double PosX { get => posX; set => posX = value; }
        public double PosY { get => posY; set => posY = value; }
        public Image Image { get => image; set => image = value; }

        //メソッド
        public void Move() {

            Console.WriteLine("Ｘ座標 = {0}, Ｙ座標 = {1}", posX, posY);
            
            if(posY > 520 || posY < 0)
            {
                moveY = -moveY;
            }

            if (posX > 730 || posX < 0)
            {
                moveX = -moveX;
            }
            posX += moveX;
            posY += moveY;
        }
    }
}
