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
using SupportIT.Controller;
using SupportIT.Controller;

namespace SupportIT.View.Perbaikan
{
    public partial class FormTandaTerimaList : Form
    {
        #region properties 

        public ControllerTandaTerima controllerTT = new ControllerTandaTerima();
        int rowcount = 0;

        #endregion

        public FormTandaTerimaList()
        {
            InitializeComponent();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            FormTandaTerima formTandaTerima = new FormTandaTerima();
            
            formTandaTerima.Tag = "Tambah";
            
            formTandaTerima.txtTTReparasi.Text = formTandaTerima.controllerTandaTerima.GetNextIDTT();
            formTandaTerima.ShowDialog();
            FormTandaTerimaList_Load(sender, e);
            
        }

        private void FormTandaTerimaList_Load(object sender, EventArgs e)
        {
            this.GCTT.DataSource = controllerTT.LoadDataTT().Tables["Master.TblTandaTerima"];
            rowcount = dgvTT.RowCount;
            groupBox1.Text = "Tanda Terima - Row Count = " + rowcount;
            dgvTT.Columns[4].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            dgvTT.Columns[4].DisplayFormat.FormatString = "c0";
            if(dgvDetTT.RowCount !=0)
            {
                dgvDetTT.Columns["BiayaPerbaikan"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                dgvDetTT.Columns["BiayaPerbaikan"].DisplayFormat.FormatString = "c0";
            }


        }

        private void dgvTT_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if(dgvTT.RowCount != 0)
            {
                this.gridCtrDetTT.DataSource = controllerTT.LoadDataDetTT(dgvTT.GetFocusedDataRow()["IDTT"].ToString()).Tables["Master.TbDetailTandaTerima"];
                this.dgvDetTT.Columns["IDTT"].Visible = false;
                this.dgvDetTT.Columns["NoUrutItem"].Visible = false;
            }
            else
            {
                this.gridCtrDetTT.DataSource = null;
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Apakah anda yakin ingin menghapus tanda terima dengan Kode " + this.dgvTT.GetFocusedDataRow()["IDTT"].ToString() + " ? ", " Warning ", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    controllerTT.DeleteTT(dgvTT.GetFocusedDataRow()["IDTT"].ToString());
                    MessageBox.Show("Data Tanda Terima Berhasil dihapus.");
                    rowcount = dgvTT.RowCount;
                    groupBox1.Text = "Tanda Terima - Row Count = " + rowcount;
                    FormTandaTerimaList_Load(sender, e);
                }
                else if (dialogResult == DialogResult.No) { }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tstButtonCetak_Click(object sender, EventArgs e)
        {
            if(dgvTT.RowCount !=0)
            {
                FormPrint formPrint = new FormPrint(dgvTT.GetFocusedDataRow()["IDTT"].ToString());
                formPrint.Tag = "TandaTerima";
                formPrint.Show(); 
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if(dgvTT.RowCount !=0)
            {
                FormTandaTerima formTandaTerima = new FormTandaTerima(this.dgvTT.GetFocusedDataRow()["IDTT"].ToString());

                formTandaTerima.Tag = "Edit";
                formTandaTerima.setEditCondition();
                formTandaTerima.ShowDialog();
                FormTandaTerimaList_Load(sender, e);
            }

        }
    }
}
