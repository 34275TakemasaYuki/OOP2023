using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem {
    public partial class Form1 : Form {
        //管理用データ
        BindingList<CarReport> CarReports = new BindingList<CarReport>();

        public Form1() {
            InitializeComponent();
            dgvCarReports.DataSource = CarReports;
        }

        //追加ボタンがクリックされた時のイベントハンドラー
        private void btAddReport_Click(object sender, EventArgs e) {
            statasLabelDisp("");//表示クリア
            if (cbAuthor.Text == "")
            {
                statasLabelDisp("編集者を入力してください");
                return;
            }
            else if(cbCarName.Text == "")
            {
                statasLabelDisp("車名を入力してください");
                return;
            }

            var cr = new CarReport
            {
                Date = dtpDate.Value,
                Author = cbAuthor.Text,
                Maker = getSelectedMaker(),
                CarName = cbCarName.Text,
                Report = tbReport.Text,
                CarImage = pbCarImage.Image,
            };

            CarReports.Add(cr);
            cbAuthor.Items.Add(cr.Author);
            cbCarName.Items.Add(cr.CarName);
            clearDialog();
            dgvCarReports.CurrentRow.Selected = false;
            buttonMask();
        }

        //ラジオボタンで選択されているメーカーを返却
        private CarReport.MakerGroup getSelectedMaker() {

            foreach (var item in gbMaker.Controls)
            {
                if (((RadioButton)item).Checked)
                {
                    return (CarReport.MakerGroup)int.Parse(((RadioButton)item).Tag.ToString());
                }
            }

            return CarReport.MakerGroup.その他;

        }

        //指定したメーカーのラジオボタンをセット
        private void getSelectedMaker(CarReport.MakerGroup makerGroup) {
            switch (makerGroup)
            {
                case CarReport.MakerGroup.トヨタ:
                    rbToyota.Checked = true;
                    break;
                case CarReport.MakerGroup.日産:
                    rbNissan.Checked = true;
                    break;
                case CarReport.MakerGroup.ホンダ:
                    rbHonda.Checked = true;
                    break;
                case CarReport.MakerGroup.スバル:
                    rbSubaru.Checked = true;
                    break;
                case CarReport.MakerGroup.スズキ:
                    rbSuzuki.Checked = true;
                    break;
                case CarReport.MakerGroup.ダイハツ:
                    rbDaihatsu.Checked = true;
                    break;
                case CarReport.MakerGroup.輸入車:
                    rbImported.Checked = true;
                    break;
                case CarReport.MakerGroup.その他:
                    rbOther.Checked = true;
                    break;
                default:
                    break;
            }
        }

        //画像追加ボタンイベントハンドラ
        private void btImageOpen_Click(object sender, EventArgs e) {
            ofdImageFileOpen.ShowDialog();
            pbCarImage.Image = Image.FromFile(ofdImageFileOpen.FileName);
        }

        private void btDeleteReport_Click(object sender, EventArgs e) {
            CarReports.RemoveAt(dgvCarReports.CurrentRow.Index);
            buttonMask();
        }

        //システム起動時の処理
        private void Form1_Load_1(object sender, EventArgs e) {
            dgvCarReports.Columns[5].Visible = false;   //画像項目非表示
            buttonMask();
            statasLabelDisp("ここにメッセージが表示されます。");
        }

        //ステータスラベルのテキスト表示・非表示
        private void statasLabelDisp(string msg) {
            tsInfoText.Text = msg;
        }

        //レコードの選択時
        private void dgvCarReports_Click(object sender, EventArgs e) {
            dtpDate.Value = (DateTime)dgvCarReports.CurrentRow.Cells[0].Value;
            cbAuthor.Text = dgvCarReports.CurrentRow.Cells[1].Value.ToString();
            getSelectedMaker((CarReport.MakerGroup)dgvCarReports.CurrentRow.Cells[2].Value);
            cbCarName.Text = dgvCarReports.CurrentRow.Cells[3].Value.ToString();
            tbReport.Text = dgvCarReports.CurrentRow.Cells[4].Value.ToString();
            pbCarImage.Image = (Image)dgvCarReports.CurrentRow.Cells[5].Value;
        }

        //更新ボタンイベントハンドラ
        private void btModifyReport_Click(object sender, EventArgs e) {
            if (dgvCarReports.Rows.Count == 0)
                return;

            var cr = new CarReport
            {
                Date = dtpDate.Value,
                Author = cbAuthor.Text,
                Maker = getSelectedMaker(),
                CarName = cbCarName.Text,
                Report = tbReport.Text,
                CarImage = pbCarImage.Image,
            };

            CarReports[dgvCarReports.CurrentRow.Index] = cr;
        }

        //編集エリアのクリア
        private void clearDialog() {
            cbAuthor.Text = null;

            foreach (var item in gbMaker.Controls)
            {
                if (((RadioButton)item).Checked)
                {
                    ((RadioButton)item).Checked = false;
                    break;
                }
            }

            cbCarName.Text = "";
            tbReport.Text = "";
            pbCarImage.Image = null;
        }

        //マスク処理メソッド
        private void buttonMask() {
            if (dgvCarReports.RowCount == 0)
            {
                btDeleteReport.Enabled = false;
                btModifyReport.Enabled = false;
            }
            else
            {
                btDeleteReport.Enabled = true;
                btModifyReport.Enabled = true;
            }
        }

        //システム終了
        private void 終了XToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        //画像削除ボタンイベントハンドラ
        private void btImageDelete_Click(object sender, EventArgs e) {
            pbCarImage.Image = null;
        }
    }
}
