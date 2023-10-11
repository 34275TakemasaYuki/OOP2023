﻿
namespace RssReader {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
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
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.btGet = new System.Windows.Forms.Button();
            this.lbRssTitle = new System.Windows.Forms.ListBox();
            this.wbBrowser = new System.Windows.Forms.WebBrowser();
            this.tbInfo = new System.Windows.Forms.TextBox();
            this.rbIT = new System.Windows.Forms.RadioButton();
            this.rbEntertainment = new System.Windows.Forms.RadioButton();
            this.gbGenre = new System.Windows.Forms.GroupBox();
            this.rbBusiness = new System.Windows.Forms.RadioButton();
            this.rbDomestic = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelURL = new System.Windows.Forms.Label();
            this.tbRecommendationURL = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelGuide = new System.Windows.Forms.Label();
            this.gbGenre.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbUrl
            // 
            this.tbUrl.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbUrl.Location = new System.Drawing.Point(12, 12);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(540, 31);
            this.tbUrl.TabIndex = 0;
            // 
            // btGet
            // 
            this.btGet.Location = new System.Drawing.Point(578, 12);
            this.btGet.Name = "btGet";
            this.btGet.Size = new System.Drawing.Size(75, 31);
            this.btGet.TabIndex = 1;
            this.btGet.Text = "取得";
            this.btGet.UseVisualStyleBackColor = true;
            this.btGet.Click += new System.EventHandler(this.btGet_Click);
            // 
            // lbRssTitle
            // 
            this.lbRssTitle.FormattingEnabled = true;
            this.lbRssTitle.ItemHeight = 12;
            this.lbRssTitle.Location = new System.Drawing.Point(12, 341);
            this.lbRssTitle.Name = "lbRssTitle";
            this.lbRssTitle.Size = new System.Drawing.Size(368, 316);
            this.lbRssTitle.TabIndex = 2;
            this.lbRssTitle.Click += new System.EventHandler(this.lbRssTitle_Click);
            // 
            // wbBrowser
            // 
            this.wbBrowser.Location = new System.Drawing.Point(404, 65);
            this.wbBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbBrowser.Name = "wbBrowser";
            this.wbBrowser.ScriptErrorsSuppressed = true;
            this.wbBrowser.Size = new System.Drawing.Size(845, 592);
            this.wbBrowser.TabIndex = 3;
            // 
            // tbInfo
            // 
            this.tbInfo.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbInfo.Location = new System.Drawing.Point(805, 12);
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.Size = new System.Drawing.Size(444, 31);
            this.tbInfo.TabIndex = 4;
            // 
            // rbIT
            // 
            this.rbIT.AutoSize = true;
            this.rbIT.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rbIT.Location = new System.Drawing.Point(18, 18);
            this.rbIT.Name = "rbIT";
            this.rbIT.Size = new System.Drawing.Size(48, 28);
            this.rbIT.TabIndex = 0;
            this.rbIT.TabStop = true;
            this.rbIT.Text = "IT";
            this.rbIT.UseVisualStyleBackColor = true;
            this.rbIT.CheckedChanged += new System.EventHandler(this.rbIT_CheckedChanged);
            // 
            // rbEntertainment
            // 
            this.rbEntertainment.AutoSize = true;
            this.rbEntertainment.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rbEntertainment.Location = new System.Drawing.Point(18, 65);
            this.rbEntertainment.Name = "rbEntertainment";
            this.rbEntertainment.Size = new System.Drawing.Size(98, 28);
            this.rbEntertainment.TabIndex = 1;
            this.rbEntertainment.TabStop = true;
            this.rbEntertainment.Text = "エンタメ";
            this.rbEntertainment.UseVisualStyleBackColor = true;
            this.rbEntertainment.CheckedChanged += new System.EventHandler(this.rbEntertainment_CheckedChanged);
            // 
            // gbGenre
            // 
            this.gbGenre.Controls.Add(this.rbDomestic);
            this.gbGenre.Controls.Add(this.rbBusiness);
            this.gbGenre.Controls.Add(this.rbEntertainment);
            this.gbGenre.Controls.Add(this.rbIT);
            this.gbGenre.Location = new System.Drawing.Point(12, 73);
            this.gbGenre.Name = "gbGenre";
            this.gbGenre.Size = new System.Drawing.Size(368, 103);
            this.gbGenre.TabIndex = 5;
            this.gbGenre.TabStop = false;
            // 
            // rbBusiness
            // 
            this.rbBusiness.AutoSize = true;
            this.rbBusiness.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rbBusiness.Location = new System.Drawing.Point(161, 18);
            this.rbBusiness.Name = "rbBusiness";
            this.rbBusiness.Size = new System.Drawing.Size(76, 28);
            this.rbBusiness.TabIndex = 2;
            this.rbBusiness.TabStop = true;
            this.rbBusiness.Text = "経済";
            this.rbBusiness.UseVisualStyleBackColor = true;
            this.rbBusiness.CheckedChanged += new System.EventHandler(this.rbBusiness_CheckedChanged);
            // 
            // rbDomestic
            // 
            this.rbDomestic.AutoSize = true;
            this.rbDomestic.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rbDomestic.Location = new System.Drawing.Point(161, 65);
            this.rbDomestic.Name = "rbDomestic";
            this.rbDomestic.Size = new System.Drawing.Size(76, 28);
            this.rbDomestic.TabIndex = 3;
            this.rbDomestic.TabStop = true;
            this.rbDomestic.Text = "国内";
            this.rbDomestic.UseVisualStyleBackColor = true;
            this.rbDomestic.CheckedChanged += new System.EventHandler(this.rbDomestic_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(329, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 52);
            this.button1.TabIndex = 6;
            this.button1.Text = "登録";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "おすすめコンテンツ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(12, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "お気に入り登録";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox1.Location = new System.Drawing.Point(92, 206);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(231, 31);
            this.textBox1.TabIndex = 9;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelName.Location = new System.Drawing.Point(12, 209);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(58, 24);
            this.labelName.TabIndex = 10;
            this.labelName.Text = "名前";
            // 
            // labelURL
            // 
            this.labelURL.AutoSize = true;
            this.labelURL.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelURL.Location = new System.Drawing.Point(17, 247);
            this.labelURL.Name = "labelURL";
            this.labelURL.Size = new System.Drawing.Size(53, 24);
            this.labelURL.TabIndex = 11;
            this.labelURL.Text = "URL";
            // 
            // tbRecommendationURL
            // 
            this.tbRecommendationURL.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbRecommendationURL.Location = new System.Drawing.Point(92, 244);
            this.tbRecommendationURL.Name = "tbRecommendationURL";
            this.tbRecommendationURL.Size = new System.Drawing.Size(231, 31);
            this.tbRecommendationURL.TabIndex = 12;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(236, 291);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(144, 24);
            this.comboBox1.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(12, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "登録したページを表示";
            // 
            // labelGuide
            // 
            this.labelGuide.AutoSize = true;
            this.labelGuide.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelGuide.Location = new System.Drawing.Point(736, 15);
            this.labelGuide.Name = "labelGuide";
            this.labelGuide.Size = new System.Drawing.Size(63, 24);
            this.labelGuide.TabIndex = 15;
            this.labelGuide.Text = "ガイド";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 691);
            this.Controls.Add(this.labelGuide);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tbRecommendationURL);
            this.Controls.Add(this.labelURL);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbGenre);
            this.Controls.Add(this.tbInfo);
            this.Controls.Add(this.wbBrowser);
            this.Controls.Add(this.lbRssTitle);
            this.Controls.Add(this.btGet);
            this.Controls.Add(this.tbUrl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbGenre.ResumeLayout(false);
            this.gbGenre.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.Button btGet;
        private System.Windows.Forms.ListBox lbRssTitle;
        private System.Windows.Forms.WebBrowser wbBrowser;
        private System.Windows.Forms.TextBox tbInfo;
        private System.Windows.Forms.RadioButton rbIT;
        private System.Windows.Forms.RadioButton rbEntertainment;
        private System.Windows.Forms.GroupBox gbGenre;
        private System.Windows.Forms.RadioButton rbDomestic;
        private System.Windows.Forms.RadioButton rbBusiness;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelURL;
        private System.Windows.Forms.TextBox tbRecommendationURL;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelGuide;
    }
}

