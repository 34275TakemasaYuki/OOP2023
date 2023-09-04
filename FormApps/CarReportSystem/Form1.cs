using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace CarReportSystem {
    public partial class Form1 : Form {
        //管理用データ
        BindingList<CarReport> CarReports = new BindingList<CarReport>();
        private uint mode = 0;

        //設定情報保存用オブジェクト
        Settings settings = new Settings();

        public Form1() {
            InitializeComponent();
            //dgvCarReports.DataSource = CarReports;
        }

        //システム起動時の処理
        private void Form1_Load_1(object sender, EventArgs e) {
            dgvCarReports.Columns[5].Visible = false;   //画像項目非表示
            buttonMask();
            statasLabelDisp("ここにメッセージが表示されます");
            timeLabelDisp(DateTime.Now.ToString("yyyy年MM月dd日(ddd) HH時mm分ss秒"));
            tssNowTime.BackColor = Color.White;
            tssNowTime.ForeColor = Color.Black;
            tmTimeDisp.Start();

            dgvCarReports.RowsDefaultCellStyle.BackColor = Color.AliceBlue; //全体に色を設定
            dgvCarReports.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray; //奇数行の色を上書き設定

            //設定ファイルを逆シリアル化して背景に設定
            try
            {
                using (var reader = XmlReader.Create("setting.xml"))
                {
                    var serializer = new XmlSerializer(typeof(Settings));
                    settings = serializer.Deserialize(reader) as Settings;
                    this.BackColor = Color.FromArgb(settings.MainFormColor);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //追加ボタンがクリックされた時のイベントハンドラー
        private void btAddReport_Click(object sender, EventArgs e) {
            statasLabelDisp("");//表示クリア
            if (cbAuthor.Text == "")
            {
                statasLabelDisp("編集者を入力してください");
                return;
            }
            else if (cbCarName.Text == "")
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

            setCbAuthor(cr.Author);
            setCbCarName(cr.CarName);

            clearDialog();
            buttonMask();
        }

        //投稿者履歴追加メソッド
        private void setCbAuthor (string author) {
            if (!cbAuthor.Items.Contains(author))
                cbAuthor.Items.Add(author);
        }

        //車名履歴追加メソッド
        private void setCbCarName(string carname) {
            if (!cbAuthor.Items.Contains(carname))
                cbCarName.Items.Add(carname);
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
            if (ofdImageFileOpen.ShowDialog() == DialogResult.OK)
            {
                pbCarImage.Image = Image.FromFile(ofdImageFileOpen.FileName);
            }
        }

        //削除ボタンイベントハンドラ
        private void btDeleteReport_Click(object sender, EventArgs e) {
            CarReports.RemoveAt(dgvCarReports.CurrentRow.Index);
            buttonMask();
            clearDialog();
        }

        //ステータスラベルのテキスト表示・非表示
        private void statasLabelDisp(string msg) {
            tsInfoText.Text = msg;
        }

        private void timeLabelDisp(string msg) {
            tssNowTime.Text = msg;
        }

        //レコードの選択時
        private void dgvCarReports_Click(object sender, EventArgs e) {
            if (0 < dgvCarReports.RowCount && dgvCarReports.CurrentRow.Selected)
            {
                dtpDate.Value = (DateTime)dgvCarReports.CurrentRow.Cells[0].Value;
                cbAuthor.Text = dgvCarReports.CurrentRow.Cells[1].Value.ToString();
                getSelectedMaker((CarReport.MakerGroup)dgvCarReports.CurrentRow.Cells[2].Value);
                cbCarName.Text = dgvCarReports.CurrentRow.Cells[3].Value.ToString();
                tbReport.Text = dgvCarReports.CurrentRow.Cells[4].Value.ToString();
                pbCarImage.Image = (Image)dgvCarReports.CurrentRow.Cells[5].Value;
            }
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
            clearDialog();
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
            dgvCarReports.CurrentRow.Selected = false;
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

        private void toolStripMenuItem4_Click(object sender, EventArgs e) {
            var vf = new VersionForm();
            vf.ShowDialog();    //モーダルダイアログとして表示
        }

        //背景変更ボタンイベントハンドラ
        private void tsmBackColor_Click(object sender, EventArgs e) {
            var cd = new ColorDialog();
            cd.Color = this.BackColor;

            if (cd.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = cd.Color;
                settings.MainFormColor = this.BackColor.ToArgb();
            }
        }

        //一秒経過毎に現在時刻表示
        private void tmTimeDisp_Tick(object sender, EventArgs e) {
            timeLabelDisp(DateTime.Now.ToString("yyyy年MM月dd日(ddd) HH時mm分ss秒"));
        }
        
        //画像サイズ変更ボタンイベントハンドラ
        private void btScaleChange_Click(object sender, EventArgs e) {
            mode = mode < 4 ? ((mode == 1) ?3 : ++mode) : 0;
            pbCarImage.SizeMode = (PictureBoxSizeMode)mode;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {

            //設定ファイルのシリアル化
            using (var writer = XmlWriter.Create("setting.xml"))
            {
                var serializer = new XmlSerializer(settings.GetType());
                serializer.Serialize(writer, settings);
            }
        }

        private void 保存LToolStripMenuItem_Click(object sender, EventArgs e) {
            if(sfdCarRepoSave.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //バイナリ形式でシリアル化
                    var bf = new BinaryFormatter();
                    using (FileStream fs = File.Open(sfdCarRepoSave.FileName, FileMode.Create))
                    {
                        bf.Serialize(fs, CarReports);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                //cbAuthor.Items.Add(cr.Author);
            }
        }

        private void 開くOToolStripMenuItem_Click(object sender, EventArgs e) {
            if(ofdCarRepoOpen.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //逆シリアル化でバイナリ形式を取り込む
                    var bf = new BinaryFormatter();
                    using (FileStream fs = File.Open(ofdCarRepoOpen.FileName,FileMode.Open,FileAccess.Read))
                    {
                        CarReports = (BindingList<CarReport>)bf.Deserialize(fs);
                        dgvCarReports.DataSource = null;
                        dgvCarReports.DataSource = CarReports;

                        cbAuthor.Items.Clear();
                        cbCarName.Items.Clear();

                        foreach (var carReport in CarReports)
                        {
                            setCbAuthor(carReport.Author);
                            setCbCarName(carReport.CarName);
                        }

                        dgvCarReports.Columns[5].Visible = false;   //画像項目非表示
                        clearDialog();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void carReportTableBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.carReportTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202327DataSet);

        }

        //接続ボタンイベントハンドラ
        private void btConnection_Click(object sender, EventArgs e) {
            // TODO: このコード行はデータを 'infosys202327DataSet.CarReportTable' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.carReportTableTableAdapter.Fill(this.infosys202327DataSet.CarReportTable);
        }
    }
}
