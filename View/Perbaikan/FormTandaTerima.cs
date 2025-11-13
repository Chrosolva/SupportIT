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
using SupportIT.Model;

namespace SupportIT.View.Perbaikan
{
    public partial class FormTandaTerima : Form
    {
        #region properties

        public ControllerInventaris controllerInventaris = new ControllerInventaris(ControllerStaticVariables.objConnection);
        public ControllerSupplierReparasi controllerSPReparasi = new ControllerSupplierReparasi();
        public ControllerTandaTerima controllerTandaTerima = new ControllerTandaTerima();
        private string IDTT;

        #endregion

        #region function

        public void setEditCondition()
        {
            controllerTandaTerima.getTandaTerima(this.IDTT);
            controllerTandaTerima.getDetailTandaTerima(this.IDTT);
            this.txtTTReparasi.Text = controllerTandaTerima.tt.IDTT;
            this.txtTTReparasi.Enabled = false;
            this.txtKodeSupplier.Text = controllerTandaTerima.tt.KodeSupp;
            this.txtNamaSupp.Text = controllerTandaTerima.tt.NamaSupp;
            this.dtpTglTT.Value = Convert.ToDateTime(controllerTandaTerima.tt.TanggalPengajuan);
            this.txtketerangan.Text = controllerTandaTerima.tt.Keterangan;
            this.txttotalBiaya.Text = Convert.ToInt32(controllerTandaTerima.tt.TotalBiaya).ToString();

            this.dgvTandaTerima.Rows.Clear();
            foreach(DetailTandaTerima detailtt in controllerTandaTerima.listDetailTandaTerima)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvTandaTerima);  // this line was missing
                row.Cells[0].Value = detailtt.KodeInventris;
                row.Cells[1].Value = detailtt.NamaBarang;
                row.Cells[3].Value = detailtt.Keterangan;
                row.Cells[4].Value = Convert.ToInt32(detailtt.BiayaPerbaikan);
                row.Cells[5].Value = detailtt.TanggalSelesai.ToShortDateString();
                dgvTandaTerima.Rows.Add(row);
            }
        }

        #endregion

        public FormTandaTerima()
        {
            InitializeComponent();
        }

        public FormTandaTerima(string IDTT)
        {
            InitializeComponent();
            this.IDTT = IDTT;
        }

        private void FormTandaTerima_Load(object sender, EventArgs e)
        {
            dgvTandaTerima.Columns["BiayaPerbaikan"].DefaultCellStyle.Format = "#,#0";
            if (this.Tag.ToString() == "Tambah")
            {
                dgvTandaTerima.Columns["CekSelesai"].ReadOnly = true;
                dgvTandaTerima.Columns["CekSelesai"].Visible = false;
                dgvTandaTerima.Columns["BiayaPerbaikan"].Visible = false;
                dgvTandaTerima.Columns["TanggalSelesai"].Visible = false;

                dgvTandaTerima.Rows[0].Cells["KodeInventaris"].Value = " ";
                dgvTandaTerima.Rows[0].Cells["Keterangan"].Value = " ";
                dgvTandaTerima.Rows[0].Cells["BiayaPerbaikan"].Value = "0";
                dgvTandaTerima.Rows[0].Cells["TanggalSelesai"].Value = "01/01/1901";

                dgvTandaTerima.Columns["Keterangan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                txtTTReparasi.Enabled = false;
                //dgvTandaTerima.Rows.Add();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FormListItem formlistitem = new FormListItem(this);
            formlistitem.Tag = "Supplier";
            formlistitem.GcList.DataSource = controllerSPReparasi.LoadDataSupp().Tables["Master.SPReparasi"];
            formlistitem.ShowDialog();
            
        }

        private void dgvTandaTerima_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             
            switch (dgvTandaTerima.Columns[e.ColumnIndex].Name)
            {
                case "Select" :
                    FormListItem formlistitem = new FormListItem(this);
                    formlistitem.Tag = "Inventaris";
                    
                    formlistitem.GcList.DataSource = controllerInventaris.getAllInventarisKomputer2();
                    formlistitem.dgvListItem.OptionsView.ColumnAutoWidth = false;
                    formlistitem.ShowDialog();

                    if (ControllerStaticVariables.KodeInventaris == null || ControllerStaticVariables.KodeInventaris == "")
                    {
                        
                    }
                    else
                    {
                        dgvTandaTerima.CurrentRow.Cells["KodeInventaris"].Value = ControllerStaticVariables.KodeInventaris.ToString();
                        dgvTandaTerima.CurrentRow.Cells["NamaBarang"].Value = ControllerStaticVariables.NamaBarang.ToString();
                        dgvTandaTerima.CurrentRow.Cells["BiayaPerbaikan"].Value = "0";
                        dgvTandaTerima.CurrentRow.Cells["TanggalSelesai"].Value = "01/01/1901";
                        dgvTandaTerima.CurrentRow.Cells["Keterangan"].Value = " ";
                        dgvTandaTerima.NotifyCurrentCellDirty(true);
                        //dgvTandaTerima.Rows.Add();
                    }
                    break;
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (this.Tag.ToString()=="Tambah")
            {
                //set Data Table TT
                controllerTandaTerima.setTT(txtTTReparasi.Text, txtKodeSupplier.Text, txtNamaSupp.Text, dtpTglTT.Value, Convert.ToDecimal(txttotalBiaya.Text), txtketerangan.Text);
                //set Data Table Det TT 
                foreach (DataGridViewRow row in dgvTandaTerima.Rows)
                {
                    //isnewrow
                    //if (row.Cells["NamaBarang"].Value.ToString() == "" || row.Cells["NamaBarang"].Value.ToString() == " " || row.Cells["NamaBarang"].Value.ToString() == null) 
                    //{
                    //    break;
                    //}
                    if (row.IsNewRow)
                    {
                        continue;
                    }
                    else
                    {
                        var tmp = row.Cells["KodeInventaris"].Value.ToString();
                        var tmpp = row.Cells["Keterangan"].Value.ToString();
                        var tmppp = row.Cells["BiayaPerbaikan"].Value.ToString();
                        var tmpppp = row.Cells["TanggalSelesai"].Value.ToString();
                        controllerTandaTerima.setDetTT(txtTTReparasi.Text, row.Cells["KodeInventaris"].Value.ToString() ?? " ", row.Cells["NamaBarang"].Value.ToString(), Convert.ToDecimal(row.Cells["BiayaPerbaikan"].Value) , Convert.ToDateTime(row.Cells["TanggalSelesai"].Value.ToString()), row.Cells["Keterangan"].Value.ToString() ?? " ");
                    } 
                }

                //var tmp = controllerTandaTerima.listDetailTandaTerima;
                //var tmpp = tmp;

                try
                {
                    controllerTandaTerima.InsertTT(controllerTandaTerima.tt);
                    controllerTandaTerima.InsertDetTT(controllerTandaTerima.listDetailTandaTerima);
                    MessageBox.Show("Tanda terima reparasi berhasil ditambah");
                    this.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }

            }

            else if (this.Tag.ToString() == "Edit")
            {
                //set Data Table TT
                controllerTandaTerima.setTT(txtTTReparasi.Text, txtKodeSupplier.Text, txtNamaSupp.Text, dtpTglTT.Value, Convert.ToDecimal(txttotalBiaya.Text), txtketerangan.Text);
                //set Data Table Det TT 
                foreach (DataGridViewRow row in dgvTandaTerima.Rows)
                {
                    //isnewrow
                    //if (row.Cells["NamaBarang"].Value.ToString() == "" || row.Cells["NamaBarang"].Value.ToString() == " " || row.Cells["NamaBarang"].Value.ToString() == null) 
                    //{
                    //    break;
                    //}
                    if (row.IsNewRow)
                    {
                        continue;
                    }
                    else
                    {
                        
                        controllerTandaTerima.setDetTT(txtTTReparasi.Text, row.Cells["KodeInventaris"].Value.ToString() ?? " ", row.Cells["NamaBarang"].Value.ToString(), Convert.ToDecimal(row.Cells["BiayaPerbaikan"].Value), Convert.ToDateTime(DateTime.Now), row.Cells["Keterangan"].Value.ToString() ?? " ");
                    }
                }

                //var tmp = controllerTandaTerima.listDetailTandaTerima;
                //var tmpp = tmp;

                try
                {
                    controllerTandaTerima.DeleteDetTT(txtTTReparasi.Text);
                    controllerTandaTerima.UpdateTT(txtTTReparasi.Text);
                    controllerTandaTerima.InsertDetTT(controllerTandaTerima.listDetailTandaTerima);
                    MessageBox.Show("Tanda terima reparasi berhasil diubah");
                    this.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }

        private void AddRow_Click(object sender, EventArgs e)
        {

        }

        private void dgvTandaTerima_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            dgvTandaTerima.Rows[dgvTandaTerima.RowCount-1].Cells["KodeInventaris"].Value = " ";
            dgvTandaTerima.Rows[dgvTandaTerima.RowCount - 1].Cells["BiayaPerbaikan"].Value = "0";
            dgvTandaTerima.Rows[dgvTandaTerima.RowCount - 1].Cells["TanggalSelesai"].Value = "01/01/1901";
            dgvTandaTerima.Rows[dgvTandaTerima.RowCount - 1].Cells["Keterangan"].Value = " ";
        }

        private void dgvTandaTerima_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }

        private void dgvTandaTerima_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                
                int tmp = 0;
                foreach(DataGridViewRow row in dgvTandaTerima.Rows)
                {
                    tmp += Convert.ToInt32(row.Cells[4].Value);
                }
                txttotalBiaya.Text = tmp.ToString();
            }
        }
    }
}
