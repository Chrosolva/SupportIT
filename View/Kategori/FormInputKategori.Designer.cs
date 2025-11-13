namespace SupportIT.View
{
    partial class FormInputKategori
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
            this.txtKodeKategori = new System.Windows.Forms.TextBox();
            this.txtNamaKategori = new System.Windows.Forms.TextBox();
            this.btnAddorEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kode Kategori";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Kategori";
            // 
            // txtKodeKategori
            // 
            this.txtKodeKategori.Location = new System.Drawing.Point(92, 23);
            this.txtKodeKategori.MaxLength = 2;
            this.txtKodeKategori.Name = "txtKodeKategori";
            this.txtKodeKategori.Size = new System.Drawing.Size(139, 20);
            this.txtKodeKategori.TabIndex = 2;
            // 
            // txtNamaKategori
            // 
            this.txtNamaKategori.Location = new System.Drawing.Point(92, 54);
            this.txtNamaKategori.Name = "txtNamaKategori";
            this.txtNamaKategori.Size = new System.Drawing.Size(139, 20);
            this.txtNamaKategori.TabIndex = 3;
            // 
            // btnAddorEdit
            // 
            this.btnAddorEdit.Location = new System.Drawing.Point(92, 91);
            this.btnAddorEdit.Name = "btnAddorEdit";
            this.btnAddorEdit.Size = new System.Drawing.Size(139, 23);
            this.btnAddorEdit.TabIndex = 4;
            this.btnAddorEdit.Text = "button1";
            this.btnAddorEdit.UseVisualStyleBackColor = true;
            this.btnAddorEdit.Click += new System.EventHandler(this.BtnAddorEdit_Click);
            // 
            // FormInputKategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 126);
            this.Controls.Add(this.btnAddorEdit);
            this.Controls.Add(this.txtNamaKategori);
            this.Controls.Add(this.txtKodeKategori);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormInputKategori";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInputKategori";
            this.Load += new System.EventHandler(this.FormInputKategori_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKodeKategori;
        private System.Windows.Forms.TextBox txtNamaKategori;
        private System.Windows.Forms.Button btnAddorEdit;
    }
}