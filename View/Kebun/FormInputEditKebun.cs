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
    public partial class FormInputEditKebun : Form
    {
        #region properties

        private string KodeKebun;
        public ControllerKebun controllerKebun;

        #endregion

        #region Constructor

        public FormInputEditKebun()
        {
            InitializeComponent();
        }

        public FormInputEditKebun(DBConnectionClass objConnection)
        {
            InitializeComponent();
            controllerKebun = new ControllerKebun(objConnection);
        }

        public FormInputEditKebun(DBConnectionClass objConnection, string KodeKebun)
        {
            InitializeComponent();
            controllerKebun = new ControllerKebun(objConnection);
            this.KodeKebun = KodeKebun;
        }

        #endregion

        #region Private Function

        public void setButtonText(string Tag)
        {
            this.btnAddorEdit.Text = Tag;
        }

        public void setEditCondition()
        {
            controllerKebun.kebun = controllerKebun.getOneRecord(KodeKebun);
            txtKodeKebun.Enabled = false;
            txtKodeKebun.Text = controllerKebun.kebun.KodeKebun;
            txtNamaKebun.Text = controllerKebun.kebun.NamaKebun;
            txtAlamat.Text = controllerKebun.kebun.Alamat;
            txtNamaSIngkat.Text = controllerKebun.kebun.NamaSingkat;
            txtKota.Text = controllerKebun.kebun.Kota;
            txtKodepos.Text = controllerKebun.kebun.KodePos;
            txtTelp.Text = controllerKebun.kebun.Telp;
            txtFax.Text = controllerKebun.kebun.Fax;
            txtStatus.Text = controllerKebun.kebun.Status;
        }

        #endregion

        private void Button1_Click(object sender, EventArgs e)
        {
            if (this.Tag.ToString() == "Tambah")
            {
                try
                {
                    controllerKebun.setKebun(txtKodeKebun.Text, txtNamaKebun.Text, txtAlamat.Text, txtNamaSIngkat.Text, txtKota.Text, txtKodepos.Text, txtTelp.Text, txtFax.Text, txtStatus.Text);
                    controllerKebun.controllerKebunForCUD.Insert(controllerKebun.kebun);
                    MessageBox.Show("Data Kebun Berhasil Ditambah");
                    this.Close();
                }

                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                    txtKodeKebun.Text = "";
                    txtNamaKebun.Text = "";
                    txtAlamat.Text = "";
                    txtNamaSIngkat.Text = "";
                    txtKota.Text = "";
                    txtKodepos.Text = "";
                    txtTelp.Text = "";
                    txtFax.Text = "";
                    txtStatus.Text = "";

                }
            }
            // if btnUbah ditekan melalui form kategori
            else if (this.Tag.ToString() == "Ubah")
            {
                try
                {
                    controllerKebun.setKebun(txtKodeKebun.Text, txtNamaKebun.Text, txtAlamat.Text, txtNamaSIngkat.Text, txtKota.Text, txtKodepos.Text, txtTelp.Text, txtFax.Text, txtStatus.Text);
                    controllerKebun.controllerKebunForCUD.Update(controllerKebun.kebun);
                    MessageBox.Show("Data Kebun Berhasil Diubah");
                    this.Close();
                }

                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }
    }
}
