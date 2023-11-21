
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
            this.rbDomestic = new System.Windows.Forms.RadioButton();
            this.rbBusiness = new System.Windows.Forms.RadioButton();
            this.btRegister = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbRegisterName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelURL = new System.Windows.Forms.Label();
            this.tbRegisterURL = new System.Windows.Forms.TextBox();
            this.cbRegisterView = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelGuide = new System.Windows.Forms.Label();
            this.btReset = new System.Windows.Forms.Button();
            this.btComboBoxRemove = new System.Windows.Forms.Button();
            this.btRegisterReset = new System.Windows.Forms.Button();
            this.btPrev = new System.Windows.Forms.Button();
            this.btNext = new System.Windows.Forms.Button();
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
            this.btGet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btGet.Location = new System.Drawing.Point(558, 12);
            this.btGet.Name = "btGet";
            this.btGet.Size = new System.Drawing.Size(75, 31);
            this.btGet.TabIndex = 1;
            this.btGet.Text = "取得";
            this.btGet.UseVisualStyleBackColor = false;
            this.btGet.Click += new System.EventHandler(this.btGet_Click);
            // 
            // lbRssTitle
            // 
            this.lbRssTitle.FormattingEnabled = true;
            this.lbRssTitle.ItemHeight = 12;
            this.lbRssTitle.Location = new System.Drawing.Point(12, 363);
            this.lbRssTitle.Name = "lbRssTitle";
            this.lbRssTitle.Size = new System.Drawing.Size(368, 316);
            this.lbRssTitle.TabIndex = 2;
            this.lbRssTitle.Click += new System.EventHandler(this.lbRssTitle_Click);
            // 
            // wbBrowser
            // 
            this.wbBrowser.Location = new System.Drawing.Point(404, 91);
            this.wbBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbBrowser.Name = "wbBrowser";
            this.wbBrowser.ScriptErrorsSuppressed = true;
            this.wbBrowser.Size = new System.Drawing.Size(845, 588);
            this.wbBrowser.TabIndex = 3;
            // 
            // tbInfo
            // 
            this.tbInfo.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbInfo.Location = new System.Drawing.Point(708, 12);
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
            // btRegister
            // 
            this.btRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btRegister.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btRegister.Location = new System.Drawing.Point(329, 206);
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(51, 64);
            this.btRegister.TabIndex = 6;
            this.btRegister.Text = "登録";
            this.btRegister.UseVisualStyleBackColor = false;
            this.btRegister.Click += new System.EventHandler(this.btRegister_Click);
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
            // tbRegisterName
            // 
            this.tbRegisterName.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbRegisterName.Location = new System.Drawing.Point(92, 206);
            this.tbRegisterName.Name = "tbRegisterName";
            this.tbRegisterName.Size = new System.Drawing.Size(231, 31);
            this.tbRegisterName.TabIndex = 9;
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
            // tbRegisterURL
            // 
            this.tbRegisterURL.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbRegisterURL.Location = new System.Drawing.Point(92, 244);
            this.tbRegisterURL.Name = "tbRegisterURL";
            this.tbRegisterURL.Size = new System.Drawing.Size(231, 31);
            this.tbRegisterURL.TabIndex = 12;
            // 
            // cbRegisterView
            // 
            this.cbRegisterView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRegisterView.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cbRegisterView.FormattingEnabled = true;
            this.cbRegisterView.Location = new System.Drawing.Point(12, 330);
            this.cbRegisterView.Name = "cbRegisterView";
            this.cbRegisterView.Size = new System.Drawing.Size(342, 24);
            this.cbRegisterView.TabIndex = 13;
            this.cbRegisterView.SelectedIndexChanged += new System.EventHandler(this.cbRegisterView_SelectedIndexChanged);
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
            this.labelGuide.Location = new System.Drawing.Point(639, 15);
            this.labelGuide.Name = "labelGuide";
            this.labelGuide.Size = new System.Drawing.Size(63, 24);
            this.labelGuide.TabIndex = 15;
            this.labelGuide.Text = "ガイド";
            // 
            // btReset
            // 
            this.btReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btReset.Location = new System.Drawing.Point(1174, 10);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(75, 33);
            this.btReset.TabIndex = 16;
            this.btReset.Text = "全てリセット";
            this.btReset.UseVisualStyleBackColor = false;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // btComboBoxRemove
            // 
            this.btComboBoxRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btComboBoxRemove.Location = new System.Drawing.Point(238, 291);
            this.btComboBoxRemove.Name = "btComboBoxRemove";
            this.btComboBoxRemove.Size = new System.Drawing.Size(116, 24);
            this.btComboBoxRemove.TabIndex = 17;
            this.btComboBoxRemove.Text = "ページの削除";
            this.btComboBoxRemove.UseVisualStyleBackColor = false;
            this.btComboBoxRemove.Click += new System.EventHandler(this.btComboBoxRemove_Click);
            // 
            // btRegisterReset
            // 
            this.btRegisterReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btRegisterReset.Location = new System.Drawing.Point(207, 179);
            this.btRegisterReset.Name = "btRegisterReset";
            this.btRegisterReset.Size = new System.Drawing.Size(116, 26);
            this.btRegisterReset.TabIndex = 18;
            this.btRegisterReset.Text = "表示をリセット";
            this.btRegisterReset.UseVisualStyleBackColor = false;
            this.btRegisterReset.Click += new System.EventHandler(this.btRegisterReset_Click);
            // 
            // btPrev
            // 
            this.btPrev.Location = new System.Drawing.Point(404, 49);
            this.btPrev.Name = "btPrev";
            this.btPrev.Size = new System.Drawing.Size(94, 35);
            this.btPrev.TabIndex = 19;
            this.btPrev.Text = "前の記事へ";
            this.btPrev.UseVisualStyleBackColor = true;
            this.btPrev.Click += new System.EventHandler(this.btPrev_Click);
            // 
            // btNext
            // 
            this.btNext.Location = new System.Drawing.Point(1162, 49);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(87, 34);
            this.btNext.TabIndex = 20;
            this.btNext.Text = "次の記事へ";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 691);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.btPrev);
            this.Controls.Add(this.btRegisterReset);
            this.Controls.Add(this.btComboBoxRemove);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.labelGuide);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbRegisterView);
            this.Controls.Add(this.tbRegisterURL);
            this.Controls.Add(this.labelURL);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.tbRegisterName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btRegister);
            this.Controls.Add(this.gbGenre);
            this.Controls.Add(this.tbInfo);
            this.Controls.Add(this.wbBrowser);
            this.Controls.Add(this.lbRssTitle);
            this.Controls.Add(this.btGet);
            this.Controls.Add(this.tbUrl);
            this.Name = "Form1";
            this.Text = "RssReader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
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
        private System.Windows.Forms.Button btRegister;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbRegisterName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelURL;
        private System.Windows.Forms.TextBox tbRegisterURL;
        private System.Windows.Forms.ComboBox cbRegisterView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelGuide;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Button btComboBoxRemove;
        private System.Windows.Forms.Button btRegisterReset;
        private System.Windows.Forms.Button btPrev;
        private System.Windows.Forms.Button btNext;
    }
}

