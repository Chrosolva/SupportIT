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
using SupportIT.Model;
using SupportIT.View.Inventaris;
using SupportIT.View;
using Master.Controller;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using QRCoder;

namespace SupportIT.View
{
    public partial class FormTabelInventaris : Form
    {
        #region properties

        public ControllerInventaris controllerInventaris;
        public ControllerKategori controllerKategori;
        public System.Data.DataTable dt;
        public ControllerKebun controllerKebun;
        public List<string> listKodeInv = new List<string>();
        public int NoOfKodeInv;
        public int RowCount = 0;

        #endregion

        #region private function 
        public void setCbxKodeKategori()
        {
            dt = controllerKategori.getAllKategori();
            cbxKodeKategori.DisplayMember = "Text";
            cbxKodeKategori.ValueMember = "Value";

            foreach (DataRow x in dt.Rows)
            {
                cbxKodeKategori.Items.Add(new { Text = x["NamaKategori"].ToString(), Value = x["KodeKategori"].ToString() });
            }
        }

        public void setcbxKebun()
        {
            dt = controllerKebun.getAllKebun();
            cbxKodeKebun.DisplayMember = "Text";
            cbxKodeKebun.ValueMember = "Value";
            foreach (DataRow x in dt.Rows)
            {
                cbxKodeKebun.Items.Add(new { Text = x["NamaKebun"].ToString(), Value = x["KodeKebun"].ToString() });
            }
        }
        #endregion

        #region Constructor

        public FormTabelInventaris()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor utk memparse connection class ke controller inventaris
        /// </summary>
        /// <param name="objConnection"></param>
        public FormTabelInventaris(DBConnectionClass objConnection)
        {
            InitializeComponent();
            this.controllerInventaris = new ControllerInventaris(objConnection);
            this.controllerKategori = new ControllerKategori(ControllerStaticVariables.objConnection);
            this.controllerKebun = new ControllerKebun(ControllerStaticVariables.objConnection);
        }


        #endregion

        private void FormTabelInventaris_Load(object sender, EventArgs e)
        {
            groupBoxInventaris.Text = "Inventaris - Row Count = " + RowCount;
            cbxStatus.SelectedIndex = 0;
            cbxKodeKategori.SelectedIndex = 0;
            
            
            cbxKodeKebun.SelectedIndex = 0;
            NUDTahun.Value = Convert.ToDecimal(ControllerStaticVariables.tahun);
            btnHapus.Enabled = ControllerStaticVariables.controllerUser.user.admin;
            //DgvForInventaris.DataSource = controllerInventaris.getAllInventarisKomputer();
            this.btnFilter_Click(sender, e);

            /// Need to 
            //DgvForInventaris.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            //DgvForInventaris.Columns[5].DefaultCellStyle.Format = "MM/dd/yyyy";
            //DgvForInventaris.Columns[0].ReadOnly = false;
            //DgvForInventaris.Columns[0].Width = 30;

            //DgvForInventaris.Columns[3].Visible = false;

            /////Need to
            //for(int i =1;i< DgvForInventaris.Columns.Count;i++)
            //{
            //    DgvForInventaris.Columns[i].ReadOnly = true;
            //}
            DgvForInventaris.OptionsSelection.MultiSelect = true;
            DgvForInventaris.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            DgvForInventaris.OptionsView.ColumnAutoWidth = false;
            DgvForInventaris.BestFitColumns();
            DgvForInventaris.Columns["KodeInventaris"].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            setcbxKebun();
            setCbxKodeKategori();
            
            cbxSearch.SelectedIndex = 0;

        }

