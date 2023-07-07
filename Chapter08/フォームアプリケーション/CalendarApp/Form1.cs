using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarApp {
    public partial class btAge : Form {
        public btAge() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

            tbNowTime.Text = DateTime.Now.ToString("yyyy年MM月dd日(ddd) HH時mm分ss秒");
            tmTimeDisp.Start();
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void btDayCalc_Click(object sender, EventArgs e) {
            var dtp = dtpDate.Value;
            var today = DateTime.Now;
            TimeSpan diff = today.Date - dtp.Date;
            tbMessage.Text = "生まれてから"+ diff.Days +"日目です。";
        }

        private void btBackYear_Click(object sender, EventArgs e) {
            var dtp = dtpDate.Value;
            tbMessage.Text = dtp.AddYears(-1).ToString("D");
        }

        private void btNextYear_Click(object sender, EventArgs e) {
            var dtp = dtpDate.Value;
            tbMessage.Text = dtp.AddYears(1).ToString("D");
        }

        private void btBackMonth_Click(object sender, EventArgs e) {
            var dtp = dtpDate.Value;
            tbMessage.Text = dtp.AddMonths(-1).ToString("D");
        }

        private void btNextMonth_Click(object sender, EventArgs e) {
            var dtp = dtpDate.Value;
            tbMessage.Text = dtp.AddMonths(1).ToString("D");
        }

        private void btBackDay_Click(object sender, EventArgs e) {
            var dtp = dtpDate.Value;
            tbMessage.Text = dtp.AddDays(-1).ToString("D");
        }

        private void btNextDay_Click(object sender, EventArgs e) {
            var dtp = dtpDate.Value;
            tbMessage.Text = dtp.AddDays(1).ToString("D");
        }

        private void button1_Age_Click(object sender, EventArgs e) {
            var dtp = dtpDate.Value;
            var today = DateTime.Today;
            var age = today.Year - dtp.Year;
            if (today < dtp.AddYears(age))
                age--;

            tbMessage.Text = "現在" + age + "歳です";
        }

        //タイマーイベントハンドラー
        private void tmTimeDisp_Tick(object sender, EventArgs e) {
            tbNowTime.Text = DateTime.Now.ToString("yyyy年MM月dd日(ddd) HH時mm分ss秒");
        }
    }
}
