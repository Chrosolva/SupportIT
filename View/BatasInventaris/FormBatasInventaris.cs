using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SupportIT.View.BatasInventaris;
using Master.Master;
using SupportIT.Controller;
namespace SupportIT.View

{
    public partial class FormBatasInventaris : Form
    {
        #region properties
        private ControllerBagian controllerBagian;
        private ControllerKebun controllerKebun;
        private ControllerKategori controllerKategori;
        private ControllerBatasInventaris controllerBatasInventaris;
        private DataTable dt;

        #endregion

        #region specialfunction

        /// <summary>
        /// set ComboBox Kategori
        /// </summary>
        public void setcbxKategori()
        {
            dt = controllerKategori.getAllKategori();
            cbxKodeKategori.DisplayMember = "Text";
            cbxKodeKategori.ValueMember = "Value";
            foreach (DataRow x in dt.Rows)
            {
                cbxKodeKategori.Items.Add(new { Text = x["NamaKategori"].ToString(), Value = x["KodeKategori"].ToString() });
            }
            cbxKodeKategori.SelectedIndex = 0;
        }

        /// <summary>
        /// set ComboBox Kebun
        /// </summary>
        public void setcbxKebun()
        {
            dt = controllerKebun.getAllKebun();
            cbxKodeKebun.DisplayMember = "Text";
            cbxKodeKebun.ValueMember = "Value";
            foreach (DataRow x in dt.Rows)
            {
                cbxKodeKebun.Items.Add(new { Text = x["NamaKebun"].ToString(), Value = x["KodeKebun"].ToString() });
            }
            cbxKodeKebun.SelectedIndex = 0;
        }

        /// <summary>
        /// set ComboBox Bagian
        /// </summary>
        public void setcbxBagian()
        {
            dt = controllerBagian.getAllBagian();
            cbxKodeBagian.DisplayMember = "Text";
            cbxKodeBagian.ValueMember = "Value";
            
            foreach (DataRow x in dt.Rows)
            {
                cbxKodeBagian.Items.Add(new { Text = x["NamaBagian"].ToString(), Value = x["KodeBagian"].ToString() });
            }
            cbxKodeBagian.SelectedIndex = 0; 
        }

        #endregion

        #region Constructor

        public FormBatasInventaris()
        {
            InitializeComponent();
        }

        public FormBatasInventaris(DBConnectionClass objConnection)
        {
            InitializeComponent();
            controllerBatasInventaris = new ControllerBatasInventaris(objConnection);
            controllerKategori = new ControllerKategori(objConnection);
            controllerBagian = new ControllerBagian(objConnection);
            controllerKebun = new ControllerKebun(objConnection);
        }

        #endregion

        private void FormBatasInventaris_Load(object sender, EventArgs e)
        {
            DgvForBatasInventaris.DataSource = controllerBatasInventaris.getAllBatasInventarisWithDetails();
            DgvForBatasInventaris.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.setcbxBagian();
            this.setcbxKategori();
            this.setcbxKebun();
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            FormInputEditBatasInventaris formInputEditBatasInventaris = new FormInputEditBatasInventaris(this.controllerBatasInventaris.objConnection);
            formInputEditBatasInventaris.Tag = "Tambah";
            formInputEditBatasInventaris.setButtonText(formInputEditBatasInventaris.Tag.ToString());
            formInputEditBatasInventaris.ShowDialog();
            DgvForBatasInventaris.DataSource = controllerBatasInventaris.getAllBatasInventarisWithDetails();
        }

        private void BtnUbah_Click(object sender, EventArgs e)
        {
            FormInputEditBatasInventaris formInputEditBatasInventaris = new FormInputEditBatasInventaris(this.controllerBatasInventaris.objConnection, DgvForBatasInventaris.CurrentRow.Cells["KodeBagian"].Value.ToString(), DgvForBatasInventaris.CurrentRow.Cells["KodeKategori"].Value.ToString(), DgvForBatasInventaris.CurrentRow.Cells["KodeKebun"].Value.ToString());
            formInputEditBatasInventaris.Tag = "Ubah";
            formInputEditBatasInventaris.setButtonText(formInputEditBatasInventaris.Tag.ToString());
            formInputEditBatasInventaris.setEditCondition();
            formInputEditBatasInventaris.ShowDialog();
            DgvForBatasInventaris.DataSource = controllerBatasInventaris.getAllBatasInventarisWithDetails();
        }

        private void DgvForBatasInventaris_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUbah.Enabled = true;
        }

        private void CbxKodeBagian_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void ToolstripFilter_Click(object sender, EventArgs e)
        {
            if(cbxKodeKebun.SelectedIndex <= 0)
            {
                DgvForBatasInventaris.DataSource = controllerBatasInventaris.Filter2parm(Convert.ToString((cbxKodeBagian.SelectedItem as dynamic).Value), Convert.ToString((cbxKodeKategori.SelectedItem as dynamic).Value));
            }
            else
            {
                DgvForBatasInventaris.DataSource = controllerBatasInventaris.Filter3Parm(Convert.ToString((cbxKodeBagian.SelectedItem as dynamic).Value), Convert.ToString((cbxKodeKategori.SelectedItem as dynamic).Value), Convert.ToString((cbxKodeKebun.SelectedItem as dynamic).Value));
            }
        }
    }
}
