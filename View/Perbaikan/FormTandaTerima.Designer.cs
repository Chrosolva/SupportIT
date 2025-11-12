namespace SupportIT.View.Perbaikan
{
    partial class FormTandaTerima
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNamaSupp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpTglTT = new System.Windows.Forms.DateTimePicker();
            this.txtketerangan = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtKodeSupplier = new System.Windows.Forms.TextBox();
            this.txtTTReparasi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvTandaTerima = new System.Windows.Forms.DataGridView();
            this.KodeInventaris = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamaBarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Select = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Keterangan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BiayaPerbaikan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TanggalSelesai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CekSelesai = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txttotalBiaya = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkAll = new System.Windows.Forms.CheckBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTandaTerima)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNamaSupp);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtpTglTT);
            this.groupBox1.Controls.Add(this.txtketerangan);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtKodeSupplier);
            this.groupBox1.Controls.Add(this.txtTTReparasi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(653, 161);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tanda Terima Reparasi";
            // 
            // txtNamaSupp
            // 
            this.txtNamaSupp.Enabled = false;
            this.txtNamaSupp.Location = new System.Drawing.Point(103, 76);
            this.txtNamaSupp.Name = "txtNamaSupp";
            this.txtNamaSupp.Size = new System.Drawing.Size(170, 20);
            this.txtNamaSupp.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nama Supplier";
            // 
            // dtpTglTT
            // 
            this.dtpTglTT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTglTT.Location = new System.Drawing.Point(533, 21);
            this.dtpTglTT.Name = "dtpTglTT";
            this.dtpTglTT.Size = new System.Drawing.Size(97, 20);
            this.dtpTglTT.TabIndex = 9;
            // 
            // txtketerangan
            // 
            this.txtketerangan.Location = new System.Drawing.Point(103, 102);
            this.txtketerangan.Multiline = true;
            this.txtketerangan.Name = "txtketerangan";
            this.txtketerangan.Size = new System.Drawing.Size(530, 46);
            this.txtketerangan.TabIndex = 8;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(279, 48);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(30, 23);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "...";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtKodeSupplier
            // 
            this.txtKodeSupplier.Enabled = false;
            this.txtKodeSupplier.Location = new System.Drawing.Point(103, 50);
            this.txtKodeSupplier.Name = "txtKodeSupplier";
            this.txtKodeSupplier.Size = new System.Drawing.Size(170, 20);
            this.txtKodeSupplier.TabIndex = 6;
            // 
            // txtTTReparasi
            // 
            this.txtTTReparasi.Location = new System.Drawing.Point(103, 24);
            this.txtTTReparasi.Name = "txtTTReparasi";
            this.txtTTReparasi.Size = new System.Drawing.Size(170, 20);
            this.txtTTReparasi.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Keterangan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(488, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tgl TT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kode Supplier";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "No. TT Reparasi";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvTandaTerima);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(653, 190);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detail";
            // 
            // dgvTandaTerima
            // 
            this.dgvTandaTerima.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTandaTerima.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KodeInventaris,
            this.NamaBarang,
            this.Select,
            this.Keterangan,
            this.BiayaPerbaikan,
            this.TanggalSelesai,
            this.CekSelesai});
            this.dgvTandaTerima.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTandaTerima.Location = new System.Drawing.Point(6, 19);
            this.dgvTandaTerima.Name = "dgvTandaTerima";
            this.dgvTandaTerima.Size = new System.Drawing.Size(641, 165);
            this.dgvTandaTerima.TabIndex = 0;
            this.dgvTandaTerima.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTandaTerima_CellContentClick);
            this.dgvTandaTerima.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTandaTerima_CellValueChanged);
            this.dgvTandaTerima.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvTandaTerima_DefaultValuesNeeded);
            this.dgvTandaTerima.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvTandaTerima_RowsAdded);
            // 
            // KodeInventaris
            // 
            this.KodeInventaris.HeaderText = "Kode Inventaris";
            this.KodeInventaris.Name = "KodeInventaris";
            this.KodeInventaris.ReadOnly = true;
            // 
            // NamaBarang
            // 
            this.NamaBarang.HeaderText = "Nama Barang";
            this.NamaBarang.Name = "NamaBarang";
            // 
            // Select
            // 
            this.Select.HeaderText = "";
            this.Select.Name = "Select";
            this.Select.Width = 25;
            // 
            // Keterangan
            // 
            this.Keterangan.HeaderText = "Keterangan";
            this.Keterangan.Name = "Keterangan";
            // 
            // BiayaPerbaikan
            // 
            this.BiayaPerbaikan.HeaderText = "Biaya Perbaikan";
            this.BiayaPerbaikan.Name = "BiayaPerbaikan";
            // 
            // TanggalSelesai
            // 
            this.TanggalSelesai.HeaderText = "Tanggal Selesai";
            this.TanggalSelesai.Name = "TanggalSelesai";
            // 
            // CekSelesai
            // 
            this.CekSelesai.HeaderText = "Cek Selesai";
            this.CekSelesai.Name = "CekSelesai";
            this.CekSelesai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CekSelesai.Width = 70;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txttotalBiaya);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.chkAll);
            this.panel1.Controls.Add(this.btnSimpan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 351);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(653, 34);
            this.panel1.TabIndex = 2;
            // 
            // txttotalBiaya
            // 
            this.txttotalBiaya.Enabled = false;
            this.txttotalBiaya.Location = new System.Drawing.Point(412, 7);
            this.txttotalBiaya.Name = "txttotalBiaya";
            this.txttotalBiaya.Size = new System.Drawing.Size(142, 20);
            this.txttotalBiaya.TabIndex = 12;
            this.txttotalBiaya.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(349, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "TotalBiaya";
            // 
            // chkAll
            // 
            this.chkAll.AutoSize = true;
            this.chkAll.Location = new System.Drawing.Point(6, 10);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(118, 17);
            this.chkAll.TabIndex = 1;
            this.chkAll.Text = "Cek Selesai Semua";
            this.chkAll.UseVisualStyleBackColor = true;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(572, 6);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 0;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // FormTandaTerima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 385);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormTandaTerima";
            this.Text = "Inventaris - Tanda Terima";
            this.Load += new System.EventHandler(this.FormTandaTerima_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTandaTerima)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpTglTT;
        private System.Windows.Forms.TextBox txtketerangan;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvTandaTerima;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkAll;
        private System.Windows.Forms.Button btnSimpan;
        public System.Windows.Forms.TextBox txtKodeSupplier;
        public System.Windows.Forms.TextBox txtTTReparasi;
        public System.Windows.Forms.TextBox txtNamaSupp;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txttotalBiaya;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn KodeInventaris;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaBarang;
        private System.Windows.Forms.DataGridViewButtonColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn Keterangan;
        private System.Windows.Forms.DataGridViewTextBoxColumn BiayaPerbaikan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TanggalSelesai;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CekSelesai;
    }
}