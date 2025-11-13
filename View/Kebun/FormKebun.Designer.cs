namespace SupportIT.View
{
    partial class FormKebun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKebun));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainMenu = new System.Windows.Forms.ToolStrip();
            this.btnTambah = new System.Windows.Forms.ToolStripButton();
            this.btnUbah = new System.Windows.Forms.ToolStripButton();
            this.btnHapus = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnCari = new System.Windows.Forms.ToolStripButton();
            this.toolStriptxtsearch = new System.Windows.Forms.ToolStripTextBox();
            this.DGVForKebun = new System.Windows.Forms.DataGridView();
            this.mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVForKebun)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.mainMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnTambah,
            this.btnUbah,
            this.btnHapus,
            this.btnRefresh,
            this.btnCari,
            this.toolStriptxtsearch});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Padding = new System.Windows.Forms.Padding(3, 0, 1, 0);
            this.mainMenu.Size = new System.Drawing.Size(750, 54);
            this.mainMenu.TabIndex = 2;
            // 
            // btnTambah
            // 
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
            this.btnUbah.Enabled = false;
            this.btnUbah.Image = ((System.Drawing.Image)(resources.GetObject("btnUbah.Image")));
            this.btnUbah.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnUbah.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnUbah.Size = new System.Drawing.Size(46, 51);
            this.btnUbah.Tag = "Edit";
            this.btnUbah.Text = "&Edit";
            this.btnUbah.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUbah.Click += new System.EventHandler(this.BtnUbah_Click);
            // 
            // btnHapus
            // 
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
            // btnCari
            // 
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
            // toolStriptxtsearch
            // 
            this.toolStriptxtsearch.Name = "toolStriptxtsearch";
            this.toolStriptxtsearch.Size = new System.Drawing.Size(120, 54);
            // 
            // DGVForKebun
            // 
            this.DGVForKebun.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(36)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(62)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.DGVForKebun.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVForKebun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVForKebun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVForKebun.Location = new System.Drawing.Point(0, 54);
            this.DGVForKebun.Name = "DGVForKebun";
            this.DGVForKebun.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(207)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(36)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(62)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.DGVForKebun.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVForKebun.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVForKebun.Size = new System.Drawing.Size(750, 287);
            this.DGVForKebun.TabIndex = 3;
            this.DGVForKebun.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVForKebun_CellClick);
            this.DGVForKebun.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // FormKebun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 341);
            this.Controls.Add(this.DGVForKebun);
            this.Controls.Add(this.mainMenu);
            this.Name = "FormKebun";
            this.Text = "FormKebun";
            this.Load += new System.EventHandler(this.FormKebun_Load);
            this.Click += new System.EventHandler(this.FormKebun_Click);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVForKebun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip mainMenu;
        private System.Windows.Forms.ToolStripButton btnTambah;
        private System.Windows.Forms.ToolStripButton btnUbah;
        private System.Windows.Forms.ToolStripButton btnHapus;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripButton btnCari;
        private System.Windows.Forms.ToolStripTextBox toolStriptxtsearch;
        private System.Windows.Forms.DataGridView DGVForKebun;
    }
}