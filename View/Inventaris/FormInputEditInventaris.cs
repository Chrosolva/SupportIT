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
using SupportIT.View;
using SupportIT.View.Inventaris;
using SupportIT.Model;
using Master.Controller;

namespace SupportIT.View.Inventaris
{
    public partial class FormInputEditInventaris : Form
    {
        #region properties

        private ControllerBagian controllerBagian;
        private ControllerKategori controllerKategori;
        private ControllerKebun controllerKebun;
        private ControllerInventaris controllerInventaris;
        
        private DataTable dt;
        private string Spesifikasi;
        private string KodeInventaris;
        private string[] ArrSpesifikasi;

        #endregion

        #region Special Function

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
            cbxKodeKategori.DisplayMember = "Text";
            cbxKodeKategori.ValueMember = "Value";
            foreach (DataRow x in dt.Rows)
            {
                cbxKodeKategori.Items.Add(new { Text = x["NamaKategori"].ToString(), Value = x["KodeKategori"].ToString() });
            }
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
                string namaopsi = x["KodeKebun"].ToString() + "-" +  x["NamaKebun"].ToString();
                cbxKodeKebun.Items.Add(new { Text = namaopsi, Value = x["KodeKebun"].ToString(), Status = x["Status"].ToString() });
            }
            cbxKodeKebun.SelectedIndex = 0;
            
        }

        /// <summary>
        /// set ComboBox Bagian
        /// </summary>
        public void setcbxBagian()
        {
            dt = controllerBagian.getAllBagian(ControllerStaticVariables.StatusKebun);
            cbxKodeBagian.DisplayMember = "Text";
            cbxKodeBagian.ValueMember = "Value";

            foreach (DataRow x in dt.Rows)
            {
                string namaopsi = x["KodeBagian"].ToString() + "-" + x["NamaBagian"].ToString();
                cbxKodeBagian.Items.Add(new { Text = namaopsi, Value = x["KodeBagian"].ToString() });
            }
        }

        /// <summary>
        /// check data kode bagian ke combobox
        /// </summary>
        /// <param name="cbxvalue"></param>
        public void checkcbxBagian (string cbxvalue)
        {
            for (int i =0; i < cbxKodeBagian.Items.Count;i++)
            {
                string tmp = (cbxKodeBagian.Items[i] as dynamic).Value;
                if((cbxKodeBagian.Items[i] as dynamic).Value == cbxvalue)
                {
                    cbxKodeBagian.SelectedIndex = i;
                    break;
                }
            }
        }

        /// <summary>
        /// check kode kategori dengan combobox
        /// </summary>
        /// <param name="cbxvalue"></param>
        public void checkcbxkategori(string cbxvalue)
        {
            for (int i = 0; i < cbxKodeKategori.Items.Count; i++)
            {
                if ((cbxKodeKategori.Items[i] as dynamic).Value == cbxvalue)
                {
                    cbxKodeKategori.SelectedIndex = i;
                    break;
                }
            }
        }

        /// <summary>
        /// check kode kebun dengan combobox
        /// </summary>
        /// <param name="cbxvalue"></param>
        public void checkcbxKebun(string cbxvalue)
        {
            for (int i = 0; i < cbxKodeKebun.Items.Count; i++)
            {
                if ((cbxKodeKebun.Items[i] as dynamic).Value == cbxvalue)
                {
                    cbxKodeKebun.SelectedIndex = i;
                    break;
                }
            }
        }

        public void setEditCondition()
        {
            this.controllerInventaris.InventarisKomputer = this.controllerInventaris.getOneRecordInventaris(KodeInventaris);
            this.controllerInventaris.detailInventarisKomputer = this.controllerInventaris.getOneRecordDetailInventaris(KodeInventaris);
            txtNoPO.Enabled = false;
            DtpTanggalBeli.Enabled = false;
            cbxKodeKategori.Enabled = true;
            cbxKodeBagian.Enabled = true;
            cbxKodeKebun.Enabled = true;
            cbxKodePT.Text = controllerInventaris.InventarisKomputer.KodePT;
            cbxKodePT.Enabled = false;
            txtKeteranganAfkir.Text = controllerInventaris.InventarisKomputer.KeteranganAfkir;
            ArrSpesifikasi = this.controllerInventaris.detailInventarisKomputer.Spesifikasi.Split('~');
            foreach(string x in ArrSpesifikasi)
            {
                DataGridViewRow newrow = (DataGridViewRow)DgvForSpesifikasi.Rows[0].Clone();
                newrow.Cells[0].Value = x;
                DgvForSpesifikasi.Rows.Add(newrow);
            }
            this.checkcbxKebun(controllerInventaris.detailInventarisKomputer.Kebun);
            this.checkcbxBagian(controllerInventaris.detailInventarisKomputer.KodeBagian);
            this.checkcbxkategori(controllerInventaris.InventarisKomputer.KodeKategori);
            
            this.txtStatus.Text = controllerInventaris.InventarisKomputer.Status;
            txtKodeInventaris.Text = controllerInventaris.InventarisKomputer.KodeInventaris;
            //cbxKodeBagian.Text = controllerInventaris.detailInventarisKomputer.KodeBagian;
            //cbxKodeKategori.Text = controllerInventaris.InventarisKomputer.KodeKategori;
            //cbxKodeKebun.Text = controllerInventaris.InventarisKomputer.KodeKebun;
            
            DtpTanggalBeli.Value = Convert.ToDateTime(controllerInventaris.InventarisKomputer.TglBeli);
            txtNoPO.Text = controllerInventaris.InventarisKomputer.NoPO;
            txtPengguna.Text = controllerInventaris.detailInventarisKomputer.Pengguna;
            txtNamaBarang.Text = controllerInventaris.InventarisKomputer.NamaBarang;
            
            txtKebutuhan.Text = controllerInventaris.detailInventarisKomputer.Kebutuhan;
            txtKeterangan.Text = controllerInventaris.detailInventarisKomputer.Keterangan;
            txtMac1.Text = controllerInventaris.detailInventarisKomputer.MacAddress1;
            txtMac2.Text = controllerInventaris.detailInventarisKomputer.MacAddress2;
            txtMac3.Text = controllerInventaris.detailInventarisKomputer.MacAddress3;
            txtIP1.Text = controllerInventaris.detailInventarisKomputer.IP1;
            txtIP2.Text = controllerInventaris.detailInventarisKomputer.IP2;
            txtIP3.Text = controllerInventaris.detailInventarisKomputer.IP3;
            txtKodeInvLama.Text = controllerInventaris.InventarisKomputer.KodeInvLama;
            chkAktif.Checked = Convert.ToBoolean(controllerInventaris.InventarisKomputer.Aktif);
        }

        public void setCopyCondition()
        {
            this.controllerInventaris.InventarisKomputer = this.controllerInventaris.getOneRecordInventaris(KodeInventaris);
            this.controllerInventaris.detailInventarisKomputer = this.controllerInventaris.getOneRecordDetailInventaris(KodeInventaris);
            
            
            cbxKodeKategori.Enabled = true;
            cbxKodeBagian.Enabled = true;
            cbxKodeKebun.Enabled = true;
            cbxKodePT.Text = controllerInventaris.InventarisKomputer.KodePT;
            cbxKodePT.Enabled = false;
            txtKeteranganAfkir.Text = controllerInventaris.InventarisKomputer.KeteranganAfkir;
            ArrSpesifikasi = this.controllerInventaris.detailInventarisKomputer.Spesifikasi.Split('~');
            foreach (string x in ArrSpesifikasi)
            {
                DataGridViewRow newrow = (DataGridViewRow)DgvForSpesifikasi.Rows[0].Clone();
                newrow.Cells[0].Value = x;
                DgvForSpesifikasi.Rows.Add(newrow);
            }
            this.checkcbxKebun(controllerInventaris.detailInventarisKomputer.Kebun);
            this.checkcbxBagian(controllerInventaris.detailInventarisKomputer.KodeBagian);
            this.checkcbxkategori(controllerInventaris.InventarisKomputer.KodeKategori);

            this.txtStatus.Text = controllerInventaris.InventarisKomputer.Status;
            /*xtKodeInventaris.Text = controllerInventaris.InventarisKomputer.KodeInventaris;*/
            //cbxKodeBagian.Text = controllerInventaris.detailInventarisKomputer.KodeBagian;
            //cbxKodeKategori.Text = controllerInventaris.InventarisKomputer.KodeKategori;
            //cbxKodeKebun.Text = controllerInventaris.InventarisKomputer.KodeKebun;

            DtpTanggalBeli.Value = Convert.ToDateTime(controllerInventaris.InventarisKomputer.TglBeli);
            txtNoPO.Text = controllerInventaris.InventarisKomputer.NoPO;
            txtPengguna.Text = controllerInventaris.detailInventarisKomputer.Pengguna;
            txtNamaBarang.Text = controllerInventaris.InventarisKomputer.NamaBarang;
            

            txtKebutuhan.Text = controllerInventaris.detailInventarisKomputer.Kebutuhan;
            txtKeterangan.Text = controllerInventaris.detailInventarisKomputer.Keterangan;
            txtMac1.Text = controllerInventaris.detailInventarisKomputer.MacAddress1;
            txtMac2.Text = controllerInventaris.detailInventarisKomputer.MacAddress2;
            txtMac3.Text = controllerInventaris.detailInventarisKomputer.MacAddress3;
            txtIP1.Text = controllerInventaris.detailInventarisKomputer.IP1;
            txtIP2.Text = controllerInventaris.detailInventarisKomputer.IP2;
            txtIP3.Text = controllerInventaris.detailInventarisKomputer.IP3;
            txtKodeInvLama.Text = controllerInventaris.InventarisKomputer.KodeInvLama;
            chkAktif.Checked = Convert.ToBoolean(controllerInventaris.InventarisKomputer.Aktif);
        }

        /// <summary>
        /// generate spesifikasi dari datagrid 
        /// </summary>
        public void generateSpecifikasi()
        {
            Spesifikasi = "";
            foreach (DataGridViewRow x in DgvForSpesifikasi.Rows)
            {
                if (x.Cells["ColumnSpesifikasi"].Value == null || x.Cells["ColumnSpesifikasi"].Value == "")
                {
                    continue;
                }
                else if (x.IsNewRow)
                {
                    break;
                }
                else if (x.IsNewRow == false && x.Cells["ColumnSpesifikasi"].Value != null || x.Cells["ColumnSpesifikasi"].Value != "")
                {
                    Spesifikasi += x.Cells["ColumnSpesifikasi"].Value.ToString() + "~";
                }

            }
        }

        #endregion

        #region Constructor

        public FormInputEditInventaris()
        {
            InitializeComponent();
        }

        public FormInputEditInventaris(DBConnectionClass objConnection)
        {
            InitializeComponent();
            this.controllerBagian = new ControllerBagian(objConnection);
            this.controllerKategori = new ControllerKategori(objConnection);
            this.controllerKebun = new ControllerKebun(objConnection);
            this.controllerInventaris= new ControllerInventaris(objConnection);
            this.setcbxKebun();
            //this.setcbxBagian();
            this.setcbxKategori();
            
        }

        public FormInputEditInventaris(DBConnectionClass objConnection, string KodeInventaris)
        {
            InitializeComponent();
            this.controllerBagian = new ControllerBagian(objConnection);
            this.controllerKategori = new ControllerKategori(objConnection);
            this.controllerKebun = new ControllerKebun(objConnection);
            this.controllerInventaris = new ControllerInventaris(objConnection);
            
            this.KodeInventaris = KodeInventaris;
            this.setcbxKebun();
            //this.setcbxBagian();
            this.setcbxKategori();
            
        }

        #endregion

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(chkAktif.Checked)
            {
                txtStatus.Text = "Aktif"; 
            }
            else if(!chkAktif.Checked)
            {
                txtStatus.Text = "";
            }
        }

        private void FormInputEditInventaris_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnAddorEdit_Click(object sender, EventArgs e)
        {
            if (txtKodeInventaris.Text == "")
            {
                MessageBox.Show("Data Inventaris Belum Diisi");
            }
            else
            {
                if(this.Tag.ToString().Equals("Tambah"))
                {
                    string tmp = controllerInventaris.controllerInventarisForCUD.checkBatas(Convert.ToString((cbxKodeBagian.SelectedItem as dynamic).Value), Convert.ToString((cbxKodeKategori.SelectedItem as dynamic).Value), Convert.ToString((cbxKodeKebun.SelectedItem as dynamic).Value));
                    if (tmp == "Lanjut" || tmp == "Batas Inventaris Belum Dibuat!")
                    {
                        this.generateSpecifikasi();
                        this.controllerInventaris.setInventaris(txtKodeInventaris.Text, Convert.ToString((cbxKodeKategori.SelectedItem as dynamic).Value), Convert.ToString((cbxKodeKebun.SelectedItem as dynamic).Value), chkAktif.Checked, txtNoPO.Text, DtpTanggalBeli.Value, txtNamaBarang.Text,txtStatus.Text, this.txtKodeInvLama.Text, cbxKodePT.Text, txtKeteranganAfkir.Text);
                        this.controllerInventaris.setDetailInventaris(txtKodeInventaris.Text, DateTime.Now, Convert.ToString((cbxKodeKebun.SelectedItem as dynamic).Value), Convert.ToString((cbxKodeBagian.SelectedItem as dynamic).Value), txtPengguna.Text, Spesifikasi, txtKebutuhan.Text, txtKeterangan.Text, txtMac1.Text, txtMac2.Text, txtMac3.Text, txtIP1.Text, txtIP2.Text, txtIP3.Text, ControllerStaticVariables.controllerUser.user.UserID);

                        try
                        {
                            controllerInventaris.controllerInventarisForCUD.Insert(controllerInventaris.InventarisKomputer, controllerInventaris.detailInventarisKomputer);
                            MessageBox.Show("Data Inventaris Komputer dan Detail Inventaris Komputer Berhasil Ditambah");
                            if (tmp == "Batas Inventaris Belum Dibuat!")
                            {
                                MessageBox.Show("Data Batas Inventaris Belum diInput");
                            }
                            this.Close();
                        }

                        catch (Exception err)
                        {
                            MessageBox.Show(err.Message);
                        }
                    }
                    
                    else if (tmp == "Melebihi Jumlah Max")
                    {
                        MessageBox.Show("Inventaris Melebihi Jumlah Max");
                    }
                } 
                else if (this.Tag.ToString().Equals("Ubah"))
                {
                    this.generateSpecifikasi();
                    this.controllerInventaris.setInventaris(txtKodeInventaris.Text, Convert.ToString((cbxKodeKategori.SelectedItem as dynamic).Value), Convert.ToString((cbxKodeKebun.SelectedItem as dynamic).Value), chkAktif.Checked, txtNoPO.Text, DtpTanggalBeli.Value, txtNamaBarang.Text,txtStatus.Text,this.txtKodeInvLama.Text, cbxKodePT.Text, txtKeteranganAfkir.Text);
                    this.controllerInventaris.setDetailInventaris(txtKodeInventaris.Text, DateTime.Now, Convert.ToString((cbxKodeKebun.SelectedItem as dynamic).Value), Convert.ToString((cbxKodeBagian.SelectedItem as dynamic).Value), txtPengguna.Text, Spesifikasi, txtKebutuhan.Text, txtKeterangan.Text, txtMac1.Text, txtMac2.Text, txtMac3.Text, txtIP1.Text, txtIP2.Text, txtIP3.Text, ControllerStaticVariables.controllerUser.user.UserID);

                    try
                    {
                        controllerInventaris.controllerInventarisForCUD.Update(controllerInventaris.InventarisKomputer, controllerInventaris.detailInventarisKomputer);
                        MessageBox.Show("Data Inventaris Komputer " +
                            "dan Detail Inventaris Komputer Berhasil DiUbah");
                        this.Close();
                    }

                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }
                }
            }
        }

            

        private void CbxKodeKebun_SelectedIndexChanged(object sender, EventArgs e)
        {
            ControllerStaticVariables.StatusKebun = Convert.ToString((cbxKodeKebun.SelectedItem as dynamic).Status);
            cbxKodeBagian.Items.Clear();
            this.setcbxBagian();
        }

        private void CbxKodeKategori_SelectedIndexChanged(object sender, EventArgs e) { 
            string tmp = DateTime.Now.ToString("yy");
            string count = controllerInventaris.controllerInventarisForCUD.hitungIndex(cbxKodePT.Text ,Convert.ToString((cbxKodeKategori.SelectedItem as dynamic).Value), Convert.ToInt32(tmp));
            txtKodeInventaris.Text = count;
        }

        private void cbxKodeBagian_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
