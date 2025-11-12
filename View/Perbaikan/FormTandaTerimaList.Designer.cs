namespace SupportIT.View.Perbaikan
{
    partial class FormTandaTerimaList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTandaTerimaList));
            this.mainMenu = new System.Windows.Forms.ToolStrip();
            this.btnTambah = new System.Windows.Forms.ToolStripButton();
            this.btnUbah = new System.Windows.Forms.ToolStripButton();
            this.btnHapus = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnFilter = new System.Windows.Forms.ToolStripButton();
            this.btnCari = new System.Windows.Forms.ToolStripButton();
            this.btnHistory = new System.Windows.Forms.ToolStripButton();
            this.tstButtonCetak = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridCtrDetTT = new DevExpress.XtraGrid.GridControl();
            this.dgvDetTT = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.GCTT = new DevExpress.XtraGrid.GridControl();
            this.dgvTT = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.mainMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrDetTT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetTT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GCTT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTT)).BeginInit();
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
            this.btnCari,
            this.btnHistory,
            this.tstButtonCetak});
            this.mainMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Padding = new System.Windows.Forms.Padding(3, 0, 1, 0);
            this.mainMenu.Size = new System.Drawing.Size(800, 54);
            this.mainMenu.TabIndex = 4;
            // 
            // btnTambah
            // 
            this.btnTambah.ForeColor = System.Drawing.Color.Black;
            this.btnTambah.Image = ((System.Drawing.Image)(resources.GetObject("btnTambah.Image")));
            this.btnTambah.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnTambah.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnTambah.Size = new System.Drawing.Size(63, 51);
            this.btnTambah.Tag = "Tambah";
            this.btnTambah.Text = "&Tambah";
            this.btnTambah.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
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
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
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
            // 
            // btnHistory
            // 
            this.btnHistory.Enabled = false;
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
            this.tstButtonCetak.Click += new System.EventHandler(this.tstButtonCetak_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridCtrDetTT);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 286);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 206);
            this.panel1.TabIndex = 9;
            // 
            // gridCtrDetTT
            // 
            this.gridCtrDetTT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCtrDetTT.Location = new System.Drawing.Point(0, 0);
            this.gridCtrDetTT.MainView = this.dgvDetTT;
            this.gridCtrDetTT.Name = "gridCtrDetTT";
            this.gridCtrDetTT.Size = new System.Drawing.Size(800, 206);
            this.gridCtrDetTT.TabIndex = 1;
            this.gridCtrDetTT.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvDetTT,
            this.gridView3});
            // 
            // dgvDetTT
            // 
            this.dgvDetTT.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Silver;
            this.dgvDetTT.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.dgvDetTT.Appearance.EvenRow.BackColor = System.Drawing.Color.LightSteelBlue;
            this.dgvDetTT.Appearance.EvenRow.Options.UseBackColor = true;
            this.dgvDetTT.Appearance.FocusedCell.BackColor = System.Drawing.SystemColors.HotTrack;
            this.dgvDetTT.Appearance.FocusedCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvDetTT.Appearance.FocusedCell.Options.UseBackColor = true;
            this.dgvDetTT.Appearance.FocusedCell.Options.UseForeColor = true;
            this.dgvDetTT.Appearance.FocusedRow.BackColor = System.Drawing.SystemColors.HotTrack;
            this.dgvDetTT.Appearance.FocusedRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvDetTT.Appearance.FocusedRow.Options.UseBackColor = true;
            this.dgvDetTT.Appearance.FocusedRow.Options.UseForeColor = true;
            this.dgvDetTT.Appearance.OddRow.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvDetTT.Appearance.OddRow.Options.UseBackColor = true;
            this.dgvDetTT.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvDetTT.Appearance.Preview.BackColor2 = System.Drawing.Color.RoyalBlue;
            this.dgvDetTT.Appearance.Preview.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDetTT.Appearance.Preview.Options.UseBackColor = true;
            this.dgvDetTT.Appearance.Preview.Options.UseFont = true;
            this.dgvDetTT.Appearance.SelectedRow.BackColor = System.Drawing.Color.RoyalBlue;
            this.dgvDetTT.Appearance.SelectedRow.Options.UseBackColor = true;
            this.dgvDetTT.GridControl = this.gridCtrDetTT;
            this.dgvDetTT.Name = "dgvDetTT";
            this.dgvDetTT.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgvDetTT.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgvDetTT.OptionsBehavior.Editable = false;
            this.dgvDetTT.OptionsView.EnableAppearanceEvenRow = true;
            this.dgvDetTT.OptionsView.EnableAppearanceOddRow = true;
            this.dgvDetTT.RowSeparatorHeight = 3;
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.gridCtrDetTT;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView3.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView3.OptionsBehavior.Editable = false;
            this.gridView3.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panelControl1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 232);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.GCTT);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(3, 16);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Padding = new System.Windows.Forms.Padding(8);
            this.panelControl1.Size = new System.Drawing.Size(794, 213);
            this.panelControl1.TabIndex = 9;
            // 
            // GCTT
            // 
            this.GCTT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GCTT.Location = new System.Drawing.Point(10, 10);
            this.GCTT.MainView = this.dgvTT;
            this.GCTT.Name = "GCTT";
            this.GCTT.Size = new System.Drawing.Size(774, 193);
            this.GCTT.TabIndex = 0;
            this.GCTT.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvTT,
            this.gridView1});
            // 
            // dgvTT
            // 
            this.dgvTT.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Silver;
            this.dgvTT.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.dgvTT.Appearance.EvenRow.BackColor = System.Drawing.Color.LightSteelBlue;
            this.dgvTT.Appearance.EvenRow.Options.UseBackColor = true;
            this.dgvTT.Appearance.FocusedCell.BackColor = System.Drawing.SystemColors.HotTrack;
            this.dgvTT.Appearance.FocusedCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvTT.Appearance.FocusedCell.Options.UseBackColor = true;
            this.dgvTT.Appearance.FocusedCell.Options.UseForeColor = true;
            this.dgvTT.Appearance.FocusedRow.BackColor = System.Drawing.SystemColors.HotTrack;
            this.dgvTT.Appearance.FocusedRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvTT.Appearance.FocusedRow.Options.UseBackColor = true;
            this.dgvTT.Appearance.FocusedRow.Options.UseForeColor = true;
            this.dgvTT.Appearance.OddRow.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvTT.Appearance.OddRow.Options.UseBackColor = true;
            this.dgvTT.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvTT.Appearance.Preview.BackColor2 = System.Drawing.Color.RoyalBlue;
            this.dgvTT.Appearance.Preview.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTT.Appearance.Preview.Options.UseBackColor = true;
            this.dgvTT.Appearance.Preview.Options.UseFont = true;
            this.dgvTT.Appearance.SelectedRow.BackColor = System.Drawing.Color.RoyalBlue;
            this.dgvTT.Appearance.SelectedRow.Options.UseBackColor = true;
            this.dgvTT.GridControl = this.GCTT;
            this.dgvTT.Name = "dgvTT";
            this.dgvTT.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgvTT.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgvTT.OptionsBehavior.Editable = false;
            this.dgvTT.OptionsView.EnableAppearanceEvenRow = true;
            this.dgvTT.OptionsView.EnableAppearanceOddRow = true;
            this.dgvTT.RowSeparatorHeight = 3;
            this.dgvTT.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.dgvTT_FocusedRowChanged);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.GCTT;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            // 
            // FormTandaTerimaList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mainMenu);
            this.Name = "FormTandaTerimaList";
            this.Text = "FormTandaTerimaList";
            this.Load += new System.EventHandler(this.FormTandaTerimaList_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrDetTT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetTT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GCTT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTT)).EndInit();
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
        private System.Windows.Forms.ToolStripButton btnFilter;
        private System.Windows.Forms.ToolStripButton btnCari;
        private System.Windows.Forms.ToolStripButton btnHistory;
        private System.Windows.Forms.ToolStripButton tstButtonCetak;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridCtrDetTT;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvDetTT;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl GCTT;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvTT;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}