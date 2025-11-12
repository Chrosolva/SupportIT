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
using Inventaris.Model;
using Master.Controller;
using Master.View;
using SupportIT.View.Inventaris;
using SupportIT.View.Perbaikan;
using SupportIT;

namespace Inventaris.View
{
    public partial class MainMDI_Form : Form
    {
        #region properties

        public DBConnectionClass objConenction;
        public User objUser;

        #endregion

        #region Constructor

        public MainMDI_Form()
        {
            InitializeComponent();
        }

        public MainMDI_Form(DBConnectionClass objConnection, User objUser)
        {
            InitializeComponent();
            this.objConenction = ControllerStaticVariables.objConnection;
            this.objUser = objUser;
        }

        #endregion

        private void TahunLaliuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControllerStaticVariables.tahun = DateTime.Now.Year -1;
        }

        private void KategoriInventarisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKategori formKategori = new FormKategori(ControllerStaticVariables.objConnection);
            formKategori.MdiParent = this;
            formKategori.Show();
        }

        private void DaftarInventarisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTabelInventaris formTabelInventaris = new FormTabelInventaris(ControllerStaticVariables.objConnection);
            formTabelInventaris.MdiParent = this;
            formTabelInventaris.Show();
        }

        private void KebunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKebun formKebun = new FormKebun(ControllerStaticVariables.objConnection);
            formKebun.MdiParent = this;
            formKebun.Show();
        }

        private void BagianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBagian formBagian = new FormBagian(ControllerStaticVariables.objConnection);
            formBagian.MdiParent = this;
            formBagian.Show();
        }

        private void MainMDI_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }

        private void BatasInventarisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBatasInventaris formBatasInventaris = new FormBatasInventaris(ControllerStaticVariables.objConnection);
            formBatasInventaris.MdiParent = this;
            formBatasInventaris.Show();
        }

        private void MainMDI_Form_Load(object sender, EventArgs e)
        {
            this.Text = "Inventaris - " + ControllerStaticVariables.controllerUser.user.UserID;
            tsslConnection.Text = "Connected to " + ControllerStaticVariables.server;
            tsslUsername.Text = "User: " + ControllerStaticVariables.controllerUser.user.UserID;
            // Pick sizes to your taste
            var appFonts = GlobalFontHelper.Resolve(
                bodySize: 12f,           // typical body
                headerSize: 12.5f,       // slightly larger headers
                headerStyle: FontStyle.Bold
            );

            // Apply to the main form (and all its current controls)
            GlobalFontHelper.Apply(this, appFonts);
        }

        private void logOFFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            foreach (Form frm in this.MdiChildren)
            {

                frm.Dispose();
                frm.Close();

            }
            new FormLogin(ControllerStaticVariables.NamaProgram).ShowDialog();
            tsslConnection.Text = "Connected to " + ControllerStaticVariables.server;
            tsslUsername.Text = "User: " + ControllerStaticVariables.controllerUser.user.UserID;
            
            this.Show();
        }

        private void supplierReparasiToolStripMenuItem_Click(object sender, EventArgs e)
        {
              
        }

        private void supplierReparasiToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormSupplierReparasi formsupplier = new FormSupplierReparasi();
            formsupplier.MdiParent = this;
            formsupplier.Show();
        }

        private void tandaTerimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTandaTerimaList formlisttandatrima = new FormTandaTerimaList();
            formlisttandatrima.MdiParent = this;
            formlisttandatrima.Show();
        }

        private void tahunSekarangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControllerStaticVariables.tahun = DateTime.Now.Year;
        }

        private void pilihTahunToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void suratPengantarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListSuratPengantar formlistSP = new FormListSuratPengantar();
            formlistSP.MdiParent = this;
            formlistSP.StartPosition = FormStartPosition.CenterParent;
            formlistSP.Show();
        }

        private void suratPerbaikanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSuratPerbaikan frmSuratPerbaikan = new FrmSuratPerbaikan();
            frmSuratPerbaikan.MdiParent = this;
            frmSuratPerbaikan.StartPosition = FormStartPosition.CenterParent;
            frmSuratPerbaikan.Show();
        }
    }
}
