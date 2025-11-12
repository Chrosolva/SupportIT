using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Master.Master;
using SupportIT.Controller;

namespace SupportIT.View
{
    public partial class FormImport : Form
    {
        public ControllerImport controllerImport;

        #region Constructor

        public FormImport()
        {
            InitializeComponent();
        }

        public FormImport(DBConnectionClass objConnection)
        {
            InitializeComponent();
            controllerImport = new ControllerImport(objConnection);
        }

        #endregion

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Filter = "Excel Files|*.xls;*.xlsx;";
            DialogResult dr = od.ShowDialog();
            if (dr == DialogResult.Abort)
                return;
            if (dr == DialogResult.Cancel)
                return;
            txtpath.Text = od.FileName.ToString();
        }

        private void BtnImportToDB_Click(object sender, EventArgs e)
        {
            string import = this.controllerImport.Import(txtpath.Text);
            MessageBox.Show(import);
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtpath_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
