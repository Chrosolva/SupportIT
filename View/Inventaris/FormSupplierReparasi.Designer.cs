namespace SupportIT.View.Inventaris
{
    partial class FormSupplierReparasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSupplierReparasi));
            this.mainMenu = new System.Windows.Forms.ToolStrip();
            this.btnTambah = new System.Windows.Forms.ToolStripButton();
            this.btnUbah = new System.Windows.Forms.ToolStripButton();
            this.btnHapus = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnFilter = new System.Windows.Forms.ToolStripButton();
            this.btnCari = new System.Windows.Forms.ToolStripButton();
            this.btnHistory = new System.Windows.Forms.ToolStripButton();
            this.tstButtonCetak = new System.Windows.Forms.ToolStripButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.dgvSPReparasi = new DevExpress.XtraGrid.GridControl();
            this.dgvReparasii = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSPReparasi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReparasii)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
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
            this.mainMenu.Size = new System.Drawing.Size(1012, 54);
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
            this.btnTambah.Size = new System.Drawing.Size(63, 51);
            this.btnTambah.Tag = "Tambah";
            this.btnTambah.Text = "&Tambah";
            this.btnTambah.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
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
            this.btnHapus.Visible = false;
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
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.dgvSPReparasi);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 54);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Padding = new System.Windows.Forms.Padding(8);
            this.panelControl1.Size = new System.Drawing.Size(1012, 297);
            this.panelControl1.TabIndex = 7;
            // 
            // dgvSPReparasi
            // 
            this.dgvSPReparasi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSPReparasi.Location = new System.Drawing.Point(10, 10);
            this.dgvSPReparasi.MainView = this.dgvReparasii;
            this.dgvSPReparasi.Name = "dgvSPReparasi";
            this.dgvSPReparasi.Size = new System.Drawing.Size(992, 277);
            this.dgvSPReparasi.TabIndex = 0;
            this.dgvSPReparasi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvReparasii,
            this.gridView1});
            // 
            // dgvReparasii
            // 
            this.dgvReparasii.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Silver;
            this.dgvReparasii.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.dgvReparasii.Appearance.EvenRow.BackColor = System.Drawing.Color.LightSteelBlue;
            this.dgvReparasii.Appearance.EvenRow.Options.UseBackColor = true;
            this.dgvReparasii.Appearance.FocusedCell.BackColor = System.Drawing.SystemColors.HotTrack;
            this.dgvReparasii.Appearance.FocusedCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvReparasii.Appearance.FocusedCell.Options.UseBackColor = true;
            this.dgvReparasii.Appearance.FocusedCell.Options.UseForeColor = true;
            this.dgvReparasii.Appearance.FocusedRow.BackColor = System.Drawing.SystemColors.HotTrack;
            this.dgvReparasii.Appearance.FocusedRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvReparasii.Appearance.FocusedRow.Options.UseBackColor = true;
            this.dgvReparasii.Appearance.FocusedRow.Options.UseForeColor = true;
            this.dgvReparasii.Appearance.OddRow.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvReparasii.Appearance.OddRow.Options.UseBackColor = true;
            this.dgvReparasii.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvReparasii.Appearance.Preview.BackColor2 = System.Drawing.Color.RoyalBlue;
            this.dgvReparasii.Appearance.Preview.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvReparasii.Appearance.Preview.Options.UseBackColor = true;
            this.dgvReparasii.Appearance.Preview.Options.UseFont = true;
            this.dgvReparasii.Appearance.SelectedRow.BackColor = System.Drawing.Color.RoyalBlue;
            this.dgvReparasii.Appearance.SelectedRow.Options.UseBackColor = true;
            this.dgvReparasii.GridControl = this.dgvSPReparasi;
            this.dgvReparasii.Name = "dgvReparasii";
            this.dgvReparasii.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgvReparasii.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgvReparasii.OptionsBehavior.Editable = false;
            this.dgvReparasii.OptionsView.EnableAppearanceEvenRow = true;
            this.dgvReparasii.OptionsView.EnableAppearanceOddRow = true;
            this.dgvReparasii.RowSeparatorHeight = 3;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.dgvSPReparasi;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.Name = "layoutViewCard1";
            // 
            // FormSupplierReparasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 351);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.mainMenu);
            this.Name = "FormSupplierReparasi";
            this.Text = "Supplier Reparasi";
            this.Load += new System.EventHandler(this.FormSupplierReparasi_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSPReparasi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReparasii)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
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
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
        private DevExpress.XtraGrid.GridControl dgvSPReparasi;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvReparasii;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}