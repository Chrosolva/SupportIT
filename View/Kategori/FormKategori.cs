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
using Master.Master;

namespace Inventaris.View
{
    public partial class FormKategori : Form
    {
        #region properties

        public ControllerKategori controllerKategori;
        

        #endregion

        public FormKategori()
        {
            InitializeComponent();
        }

        public FormKategori(DBConnectionClass objConnection)
        {
            InitializeComponent();
            this.controllerKategori = new ControllerKategori(objConnection);
            DGVForKategori.DataSource = controllerKategori.getAllKategori();
            DGVForKategori.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            FormInputKategori frminputkategori = new FormInputKategori(controllerKategori.objConnection);
            frminputkategori.Tag = "Tambah";
            frminputkategori.setButtonText();
            frminputkategori.ShowDialog();
            DGVForKategori.DataSource = controllerKategori.getAllKategori();
        }

        private void BtnUbah_Click(object sender, EventArgs e)
        {
            FormInputKategori frminputkategori = new FormInputKategori(controllerKategori.objConnection, DGVForKategori.CurrentRow.Cells["KodeKategori"].Value.ToString());
            frminputkategori.Tag = "Ubah";
            frminputkategori.setButtonText();
            frminputkategori.setEditCondition();
            frminputkategori.ShowDialog();
            DGVForKategori.DataSource = controllerKategori.getAllKategori();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Panel1_Click(object sender, EventArgs e)
        {
            btnUbah.Enabled = false;
        }

        private void DGVForKategori_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DGVForKategori_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUbah.Enabled = true;
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {

        }
    }
}
