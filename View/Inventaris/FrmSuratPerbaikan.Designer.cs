namespace SupportIT.View.Inventaris
{
    partial class FrmSuratPerbaikan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSuratPerbaikan));
            this.mainMenu = new System.Windows.Forms.ToolStrip();
            this.btnTambah = new System.Windows.Forms.ToolStripButton();
            this.btnUbah = new System.Windows.Forms.ToolStripButton();
            this.btnHapus = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnHistory = new System.Windows.Forms.ToolStripButton();
            this.tstButtonCetak = new System.Windows.Forms.ToolStripButton();
            this.btnExport = new System.Windows.Forms.ToolStripButton();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbPIC = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbKodePT = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rightpanel = new System.Windows.Forms.Panel();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.gbheader = new System.Windows.Forms.GroupBox();
            this.gnDetail = new System.Windows.Forms.GroupBox();
            this.dgvSuratPerbaikan = new System.Windows.Forms.DataGridView();
            this.dgvDetailSP = new System.Windows.Forms.DataGridView();
            this.lstTimeline = new System.Windows.Forms.ListBox();
            this.lblNoSP = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblPIC = new System.Windows.Forms.Label();
            this.lblKodePT = new System.Windows.Forms.Label();
            this.lblKepada = new System.Windows.Forms.Label();
            this.lblLokasi = new System.Windows.Forms.Label();
            this.lblCreatedAt = new System.Windows.Forms.Label();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.lblUpdatedBy = new System.Windows.Forms.Label();
            this.lblUpdatedAt = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.mainMenu.SuspendLayout();
            this.gbFilter.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.mainpanel.SuspendLayout();
            this.gbheader.SuspendLayout();
            this.gnDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuratPerbaikan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailSP)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(198)))), ((int)(((byte)(252)))));
            this.mainMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(10, 10);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnTambah,
            this.btnUbah,
            this.btnHapus,
            this.btnRefresh,
            this.btnHistory,
            this.tstButtonCetak,
            this.btnExport});
            this.mainMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Padding = new System.Windows.Forms.Padding(3, 0, 1, 0);
            this.mainMenu.Size = new System.Drawing.Size(1342, 54);
            this.mainMenu.TabIndex = 3;
            // 
            // btnTambah
            // 
            this.btnTambah.ForeColor = System.Drawing.Color.Black;
            this.btnTambah.Image = ((System.Drawing.Image)(resources.GetObject("btnTambah.Image")));
            this.btnTambah.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnTambah.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnTambah.Size = new System.Drawing.Size(64, 51);
            this.btnTambah.Tag = "Tambah";
            this.btnTambah.Text = "&Tambah";
            this.btnTambah.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnUbah
            // 
            this.btnUbah.ForeColor = System.Drawing.Color.Black;
            this.btnUbah.Image = ((System.Drawing.Image)(resources.GetObject("btnUbah.Image")));
            this.btnUbah.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnUbah.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnUbah.Size = new System.Drawing.Size(49, 51);
            this.btnUbah.Tag = "Ubah";
            this.btnUbah.Text = "&Ubah";
            this.btnUbah.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnHapus
            // 
            this.btnHapus.ForeColor = System.Drawing.Color.Black;
            this.btnHapus.Image = ((System.Drawing.Image)(resources.GetObject("btnHapus.Image")));
            this.btnHapus.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnHapus.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnHapus.Size = new System.Drawing.Size(55, 51);
            this.btnHapus.Tag = "Hapus";
            this.btnHapus.Text = "&Hapus";
            this.btnHapus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnRefresh
            // 
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnRefresh.Size = new System.Drawing.Size(60, 51);
            this.btnRefresh.Tag = "-";
            this.btnRefresh.Text = "&Refresh";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnHistory
            // 
            this.btnHistory.ForeColor = System.Drawing.Color.Black;
            this.btnHistory.Image = ((System.Drawing.Image)(resources.GetObject("btnHistory.Image")));
            this.btnHistory.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnHistory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnHistory.Size = new System.Drawing.Size(59, 51);
            this.btnHistory.Tag = "-";
            this.btnHistory.Text = "&History";
            this.btnHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHistory.ToolTipText = "History";
            // 
            // tstButtonCetak
            // 
            this.tstButtonCetak.Image = ((System.Drawing.Image)(resources.GetObject("tstButtonCetak.Image")));
            this.tstButtonCetak.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tstButtonCetak.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstButtonCetak.Name = "tstButtonCetak";
            this.tstButtonCetak.Size = new System.Drawing.Size(41, 51);
            this.tstButtonCetak.Text = "Cetak";
            this.tstButtonCetak.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnExport
            // 
            this.btnExport.ForeColor = System.Drawing.Color.Black;
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExport.Name = "btnExport";
            this.btnExport.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnExport.Size = new System.Drawing.Size(54, 51);
            this.btnExport.Tag = "-";
            this.btnExport.Text = "&Export";
            this.btnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExport.ToolTipText = "Import to DB";
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.label6);
            this.gbFilter.Controls.Add(this.txtSearch);
            this.gbFilter.Controls.Add(this.btnFilter);
            this.gbFilter.Controls.Add(this.label5);
            this.gbFilter.Controls.Add(this.cbKodePT);
            this.gbFilter.Controls.Add(this.label4);
            this.gbFilter.Controls.Add(this.cbPIC);
            this.gbFilter.Controls.Add(this.label3);
            this.gbFilter.Controls.Add(this.cbStatus);
            this.gbFilter.Controls.Add(this.label2);
            this.gbFilter.Controls.Add(this.label1);
            this.gbFilter.Controls.Add(this.dtpTo);
            this.gbFilter.Controls.Add(this.dtpFrom);
            this.gbFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbFilter.Location = new System.Drawing.Point(0, 54);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(1342, 78);
            this.gbFilter.TabIndex = 4;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "FILTER";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Dari Tgl";
            // 
            // dtpTo
            // 
            this.dtpTo.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(71, 42);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(200, 20);
            this.dtpTo.TabIndex = 32;
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(71, 16);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(200, 20);
            this.dtpFrom.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Sampai Tgl";
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "ALL",
            "DRAFT",
            "DIKIRIM",
            "DITERIMA",
            "SELESAI"});
            this.cbStatus.Location = new System.Drawing.Point(277, 41);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(88, 21);
            this.cbStatus.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "STATUS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(371, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "PIC";
            // 
            // cbPIC
            // 
            this.cbPIC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPIC.FormattingEnabled = true;
            this.cbPIC.Items.AddRange(new object[] {
            "ALL",
            "DRAFT",
            "DIKIRIM",
            "DITERIMA",
            "SELESAI"});
            this.cbPIC.Location = new System.Drawing.Point(371, 39);
            this.cbPIC.Name = "cbPIC";
            this.cbPIC.Size = new System.Drawing.Size(88, 21);
            this.cbPIC.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(465, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "KODE PT";
            // 
            // cbKodePT
            // 
            this.cbKodePT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKodePT.FormattingEnabled = true;
            this.cbKodePT.Items.AddRange(new object[] {
            "ALL",
            "DRAFT",
            "DIKIRIM",
            "DITERIMA",
            "SELESAI"});
            this.cbKodePT.Location = new System.Drawing.Point(465, 39);
            this.cbKodePT.Name = "cbKodePT";
            this.cbKodePT.Size = new System.Drawing.Size(88, 21);
            this.cbKodePT.TabIndex = 39;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(858, 37);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 41;
            this.btnFilter.Text = "FILTER";
            this.btnFilter.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(559, 40);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(293, 20);
            this.txtSearch.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(565, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "SEARCH";
            // 
            // rightpanel
            // 
            this.rightpanel.Controls.Add(this.label7);
            this.rightpanel.Controls.Add(this.label8);
            this.rightpanel.Controls.Add(this.label9);
            this.rightpanel.Controls.Add(this.label10);
            this.rightpanel.Controls.Add(this.label11);
            this.rightpanel.Controls.Add(this.label12);
            this.rightpanel.Controls.Add(this.label13);
            this.rightpanel.Controls.Add(this.label14);
            this.rightpanel.Controls.Add(this.label15);
            this.rightpanel.Controls.Add(this.label16);
            this.rightpanel.Controls.Add(this.lblUpdatedBy);
            this.rightpanel.Controls.Add(this.lblUpdatedAt);
            this.rightpanel.Controls.Add(this.lblCreatedBy);
            this.rightpanel.Controls.Add(this.lblCreatedAt);
            this.rightpanel.Controls.Add(this.lblLokasi);
            this.rightpanel.Controls.Add(this.lblKepada);
            this.rightpanel.Controls.Add(this.lblKodePT);
            this.rightpanel.Controls.Add(this.lblPIC);
            this.rightpanel.Controls.Add(this.lblStatus);
            this.rightpanel.Controls.Add(this.lblNoSP);
            this.rightpanel.Controls.Add(this.lstTimeline);
            this.rightpanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightpanel.Location = new System.Drawing.Point(1009, 132);
            this.rightpanel.Name = "rightpanel";
            this.rightpanel.Padding = new System.Windows.Forms.Padding(3);
            this.rightpanel.Size = new System.Drawing.Size(333, 428);
            this.rightpanel.TabIndex = 5;
            // 
            // mainpanel
            // 
            this.mainpanel.Controls.Add(this.gnDetail);
            this.mainpanel.Controls.Add(this.gbheader);
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(0, 132);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Padding = new System.Windows.Forms.Padding(3);
            this.mainpanel.Size = new System.Drawing.Size(1009, 428);
            this.mainpanel.TabIndex = 6;
            // 
            // gbheader
            // 
            this.gbheader.Controls.Add(this.dgvSuratPerbaikan);
            this.gbheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbheader.Location = new System.Drawing.Point(3, 3);
            this.gbheader.Name = "gbheader";
            this.gbheader.Size = new System.Drawing.Size(1003, 281);
            this.gbheader.TabIndex = 0;
            this.gbheader.TabStop = false;
            this.gbheader.Text = "SURAT PERBAIKAN";
            // 
            // gnDetail
            // 
            this.gnDetail.Controls.Add(this.dgvDetailSP);
            this.gnDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gnDetail.Location = new System.Drawing.Point(3, 284);
            this.gnDetail.Name = "gnDetail";
            this.gnDetail.Size = new System.Drawing.Size(1003, 141);
            this.gnDetail.TabIndex = 1;
            this.gnDetail.TabStop = false;
            this.gnDetail.Text = "DETAIL SURAT PERBAIKAN";
            // 
            // dgvSuratPerbaikan
            // 
            this.dgvSuratPerbaikan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuratPerbaikan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSuratPerbaikan.Location = new System.Drawing.Point(3, 16);
            this.dgvSuratPerbaikan.Name = "dgvSuratPerbaikan";
            this.dgvSuratPerbaikan.Size = new System.Drawing.Size(997, 262);
            this.dgvSuratPerbaikan.TabIndex = 0;
            // 
            // dgvDetailSP
            // 
            this.dgvDetailSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetailSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetailSP.Location = new System.Drawing.Point(3, 16);
            this.dgvDetailSP.Name = "dgvDetailSP";
            this.dgvDetailSP.Size = new System.Drawing.Size(997, 122);
            this.dgvDetailSP.TabIndex = 0;
            // 
            // lstTimeline
            // 
            this.lstTimeline.FormattingEnabled = true;
            this.lstTimeline.Location = new System.Drawing.Point(6, 258);
            this.lstTimeline.Name = "lstTimeline";
            this.lstTimeline.Size = new System.Drawing.Size(315, 160);
            this.lstTimeline.TabIndex = 0;
            // 
            // lblNoSP
            // 
            this.lblNoSP.AutoSize = true;
            this.lblNoSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoSP.Location = new System.Drawing.Point(86, 19);
            this.lblNoSP.Name = "lblNoSP";
            this.lblNoSP.Size = new System.Drawing.Size(41, 13);
            this.lblNoSP.TabIndex = 44;
            this.lblNoSP.Text = "NOSP";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(86, 41);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 44;
            this.lblStatus.Text = "Status";
            // 
            // lblPIC
            // 
            this.lblPIC.AutoSize = true;
            this.lblPIC.Location = new System.Drawing.Point(86, 63);
            this.lblPIC.Name = "lblPIC";
            this.lblPIC.Size = new System.Drawing.Size(24, 13);
            this.lblPIC.TabIndex = 45;
            this.lblPIC.Text = "PIC";
            // 
            // lblKodePT
            // 
            this.lblKodePT.AutoSize = true;
            this.lblKodePT.Location = new System.Drawing.Point(86, 85);
            this.lblKodePT.Name = "lblKodePT";
            this.lblKodePT.Size = new System.Drawing.Size(46, 13);
            this.lblKodePT.TabIndex = 46;
            this.lblKodePT.Text = "KodePT";
            // 
            // lblKepada
            // 
            this.lblKepada.AutoSize = true;
            this.lblKepada.Location = new System.Drawing.Point(86, 108);
            this.lblKepada.Name = "lblKepada";
            this.lblKepada.Size = new System.Drawing.Size(44, 13);
            this.lblKepada.TabIndex = 47;
            this.lblKepada.Text = "Kepada";
            // 
            // lblLokasi
            // 
            this.lblLokasi.AutoSize = true;
            this.lblLokasi.Location = new System.Drawing.Point(86, 131);
            this.lblLokasi.Name = "lblLokasi";
            this.lblLokasi.Size = new System.Drawing.Size(38, 13);
            this.lblLokasi.TabIndex = 48;
            this.lblLokasi.Text = "Lokasi";
            // 
            // lblCreatedAt
            // 
            this.lblCreatedAt.AutoSize = true;
            this.lblCreatedAt.Location = new System.Drawing.Point(86, 153);
            this.lblCreatedAt.Name = "lblCreatedAt";
            this.lblCreatedAt.Size = new System.Drawing.Size(57, 13);
            this.lblCreatedAt.TabIndex = 49;
            this.lblCreatedAt.Text = "Created At";
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Location = new System.Drawing.Point(86, 175);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(59, 13);
            this.lblCreatedBy.TabIndex = 50;
            this.lblCreatedBy.Text = "Created By";
            // 
            // lblUpdatedBy
            // 
            this.lblUpdatedBy.AutoSize = true;
            this.lblUpdatedBy.Location = new System.Drawing.Point(86, 219);
            this.lblUpdatedBy.Name = "lblUpdatedBy";
            this.lblUpdatedBy.Size = new System.Drawing.Size(63, 13);
            this.lblUpdatedBy.TabIndex = 52;
            this.lblUpdatedBy.Text = "Updated By";
            // 
            // lblUpdatedAt
            // 
            this.lblUpdatedAt.AutoSize = true;
            this.lblUpdatedAt.Location = new System.Drawing.Point(86, 197);
            this.lblUpdatedAt.Name = "lblUpdatedAt";
            this.lblUpdatedAt.Size = new System.Drawing.Size(61, 13);
            this.lblUpdatedAt.TabIndex = 51;
            this.lblUpdatedAt.Text = "Updated At";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 62;
            this.label7.Text = "Updated By";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 61;
            this.label8.Text = "Updated At";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 60;
            this.label9.Text = "Created By";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 153);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 59;
            this.label10.Text = "Created At";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 131);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 58;
            this.label11.Text = "Lokasi";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 108);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 57;
            this.label12.Text = "Kepada";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 85);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 56;
            this.label13.Text = "KodePT";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 63);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(24, 13);
            this.label14.TabIndex = 55;
            this.label14.Text = "PIC";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 41);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 13);
            this.label15.TabIndex = 53;
            this.label15.Text = "Status";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(6, 19);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 13);
            this.label16.TabIndex = 54;
            this.label16.Text = "NOSP";
            // 
            // FrmSuratPerbaikan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 560);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.rightpanel);
            this.Controls.Add(this.gbFilter);
            this.Controls.Add(this.mainMenu);
            this.Name = "FrmSuratPerbaikan";
            this.Text = "FrmSuratPerbaikan";
            this.Load += new System.EventHandler(this.FrmSuratPerbaikan_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.rightpanel.ResumeLayout(false);
            this.rightpanel.PerformLayout();
            this.mainpanel.ResumeLayout(false);
            this.gbheader.ResumeLayout(false);
            this.gnDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuratPerbaikan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip mainMenu;
        private System.Windows.Forms.ToolStripButton btnTambah;
        private System.Windows.Forms.ToolStripButton btnUbah;
        private System.Windows.Forms.ToolStripButton btnHapus;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripButton btnHistory;
        private System.Windows.Forms.ToolStripButton tstButtonCetak;
        private System.Windows.Forms.ToolStripButton btnExport;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbKodePT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbPIC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel rightpanel;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblUpdatedBy;
        private System.Windows.Forms.Label lblUpdatedAt;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label lblCreatedAt;
        private System.Windows.Forms.Label lblLokasi;
        private System.Windows.Forms.Label lblKepada;
        private System.Windows.Forms.Label lblKodePT;
        private System.Windows.Forms.Label lblPIC;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblNoSP;
        private System.Windows.Forms.ListBox lstTimeline;
        private System.Windows.Forms.GroupBox gnDetail;
        private System.Windows.Forms.DataGridView dgvDetailSP;
        private System.Windows.Forms.GroupBox gbheader;
        private System.Windows.Forms.DataGridView dgvSuratPerbaikan;
    }
}