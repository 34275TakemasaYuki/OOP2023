
namespace CalendarApp {
    partial class btAge {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btDayCalc = new System.Windows.Forms.Button();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.btBackMonth = new System.Windows.Forms.Button();
            this.btNextMonth = new System.Windows.Forms.Button();
            this.btBackYear = new System.Windows.Forms.Button();
            this.btNextYear = new System.Windows.Forms.Button();
            this.btBackDay = new System.Windows.Forms.Button();
            this.btNextDay = new System.Windows.Forms.Button();
            this.Now = new System.Windows.Forms.Label();
            this.tbNowTime = new System.Windows.Forms.TextBox();
            this.button1_Age = new System.Windows.Forms.Button();
            this.tmTimeDisp = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "日付：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dtpDate.Location = new System.Drawing.Point(104, 21);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(191, 31);
            this.dtpDate.TabIndex = 1;
            // 
            // btDayCalc
            // 
            this.btDayCalc.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btDayCalc.Location = new System.Drawing.Point(33, 58);
            this.btDayCalc.Name = "btDayCalc";
            this.btDayCalc.Size = new System.Drawing.Size(130, 37);
            this.btDayCalc.TabIndex = 2;
            this.btDayCalc.Text = "日数計算";
            this.btDayCalc.UseVisualStyleBackColor = true;
            this.btDayCalc.Click += new System.EventHandler(this.btDayCalc_Click);
            // 
            // tbMessage
            // 
            this.tbMessage.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbMessage.Location = new System.Drawing.Point(334, 21);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(288, 247);
            this.tbMessage.TabIndex = 3;
            // 
            // btBackMonth
            // 
            this.btBackMonth.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btBackMonth.Location = new System.Drawing.Point(33, 228);
            this.btBackMonth.Name = "btBackMonth";
            this.btBackMonth.Size = new System.Drawing.Size(108, 40);
            this.btBackMonth.TabIndex = 4;
            this.btBackMonth.Text = "-月";
            this.btBackMonth.UseVisualStyleBackColor = true;
            this.btBackMonth.Click += new System.EventHandler(this.btBackMonth_Click);
            // 
            // btNextMonth
            // 
            this.btNextMonth.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btNextMonth.Location = new System.Drawing.Point(180, 228);
            this.btNextMonth.Name = "btNextMonth";
            this.btNextMonth.Size = new System.Drawing.Size(115, 40);
            this.btNextMonth.TabIndex = 5;
            this.btNextMonth.Text = "+月";
            this.btNextMonth.UseVisualStyleBackColor = true;
            this.btNextMonth.Click += new System.EventHandler(this.btNextMonth_Click);
            // 
            // btBackYear
            // 
            this.btBackYear.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btBackYear.Location = new System.Drawing.Point(33, 159);
            this.btBackYear.Name = "btBackYear";
            this.btBackYear.Size = new System.Drawing.Size(108, 43);
            this.btBackYear.TabIndex = 6;
            this.btBackYear.Text = "-年";
            this.btBackYear.UseVisualStyleBackColor = true;
            this.btBackYear.Click += new System.EventHandler(this.btBackYear_Click);
            // 
            // btNextYear
            // 
            this.btNextYear.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btNextYear.Location = new System.Drawing.Point(180, 159);
            this.btNextYear.Name = "btNextYear";
            this.btNextYear.Size = new System.Drawing.Size(115, 43);
            this.btNextYear.TabIndex = 7;
            this.btNextYear.Text = "+年";
            this.btNextYear.UseVisualStyleBackColor = true;
            this.btNextYear.Click += new System.EventHandler(this.btNextYear_Click);
            // 
            // btBackDay
            // 
            this.btBackDay.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btBackDay.Location = new System.Drawing.Point(33, 293);
            this.btBackDay.Name = "btBackDay";
            this.btBackDay.Size = new System.Drawing.Size(108, 44);
            this.btBackDay.TabIndex = 8;
            this.btBackDay.Text = "-日";
            this.btBackDay.UseVisualStyleBackColor = true;
            this.btBackDay.Click += new System.EventHandler(this.btBackDay_Click);
            // 
            // btNextDay
            // 
            this.btNextDay.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btNextDay.Location = new System.Drawing.Point(180, 293);
            this.btNextDay.Name = "btNextDay";
            this.btNextDay.Size = new System.Drawing.Size(115, 44);
            this.btNextDay.TabIndex = 9;
            this.btNextDay.Text = "+日";
            this.btNextDay.UseVisualStyleBackColor = true;
            this.btNextDay.Click += new System.EventHandler(this.btNextDay_Click);
            // 
            // Now
            // 
            this.Now.AutoSize = true;
            this.Now.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Now.Location = new System.Drawing.Point(12, 368);
            this.Now.Name = "Now";
            this.Now.Size = new System.Drawing.Size(118, 24);
            this.Now.TabIndex = 10;
            this.Now.Text = "現在時刻：";
            // 
            // tbNowTime
            // 
            this.tbNowTime.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbNowTime.Location = new System.Drawing.Point(161, 365);
            this.tbNowTime.Multiline = true;
            this.tbNowTime.Name = "tbNowTime";
            this.tbNowTime.Size = new System.Drawing.Size(461, 35);
            this.tbNowTime.TabIndex = 11;
            // 
            // button1_Age
            // 
            this.button1_Age.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1_Age.Location = new System.Drawing.Point(33, 101);
            this.button1_Age.Name = "button1_Age";
            this.button1_Age.Size = new System.Drawing.Size(130, 33);
            this.button1_Age.TabIndex = 12;
            this.button1_Age.Text = "年齢";
            this.button1_Age.UseVisualStyleBackColor = true;
            this.button1_Age.Click += new System.EventHandler(this.button1_Age_Click);
            // 
            // tmTimeDisp
            // 
            this.tmTimeDisp.Interval = 1000;
            this.tmTimeDisp.Tick += new System.EventHandler(this.tmTimeDisp_Tick);
            // 
            // btAge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 415);
            this.Controls.Add(this.button1_Age);
            this.Controls.Add(this.tbNowTime);
            this.Controls.Add(this.Now);
            this.Controls.Add(this.btNextDay);
            this.Controls.Add(this.btBackDay);
            this.Controls.Add(this.btNextYear);
            this.Controls.Add(this.btBackYear);
            this.Controls.Add(this.btNextMonth);
            this.Controls.Add(this.btBackMonth);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.btDayCalc);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label1);
            this.Name = "btAge";
            this.Text = "カレンダーアプリ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btDayCalc;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Button btBackMonth;
        private System.Windows.Forms.Button btNextMonth;
        private System.Windows.Forms.Button btBackYear;
        private System.Windows.Forms.Button btNextYear;
        private System.Windows.Forms.Button btBackDay;
        private System.Windows.Forms.Button btNextDay;
        private System.Windows.Forms.Label Now;
        private System.Windows.Forms.TextBox tbNowTime;
        private System.Windows.Forms.Button button1_Age;
        private System.Windows.Forms.Timer tmTimeDisp;
    }
}

