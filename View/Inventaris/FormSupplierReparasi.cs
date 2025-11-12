using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventaris.Controller;

namespace SupportIT.View.Inventaris
{
    public partial class FormSupplierReparasi : Form
    {
        #region properties

        public ControllerSupplierReparasi controllerSPReparasi = new ControllerSupplierReparasi();

        #endregion

        public FormSupplierReparasi()
        {
            InitializeComponent();
        }

        private void FormSupplierReparasi_Load(object sender, EventArgs e)
        {
            this.dgvSPReparasi.DataSource = controllerSPReparasi.LoadDataSupp().Tables["Master.SPReparasi"];
            
        }
    }
}
