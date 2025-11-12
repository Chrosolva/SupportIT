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
    public partial class FormLogin : Form
    {
        #region properties

        public ControllerUser controllerUser;

        #endregion

        public FormLogin()
        {
            InitializeComponent();
            controllerUser = new ControllerUser("DBMISPEUKD", "172.25.20.21");

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtUserID.Text) || String.IsNullOrEmpty(txtPass.Text))
            {
                MessageBox.Show("Silahkan isi UserId atau Password. Pastikan tidak ada yang kosong");
            }
            else
            {
                if (controllerUser.login(this.txtUserID.Text.ToUpper(), this.txtPass.Text.ToUpper()))
                {
                    MainMDI_Form mainMDI_Form = new MainMDI_Form(controllerUser.objConnection, controllerUser.objUser);
                    mainMDI_Form.Show();
                    this.Hide();
                }
                else if(!controllerUser.login(this.txtUserID.Text.ToUpper(), this.txtPass.Text.ToUpper()))
                {
                    MessageBox.Show("UserID atau Password Salah");
                    txtUserID.Text = "";
                    txtPass.Text = "";
                }
            }
        }

        private void BtnBatal_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
