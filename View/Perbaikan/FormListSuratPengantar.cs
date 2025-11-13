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
using SupportIT.Controller;
using SupportIT.Controller;

namespace SupportIT.View.Perbaikan
{
    public partial class FormListSuratPengantar : Form
    {
        #region properties

        public ControllerSP controllerSP = new ControllerSP();

        #endregion

        public FormListSuratPengantar()
        {
            InitializeComponent();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            FormInputEditSuratPengantar formInputEditSP = new FormInputEditSuratPengantar();
            formInputEditSP.Tag = "Tambah";
            formInputEditSP.BtnAddEdit.Text = formInputEditSP.Tag.ToString();
            formInputEditSP.ShowDialog();
            FormListSuratPengantar_Load(sender, e);
        }

        private void FormListSuratPengantar_Load(object sender, EventArgs e)
        {
            GCSP.DataSource = controllerSP.LoadDataSP().Tables["TblSuratPengantar"];
            
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FormListSuratPengantar_Load(sender, e);
        }

        private void dgvSP_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if(dgvSP.RowCount != 0 )
            {
                GCDetSP.DataSource = controllerSP.LoadDataDetSP(dgvSP.GetFocusedDataRow()["NoSP"].ToString()).Tables["TblDetSuratPengantar"];
                dgvDetSP.Columns["NoSP"].Visible = false;
            }
            else
            {
                GCDetSP.DataSource = null;
            }
        }

        private void tstButtonCetak_Click(object sender, EventArgs e)
        {
            if (dgvSP.RowCount != 0)
            {
                FormPrint formPrint = new FormPrint(dgvSP.GetFocusedDataRow()["NoSP"].ToString());
                formPrint.Tag = "SuratPengantar";
                formPrint.Show();
            }
        }

        private void dgvSP_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            btnUbah.Enabled = true;
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if(dgvSP.RowCount !=0)
            {

            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {

        }
    }
}
