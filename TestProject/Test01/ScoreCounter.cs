using System.Collections.Generic;
using System.IO;

namespace Test01 {
    class ScoreCounter {
        private IEnumerable<Student> _score;

        // コンストラクタ
        public ScoreCounter(string filePath) {
            _score = ReadScore(filePath);



        }


        //メソッドの概要： 学生データを読み込み、Studentオブジェクトのリストを返す
        private static IEnumerable<Student> ReadScore(string filePath) {

            var students = new List<Student>();//学生データを格納する
            var lines = File.ReadAllLines(filePath);//ファイルからすべてのデータを読み込む

            foreach (var line in lines)//すべての行から一行ずつ取り出す
            {
                var items = line.Split(',');//区切りで項目別に分ける
                var student = new Student    //Studentインスタンス生成
                {
                    Name = items[0],
                    Subject = items[1],
                    Score = int.Parse(items[2])
                };
                students.Add(student);    //Studentインスタンスをコレクションに追加

            }
            return students;






        }

        //メソッドの概要： 科目別の点数を集計
        public IDictionary<string, int> GetPerStudentScore() {

            var dict = new SortedDictionary<string, int>();
            foreach (var scoreCnt in _score)
            {
                if (dict.ContainsKey(scoreCnt.Subject))
                    dict[scoreCnt.Subject] += scoreCnt.Score;//科目が既に存在する（点数加算）
                else
                    dict[scoreCnt.Subject] = scoreCnt.Score;//科目が存在しない（新規格納）
            }
            return dict;




        }
    }
}
