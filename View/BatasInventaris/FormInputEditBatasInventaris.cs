using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Master.Master;
using Inventaris.Controller;

namespace Inventaris.View.BatasInventaris
{
    public partial class FormInputEditBatasInventaris : Form
    {
        #region properties 

        private ControllerBatasInventaris controllerBatasInventaris;
        private ControllerBagian controllerBagian;
        private ControllerKebun controllerKebun;
        private ControllerKategori controllerKategori;
        private DataTable dt;
        private string KodeBagian, KodeKategori, KodeKebun;

        #endregion

        #region specialFunction

        /// <summary>
        /// set button text sesuai dengan Tag yang diberikan
        /// </summary>
        /// <param name="Tag"></param>
        public void setButtonText(string Tag)
        {
            this.btnAddorEdit.Text = Tag;
        }

        /// <summary>
        /// set ComboBox Kategori
        /// </summary>
        public void setcbxKategori()
        {
            dt = controllerKategori.getAllKategori();
            foreach(DataRow x in dt.Rows)
            {
                cbxKodeKategori.Items.Add(x["KodeKategori"].ToString());
            }
        }

        /// <summary>
        /// set ComboBox Kebun
        /// </summary>
        public void setcbxKebun()
        {
            dt = controllerKebun.getAllKebun();
            foreach (DataRow x in dt.Rows)
            {
                cbxKodeKebun.Items.Add(x["KodeKebun"].ToString());
            }
        }

        /// <summary>
        /// set ComboBox Bagian
        /// </summary>
        public void setcbxBagian()
        {
            dt = controllerBagian.getAllBagian();
            foreach (DataRow x in dt.Rows)
            {
                cbxKodeBagian.Items.Add(x["KodeBagian"].ToString());
            }
        }

        /// <summary>
        /// set value pada field yang ada di form inputeditbatasinventaris
        /// </summary>
        /// <param name="KodeBagian"></param>
        /// <param name="KodeKategori"></param>
        /// <param name="KodeKebun"></param>
        public void setEditCondition()
        {
            cbxKodeBagian.Enabled = false;
            cbxKodeKategori.Enabled = false;
            cbxKodeKebun.Enabled = false;
            controllerBatasInventaris.batasInventaris = controllerBatasInventaris.getOneRecord(KodeBagian, KodeKategori, KodeKebun);
            cbxKodeBagian.Text = controllerBatasInventaris.batasInventaris.KodeBagian;
            cbxKodeKategori.Text = controllerBatasInventaris.batasInventaris.KodeKategori;
            cbxKodeKebun.Text = controllerBatasInventaris.batasInventaris.KodeKebun;
            NUDJlhMax.Value = controllerBatasInventaris.batasInventaris.JumlahMax;
            txtKeterangan.Text = controllerBatasInventaris.batasInventaris.Keterangan;
        }

        #endregion

        #region Constructor

        public FormInputEditBatasInventaris()
        {
            InitializeComponent();
        }

        public FormInputEditBatasInventaris(DBConnectionClass objConnection)
        {
            InitializeComponent();
            this.controllerBatasInventaris = new ControllerBatasInventaris(objConnection);
            this.controllerKategori = new ControllerKategori(objConnection);
            this.controllerKebun = new ControllerKebun(objConnection);
            this.controllerBagian = new ControllerBagian(objConnection);
        }

        public FormInputEditBatasInventaris(DBConnectionClass objConnection, string KodeBagian, string KodeKategori, string KodeKebun)
        {
            InitializeComponent();
            this.controllerBatasInventaris = new ControllerBatasInventaris(objConnection);
            this.controllerKategori = new ControllerKategori(objConnection);
            this.controllerKebun = new ControllerKebun(objConnection);
            this.controllerBagian = new ControllerBagian(objConnection);
            this.KodeBagian = KodeBagian;
            this.KodeKategori = KodeKategori;
            this.KodeKebun = KodeKebun;
        }


        #endregion

        private void BtnAddorEdit_Click(object sender, EventArgs e)
        {
            if(this.Tag.ToString().Equals("Tambah"))
            {
                if (controllerBatasInventaris.controllerBIforCUD.checkRecord(cbxKodeBagian.SelectedItem.ToString(), cbxKodeKategori.SelectedItem.ToString(), cbxKodeKebun.SelectedItem.ToString()))
                {
                    this.controllerBatasInventaris.setBatasInventaris(cbxKodeBagian.SelectedItem.ToString(), cbxKodeKategori.SelectedItem.ToString(), cbxKodeKebun.SelectedItem.ToString(), Convert.ToInt32(NUDJlhMax.Value), txtKeterangan.Text.ToString());
                    try
                    {
                        controllerBatasInventaris.controllerBIforCUD.InsertRecord(this.controllerBatasInventaris.batasInventaris);
                        MessageBox.Show("Data Batas Inventaris untuk Kode Kategori " + cbxKodeKategori.SelectedItem.ToString() + " dengan KodeBagian = " + cbxKodeBagian.SelectedItem.ToString() + " dan KodeKebun = " + cbxKodeKebun.SelectedItem.ToString() + " Berhasil Ditambah ");
                        this.Close();
                    }

                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Data Batas Inventaris Sudah Ada untuk Kode Kategori " + cbxKodeKategori.SelectedItem.ToString() + " dengan KodeBagian = " + cbxKodeBagian.SelectedItem.ToString() + " dan KodeKebun = " + cbxKodeKebun.SelectedItem.ToString());
                }
            }
            else if(this.Tag.ToString().Equals("Ubah"))
            {
                try
                {
                    this.controllerBatasInventaris.setBatasInventaris(cbxKodeBagian.Text, cbxKodeKategori.Text, cbxKodeKebun.Text, Convert.ToInt32(NUDJlhMax.Value), txtKeterangan.Text);
                    this.controllerBatasInventaris.controllerBIforCUD.UpdateRecord(this.controllerBatasInventaris.batasInventaris);
                    MessageBox.Show("Data BatasInventaris berhasil di ubah");
                    this.Close();
                }
                catch(Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void FormInputEditBatasInventaris_Load(object sender, EventArgs e)
        {
            this.setcbxBagian();
            this.setcbxKategori();
            this.setcbxKebun();
        }
    }
}
