namespace Inventaris.View.BatasInventaris
{
    partial class FormInputEditBatasInventaris
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxKodeBagian = new System.Windows.Forms.ComboBox();
            this.cbxKodeKategori = new System.Windows.Forms.ComboBox();
            this.cbxKodeKebun = new System.Windows.Forms.ComboBox();
            this.NUDJlhMax = new System.Windows.Forms.NumericUpDown();
            this.txtKeterangan = new System.Windows.Forms.TextBox();
            this.btnAddorEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NUDJlhMax)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kode Bagian";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kode Kategori";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kode Kebun";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Jumlah Max";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Keterangan";
            // 
            // cbxKodeBagian
            // 
            this.cbxKodeBagian.FormattingEnabled = true;
            this.cbxKodeBagian.Location = new System.Drawing.Point(198, 27);
            this.cbxKodeBagian.Name = "cbxKodeBagian";
            this.cbxKodeBagian.Size = new System.Drawing.Size(144, 21);
            this.cbxKodeBagian.TabIndex = 5;
            // 
            // cbxKodeKategori
            // 
            this.cbxKodeKategori.FormattingEnabled = true;
            this.cbxKodeKategori.Location = new System.Drawing.Point(198, 69);
            this.cbxKodeKategori.Name = "cbxKodeKategori";
            this.cbxKodeKategori.Size = new System.Drawing.Size(144, 21);
            this.cbxKodeKategori.TabIndex = 6;
            // 
            // cbxKodeKebun
            // 
            this.cbxKodeKebun.FormattingEnabled = true;
            this.cbxKodeKebun.Location = new System.Drawing.Point(198, 106);
            this.cbxKodeKebun.Name = "cbxKodeKebun";
            this.cbxKodeKebun.Size = new System.Drawing.Size(144, 21);
            this.cbxKodeKebun.TabIndex = 7;
            // 
            // NUDJlhMax
            // 
            this.NUDJlhMax.Location = new System.Drawing.Point(222, 143);
            this.NUDJlhMax.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.NUDJlhMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDJlhMax.Name = "NUDJlhMax";
            this.NUDJlhMax.Size = new System.Drawing.Size(120, 20);
            this.NUDJlhMax.TabIndex = 8;
            this.NUDJlhMax.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtKeterangan
            // 
            this.txtKeterangan.Location = new System.Drawing.Point(147, 178);
            this.txtKeterangan.Multiline = true;
            this.txtKeterangan.Name = "txtKeterangan";
            this.txtKeterangan.Size = new System.Drawing.Size(195, 41);
            this.txtKeterangan.TabIndex = 9;
            // 
            // btnAddorEdit
            // 
            this.btnAddorEdit.Location = new System.Drawing.Point(267, 237);
            this.btnAddorEdit.Name = "btnAddorEdit";
            this.btnAddorEdit.Size = new System.Drawing.Size(75, 23);
            this.btnAddorEdit.TabIndex = 10;
            this.btnAddorEdit.Text = "button1";
            this.btnAddorEdit.UseVisualStyleBackColor = true;
            this.btnAddorEdit.Click += new System.EventHandler(this.BtnAddorEdit_Click);
            // 
            // FormInputEditBatasInventaris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 268);
            this.Controls.Add(this.btnAddorEdit);
            this.Controls.Add(this.txtKeterangan);
            this.Controls.Add(this.NUDJlhMax);
            this.Controls.Add(this.cbxKodeKebun);
            this.Controls.Add(this.cbxKodeKategori);
            this.Controls.Add(this.cbxKodeBagian);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormInputEditBatasInventaris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInputEditBatasInventaris";
            this.Load += new System.EventHandler(this.FormInputEditBatasInventaris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUDJlhMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxKodeBagian;
        private System.Windows.Forms.ComboBox cbxKodeKategori;
        private System.Windows.Forms.ComboBox cbxKodeKebun;
        private System.Windows.Forms.NumericUpDown NUDJlhMax;
        private System.Windows.Forms.TextBox txtKeterangan;
        private System.Windows.Forms.Button btnAddorEdit;
    }
}