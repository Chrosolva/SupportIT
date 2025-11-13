namespace SupportIT.View
{
    partial class FormInputEditBagian
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
            this.txt_KodeBagian = new System.Windows.Forms.TextBox();
            this.txt_NamaBagian = new System.Windows.Forms.TextBox();
            this.txt_Asisten = new System.Windows.Forms.TextBox();
            this.txt_Grup = new System.Windows.Forms.TextBox();
            this.btnAddorEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kode Bagian";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Bagian";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Assisten";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Grup";
            // 
            // txt_KodeBagian
            // 
            this.txt_KodeBagian.Location = new System.Drawing.Point(128, 19);
            this.txt_KodeBagian.Name = "txt_KodeBagian";
            this.txt_KodeBagian.Size = new System.Drawing.Size(164, 20);
            this.txt_KodeBagian.TabIndex = 4;
            // 
            // txt_NamaBagian
            // 
            this.txt_NamaBagian.Location = new System.Drawing.Point(128, 58);
            this.txt_NamaBagian.Name = "txt_NamaBagian";
            this.txt_NamaBagian.Size = new System.Drawing.Size(164, 20);
            this.txt_NamaBagian.TabIndex = 5;
            // 
            // txt_Asisten
            // 
            this.txt_Asisten.Location = new System.Drawing.Point(128, 97);
            this.txt_Asisten.Name = "txt_Asisten";
            this.txt_Asisten.Size = new System.Drawing.Size(164, 20);
            this.txt_Asisten.TabIndex = 6;
            // 
            // txt_Grup
            // 
            this.txt_Grup.Location = new System.Drawing.Point(128, 129);
            this.txt_Grup.Name = "txt_Grup";
            this.txt_Grup.Size = new System.Drawing.Size(164, 20);
            this.txt_Grup.TabIndex = 7;
            // 
            // btnAddorEdit
            // 
            this.btnAddorEdit.Location = new System.Drawing.Point(217, 163);
            this.btnAddorEdit.Name = "btnAddorEdit";
            this.btnAddorEdit.Size = new System.Drawing.Size(75, 23);
            this.btnAddorEdit.TabIndex = 8;
            this.btnAddorEdit.Text = "button1";
            this.btnAddorEdit.UseVisualStyleBackColor = true;
            this.btnAddorEdit.Click += new System.EventHandler(this.BtnAddorEdit_Click);
            // 
            // FormInputEditBagian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 198);
            this.Controls.Add(this.btnAddorEdit);
            this.Controls.Add(this.txt_Grup);
            this.Controls.Add(this.txt_Asisten);
            this.Controls.Add(this.txt_NamaBagian);
            this.Controls.Add(this.txt_KodeBagian);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormInputEditBagian";
            this.Text = "FormInputEditBagian";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_KodeBagian;
        private System.Windows.Forms.TextBox txt_NamaBagian;
        private System.Windows.Forms.TextBox txt_Asisten;
        private System.Windows.Forms.TextBox txt_Grup;
        private System.Windows.Forms.Button btnAddorEdit;
    }
}