        private void DgvForInventaris_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DgvForInventaris_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void BtnHistory_Click(object sender, EventArgs e)
        {
            FormHistoryInventaris formHistoryInventaris = new FormHistoryInventaris(controllerInventaris.getAllHistoryDetailInventaris(DgvForInventaris.GetFocusedDataRow()["KodeInventaris"].ToString()));
            formHistoryInventaris.ShowDialog();
            
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            FormInputEditInventaris formInputEditInventaris = new FormInputEditInventaris(this.controllerInventaris.objConnection);
            formInputEditInventaris.Tag = "Tambah";
            formInputEditInventaris.setButtonText(formInputEditInventaris.Tag.ToString());
            formInputEditInventaris.cbxKodePT.SelectedIndex = 0;
            formInputEditInventaris.ShowDialog();
            if ( this.chkAllYear.Checked)
            {
                GCInv.DataSource = controllerInventaris.getAllInventarisKomputerV2();
            }
            else
            {
                GCInv.DataSource = controllerInventaris.getAllInventarisKomputer();
            }
            DgvForInventaris.Columns[5].DisplayFormat.FormatString = "MM/dd/yyyy";
            RowCount = DgvForInventaris.RowCount;
            groupBoxInventaris.Text = "Inventaris - Row Count = " + RowCount;
        }   

        private void GroupBoxInventaris_Enter(object sender, EventArgs e)
        {
            
        }

        private void BtnUbah_Click(object sender, EventArgs e)
        {
            if(DgvForInventaris.RowCount !=0 )
            {
                FormInputEditInventaris formInputEditInventaris = new FormInputEditInventaris(this.controllerInventaris.objConnection, DgvForInventaris.GetFocusedDataRow()["KodeInventaris"].ToString());
                formInputEditInventaris.Tag = "Ubah";
                formInputEditInventaris.setButtonText(formInputEditInventaris.Tag.ToString());
                formInputEditInventaris.setEditCondition();
                formInputEditInventaris.ShowDialog();
                if (this.chkAllYear.Checked)
                {
                    GCInv.DataSource = controllerInventaris.getAllInventarisKomputerV2();
                }
                else
                {
                    GCInv.DataSource = controllerInventaris.getAllInventarisKomputer();
                }
                DgvForInventaris.Columns[5].DisplayFormat.FormatString = "MM/dd/yyyy";
                RowCount = DgvForInventaris.RowCount;
                groupBoxInventaris.Text = "Inventaris - Row Count = " + RowCount;
            }
        }

        private void DgvForInventaris_SelectionChanged(object sender, EventArgs e)
        {
            btnUbah.Enabled = true;
            btnHistory.Enabled = true;
            
        }

