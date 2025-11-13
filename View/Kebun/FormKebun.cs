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
    public partial class FormKebun : Form
    {
        #region properties
        private ControllerKebun controllerKebun;

        #endregion

        #region Constructor

        public FormKebun()
        {
            InitializeComponent();
        }

        public FormKebun(DBConnectionClass objConnection)
        {
            InitializeComponent();
            this.controllerKebun = new ControllerKebun(objConnection);
        }


        #endregion

        private void FormKebun_Load(object sender, EventArgs e)
        {
            DGVForKebun.DataSource = controllerKebun.getAllKebun();
            DGVForKebun.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            FormInputEditKebun formInputEditKebun = new FormInputEditKebun(this.controllerKebun.objConnection);
            formInputEditKebun.Tag = "Tambah";
            formInputEditKebun.setButtonText(formInputEditKebun.Tag.ToString());
            formInputEditKebun.ShowDialog();
            DGVForKebun.DataSource = controllerKebun.getAllKebun();
        }

        private void DGVForKebun_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUbah.Enabled = true;
        }

        private void FormKebun_Click(object sender, EventArgs e)
        {
            btnUbah.Enabled = false;
        }

        private void BtnUbah_Click(object sender, EventArgs e)
        {
            FormInputEditKebun formInputEditKebun = new FormInputEditKebun(this.controllerKebun.objConnection, DGVForKebun.CurrentRow.Cells["KodeKebun"].Value.ToString());
            formInputEditKebun.Tag = "Ubah";
            formInputEditKebun.setButtonText(formInputEditKebun.Tag.ToString());
            formInputEditKebun.setEditCondition();
            formInputEditKebun.ShowDialog();
            DGVForKebun.DataSource = controllerKebun.getAllKebun();
        }
    }
}
