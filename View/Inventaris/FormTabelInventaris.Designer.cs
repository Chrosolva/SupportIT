namespace Inventaris.View
{
    partial class FormTabelInventaris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTabelInventaris));
            this.mainMenu = new System.Windows.Forms.ToolStrip();
            this.btnTambah = new System.Windows.Forms.ToolStripButton();
            this.btnUbah = new System.Windows.Forms.ToolStripButton();
            this.btnHapus = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnFilter = new System.Windows.Forms.ToolStripButton();
            this.tsbCopy = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cbxSearch = new System.Windows.Forms.ToolStripComboBox();
            this.txtSearch = new System.Windows.Forms.ToolStripTextBox();
            this.btnCari = new System.Windows.Forms.ToolStripButton();
            this.btnHistory = new System.Windows.Forms.ToolStripButton();
            this.tstButtonCetak = new System.Windows.Forms.ToolStripButton();
            this.btnExport = new System.Windows.Forms.ToolStripButton();
            this.tstBarcode = new System.Windows.Forms.ToolStripButton();
            this.btnImport = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.chkAllYear = new System.Windows.Forms.CheckBox();
            this.NUDTahun = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbxKodeKebun = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbxKodeKategori = new System.Windows.Forms.ComboBox();
            this.groupBoxInventaris = new System.Windows.Forms.GroupBox();
            this.GCInv = new DevExpress.XtraGrid.GridControl();
            this.DgvForInventaris = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnAfkir = new System.Windows.Forms.ToolStripButton();
            this.mainMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDTahun)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBoxInventaris.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GCInv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvForInventaris)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            this.btnFilter,
            this.tsbCopy,
            this.toolStripLabel1,
            this.cbxSearch,
            this.txtSearch,
            this.btnCari,
            this.btnHistory,
            this.tstButtonCetak,
            this.btnExport,
            this.tstBarcode,
            this.btnImport,
            this.btnAfkir});
            this.mainMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Padding = new System.Windows.Forms.Padding(3, 0, 1, 0);
            this.mainMenu.Size = new System.Drawing.Size(1280, 54);
            this.mainMenu.TabIndex = 2;
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
            this.btnTambah.Click += new System.EventHandler(this.BtnTambah_Click);
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
            this.btnUbah.Click += new System.EventHandler(this.BtnUbah_Click);
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
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
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
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.ForeColor = System.Drawing.Color.Black;
            this.btnFilter.Image = ((System.Drawing.Image)(resources.GetObject("btnFilter.Image")));
            this.btnFilter.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnFilter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnFilter.Size = new System.Drawing.Size(47, 51);
            this.btnFilter.Tag = "-";
            this.btnFilter.Text = "&Filter";
            this.btnFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // tsbCopy
            // 
            this.tsbCopy.ForeColor = System.Drawing.Color.Black;
            this.tsbCopy.Image = ((System.Drawing.Image)(resources.GetObject("tsbCopy.Image")));
            this.tsbCopy.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCopy.Name = "tsbCopy";
            this.tsbCopy.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsbCopy.Size = new System.Drawing.Size(49, 51);
            this.tsbCopy.Tag = "Copy";
            this.tsbCopy.Text = "&Copy";
            this.tsbCopy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbCopy.Click += new System.EventHandler(this.tsbCopy_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(98, 51);
            this.toolStripLabel1.Text = "Cari Berdasarkan.";
            // 
            // cbxSearch
            // 
            this.cbxSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSearch.Items.AddRange(new object[] {
            "KodeInventaris",
            "NamaBarang",
            "KodeInvLama"});
            this.cbxSearch.Margin = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.cbxSearch.Name = "cbxSearch";
            this.cbxSearch.Size = new System.Drawing.Size(121, 54);
            // 
            // txtSearch
            // 
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(220, 54);
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnCari
            // 
            this.btnCari.ForeColor = System.Drawing.Color.Black;
            this.btnCari.Image = ((System.Drawing.Image)(resources.GetObject("btnCari.Image")));
            this.btnCari.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCari.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCari.Name = "btnCari";
            this.btnCari.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnCari.Size = new System.Drawing.Size(46, 51);
            this.btnCari.Tag = "-";
            this.btnCari.Text = "&Cari";
            this.btnCari.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
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
            this.btnHistory.Click += new System.EventHandler(this.BtnHistory_Click);
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
            this.tstButtonCetak.Click += new System.EventHandler(this.tstButtonCetak_Click);
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
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // tstBarcode
            // 
            this.tstBarcode.Image = ((System.Drawing.Image)(resources.GetObject("tstBarcode.Image")));
            this.tstBarcode.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tstBarcode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstBarcode.Name = "tstBarcode";
            this.tstBarcode.Size = new System.Drawing.Size(54, 51);
            this.tstBarcode.Text = "Barcode";
            this.tstBarcode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tstBarcode.Click += new System.EventHandler(this.tstBarcode_Click);
            // 
            // btnImport
            // 
            this.btnImport.ForeColor = System.Drawing.Color.Black;
            this.btnImport.Image = ((System.Drawing.Image)(resources.GetObject("btnImport.Image")));
            this.btnImport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImport.Name = "btnImport";
            this.btnImport.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnImport.Size = new System.Drawing.Size(89, 51);
            this.btnImport.Tag = "-";
            this.btnImport.Text = "&Import to DB";
            this.btnImport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnImport.ToolTipText = "Import to DB";
            this.btnImport.Click += new System.EventHandler(this.BtnImport_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(0, 54);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1280, 81);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.groupBox5.Controls.Add(this.cbxStatus);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox5.Location = new System.Drawing.Point(568, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(119, 47);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Status";
            // 
            // cbxStatus
            // 
            this.cbxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Items.AddRange(new object[] {
            "Semua",
            "Aktif",
            "Rusak",
            "Afkir",
            "Tidak Active"});
            this.cbxStatus.Location = new System.Drawing.Point(9, 16);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(97, 21);
            this.cbxStatus.TabIndex = 2;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.groupBox6.Controls.Add(this.chkAllYear);
            this.groupBox6.Controls.Add(this.NUDTahun);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox6.Location = new System.Drawing.Point(379, 19);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(183, 47);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Tahun";
            // 
            // chkAllYear
            // 
            this.chkAllYear.AutoSize = true;
            this.chkAllYear.ForeColor = System.Drawing.Color.White;
            this.chkAllYear.Location = new System.Drawing.Point(81, 20);
            this.chkAllYear.Name = "chkAllYear";
            this.chkAllYear.Size = new System.Drawing.Size(93, 17);
            this.chkAllYear.TabIndex = 5;
            this.chkAllYear.Text = "Semua Tahun";
            this.chkAllYear.UseVisualStyleBackColor = true;
            this.chkAllYear.CheckedChanged += new System.EventHandler(this.chkAllYear_CheckedChanged);
            // 
            // NUDTahun
            // 
            this.NUDTahun.Location = new System.Drawing.Point(7, 19);
            this.NUDTahun.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.NUDTahun.Minimum = new decimal(new int[] {
            1980,
            0,
            0,
            0});
            this.NUDTahun.Name = "NUDTahun";
            this.NUDTahun.Size = new System.Drawing.Size(68, 20);
            this.NUDTahun.TabIndex = 4;
            this.NUDTahun.Value = new decimal(new int[] {
            1980,
            0,
            0,
            0});
            this.NUDTahun.ValueChanged += new System.EventHandler(this.NUDTahun_ValueChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.groupBox4.Controls.Add(this.cbxKodeKebun);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.groupBox4.Location = new System.Drawing.Point(195, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(165, 47);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Kebun";
            // 
            // cbxKodeKebun
            // 
            this.cbxKodeKebun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxKodeKebun.FormattingEnabled = true;
            this.cbxKodeKebun.Items.AddRange(new object[] {
            "Semua"});
            this.cbxKodeKebun.Location = new System.Drawing.Point(6, 13);
            this.cbxKodeKebun.Name = "cbxKodeKebun";
            this.cbxKodeKebun.Size = new System.Drawing.Size(153, 21);
            this.cbxKodeKebun.TabIndex = 1;
            this.cbxKodeKebun.SelectedIndexChanged += new System.EventHandler(this.cbxKodeKebun_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.groupBox3.Controls.Add(this.cbxKodeKategori);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.groupBox3.Location = new System.Drawing.Point(24, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(165, 47);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kategori";
            // 
            // cbxKodeKategori
            // 
            this.cbxKodeKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxKodeKategori.FormattingEnabled = true;
            this.cbxKodeKategori.Items.AddRange(new object[] {
            "Semua"});
            this.cbxKodeKategori.Location = new System.Drawing.Point(6, 12);
            this.cbxKodeKategori.Name = "cbxKodeKategori";
            this.cbxKodeKategori.Size = new System.Drawing.Size(153, 21);
            this.cbxKodeKategori.TabIndex = 1;
            this.cbxKodeKategori.SelectedIndexChanged += new System.EventHandler(this.cbxKodeKategori_SelectedIndexChanged);
            // 
            // groupBoxInventaris
            // 
            this.groupBoxInventaris.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBoxInventaris.Controls.Add(this.GCInv);
            this.groupBoxInventaris.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInventaris.Location = new System.Drawing.Point(0, 135);
            this.groupBoxInventaris.Name = "groupBoxInventaris";
            this.groupBoxInventaris.Size = new System.Drawing.Size(1280, 426);
            this.groupBoxInventaris.TabIndex = 6;
            this.groupBoxInventaris.TabStop = false;
            this.groupBoxInventaris.Enter += new System.EventHandler(this.GroupBoxInventaris_Enter);
            // 
            // GCInv
            // 
            this.GCInv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GCInv.Location = new System.Drawing.Point(3, 16);
            this.GCInv.MainView = this.DgvForInventaris;
            this.GCInv.Name = "GCInv";
            this.GCInv.Size = new System.Drawing.Size(1274, 407);
            this.GCInv.TabIndex = 1;
            this.GCInv.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.DgvForInventaris,
            this.gridView1});
            // 
            // DgvForInventaris
            // 
            this.DgvForInventaris.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Silver;
            this.DgvForInventaris.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.DgvForInventaris.Appearance.EvenRow.BackColor = System.Drawing.Color.CornflowerBlue;
            this.DgvForInventaris.Appearance.EvenRow.Options.UseBackColor = true;
            this.DgvForInventaris.Appearance.FocusedCell.BackColor = System.Drawing.SystemColors.HotTrack;
            this.DgvForInventaris.Appearance.FocusedCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DgvForInventaris.Appearance.FocusedCell.Options.UseBackColor = true;
            this.DgvForInventaris.Appearance.FocusedCell.Options.UseForeColor = true;
            this.DgvForInventaris.Appearance.FocusedRow.BackColor = System.Drawing.SystemColors.HotTrack;
            this.DgvForInventaris.Appearance.FocusedRow.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            this.DgvForInventaris.Appearance.FocusedRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DgvForInventaris.Appearance.FocusedRow.Options.UseBackColor = true;
            this.DgvForInventaris.Appearance.FocusedRow.Options.UseForeColor = true;
            this.DgvForInventaris.Appearance.OddRow.BackColor = System.Drawing.Color.Gainsboro;
            this.DgvForInventaris.Appearance.OddRow.Options.UseBackColor = true;
            this.DgvForInventaris.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DgvForInventaris.Appearance.Preview.BackColor2 = System.Drawing.Color.RoyalBlue;
            this.DgvForInventaris.Appearance.Preview.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvForInventaris.Appearance.Preview.Options.UseBackColor = true;
            this.DgvForInventaris.Appearance.Preview.Options.UseFont = true;
            this.DgvForInventaris.Appearance.SelectedRow.BackColor = System.Drawing.Color.RoyalBlue;
            this.DgvForInventaris.Appearance.SelectedRow.Options.UseBackColor = true;
            this.DgvForInventaris.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.DgvForInventaris.GridControl = this.GCInv;
            this.DgvForInventaris.Name = "DgvForInventaris";
            this.DgvForInventaris.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.DgvForInventaris.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.DgvForInventaris.OptionsBehavior.Editable = false;
            this.DgvForInventaris.OptionsView.EnableAppearanceEvenRow = true;
            this.DgvForInventaris.OptionsView.EnableAppearanceOddRow = true;
            this.DgvForInventaris.RowSeparatorHeight = 3;
            this.DgvForInventaris.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.DgvForInventaris_SelectionChanged);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.GCInv;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            // 
            // btnAfkir
            // 
            this.btnAfkir.ForeColor = System.Drawing.Color.Black;
            this.btnAfkir.Image = ((System.Drawing.Image)(resources.GetObject("btnAfkir.Image")));
            this.btnAfkir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAfkir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAfkir.Name = "btnAfkir";
            this.btnAfkir.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnAfkir.Size = new System.Drawing.Size(52, 51);
            this.btnAfkir.Tag = "-";
            this.btnAfkir.Text = "&AFKIR";
            this.btnAfkir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAfkir.ToolTipText = "Import to DB";
            this.btnAfkir.Click += new System.EventHandler(this.btnAfkir_Click);
            // 
            // FormTabelInventaris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(1280, 561);
            this.Controls.Add(this.groupBoxInventaris);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormTabelInventaris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "                                                                    ";
            this.Load += new System.EventHandler(this.FormTabelInventaris_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDTahun)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBoxInventaris.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GCInv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvForInventaris)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
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
        private System.Windows.Forms.ToolStripTextBox txtSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxInventaris;
        private System.Windows.Forms.ToolStripButton btnFilter;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox cbxSearch;
        private System.Windows.Forms.ToolStripButton btnCari;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbxKodeKategori;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbxKodeKebun;
        private System.Windows.Forms.ToolStripButton btnImport;
        private System.Windows.Forms.ToolStripButton tstButtonCetak;
        private System.Windows.Forms.NumericUpDown NUDTahun;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox chkAllYear;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.ToolStripButton btnExport;
        private DevExpress.XtraGrid.GridControl GCInv;
        private DevExpress.XtraGrid.Views.Grid.GridView DgvForInventaris;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.ToolStripButton tstBarcode;
        private System.Windows.Forms.ToolStripButton tsbCopy;
        private System.Windows.Forms.ToolStripButton btnAfkir;
    }
}