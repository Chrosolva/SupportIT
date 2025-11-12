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

namespace Inventaris.View
{
    public partial class FormInputKategori : Form
    {

        #region properties

        public ControllerKategori controllerKategori;
        private string KodeKategori;

        #endregion

        #region Constructor

        public FormInputKategori()
        {
            InitializeComponent();
        }

        public FormInputKategori(DBConnectionClass objConnection)
        {
            this.controllerKategori = new ControllerKategori(objConnection);
            InitializeComponent();
        }

        public FormInputKategori(DBConnectionClass objConnection, string KodeKategori)
        {
            this.controllerKategori = new ControllerKategori(objConnection);
            InitializeComponent();
            this.KodeKategori = KodeKategori;
        }

        #endregion

        #region privatefunction

        /// <summary>
        /// set btnAddorEdit text sesuai dengan Tag
        /// </summary>
        public void setButtonText()
        {
            if (this.Tag != null)
            {
                btnAddorEdit.Text = this.Tag.ToString();
                txtKodeKategori.Enabled = true;
            }
        }

        /// <summary>
        /// set Textbook dengan nilai yang ada pada objek Kategori
        /// </summary>
        public void setEditCondition()
        {
            this.controllerKategori.objKategori = this.controllerKategori.getOnerecord(KodeKategori);
            txtKodeKategori.Text = controllerKategori.objKategori.KodeKategori.ToString();
            txtKodeKategori.Enabled = false;
            txtNamaKategori.Text = controllerKategori.objKategori.NamaKategori.ToString();
        }

        #endregion

        private void BtnAddorEdit_Click(object sender, EventArgs e)
        {
            // if btnTambah ditekan melalui formkategori
            if(this.Tag.ToString() == "Tambah")
            {
                try
                {
                    controllerKategori.setKategori(txtKodeKategori.Text, txtNamaKategori.Text);
                    controllerKategori.controllerKategoriForCUD.Insert(controllerKategori.objKategori);
                    MessageBox.Show("Data Kategori Berhasil Ditambah");
                    this.Close();
                }

                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                    txtKodeKategori.Text = "";
                    txtNamaKategori.Text = "";
                }
            }
            // if btnUbah ditekan melalui form kategori
            else if (this.Tag.ToString() =="Ubah")
            {
                try
                {
                    controllerKategori.setKategori(txtKodeKategori.Text, txtNamaKategori.Text);
                    controllerKategori.controllerKategoriForCUD.Update(controllerKategori.objKategori);
                    MessageBox.Show("Data Kategori Berhasil Diubah");
                    this.Close();
                }

                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void FormInputKategori_Load(object sender, EventArgs e)
        {

        }
    }
}
