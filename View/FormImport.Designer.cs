namespace SupportIT.View
{
    partial class FormImport
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtpath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnImportToDB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Path";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtpath
            // 
            this.txtpath.Enabled = false;
            this.txtpath.Location = new System.Drawing.Point(101, 12);
            this.txtpath.Name = "txtpath";
            this.txtpath.Size = new System.Drawing.Size(324, 20);
            this.txtpath.TabIndex = 3;
            this.txtpath.TextChanged += new System.EventHandler(this.txtpath_TextChanged);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(431, 10);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // btnImportToDB
            // 
            this.btnImportToDB.Location = new System.Drawing.Point(431, 44);
            this.btnImportToDB.Name = "btnImportToDB";
            this.btnImportToDB.Size = new System.Drawing.Size(75, 23);
            this.btnImportToDB.TabIndex = 5;
            this.btnImportToDB.Text = "Import to DB";
            this.btnImportToDB.UseVisualStyleBackColor = true;
            this.btnImportToDB.Click += new System.EventHandler(this.BtnImportToDB_Click);
            // 
            // FormImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 72);
            this.Controls.Add(this.btnImportToDB);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtpath);
            this.Controls.Add(this.label2);
            this.Name = "FormImport";
            this.Text = "FormImport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnImportToDB;
    }
}