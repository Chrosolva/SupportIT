namespace SupportIT.View.Inventaris
{
    partial class FrmPilihInventaris
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
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbKodePT = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbKebun = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbKategori = new System.Windows.Forms.ComboBox();
            this.bottompanel = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.contentpanel = new System.Windows.Forms.Panel();
            this.dgvInventaris = new System.Windows.Forms.DataGridView();
            this.gbFilter.SuspendLayout();
            this.bottompanel.SuspendLayout();
            this.contentpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventaris)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.label6);
            this.gbFilter.Controls.Add(this.txtSearch);
            this.gbFilter.Controls.Add(this.btnFilter);
            this.gbFilter.Controls.Add(this.label5);
            this.gbFilter.Controls.Add(this.cbKodePT);
            this.gbFilter.Controls.Add(this.label4);
            this.gbFilter.Controls.Add(this.cbKebun);
            this.gbFilter.Controls.Add(this.label3);
            this.gbFilter.Controls.Add(this.cbKategori);
            this.gbFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbFilter.Location = new System.Drawing.Point(0, 0);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(1207, 78);
            this.gbFilter.TabIndex = 5;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "FILTER";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(486, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "SEARCH";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(489, 35);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(293, 20);
            this.txtSearch.TabIndex = 42;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(804, 32);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 41;
            this.btnFilter.Text = "FILTER";
            this.btnFilter.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(359, 16);
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
            this.cbKodePT.Location = new System.Drawing.Point(362, 37);
            this.cbKodePT.Name = "cbKodePT";
            this.cbKodePT.Size = new System.Drawing.Size(104, 21);
            this.cbKodePT.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(185, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "KEBUN";
            // 
            // cbKebun
            // 
            this.cbKebun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKebun.FormattingEnabled = true;
            this.cbKebun.Items.AddRange(new object[] {
            "ALL",
            "DRAFT",
            "DIKIRIM",
            "DITERIMA",
            "SELESAI"});
            this.cbKebun.Location = new System.Drawing.Point(188, 37);
            this.cbKebun.Name = "cbKebun";
            this.cbKebun.Size = new System.Drawing.Size(145, 21);
            this.cbKebun.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "KATEGORI";
            // 
            // cbKategori
            // 
            this.cbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKategori.FormattingEnabled = true;
            this.cbKategori.Items.AddRange(new object[] {
            "ALL",
            "DRAFT",
            "DIKIRIM",
            "DIPROSES",
            "SELESAI"});
            this.cbKategori.Location = new System.Drawing.Point(6, 37);
            this.cbKategori.Name = "cbKategori";
            this.cbKategori.Size = new System.Drawing.Size(161, 21);
            this.cbKategori.TabIndex = 35;
            // 
            // bottompanel
            // 
            this.bottompanel.Controls.Add(this.btnCancel);
            this.bottompanel.Controls.Add(this.btnSelect);
            this.bottompanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottompanel.Location = new System.Drawing.Point(0, 369);
            this.bottompanel.Name = "bottompanel";
            this.bottompanel.Size = new System.Drawing.Size(1207, 53);
            this.bottompanel.TabIndex = 6;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(749, 18);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 43;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(534, 18);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 42;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            // 
            // contentpanel
            // 
            this.contentpanel.Controls.Add(this.dgvInventaris);
            this.contentpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentpanel.Location = new System.Drawing.Point(0, 78);
            this.contentpanel.Name = "contentpanel";
            this.contentpanel.Padding = new System.Windows.Forms.Padding(4);
            this.contentpanel.Size = new System.Drawing.Size(1207, 291);
            this.contentpanel.TabIndex = 7;
            // 
            // dgvInventaris
            // 
            this.dgvInventaris.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventaris.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInventaris.Location = new System.Drawing.Point(4, 4);
            this.dgvInventaris.Name = "dgvInventaris";
            this.dgvInventaris.Size = new System.Drawing.Size(1199, 283);
            this.dgvInventaris.TabIndex = 0;
            this.dgvInventaris.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventaris_CellContentDoubleClick);
            // 
            // FrmPilihInventaris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 422);
            this.Controls.Add(this.contentpanel);
            this.Controls.Add(this.bottompanel);
            this.Controls.Add(this.gbFilter);
            this.Name = "FrmPilihInventaris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPilihInventaris";
            this.Load += new System.EventHandler(this.FrmPilihInventaris_Load);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.bottompanel.ResumeLayout(false);
            this.contentpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventaris)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbKodePT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbKebun;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbKategori;
        private System.Windows.Forms.Panel bottompanel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Panel contentpanel;
        private System.Windows.Forms.DataGridView dgvInventaris;
    }
}