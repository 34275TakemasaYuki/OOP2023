﻿
namespace CarReportSystem {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cbAuthor = new System.Windows.Forms.ComboBox();
            this.gbMaker = new System.Windows.Forms.GroupBox();
            this.rbDaihatsu = new System.Windows.Forms.RadioButton();
            this.rbOther = new System.Windows.Forms.RadioButton();
            this.rbSuzuki = new System.Windows.Forms.RadioButton();
            this.rbImported = new System.Windows.Forms.RadioButton();
            this.rbSubaru = new System.Windows.Forms.RadioButton();
            this.rbHonda = new System.Windows.Forms.RadioButton();
            this.rbNissan = new System.Windows.Forms.RadioButton();
            this.rbToyota = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCarName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbReport = new System.Windows.Forms.TextBox();
            this.dgvCarReports = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.carReportTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.infosys202327DataSet = new CarReportSystem.infosys202327DataSet();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btImageOpen = new System.Windows.Forms.Button();
            this.btImageDelete = new System.Windows.Forms.Button();
            this.pbCarImage = new System.Windows.Forms.PictureBox();
            this.btAddReport = new System.Windows.Forms.Button();
            this.btModifyReport = new System.Windows.Forms.Button();
            this.btDeleteReport = new System.Windows.Forms.Button();
            this.menuItems = new System.Windows.Forms.MenuStrip();
            this.ファイルToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.接続OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.終了XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmColor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmBackColor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.ofdImageFileOpen = new System.Windows.Forms.OpenFileDialog();
            this.statusDisp = new System.Windows.Forms.StatusStrip();
            this.tsInfoText = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssNowTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.cdColor = new System.Windows.Forms.ColorDialog();
            this.tmTimeDisp = new System.Windows.Forms.Timer(this.components);
            this.btScaleChange = new System.Windows.Forms.Button();
            this.ofdCarRepoOpen = new System.Windows.Forms.OpenFileDialog();
            this.sfdCarRepoSave = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpSearch_e = new System.Windows.Forms.DateTimePicker();
            this.btReset = new System.Windows.Forms.Button();
            this.btDateSearch = new System.Windows.Forms.Button();
            this.dtpSearch_s = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.btCarNameSearch = new System.Windows.Forms.Button();
            this.btAuthorSearch = new System.Windows.Forms.Button();
            this.tbCarNameSearch = new System.Windows.Forms.TextBox();
            this.tbAuthorSearch = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.carReportTableTableAdapter = new CarReportSystem.infosys202327DataSetTableAdapters.CarReportTableTableAdapter();
            this.tableAdapterManager = new CarReportSystem.infosys202327DataSetTableAdapters.TableAdapterManager();
            this.gbMaker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carReportTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202327DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarImage)).BeginInit();
            this.menuItems.SuspendLayout();
            this.statusDisp.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(40, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "日付：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(21, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "記録者：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(21, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "メーカー：";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(120, 38);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(233, 23);
            this.dtpDate.TabIndex = 1;
            // 
            // cbAuthor
            // 
            this.cbAuthor.FormattingEnabled = true;
            this.cbAuthor.Location = new System.Drawing.Point(120, 98);
            this.cbAuthor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbAuthor.Name = "cbAuthor";
            this.cbAuthor.Size = new System.Drawing.Size(233, 23);
            this.cbAuthor.TabIndex = 2;
            // 
            // gbMaker
            // 
            this.gbMaker.Controls.Add(this.rbDaihatsu);
            this.gbMaker.Controls.Add(this.rbOther);
            this.gbMaker.Controls.Add(this.rbSuzuki);
            this.gbMaker.Controls.Add(this.rbImported);
            this.gbMaker.Controls.Add(this.rbSubaru);
            this.gbMaker.Controls.Add(this.rbHonda);
            this.gbMaker.Controls.Add(this.rbNissan);
            this.gbMaker.Controls.Add(this.rbToyota);
            this.gbMaker.Location = new System.Drawing.Point(120, 155);
            this.gbMaker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbMaker.Name = "gbMaker";
            this.gbMaker.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbMaker.Size = new System.Drawing.Size(282, 112);
            this.gbMaker.TabIndex = 3;
            this.gbMaker.TabStop = false;
            // 
            // rbDaihatsu
            // 
            this.rbDaihatsu.AutoSize = true;
            this.rbDaihatsu.Location = new System.Drawing.Point(131, 66);
            this.rbDaihatsu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbDaihatsu.Name = "rbDaihatsu";
            this.rbDaihatsu.Size = new System.Drawing.Size(60, 19);
            this.rbDaihatsu.TabIndex = 9;
            this.rbDaihatsu.TabStop = true;
            this.rbDaihatsu.Tag = "5";
            this.rbDaihatsu.Text = "ダイハツ";
            this.rbDaihatsu.UseVisualStyleBackColor = true;
            // 
            // rbOther
            // 
            this.rbOther.AutoSize = true;
            this.rbOther.Location = new System.Drawing.Point(203, 66);
            this.rbOther.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbOther.Name = "rbOther";
            this.rbOther.Size = new System.Drawing.Size(56, 19);
            this.rbOther.TabIndex = 10;
            this.rbOther.TabStop = true;
            this.rbOther.Tag = "7";
            this.rbOther.Text = "その他";
            this.rbOther.UseVisualStyleBackColor = true;
            // 
            // rbSuzuki
            // 
            this.rbSuzuki.AutoSize = true;
            this.rbSuzuki.Location = new System.Drawing.Point(69, 66);
            this.rbSuzuki.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbSuzuki.Name = "rbSuzuki";
            this.rbSuzuki.Size = new System.Drawing.Size(52, 19);
            this.rbSuzuki.TabIndex = 8;
            this.rbSuzuki.TabStop = true;
            this.rbSuzuki.Tag = "4";
            this.rbSuzuki.Text = "スズキ";
            this.rbSuzuki.UseVisualStyleBackColor = true;
            // 
            // rbImported
            // 
            this.rbImported.AutoSize = true;
            this.rbImported.Location = new System.Drawing.Point(203, 22);
            this.rbImported.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbImported.Name = "rbImported";
            this.rbImported.Size = new System.Drawing.Size(61, 19);
            this.rbImported.TabIndex = 6;
            this.rbImported.TabStop = true;
            this.rbImported.Tag = "6";
            this.rbImported.Text = "輸入車";
            this.rbImported.UseVisualStyleBackColor = true;
            // 
            // rbSubaru
            // 
            this.rbSubaru.AutoSize = true;
            this.rbSubaru.Location = new System.Drawing.Point(7, 66);
            this.rbSubaru.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbSubaru.Name = "rbSubaru";
            this.rbSubaru.Size = new System.Drawing.Size(54, 19);
            this.rbSubaru.TabIndex = 7;
            this.rbSubaru.TabStop = true;
            this.rbSubaru.Tag = "3";
            this.rbSubaru.Text = "スバル";
            this.rbSubaru.UseVisualStyleBackColor = true;
            // 
            // rbHonda
            // 
            this.rbHonda.AutoSize = true;
            this.rbHonda.Location = new System.Drawing.Point(131, 22);
            this.rbHonda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbHonda.Name = "rbHonda";
            this.rbHonda.Size = new System.Drawing.Size(53, 19);
            this.rbHonda.TabIndex = 5;
            this.rbHonda.TabStop = true;
            this.rbHonda.Tag = "2";
            this.rbHonda.Text = "ホンダ";
            this.rbHonda.UseVisualStyleBackColor = true;
            // 
            // rbNissan
            // 
            this.rbNissan.AutoSize = true;
            this.rbNissan.Location = new System.Drawing.Point(69, 22);
            this.rbNissan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbNissan.Name = "rbNissan";
            this.rbNissan.Size = new System.Drawing.Size(49, 19);
            this.rbNissan.TabIndex = 4;
            this.rbNissan.TabStop = true;
            this.rbNissan.Tag = "1";
            this.rbNissan.Text = "日産";
            this.rbNissan.UseVisualStyleBackColor = true;
            // 
            // rbToyota
            // 
            this.rbToyota.AutoSize = true;
            this.rbToyota.Location = new System.Drawing.Point(7, 22);
            this.rbToyota.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbToyota.Name = "rbToyota";
            this.rbToyota.Size = new System.Drawing.Size(50, 19);
            this.rbToyota.TabIndex = 3;
            this.rbToyota.TabStop = true;
            this.rbToyota.Tag = "0";
            this.rbToyota.Text = "トヨタ";
            this.rbToyota.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(40, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "車名：";
            // 
            // cbCarName
            // 
            this.cbCarName.FormattingEnabled = true;
            this.cbCarName.Location = new System.Drawing.Point(120, 299);
            this.cbCarName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbCarName.Name = "cbCarName";
            this.cbCarName.Size = new System.Drawing.Size(233, 23);
            this.cbCarName.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(20, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "レポート：";
            // 
            // tbReport
            // 
            this.tbReport.Location = new System.Drawing.Point(120, 368);
            this.tbReport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbReport.Multiline = true;
            this.tbReport.Name = "tbReport";
            this.tbReport.Size = new System.Drawing.Size(282, 158);
            this.tbReport.TabIndex = 5;
            // 
            // dgvCarReports
            // 
            this.dgvCarReports.AllowUserToAddRows = false;
            this.dgvCarReports.AllowUserToDeleteRows = false;
            this.dgvCarReports.AutoGenerateColumns = false;
            this.dgvCarReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarReports.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.makerDataGridViewTextBoxColumn,
            this.carNameDataGridViewTextBoxColumn,
            this.reportDataGridViewTextBoxColumn,
            this.imageDataGridViewImageColumn});
            this.dgvCarReports.DataSource = this.carReportTableBindingSource;
            this.dgvCarReports.Location = new System.Drawing.Point(786, 98);
            this.dgvCarReports.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvCarReports.MultiSelect = false;
            this.dgvCarReports.Name = "dgvCarReports";
            this.dgvCarReports.ReadOnly = true;
            this.dgvCarReports.RowHeadersVisible = false;
            this.dgvCarReports.RowTemplate.Height = 21;
            this.dgvCarReports.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCarReports.Size = new System.Drawing.Size(599, 727);
            this.dgvCarReports.TabIndex = 10;
            this.dgvCarReports.Click += new System.EventHandler(this.dgvCarReports_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "Author";
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            this.authorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // makerDataGridViewTextBoxColumn
            // 
            this.makerDataGridViewTextBoxColumn.DataPropertyName = "Maker";
            this.makerDataGridViewTextBoxColumn.HeaderText = "Maker";
            this.makerDataGridViewTextBoxColumn.Name = "makerDataGridViewTextBoxColumn";
            this.makerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carNameDataGridViewTextBoxColumn
            // 
            this.carNameDataGridViewTextBoxColumn.DataPropertyName = "CarName";
            this.carNameDataGridViewTextBoxColumn.HeaderText = "CarName";
            this.carNameDataGridViewTextBoxColumn.Name = "carNameDataGridViewTextBoxColumn";
            this.carNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reportDataGridViewTextBoxColumn
            // 
            this.reportDataGridViewTextBoxColumn.DataPropertyName = "Report";
            this.reportDataGridViewTextBoxColumn.HeaderText = "Report";
            this.reportDataGridViewTextBoxColumn.Name = "reportDataGridViewTextBoxColumn";
            this.reportDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imageDataGridViewImageColumn
            // 
            this.imageDataGridViewImageColumn.DataPropertyName = "Image";
            this.imageDataGridViewImageColumn.HeaderText = "Image";
            this.imageDataGridViewImageColumn.Name = "imageDataGridViewImageColumn";
            this.imageDataGridViewImageColumn.ReadOnly = true;
            // 
            // carReportTableBindingSource
            // 
            this.carReportTableBindingSource.DataMember = "CarReportTable";
            this.carReportTableBindingSource.DataSource = this.infosys202327DataSet;
            // 
            // infosys202327DataSet
            // 
            this.infosys202327DataSet.DataSetName = "infosys202327DataSet";
            this.infosys202327DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(782, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "記事一覧：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(404, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "画像：";
            // 
            // btImageOpen
            // 
            this.btImageOpen.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btImageOpen.Location = new System.Drawing.Point(468, 40);
            this.btImageOpen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btImageOpen.Name = "btImageOpen";
            this.btImageOpen.Size = new System.Drawing.Size(87, 29);
            this.btImageOpen.TabIndex = 6;
            this.btImageOpen.Text = "開く...";
            this.btImageOpen.UseVisualStyleBackColor = true;
            this.btImageOpen.Click += new System.EventHandler(this.btImageOpen_Click);
            // 
            // btImageDelete
            // 
            this.btImageDelete.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btImageDelete.Location = new System.Drawing.Point(561, 41);
            this.btImageDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btImageDelete.Name = "btImageDelete";
            this.btImageDelete.Size = new System.Drawing.Size(87, 29);
            this.btImageDelete.TabIndex = 7;
            this.btImageDelete.Text = "削除";
            this.btImageDelete.UseVisualStyleBackColor = true;
            this.btImageDelete.Click += new System.EventHandler(this.btImageDelete_Click);
            // 
            // pbCarImage
            // 
            this.pbCarImage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pbCarImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbCarImage.Location = new System.Drawing.Point(408, 98);
            this.pbCarImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbCarImage.Name = "pbCarImage";
            this.pbCarImage.Size = new System.Drawing.Size(372, 270);
            this.pbCarImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCarImage.TabIndex = 15;
            this.pbCarImage.TabStop = false;
            // 
            // btAddReport
            // 
            this.btAddReport.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btAddReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddReport.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btAddReport.Location = new System.Drawing.Point(442, 396);
            this.btAddReport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btAddReport.Name = "btAddReport";
            this.btAddReport.Size = new System.Drawing.Size(87, 56);
            this.btAddReport.TabIndex = 9;
            this.btAddReport.Text = "追加";
            this.btAddReport.UseVisualStyleBackColor = false;
            this.btAddReport.Click += new System.EventHandler(this.btAddReport_Click);
            // 
            // btModifyReport
            // 
            this.btModifyReport.BackColor = System.Drawing.SystemColors.Info;
            this.btModifyReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btModifyReport.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btModifyReport.Location = new System.Drawing.Point(552, 396);
            this.btModifyReport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btModifyReport.Name = "btModifyReport";
            this.btModifyReport.Size = new System.Drawing.Size(87, 56);
            this.btModifyReport.TabIndex = 10;
            this.btModifyReport.Text = "修正";
            this.btModifyReport.UseVisualStyleBackColor = false;
            this.btModifyReport.Click += new System.EventHandler(this.btModifyReport_Click);
            // 
            // btDeleteReport
            // 
            this.btDeleteReport.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btDeleteReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDeleteReport.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btDeleteReport.Location = new System.Drawing.Point(666, 396);
            this.btDeleteReport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btDeleteReport.Name = "btDeleteReport";
            this.btDeleteReport.Size = new System.Drawing.Size(87, 56);
            this.btDeleteReport.TabIndex = 11;
            this.btDeleteReport.Text = "削除";
            this.btDeleteReport.UseVisualStyleBackColor = false;
            this.btDeleteReport.Click += new System.EventHandler(this.btDeleteReport_Click);
            // 
            // menuItems
            // 
            this.menuItems.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuItems.Location = new System.Drawing.Point(0, 0);
            this.menuItems.Name = "menuItems";
            this.menuItems.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuItems.Size = new System.Drawing.Size(1385, 24);
            this.menuItems.TabIndex = 22;
            this.menuItems.Text = "menuStrip1";
            // 
            // ファイルToolStripMenuItem
            // 
            this.ファイルToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.接続OToolStripMenuItem,
            this.toolStripSeparator2,
            this.終了XToolStripMenuItem});
            this.ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            this.ファイルToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.ファイルToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // 接続OToolStripMenuItem
            // 
            this.接続OToolStripMenuItem.Name = "接続OToolStripMenuItem";
            this.接続OToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.接続OToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.接続OToolStripMenuItem.Text = "接続(&O)";
            this.接続OToolStripMenuItem.Click += new System.EventHandler(this.接続OToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(155, 6);
            // 
            // 終了XToolStripMenuItem
            // 
            this.終了XToolStripMenuItem.Name = "終了XToolStripMenuItem";
            this.終了XToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F4)));
            this.終了XToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.終了XToolStripMenuItem.Text = "終了(&X)";
            this.終了XToolStripMenuItem.Click += new System.EventHandler(this.終了XToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmColor});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(57, 20);
            this.toolStripMenuItem1.Text = "編集(&E)";
            // 
            // tsmColor
            // 
            this.tsmColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmBackColor});
            this.tsmColor.Name = "tsmColor";
            this.tsmColor.Size = new System.Drawing.Size(119, 22);
            this.tsmColor.Text = "色設定...";
            // 
            // tsmBackColor
            // 
            this.tsmBackColor.Name = "tsmBackColor";
            this.tsmBackColor.Size = new System.Drawing.Size(98, 22);
            this.tsmBackColor.Text = "背景";
            this.tsmBackColor.Click += new System.EventHandler(this.tsmBackColor_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(65, 20);
            this.toolStripMenuItem2.Text = "ヘルプ(&H)";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(142, 22);
            this.toolStripMenuItem4.Text = "バージョン情報";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // ofdImageFileOpen
            // 
            this.ofdImageFileOpen.FileName = "openFileDialog1";
            // 
            // statusDisp
            // 
            this.statusDisp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsInfoText,
            this.tssNowTime});
            this.statusDisp.Location = new System.Drawing.Point(0, 829);
            this.statusDisp.Name = "statusDisp";
            this.statusDisp.Size = new System.Drawing.Size(1385, 22);
            this.statusDisp.SizingGrip = false;
            this.statusDisp.TabIndex = 23;
            this.statusDisp.Text = "statusStrip1";
            // 
            // tsInfoText
            // 
            this.tsInfoText.Name = "tsInfoText";
            this.tsInfoText.Size = new System.Drawing.Size(118, 17);
            this.tsInfoText.Text = "toolStripStatusLabel1";
            // 
            // tssNowTime
            // 
            this.tssNowTime.Name = "tssNowTime";
            this.tssNowTime.Size = new System.Drawing.Size(118, 17);
            this.tssNowTime.Text = "toolStripStatusLabel1";
            // 
            // tmTimeDisp
            // 
            this.tmTimeDisp.Interval = 1000;
            this.tmTimeDisp.Tick += new System.EventHandler(this.tmTimeDisp_Tick);
            // 
            // btScaleChange
            // 
            this.btScaleChange.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btScaleChange.Location = new System.Drawing.Point(654, 41);
            this.btScaleChange.Name = "btScaleChange";
            this.btScaleChange.Size = new System.Drawing.Size(99, 30);
            this.btScaleChange.TabIndex = 8;
            this.btScaleChange.Text = "サイズ変更";
            this.btScaleChange.UseVisualStyleBackColor = true;
            this.btScaleChange.Click += new System.EventHandler(this.btScaleChange_Click);
            // 
            // ofdCarRepoOpen
            // 
            this.ofdCarRepoOpen.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.dtpSearch_e);
            this.groupBox1.Controls.Add(this.btReset);
            this.groupBox1.Controls.Add(this.btDateSearch);
            this.groupBox1.Controls.Add(this.dtpSearch_s);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btCarNameSearch);
            this.groupBox1.Controls.Add(this.btAuthorSearch);
            this.groupBox1.Controls.Add(this.tbCarNameSearch);
            this.groupBox1.Controls.Add(this.tbAuthorSearch);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(120, 556);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 270);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "検索";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(79, 173);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 15);
            this.label11.TabIndex = 11;
            this.label11.Text = "～";
            // 
            // dtpSearch_e
            // 
            this.dtpSearch_e.Location = new System.Drawing.Point(119, 167);
            this.dtpSearch_e.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpSearch_e.Name = "dtpSearch_e";
            this.dtpSearch_e.Size = new System.Drawing.Size(155, 23);
            this.dtpSearch_e.TabIndex = 10;
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(280, 198);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(104, 23);
            this.btReset.TabIndex = 9;
            this.btReset.Text = "リセット";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // btDateSearch
            // 
            this.btDateSearch.Location = new System.Drawing.Point(280, 169);
            this.btDateSearch.Name = "btDateSearch";
            this.btDateSearch.Size = new System.Drawing.Size(104, 23);
            this.btDateSearch.TabIndex = 8;
            this.btDateSearch.Text = "日付から検索";
            this.btDateSearch.UseVisualStyleBackColor = true;
            this.btDateSearch.Click += new System.EventHandler(this.btDateSearch_Click);
            // 
            // dtpSearch_s
            // 
            this.dtpSearch_s.Location = new System.Drawing.Point(104, 128);
            this.dtpSearch_s.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpSearch_s.Name = "dtpSearch_s";
            this.dtpSearch_s.Size = new System.Drawing.Size(155, 23);
            this.dtpSearch_s.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(43, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 15);
            this.label10.TabIndex = 6;
            this.label10.Text = "日付";
            // 
            // btCarNameSearch
            // 
            this.btCarNameSearch.Location = new System.Drawing.Point(280, 88);
            this.btCarNameSearch.Name = "btCarNameSearch";
            this.btCarNameSearch.Size = new System.Drawing.Size(104, 23);
            this.btCarNameSearch.TabIndex = 5;
            this.btCarNameSearch.Text = "車名から検索";
            this.btCarNameSearch.UseVisualStyleBackColor = true;
            this.btCarNameSearch.Click += new System.EventHandler(this.btCarNameSearch_Click);
            // 
            // btAuthorSearch
            // 
            this.btAuthorSearch.Location = new System.Drawing.Point(280, 50);
            this.btAuthorSearch.Name = "btAuthorSearch";
            this.btAuthorSearch.Size = new System.Drawing.Size(104, 23);
            this.btAuthorSearch.TabIndex = 4;
            this.btAuthorSearch.Text = "記録者から検索";
            this.btAuthorSearch.UseVisualStyleBackColor = true;
            this.btAuthorSearch.Click += new System.EventHandler(this.btAuthorSearch_Click);
            // 
            // tbCarNameSearch
            // 
            this.tbCarNameSearch.Location = new System.Drawing.Point(104, 89);
            this.tbCarNameSearch.Name = "tbCarNameSearch";
            this.tbCarNameSearch.Size = new System.Drawing.Size(155, 23);
            this.tbCarNameSearch.TabIndex = 3;
            // 
            // tbAuthorSearch
            // 
            this.tbAuthorSearch.Location = new System.Drawing.Point(104, 51);
            this.tbAuthorSearch.Name = "tbAuthorSearch";
            this.tbAuthorSearch.Size = new System.Drawing.Size(155, 23);
            this.tbAuthorSearch.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(43, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "車名";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "記録者";
            // 
            // carReportTableTableAdapter
            // 
            this.carReportTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarReportTableTableAdapter = this.carReportTableTableAdapter;
            this.tableAdapterManager.UpdateOrder = CarReportSystem.infosys202327DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1385, 851);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btScaleChange);
            this.Controls.Add(this.statusDisp);
            this.Controls.Add(this.btDeleteReport);
            this.Controls.Add(this.btModifyReport);
            this.Controls.Add(this.btAddReport);
            this.Controls.Add(this.pbCarImage);
            this.Controls.Add(this.btImageDelete);
            this.Controls.Add(this.btImageOpen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvCarReports);
            this.Controls.Add(this.tbReport);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbCarName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gbMaker);
            this.Controls.Add(this.cbAuthor);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuItems);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuItems;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "カーレポート管理システム";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.gbMaker.ResumeLayout(false);
            this.gbMaker.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carReportTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202327DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarImage)).EndInit();
            this.menuItems.ResumeLayout(false);
            this.menuItems.PerformLayout();
            this.statusDisp.ResumeLayout(false);
            this.statusDisp.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cbAuthor;
        private System.Windows.Forms.GroupBox gbMaker;
        private System.Windows.Forms.RadioButton rbDaihatsu;
        private System.Windows.Forms.RadioButton rbOther;
        private System.Windows.Forms.RadioButton rbSuzuki;
        private System.Windows.Forms.RadioButton rbImported;
        private System.Windows.Forms.RadioButton rbSubaru;
        private System.Windows.Forms.RadioButton rbHonda;
        private System.Windows.Forms.RadioButton rbNissan;
        private System.Windows.Forms.RadioButton rbToyota;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbCarName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbReport;
        private System.Windows.Forms.DataGridView dgvCarReports;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btImageOpen;
        private System.Windows.Forms.Button btImageDelete;
        private System.Windows.Forms.PictureBox pbCarImage;
        private System.Windows.Forms.Button btAddReport;
        private System.Windows.Forms.Button btModifyReport;
        private System.Windows.Forms.Button btDeleteReport;
        private System.Windows.Forms.MenuStrip menuItems;
        private System.Windows.Forms.ToolStripMenuItem ファイルToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 接続OToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 終了XToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog ofdImageFileOpen;
        private System.Windows.Forms.StatusStrip statusDisp;
        private System.Windows.Forms.ToolStripStatusLabel tsInfoText;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmColor;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ColorDialog cdColor;
        private System.Windows.Forms.ToolStripMenuItem tsmBackColor;
        private System.Windows.Forms.ToolStripStatusLabel tssNowTime;
        private System.Windows.Forms.Timer tmTimeDisp;
        private System.Windows.Forms.Button btScaleChange;
        private System.Windows.Forms.OpenFileDialog ofdCarRepoOpen;
        private System.Windows.Forms.SaveFileDialog sfdCarRepoSave;
        private infosys202327DataSet infosys202327DataSet;
        private System.Windows.Forms.BindingSource carReportTableBindingSource;
        private infosys202327DataSetTableAdapters.CarReportTableTableAdapter carReportTableTableAdapter;
        private infosys202327DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn makerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btCarNameSearch;
        private System.Windows.Forms.Button btAuthorSearch;
        private System.Windows.Forms.TextBox tbCarNameSearch;
        private System.Windows.Forms.TextBox tbAuthorSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btDateSearch;
        private System.Windows.Forms.DateTimePicker dtpSearch_s;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.DateTimePicker dtpSearch_e;
        private System.Windows.Forms.Label label11;
    }
}

