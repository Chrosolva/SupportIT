namespace SupportIT.View
{
    partial class FormListItem
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
            this.GcList = new DevExpress.XtraGrid.GridControl();
            this.dgvListItem = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.GcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListItem)).BeginInit();
            this.SuspendLayout();
            // 
            // GcList
            // 
            this.GcList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GcList.Location = new System.Drawing.Point(0, 0);
            this.GcList.MainView = this.dgvListItem;
            this.GcList.Name = "GcList";
            this.GcList.Size = new System.Drawing.Size(761, 356);
            this.GcList.TabIndex = 0;
            this.GcList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvListItem});
            // 
            // dgvListItem
            // 
            this.dgvListItem.GridControl = this.GcList;
            this.dgvListItem.Name = "dgvListItem";
            this.dgvListItem.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgvListItem.OptionsBehavior.Editable = false;
            this.dgvListItem.DoubleClick += new System.EventHandler(this.dgvListItem_DoubleClick);
            // 
            // FormListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 356);
            this.Controls.Add(this.GcList);
            this.Name = "FormListItem";
            this.Text = "FormListItem";
            this.Load += new System.EventHandler(this.FormListItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraGrid.GridControl GcList;
        public DevExpress.XtraGrid.Views.Grid.GridView dgvListItem;
    }
}