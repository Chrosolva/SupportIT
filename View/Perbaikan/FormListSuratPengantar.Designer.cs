namespace SupportIT.View.Perbaikan
{
    partial class FormListSuratPengantar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListSuratPengantar));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.GCSP = new DevExpress.XtraGrid.GridControl();
            this.dgvSP = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.mainMenu = new System.Windows.Forms.ToolStrip();
            this.btnTambah = new System.Windows.Forms.ToolStripButton();
            this.btnUbah = new System.Windows.Forms.ToolStripButton();
            this.btnHapus = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.tstButtonCetak = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GCDetSP = new DevExpress.XtraGrid.GridControl();
            this.dgvDetSP = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GCSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.mainMenu.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GCDetSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetSP)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panelControl1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(746, 232);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Surat Pengantar";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.GCSP);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(3, 16);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Padding = new System.Windows.Forms.Padding(8);
            this.panelControl1.Size = new System.Drawing.Size(740, 213);
            this.panelControl1.TabIndex = 9;
            // 
            // GCSP
            // 
            this.GCSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GCSP.Location = new System.Drawing.Point(10, 10);
            this.GCSP.MainView = this.dgvSP;
            this.GCSP.Name = "GCSP";
            this.GCSP.Size = new System.Drawing.Size(720, 193);
            this.GCSP.TabIndex = 0;
            this.GCSP.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvSP,
            this.gridView1});
            // 
            // dgvSP
            // 
            this.dgvSP.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Silver;
            this.dgvSP.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.dgvSP.Appearance.EvenRow.BackColor = System.Drawing.Color.LightSteelBlue;
            this.dgvSP.Appearance.EvenRow.Options.UseBackColor = true;
            this.dgvSP.Appearance.FocusedCell.BackColor = System.Drawing.SystemColors.HotTrack;
            this.dgvSP.Appearance.FocusedCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvSP.Appearance.FocusedCell.Options.UseBackColor = true;
            this.dgvSP.Appearance.FocusedCell.Options.UseForeColor = true;
            this.dgvSP.Appearance.FocusedRow.BackColor = System.Drawing.SystemColors.HotTrack;
            this.dgvSP.Appearance.FocusedRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvSP.Appearance.FocusedRow.Options.UseBackColor = true;
            this.dgvSP.Appearance.FocusedRow.Options.UseForeColor = true;
            this.dgvSP.Appearance.OddRow.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvSP.Appearance.OddRow.Options.UseBackColor = true;
            this.dgvSP.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvSP.Appearance.Preview.BackColor2 = System.Drawing.Color.RoyalBlue;
            this.dgvSP.Appearance.Preview.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSP.Appearance.Preview.Options.UseBackColor = true;
            this.dgvSP.Appearance.Preview.Options.UseFont = true;
            this.dgvSP.Appearance.SelectedRow.BackColor = System.Drawing.Color.RoyalBlue;
            this.dgvSP.Appearance.SelectedRow.Options.UseBackColor = true;
            this.dgvSP.GridControl = this.GCSP;
            this.dgvSP.Name = "dgvSP";
            this.dgvSP.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgvSP.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgvSP.OptionsBehavior.Editable = false;
            this.dgvSP.OptionsView.EnableAppearanceEvenRow = true;
            this.dgvSP.OptionsView.EnableAppearanceOddRow = true;
            this.dgvSP.RowSeparatorHeight = 3;
            this.dgvSP.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.dgvSP_RowClick);
            this.dgvSP.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.dgvSP_FocusedRowChanged);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.GCSP;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
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
            this.tstButtonCetak});
            this.mainMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Padding = new System.Windows.Forms.Padding(3, 0, 1, 0);
            this.mainMenu.Size = new System.Drawing.Size(746, 54);
            this.mainMenu.TabIndex = 11;
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
            this.btnUbah.Enabled = false;
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
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.GCDetSP);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 286);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(746, 225);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detail Surat Pengantar";
            // 
            // GCDetSP
            // 
            this.GCDetSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GCDetSP.Location = new System.Drawing.Point(3, 16);
            this.GCDetSP.MainView = this.dgvDetSP;
            this.GCDetSP.Name = "GCDetSP";
            this.GCDetSP.Size = new System.Drawing.Size(740, 206);
            this.GCDetSP.TabIndex = 0;
            this.GCDetSP.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvDetSP});
            // 
            // dgvDetSP
            // 
            this.dgvDetSP.GridControl = this.GCDetSP;
            this.dgvDetSP.Name = "dgvDetSP";
            // 
            // FormListSuratPengantar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 511);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mainMenu);
            this.Name = "FormListSuratPengantar";
            this.Text = "FormListSuratPengantar";
            this.Load += new System.EventHandler(this.FormListSuratPengantar_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GCSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GCDetSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl GCSP;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvSP;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.ToolStrip mainMenu;
        private System.Windows.Forms.ToolStripButton btnTambah;
        private System.Windows.Forms.ToolStripButton btnUbah;
        private System.Windows.Forms.ToolStripButton btnHapus;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripButton tstButtonCetak;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraGrid.GridControl GCDetSP;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvDetSP;
    }
}