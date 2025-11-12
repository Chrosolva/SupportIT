using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Master.Controller;
using Master.Master;
using SupportIT.Controller;
using Inventaris.Controller;

namespace SupportIT.View.Perbaikan
{
    public partial class FormInputEditSuratPengantar : Form
    {
        #region properties

        public string query;
        public ControllerSP controllerSP = new ControllerSP();

        #endregion

        #region function

        private void getBagian()
        {
            if (ControllerStaticVariables.DataBase == "DBMISPEUKD")
            {
                cbxBagian.Text = "II.11";
                cbxBagian.Enabled = false;
            }
        }

        private string getNextIDSP()
        {
            query = "Select Count(NoSP) from TblSuratPengantar ";
            if (Convert.ToInt32(ControllerStaticVariables.objConnection.objsqlconnection.ExecuteScalar(query)) == 0)
            {
                return "SP." + ControllerStaticVariables.tahun.ToString().Substring(2, 2) + "-" + 1.ToString("D3");
            }
            else
            {
                query = "Select top 1 NoSP from TblSuratPengantar order by NoSP desc";
                ControllerStaticVariables.NoSP = ControllerStaticVariables.objConnection.objsqlconnection.ExecuteScalar(query);
                int tmp = Convert.ToInt32(ControllerStaticVariables.NoSP.Substring(6, 3));
                return "SP." + ControllerStaticVariables.tahun.ToString().Substring(2, 2) + "-" + (tmp + 1).ToString("D3");
            }
        }

        

        #endregion

        public FormInputEditSuratPengantar()
        {
            InitializeComponent();
        }

        private void FormInputEditSuratPengantar_Load(object sender, EventArgs e)
        {
            DgvDetSP.Columns["Keterangan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.getBagian();
            txtNoSP.Text = this.getNextIDSP();
            DgvDetSP.Rows[0].Cells["Uraian"].Value = " ";
            DgvDetSP.Rows[0].Cells["Jumlah"].Value = "0";
            DgvDetSP.Rows[0].Cells["Satuan"].Value = "UNIT";
            DgvDetSP.Rows[0].Cells["Keterangan"].Value = " ";
        }

        private void BtnAddEdit_Click(object sender, EventArgs e)
        {
            if(this.Tag.ToString() == "Tambah")
            {
                bool next = true;
                foreach(DataGridViewRow row in DgvDetSP.Rows)
                {
                    if (row.IsNewRow)
                    {
                        break;
                    }
                    else if(Convert.ToString(row.Cells["NoUrut"].Value) == string.Empty)
                    {
                        next = false;
                        break;
                    }
                }
                if(!next)
                {
                   MessageBox.Show("NoUrut Kosong");
                }
                else
                {
                    try
                    {
                        controllerSP.SetSuratPengantar(txtNoSP.Text, dateTimePicker1.Value, cbxBagian.Text, txtKepada.Text ?? " ", txtLokasi.Text ?? " ");

                        foreach (DataGridViewRow row in DgvDetSP.Rows)
                        {
                            if(row.IsNewRow)
                            {
                                break; 
                            }
                            else
                            {
                                controllerSP.SetDetailSuratPengantar(txtNoSP.Text, Convert.ToInt32(row.Cells["NoUrut"].Value), row.Cells["KodeInventaris"].Value.ToString() ?? " ", row.Cells["Uraian"].Value.ToString() ?? " ", Convert.ToInt32(row.Cells["Jumlah"].Value.ToString()), row.Cells["Satuan"].Value.ToString() ?? "UNIT", row.Cells["Keterangan"].Value.ToString() ?? " ");
                            }
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    try
                    {
                        controllerSP.TambahSuratPengantar(controllerSP.SP);
                        controllerSP.TambahDetailSuratPengantar(controllerSP.listDetSP);
                        MessageBox.Show("Data Surat Pengantar berhasil ditambah");
                        this.Close();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, " Data Gagal untuk ditambah");
                        //controllerSP.DeleteSuratPengantar(txtNoSP.Text);
                    }
                }
            }
        }

        private void DgvDetSP_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            DgvDetSP.Rows[e.RowIndex].Cells["Uraian"].Value = " ";
            DgvDetSP.Rows[e.RowIndex].Cells["Jumlah"].Value = "0";
            DgvDetSP.Rows[e.RowIndex].Cells["Satuan"].Value = "UNIT";
            DgvDetSP.Rows[e.RowIndex].Cells["Keterangan"].Value = " ";
        }
    }
}