        private void DgvForInventaris_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvForInventaris.RowCount != 0)
            {
                this.DgvForInventaris_SelectionChanged(sender, e);
            }
            
        }

        private void BtnImport_Click(object sender, EventArgs e)
        {
            FormImport formImport = new FormImport(controllerInventaris.objConnection);
            formImport.ShowDialog();
        }

        private void DgvForInventaris_SelectionChanged_1(object sender, EventArgs e)
        {
            if (DgvForInventaris.RowCount != 0)
            {
                this.DgvForInventaris_SelectionChanged(sender, e);
            }
        }

        private void tstButtonCetak_Click(object sender, EventArgs e)
        {
            listKodeInv = new List<string>();
            //DgvForInventaris.EndEdit();
            for (int j = 0; j < DgvForInventaris.RowCount; j++)
            {

                //DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)DgvForInventaris.Rows[j].Cells[0];
                //chk.TrueValue = true;
                //if (Convert.ToBoolean(chk.Value))
                //{
                //    listKodeInv.Add(DgvForInventaris.Rows[j].Cells[1].Value.ToString());
                //}
                if(this.DgvForInventaris.IsRowSelected(j))
                {
                    var tmp = DgvForInventaris.GetRowCellValue(j,"KodeInventaris");
                    var tmpp = tmp; 
                    listKodeInv.Add(DgvForInventaris.GetRowCellValue(j, "KodeInventaris").ToString());
                }
            }
            if (listKodeInv.Count == 0)
            {
                MessageBox.Show("Pilih minimal 1 item");
            }
            else
            {
                FormPrint formPrint;
                formPrint = new FormPrint(listKodeInv);
                formPrint.Tag = "Inventaris";
                formPrint.MdiParent = this.MdiParent;
                formPrint.Show();
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (this.chkAllYear.Checked)
            {
                GCInv.DataSource = controllerInventaris.getAllInventarisKomputerV2();
            }
            else
            {
                GCInv.DataSource = controllerInventaris.getAllInventarisKomputer();
            }
            RowCount = DgvForInventaris.RowCount;
            groupBoxInventaris.Text = "Inventaris - Row Count = " + RowCount;
        }

        private void cbxKodeKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxKodeKategori.SelectedIndex !=0)
            {
                btnFilter_Click(sender, e);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Apakah anda yakin ingin menghapus dokumen Inventaris dengan Kode " + this.DgvForInventaris.GetFocusedDataRow()[1].ToString() + " ? ", " Warning ", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if(this.controllerInventaris.controllerInventarisForCUD.DeleteInventaris(this.DgvForInventaris.GetFocusedDataRow()[0].ToString()))
                {
                    MessageBox.Show("Data Inventaris berhasil dihapus");
                }   
                else
                {
                    MessageBox.Show("Data Inventaris Tidak berhasil dihapus");
                }
                if (this.chkAllYear.Checked)
                {
                    GCInv.DataSource = controllerInventaris.getAllInventarisKomputerV2();
                }
                else
                {
                    GCInv.DataSource = controllerInventaris.getAllInventarisKomputer();
                }
                RowCount = DgvForInventaris.RowCount;
                groupBoxInventaris.Text = "Inventaris - Row Count = " + RowCount;
            }
            else if (dialogResult == DialogResult.No) { }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string Parm1 = "";
            string Parm2 = "";
            string Parm3 = "";
            if(cbxKodeKategori.SelectedIndex == 0)
            {
                Parm1 = "%";
            }
            else
            {
                Parm1 = (cbxKodeKategori.SelectedItem as dynamic).Value;
            }
            if(cbxKodeKebun.SelectedIndex == 0)
            {
                Parm2 = "%";
            }
            else
            {
                Parm2 = (cbxKodeKebun.SelectedItem as dynamic).Value;
            }
            if(cbxStatus.SelectedIndex == 0)
            {
                Parm3 = "%";
            }
            else
            {
                Parm3 = cbxStatus.SelectedItem.ToString();
            }
            if(chkAllYear.Checked == true)
            {
                GCInv.DataSource = controllerInventaris.getAllInventarisWith2Parm(Parm1, Parm2, Parm3).Tables["Master.TblInventarisKomputer"];
            }
            else
            {
                GCInv.DataSource = controllerInventaris.getAllInventarisWith2ParmV2(Parm1, Parm2, Parm3).Tables["Master.TblInventarisKomputer"];
            }
            RowCount = DgvForInventaris.RowCount;
            groupBoxInventaris.Text = "Inventaris - Row Count = " + RowCount;
        }

        private void cbxKodeKebun_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            btnFilter_Click(sender, e);
           
        }

        private void NUDTahun_ValueChanged(object sender, EventArgs e)
        {
            ControllerStaticVariables.tahun = Convert.ToInt32(NUDTahun.Value);
            btnFilter_Click(sender, e);
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            string Parm1 = "";
            string Parm2 = "";
            string Parm3 = "";
            if (cbxKodeKategori.SelectedIndex == 0)
            {
                Parm1 = "%";
            }
            else
            {
                Parm1 = (cbxKodeKategori.SelectedItem as dynamic).Value;
            }
            if (cbxKodeKebun.SelectedIndex == 0)
            {
                Parm2 = "%";
            }
            else
            {
                Parm2 = (cbxKodeKebun.SelectedItem as dynamic).Value;
            }
            if (cbxStatus.SelectedIndex == 0)
            {
                Parm3 = "%";
            }
            else
            {
                Parm3 = cbxStatus.SelectedItem.ToString();
            }
            if (chkAllYear.Checked)
            {
                GCInv.DataSource = controllerInventaris.SearchInvntaris2(cbxSearch.SelectedItem.ToString(), txtSearch.Text, Parm1, Parm2, Parm3);
            }
            else
            {
                GCInv.DataSource = controllerInventaris.SearchInventaris(cbxSearch.SelectedItem.ToString(), txtSearch.Text, Parm1, Parm2, Parm3);
            }
            RowCount = DgvForInventaris.RowCount;
            groupBoxInventaris.Text = "Inventaris - Row Count = " + RowCount;
        }

        private void chkAllYear_CheckedChanged(object sender, EventArgs e)
        {
            if(chkAllYear.Checked == true)
            {
                NUDTahun.Enabled = false;
                GCInv.DataSource = controllerInventaris.getAllInventarisKomputerV2();
            }
            else if (chkAllYear.Checked == false)
            {
                NUDTahun.Enabled = true;
                GCInv.DataSource = controllerInventaris.getAllInventarisKomputer();
            }
            RowCount = DgvForInventaris.RowCount;
            groupBoxInventaris.Text = "Inventaris - Row Count = " + RowCount;
        }

        private void rdbAll_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rdbAktif_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            btnCari_Click(sender, e);
        }

        

        private void btnExport_Click(object sender, EventArgs e)
        {

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = "Inventory_Export.xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                //// Copy DataGridView results to clipboard
                //copyAlltoClipboard();

                //object misValue = System.Reflection.Missing.Value;
                //Excel.Application xlexcel = new Excel.Application();

                //xlexcel.DisplayAlerts = false; // Without this you will get two confirm overwrite prompts
                //Excel.Workbook xlWorkBook = xlexcel.Workbooks.Add(misValue);
                //Excel.Worksheet xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                //// Format column D as text before pasting results, this was required for my data
                //Excel.Range rng = xlWorkSheet.get_Range("D:D").Cells;
                //rng.NumberFormat = "@";

                //// Paste clipboard results to worksheet range
                //Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
                //CR.Select();
                //xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

                //// For some reason column A is always blank in the worksheet. ¯\_(ツ)_/¯
                //// Delete blank column A and select cell A1
                //Excel.Range delRng = xlWorkSheet.get_Range("A:A").Cells;
                //delRng.Delete(Type.Missing);
                //xlWorkSheet.get_Range("A1").Select();

                //// Save the excel file under the captured location from the SaveFileDialog
                //xlWorkBook.SaveAs(sfd.FileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                //xlexcel.DisplayAlerts = true;
                //xlWorkBook.Close(true, misValue, misValue);
                //xlexcel.Quit();

                //releaseObject(xlWorkSheet);
                //releaseObject(xlWorkBook);
                //releaseObject(xlexcel);

                //// Clear Clipboard and DataGridView selection
                //Clipboard.Clear();
                //DgvForInventaris.ClearSelection();

                GCInv.ExportToXls(sfd.FileName);

                // Open the newly saved excel file
                if (File.Exists(sfd.FileName))
                    System.Diagnostics.Process.Start(sfd.FileName);
            }
        }

        private void copyAlltoClipboard()
        {
            //DgvForInventaris.SelectAll();
            //DataObject dataObj = DgvForInventaris.GetClipboardContent();
            //if (dataObj != null)
            //    Clipboard.SetDataObject(dataObj);
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occurred while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void DgvForInventaris_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            this.DgvForInventaris_SelectionChanged_1(sender, e);
            if(DgvForInventaris.RowCount !=0 )
            {
                btnUbah.Enabled = true;
                btnHistory.Enabled = true;
            }
        }

        private void tstBarcode_Click(object sender, EventArgs e)
        {
            listKodeInv = new List<string>();
            List<byte[]> listQrCodes = new List<byte[]>();
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            for (int j = 0; j < DgvForInventaris.RowCount; j++)
            {
                if (this.DgvForInventaris.IsRowSelected(j))
                {
                    var kodeinv = DgvForInventaris.GetRowCellValue(j, "KodeInventaris");
                    var spesifikasi = DgvForInventaris.GetRowCellValue(j, "Spesifikasi");
                    var Keterangan = DgvForInventaris.GetRowCellValue(j, "Keterangan");
                    var Kebutuhan = DgvForInventaris.GetRowCellValue(j, "Kebutuhan");

                    //QRCodeData qrCodeData = qrGenerator.CreateQrCode(kodeinv + "\n" + spesifikasi + "\n" + Kebutuhan + "\n" + Keterangan, QRCodeGenerator.ECCLevel.Q);
                    QRCodeData qrCodeData = qrGenerator.CreateQrCode(kodeinv + "", QRCodeGenerator.ECCLevel.H);
                    QRCode qrCode = new QRCode(qrCodeData);
                    Bitmap qrCodeImage = qrCode.GetGraphic(7);
                    
                    ///// save to PC 
                    //qrCodeImage.Save("D:\\QRCodes\\" + this.DgvForInventaris.GetFocusedDataRow()["KodeInventaris"].ToString() + ".jpeg");
                    //MessageBox.Show("Save successfull");
                    byte[] yourByteArray;
                    using (var mStream = new System.IO.MemoryStream())
                    {
                        qrCodeImage.Save(mStream, System.Drawing.Imaging.ImageFormat.Bmp);
                        yourByteArray = mStream.ToArray();
                        listQrCodes.Add(yourByteArray);
                    }
                    listKodeInv.Add(DgvForInventaris.GetRowCellValue(j, "KodeInventaris").ToString());
                }
            }

            
            //listKodeInv.Add(this.DgvForInventaris.GetFocusedDataRow()["KodeInventaris"].ToString());

            FormPrint formPrint;
            formPrint = new FormPrint(listQrCodes, listKodeInv);
            formPrint.Tag = "InventarisQR";
            formPrint.MdiParent = this.MdiParent;
            formPrint.Show();



        }

        private void txtSearch_Click(object sender, EventArgs e)
        {

        }

        private void tsbCopy_Click(object sender, EventArgs e)
        {
            if (DgvForInventaris.RowCount != 0)
            {
                FormInputEditInventaris formInputEditInventaris = new FormInputEditInventaris(this.controllerInventaris.objConnection, DgvForInventaris.GetFocusedDataRow()["KodeInventaris"].ToString());
                formInputEditInventaris.Tag = "Tambah";
                formInputEditInventaris.setButtonText("Tambah");
                formInputEditInventaris.setCopyCondition();

                formInputEditInventaris.ShowDialog();
                if (this.chkAllYear.Checked)
                {
                    GCInv.DataSource = controllerInventaris.getAllInventarisKomputerV2();
                }
                else
                {
                    GCInv.DataSource = controllerInventaris.getAllInventarisKomputer();
                }
                DgvForInventaris.Columns[5].DisplayFormat.FormatString = "MM/dd/yyyy";
                RowCount = DgvForInventaris.RowCount;
                groupBoxInventaris.Text = "Inventaris - Row Count = " + RowCount;
            }
        }

        private void btnAfkir_Click(object sender, EventArgs e)
        {
            try
            {
                int jlh = 0;
                for (int j = 0; j < DgvForInventaris.RowCount; j++)
                {
                    var kodeinv = DgvForInventaris.GetRowCellValue(j, "KodeInventaris");
                    if (this.DgvForInventaris.IsRowSelected(j))
                    {
                        controllerInventaris.controllerInventarisForCUD.UpdateAfkir(kodeinv.ToString());
                        jlh++;
                    }
                    
                }
                MessageBox.Show("Afkir Inventaris Selesai sebanyak = " + jlh);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            btnFilter_Click(null, null);

        }
    }
}
