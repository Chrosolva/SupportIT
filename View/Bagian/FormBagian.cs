using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SupportIT.Controller;
using Master.Master;

namespace SupportIT.View
{
    public partial class FormBagian : Form
    {
        #region properties

        private ControllerBagian controllerBagian;

        #endregion

        #region Constructor 

        public FormBagian()
        {
            InitializeComponent();

        }

        /// <summary>
        /// Constructor FormBagian dengan parameter objek class koneksi
        /// </summary>
        /// <param name="objConnection"></param>
        public FormBagian(DBConnectionClass objConnection)
        {
            InitializeComponent();
            this.controllerBagian = new ControllerBagian(objConnection);
            DGVForBagian.DataSource = controllerBagian.getAllBagian();
            DGVForBagian.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        #endregion

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            FormInputEditBagian formInputEditBagian = new FormInputEditBagian(this.controllerBagian.objConnection);
            formInputEditBagian.Tag = "Tambah";
            formInputEditBagian.setButtontext(formInputEditBagian.Tag.ToString());
            formInputEditBagian.ShowDialog();
            DGVForBagian.DataSource = controllerBagian.getAllBagian();
        }

        private void DGVForBagian_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void FormBagian_Load(object sender, EventArgs e)
        {
            btnUbah.Enabled = false;
        }

        private void BtnUbah_Click(object sender, EventArgs e)
        {
            FormInputEditBagian formInputEditBagian = new FormInputEditBagian(this.controllerBagian.objConnection, DGVForBagian.CurrentRow.Cells["KodeBagian"].Value.ToString());
            formInputEditBagian.Tag = "Ubah";
            formInputEditBagian.setButtontext(formInputEditBagian.Tag.ToString());
            this.controllerBagian.bagian = this.controllerBagian.getOnerecord(DGVForBagian.CurrentRow.Cells["KodeBagian"].Value.ToString());
            formInputEditBagian.setEditcondition(this.controllerBagian.bagian);
            formInputEditBagian.ShowDialog();
            DGVForBagian.DataSource = controllerBagian.getAllBagian();
        }

        private void DGVForBagian_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUbah.Enabled = true;
        }
    }
}
