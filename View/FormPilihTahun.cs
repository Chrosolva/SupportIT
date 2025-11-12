using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Master.Controller;

namespace SupportIT.View
{
    public partial class FormPilihTahun : Form
    {
        public FormPilihTahun()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ControllerStaticVariables.tahun = dtpPilihTahun.Value.Year;
        }
    }
}
