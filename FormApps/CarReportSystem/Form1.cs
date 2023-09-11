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
        private uint mode = 0;

        //設定情報保存用オブジェクト
        Settings settings = Settings.getInstance();

        public Form1() {
            InitializeComponent();

        }

        //システム起動時の処理
        private void Form1_Load_1(object sender, EventArgs e) {
            dgvCarReports.Columns[6].Visible = false;   //画像項目非表示
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

            DataRow newRow = infosys202327DataSet.CarReportTable.NewRow();

            newRow[1] = dtpDate.Value;
            newRow[2] = cbAuthor.Text;
            newRow[3] = getSelectedMaker();
            newRow[4] = cbCarName.Text;
            newRow[5] = tbReport.Text;
            newRow[6] = ImageToByteArray(pbCarImage.Image);

            infosys202327DataSet.CarReportTable.Rows.Add(newRow);
            this.carReportTableTableAdapter.Update(infosys202327DataSet.CarReportTable);

            setCbAuthor(cbAuthor.Text);
            setCbCarName(cbCarName.Text);

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
        private void setSelectedMaker(string makerGroup) {
            switch (makerGroup)
            {
                case "トヨタ":
                    rbToyota.Checked = true;
                    break;
                case "日産":
                    rbNissan.Checked = true;
                    break;
                case "ホンダ":
                    rbHonda.Checked = true;
                    break;
                case "スバル":
                    rbSubaru.Checked = true;
                    break;
                case "スズキ":
                    rbSuzuki.Checked = true;
                    break;
                case "ダイハツ":
                    rbDaihatsu.Checked = true;
                    break;
                case "輸入車":
                    rbImported.Checked = true;
                    break;
                case "その他":
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
            dgvCarReports.Rows.RemoveAt(dgvCarReports.CurrentRow.Index);

            this.Validate();
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
                dtpDate.Value = (DateTime)dgvCarReports.CurrentRow.Cells[1].Value;
                cbAuthor.Text = dgvCarReports.CurrentRow.Cells[2].Value.ToString();
                setSelectedMaker(dgvCarReports.CurrentRow.Cells[3].ToString());
                cbCarName.Text = dgvCarReports.CurrentRow.Cells[4].Value.ToString();
                tbReport.Text = dgvCarReports.CurrentRow.Cells[5].Value.ToString();

                if (!dgvCarReports.CurrentRow.Cells[6].Value.Equals(DBNull.Value))
                {
                    pbCarImage.Image = !dgvCarReports.CurrentRow.Cells[6].Value.Equals(DBNull.Value)
                        && ((Byte[])dgvCarReports.CurrentRow.Cells[6].Value).Length != 0 ?
                        ByteArrayToImage((Byte[])dgvCarReports.CurrentRow.Cells[6].Value) : null;
                }
                else
                {
                    pbCarImage.Image = null;
                }

                buttonMask();
            }
        }



        //更新ボタンイベントハンドラ
        private void btModifyReport_Click(object sender, EventArgs e) {

            if(dgvCarReports.Rows.Count != 0)
            {
                dgvCarReports.CurrentRow.Cells[1].Value = dtpDate.Value;
                dgvCarReports.CurrentRow.Cells[2].Value = cbAuthor.Text;
                dgvCarReports.CurrentRow.Cells[3].Value = getSelectedMaker();
                dgvCarReports.CurrentRow.Cells[4].Value = cbCarName.Text;
                dgvCarReports.CurrentRow.Cells[5].Value = tbReport.Text;
                dgvCarReports.CurrentRow.Cells[6].Value = pbCarImage.Image;

            }

            this.Validate();
            this.carReportTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202327DataSet);

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
            if(dgvCarReports.Rows.Equals(true))
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

        private void carReportTableBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.carReportTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202327DataSet);

        }

        // バイト配列をImageオブジェクトに変換
        public static Image ByteArrayToImage(byte[] b) {
            ImageConverter imgconv = new ImageConverter();
            Image img = (Image)imgconv.ConvertFrom(b);
            return img;
        }

        // Imageオブジェクトをバイト配列に変換
        public static byte[] ImageToByteArray(Image img) {
            ImageConverter imgconv = new ImageConverter();
            byte[] b = (byte[])imgconv.ConvertTo(img, typeof(byte[]));
            return b;
        }

        private void 接続OToolStripMenuItem_Click(object sender, EventArgs e) {
            dbConnect();
        }

        private void dbConnect() {
            this.carReportTableTableAdapter.Fill(this.infosys202327DataSet.CarReportTable);

            foreach (var carReport in infosys202327DataSet.CarReportTable)
            {
                setCbAuthor(carReport.Author);
                setCbCarName(carReport.CarName);
            }

            buttonMask();
            clearDialog();
        }
    }
}
