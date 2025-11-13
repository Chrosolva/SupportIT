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
using SupportIT.Controller;
using SupportIT.Model;

namespace SupportIT.View
{
    public partial class FormInputEditBagian : Form
    {
        #region properties

        private ControllerBagian controllerBagian;
        private string KodeBagian;

        #endregion

        #region Constructor

        public FormInputEditBagian()
        {
            InitializeComponent();
        }

        public FormInputEditBagian(DBConnectionClass objConenection)
        {
            InitializeComponent();
            this.controllerBagian = new ControllerBagian(objConenection);
        }

        public FormInputEditBagian(DBConnectionClass objConenection, string KodeBagian)
        {
            InitializeComponent();
            this.controllerBagian = new ControllerBagian(objConenection);
            this.KodeBagian = KodeBagian;
        }

        #endregion

        #region privateFUnction

        public void setButtontext(string Tag)
        {
            this.btnAddorEdit.Text = Tag;
        }

        /// <summary>
        /// set field sesuai dengan objek bagian
        /// </summary>
        /// <param name="bagian"></param>
        public void setEditcondition(Bagian bagian)
        {
            txt_KodeBagian.Enabled = false;
            txt_KodeBagian.Text = bagian.KodeBagian;
            txt_NamaBagian.Text = bagian.NamaBagian;
            txt_Asisten.Text = bagian.Asisten;
            txt_Grup.Text = bagian.Grup;
        }

        #endregion

        private void BtnAddorEdit_Click(object sender, EventArgs e)
        {
            if (this.Tag.ToString() == "Tambah")
            {
                try
                {
                    controllerBagian.setBagian(txt_KodeBagian.Text,txt_NamaBagian.Text,txt_Asisten.Text,txt_Grup.Text);
                    controllerBagian.ControllerBagianforCUD.Insert(controllerBagian.bagian);
                    MessageBox.Show("Data Bagian Berhasil Ditambah");
                    this.Close();
                }

                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                    txt_KodeBagian.Text = "";
                    txt_NamaBagian.Text = "";
                    txt_Asisten.Text = "";
                    txt_Grup.Text = ""; 
                }
            }
            // if btnUbah ditekan melalui form kategori
            else if (this.Tag.ToString() == "Ubah")
            {
                try
                {
                    controllerBagian.setBagian(txt_KodeBagian.Text, txt_NamaBagian.Text,txt_Asisten.Text,txt_Grup.Text);
                    controllerBagian.ControllerBagianforCUD.Update(controllerBagian.bagian);
                    MessageBox.Show("Data Bagian Berhasil Diubah");
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
