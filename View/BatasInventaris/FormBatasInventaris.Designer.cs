namespace Inventaris.View
{
    partial class FormBatasInventaris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBatasInventaris));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainMenu = new System.Windows.Forms.ToolStrip();
            this.btnTambah = new System.Windows.Forms.ToolStripButton();
            this.btnUbah = new System.Windows.Forms.ToolStripButton();
            this.btnHapus = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripcbxCariParm = new System.Windows.Forms.ToolStripComboBox();
            this.toolStriptxtsearch = new System.Windows.Forms.ToolStripTextBox();
            this.btnCari = new System.Windows.Forms.ToolStripButton();
            this.toolstripFilter = new System.Windows.Forms.ToolStripButton();
            this.DgvForBatasInventaris = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxKodeKategori = new System.Windows.Forms.ComboBox();
            this.cbxKodeKebun = new System.Windows.Forms.ComboBox();
            this.cbxKodeBagian = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvForBatasInventaris)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.toolStripcbxCariParm,
            this.toolStriptxtsearch,
            this.btnCari,
            this.toolstripFilter});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Padding = new System.Windows.Forms.Padding(3, 0, 1, 0);
            this.mainMenu.Size = new System.Drawing.Size(679, 54);
            this.mainMenu.TabIndex = 4;
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
            // toolStripcbxCariParm
            // 
            this.toolStripcbxCariParm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripcbxCariParm.Margin = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.toolStripcbxCariParm.Name = "toolStripcbxCariParm";
            this.toolStripcbxCariParm.Size = new System.Drawing.Size(121, 54);
            // 
            // toolStriptxtsearch
            // 
            this.toolStriptxtsearch.Name = "toolStriptxtsearch";
            this.toolStriptxtsearch.Size = new System.Drawing.Size(120, 54);
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
            // toolstripFilter
            // 
            this.toolstripFilter.Image = ((System.Drawing.Image)(resources.GetObject("toolstripFilter.Image")));
            this.toolstripFilter.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolstripFilter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolstripFilter.Name = "toolstripFilter";
            this.toolstripFilter.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.toolstripFilter.Size = new System.Drawing.Size(47, 51);
            this.toolstripFilter.Tag = "-";
            this.toolstripFilter.Text = "&Filter";
            this.toolstripFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolstripFilter.Click += new System.EventHandler(this.ToolstripFilter_Click);
            // 
            // DgvForBatasInventaris
            // 
            this.DgvForBatasInventaris.AllowUserToAddRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(36)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(62)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.DgvForBatasInventaris.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvForBatasInventaris.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvForBatasInventaris.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvForBatasInventaris.Location = new System.Drawing.Point(0, 124);
            this.DgvForBatasInventaris.Name = "DgvForBatasInventaris";
            this.DgvForBatasInventaris.ReadOnly = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(207)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(36)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(62)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.DgvForBatasInventaris.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvForBatasInventaris.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvForBatasInventaris.Size = new System.Drawing.Size(679, 379);
            this.DgvForBatasInventaris.TabIndex = 5;
            this.DgvForBatasInventaris.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvForBatasInventaris_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.cbxKodeKategori);
            this.groupBox1.Controls.Add(this.cbxKodeKebun);
            this.groupBox1.Controls.Add(this.cbxKodeBagian);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(679, 70);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // cbxKodeKategori
            // 
            this.cbxKodeKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxKodeKategori.FormattingEnabled = true;
            this.cbxKodeKategori.Location = new System.Drawing.Point(295, 30);
            this.cbxKodeKategori.Name = "cbxKodeKategori";
            this.cbxKodeKategori.Size = new System.Drawing.Size(158, 21);
            this.cbxKodeKategori.TabIndex = 9;
            // 
            // cbxKodeKebun
            // 
            this.cbxKodeKebun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxKodeKebun.FormattingEnabled = true;
            this.cbxKodeKebun.Items.AddRange(new object[] {
            "All"});
            this.cbxKodeKebun.Location = new System.Drawing.Point(552, 30);
            this.cbxKodeKebun.Name = "cbxKodeKebun";
            this.cbxKodeKebun.Size = new System.Drawing.Size(121, 21);
            this.cbxKodeKebun.TabIndex = 8;
            // 
            // cbxKodeBagian
            // 
            this.cbxKodeBagian.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxKodeBagian.FormattingEnabled = true;
            this.cbxKodeBagian.Location = new System.Drawing.Point(80, 30);
            this.cbxKodeBagian.Name = "cbxKodeBagian";
            this.cbxKodeBagian.Size = new System.Drawing.Size(121, 21);
            this.cbxKodeBagian.TabIndex = 7;
            this.cbxKodeBagian.SelectedIndexChanged += new System.EventHandler(this.CbxKodeBagian_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kode Kategori";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(480, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kode Kebun";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kode Bagian";
            // 
            // FormBatasInventaris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 503);
            this.Controls.Add(this.DgvForBatasInventaris);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mainMenu);
            this.Name = "FormBatasInventaris";
            this.Text = "FormBatasInventaris";
            this.Load += new System.EventHandler(this.FormBatasInventaris_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvForBatasInventaris)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.ToolStripComboBox toolStripcbxCariParm;
        private System.Windows.Forms.DataGridView DgvForBatasInventaris;
        private System.Windows.Forms.ToolStripButton toolstripFilter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxKodeKategori;
        private System.Windows.Forms.ComboBox cbxKodeKebun;
        private System.Windows.Forms.ComboBox cbxKodeBagian;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}