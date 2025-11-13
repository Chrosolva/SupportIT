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
using Master.Master;
using SupportIT.View.Perbaikan;
using SupportIT.View.Inventaris;
using SupportIT.Controller;


namespace SupportIT.View
{
    public partial class FormListItem : Form
    {
        #region properties

        public FormTandaTerima formTandaTerima;
        public ControllerSupplierReparasi controllerSPReparasi = new ControllerSupplierReparasi();
        public ControllerKategori controllerKategori = new ControllerKategori();
        public ControllerKebun controllerKebun = new ControllerKebun();
        public ControllerInventaris controllerInventaris = new ControllerInventaris();
        #endregion

        #region private function 

        

        #endregion

        public FormListItem()
        {
            InitializeComponent();
        }

        public FormListItem(FormTandaTerima formTandaTerima)
        {
            InitializeComponent();
            this.formTandaTerima = formTandaTerima;
        }

        private void FormListItem_Load(object sender, EventArgs e)
        {
            
        }

        private void dgvListItem_DoubleClick(object sender, EventArgs e)
        {
            if(this.Tag.ToString() == "Supplier")
            {
                formTandaTerima.txtKodeSupplier.Text = dgvListItem.GetFocusedDataRow()["KodeSupp"].ToString();
                formTandaTerima.txtNamaSupp.Text = dgvListItem.GetFocusedDataRow()["NamaSupp"].ToString();

                this.Close();
            }
            else if (this.Tag.ToString() == "Inventaris")
            {
                ControllerStaticVariables.KodeInventaris = dgvListItem.GetFocusedDataRow()["KodeInventaris"].ToString();
                ControllerStaticVariables.NamaBarang = dgvListItem.GetFocusedDataRow()["NamaBarang"].ToString();
                this.Close();
            }
        }

        private void NUDTahun_ValueChanged(object sender, EventArgs e)
        {
            if (this.Tag.ToString() == "Supplier")
            {

            }
        }
    }
}
