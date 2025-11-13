using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using SupportIT.Data;              // your EF context
using SupportIT.Model;            // TblSuratPerbaikan, TblDetailSuratPerbaikan
using SupportIT.Services;          // SuratPerbaikanService, InventarisKomputerService
using Master.Controller;            // ControllerStaticVariables for current user


namespace SupportIT.View.Inventaris
{
    public partial class FrmSuratPerbaikanEdit : Form
    {
        private DBMISPEUKDContext _db;
        private SuratPerbaikanService _suratSvc;
        private InventarisKomputerService _inventarisSvc;
        private BindingList<TblDetailSuratPerbaikan> _details;

        // SPId will be null for "new" mode and non-null for "edit" mode.
        public int? SPId { get; set; }

        public FrmSuratPerbaikanEdit(int? spId = null)
        {
            InitializeComponent();
            SPId = spId;
        }

        public FrmSuratPerbaikanEdit()
        {
            InitializeComponent();
        }

        private void FrmSuratPerbaikanEdit_Load(object sender, EventArgs e)
        {
            _db = new DBMISPEUKDContext();
            _suratSvc = new SuratPerbaikanService(_db);
            _inventarisSvc = new InventarisKomputerService(_db);

            // Apply any style helpers you use in your project
            DataGridViewHelper.ApplyDefaultStyleThemed(dgvDetailSP, DataGridViewHelper.BlueCalmLight, true, false);
            ButtonHelper.Apply(btnSave, ButtonHelper.BlueCalmLight);
            ButtonHelper.Apply(btnCancel, ButtonHelper.BlueCalmLight);

            // Initialize status and KodePT lists
            cbStatus.Items.Clear();
            cbStatus.Items.AddRange(new object[] { "DRAFT", "DIKIRIM", "DIPROSES", "DITERIMA", "SELESAI" });
            cbStatus.SelectedIndex = 0;

            // Populate KodePT (this example pulls distinct values from the DB)
            cbKodePT.Items.AddRange(new object[] { "PEU", "APMR", "BMML", "MMMA", "SANR" });
            //cbKodePT.DataSource = _db.SuratPerbaikans.Select(x => x.KodePT).Distinct().ToList();
            cbKodePT.SelectedIndex = 0;

            // Determine whether we're creating new or editing existing data
            if (SPId.HasValue)
            {
                LoadExisting(SPId.Value);
            }
            else
            {
                CreateNew();
            }

            SetupDetailGridColumns();
            dgvDetailSP.DataSource = _details;

            // Register grid event handlers
            dgvDetailSP.UserDeletingRow += DgvDetailSP_UserDeletingRow;
            dgvDetailSP.CellDoubleClick += DgvDetailSP_CellDoubleClick;
            dgvDetailSP.CellEndEdit += DgvDetailSP_CellEndEdit;
        }

        private void CreateNew()
        {
            txtNoSP.ReadOnly = false;
            txtNoSP.Text = GenerateNewNoSP();  // implement a numbering scheme or call a stored procedure
            txtNoSP.ReadOnly = true;

            dtpTglSP.Value = DateTime.Now;
            txtKepada.Clear();
            txtLokasi.Clear();
            cbStatus.SelectedItem = "DRAFT";
            cbKodePT.SelectedIndex = 0;

            // Set PIC (read-only textBox1) to current user
            textBox1.Text = ControllerStaticVariables.controllerUser.user.UserID;

            _details = new BindingList<TblDetailSuratPerbaikan>();
        }

        /// <summary>
        /// Generates a new NoSP in the format "SP-YY.NNNN", where YY is the last two
        /// digits of the current year and NNNN is a zero‑padded sequence number
        /// (starting from 0001) for that year.
        /// </summary>
        private string GenerateNewNoSP()
        {
            // Get the last two digits of the current year (e.g., "25" for 2025).
            string yearPart = DateTime.Now.ToString("yy");

            // Build the prefix (e.g., "SP-25.").
            string prefix = "SP-" + yearPart + ".";

            // Retrieve all existing NoSP values that start with this prefix.
            var existingNumbers = _db.SuratPerbaikans
                                     .Where(sp => sp.NoSP.StartsWith(prefix))
                                     .Select(sp => sp.NoSP)
                                     .ToList();

            // Determine the highest sequence number already in use.
            int maxSequence = 0;
            foreach (string no in existingNumbers)
            {
                if (no.Length > prefix.Length)
                {
                    string seqString = no.Substring(prefix.Length);
                    int seq;
                    if (int.TryParse(seqString, out seq))
                    {
                        if (seq > maxSequence)
                        {
                            maxSequence = seq;
                        }
                    }
                }
            }

            // The new sequence number is the highest found plus one.
            int newSequence = maxSequence + 1;

            // Return the new NoSP, zero‑padding the sequence to 4 digits.
            return prefix + newSequence.ToString("D4");
        }



        private void LoadExisting(int spId)
        {
            var header = _db.SuratPerbaikans.FirstOrDefault(x => x.SPId == spId);
            if (header == null)
            {
                MessageBox.Show("Data not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            txtNoSP.Text = header.NoSP;
            txtNoSP.ReadOnly = true;
            dtpTglSP.Value = header.TglSP;
            txtKepada.Text = header.Kepada;
            txtLokasi.Text = header.Lokasi;
            cbStatus.SelectedItem = header.Status;
            cbKodePT.SelectedItem = header.KodePT;
            textBox1.Text = header.PIC;

            var list = _suratSvc.GetDetails(spId);
            _details = new BindingList<TblDetailSuratPerbaikan>(list);
        }

        private void SetupDetailGridColumns()
        {
            dgvDetailSP.Columns.Clear();
            dgvDetailSP.AutoGenerateColumns = false;
            dgvDetailSP.AllowUserToAddRows = true;
            dgvDetailSP.AllowUserToDeleteRows = true;
            dgvDetailSP.EditMode = DataGridViewEditMode.EditOnEnter;

            // NoUrut (read-only)
            var colNoUrut = new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(TblDetailSuratPerbaikan.NoUrut),
                HeaderText = "No.",
                Width = 50,
                ReadOnly = true
            };
            dgvDetailSP.Columns.Add(colNoUrut);

            // KodeInventaris
            var colKode = new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(TblDetailSuratPerbaikan.KodeInventaris),
                HeaderText = "Kode Inventaris",
                Width = 120
            };
            dgvDetailSP.Columns.Add(colKode);

            // NamaBarang
            var colNama = new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(TblDetailSuratPerbaikan.NamaBarang),
                HeaderText = "Nama Barang",
                Width = 200
            };
            dgvDetailSP.Columns.Add(colNama);

            // Jumlah
            var colJumlah = new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(TblDetailSuratPerbaikan.Jumlah),
                HeaderText = "Jumlah",
                Width = 80
            };
            dgvDetailSP.Columns.Add(colJumlah);

            // Satuan
            var colSatuan = new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(TblDetailSuratPerbaikan.Satuan),
                HeaderText = "Satuan",
                Width = 80
            };
            dgvDetailSP.Columns.Add(colSatuan);

            // Keterangan
            var colKet = new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(TblDetailSuratPerbaikan.Keterangan),
                HeaderText = "Keterangan",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };
            dgvDetailSP.Columns.Add(colKet);
        }

        private void DgvDetailSP_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Only handle double-clicks on the KodeInventaris column
            var colName = dgvDetailSP.Columns[e.ColumnIndex].DataPropertyName;
            if (colName != nameof(TblDetailSuratPerbaikan.KodeInventaris)) return;

            using (var frm = new FrmPilihInventaris())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    var selected = frm.SelectedInventaris;
                    var row = dgvDetailSP.Rows[e.RowIndex];
                    row.Cells[nameof(TblDetailSuratPerbaikan.KodeInventaris)].Value = selected.KodeInventaris;
                    row.Cells[nameof(TblDetailSuratPerbaikan.NamaBarang)].Value = selected.NamaBarang;
                    // If you store Satuan in inventory, set it here:
                    // row.Cells[nameof(TblDetailSuratPerbaikan.Satuan)].Value = selected.Satuan;
                }
            }
        }

        private void DgvDetailSP_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var colName = dgvDetailSP.Columns[e.ColumnIndex].DataPropertyName;
            if (colName == nameof(TblDetailSuratPerbaikan.KodeInventaris))
            {
                var row = dgvDetailSP.Rows[e.RowIndex];
                var kode = row.Cells[e.ColumnIndex].Value?.ToString();
                if (!string.IsNullOrWhiteSpace(kode))
                {
                    var item = _inventarisSvc.FindByKode(kode);
                    if (item != null)
                    {
                        row.Cells[nameof(TblDetailSuratPerbaikan.NamaBarang)].Value = item.NamaBarang;
                    }
                }
            }
        }

        private void DgvDetailSP_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            BeginInvoke((Action)(() => ReindexDetailRows()));
        }

        private void ReindexDetailRows()
        {
            for (int i = 0; i < _details.Count; i++)
            {
                _details[i].NoUrut = i + 1;
            }
            dgvDetailSP.Refresh();
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtNoSP.Text))
            {
                MessageBox.Show("NoSP must be filled.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtKepada.Text))
            {
                MessageBox.Show("Kepada must be filled.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtLokasi.Text))
            {
                MessageBox.Show("Lokasi must be filled.");
                return false;
            }
            foreach (var d in _details)
            {
                if (d.Jumlah <= 0)
                {
                    MessageBox.Show("Jumlah must be greater than zero.");
                    return false;
                }
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            // Re-index detail rows before saving
            ReindexDetailRows();

            using (var tran = _db.Database.BeginTransaction())
            {
                try
                {
                    bool isNew = !SPId.HasValue;
                    TblSuratPerbaikan header;

                    if (isNew)
                    {
                        header = new TblSuratPerbaikan
                        {
                            CreatedAt = DateTime.UtcNow,
                            CreatedBy = ControllerStaticVariables.controllerUser.user.UserID
                        };
                        _db.SuratPerbaikans.Add(header);
                    }
                    else
                    {
                        header = _db.SuratPerbaikans.First(x => x.SPId == SPId.Value);
                    }

                    // Save header fields
                    header.NoSP = txtNoSP.Text.Trim();
                    header.TglSP = dtpTglSP.Value;
                    header.Kepada = txtKepada.Text.Trim();
                    header.Lokasi = txtLokasi.Text.Trim();
                    header.Status = cbStatus.SelectedItem.ToString();
                    header.PIC = ControllerStaticVariables.controllerUser.user.UserID;
                    header.KodePT = cbKodePT.SelectedItem?.ToString();
                    header.UpdatedAt = DateTime.UtcNow;
                    header.UpdatedBy = ControllerStaticVariables.controllerUser.user.UserID;

                    // Persist header and get SPId
                    _db.SaveChanges();
                    SPId = header.SPId;

                    // Remove existing details if editing
                    if (!isNew)
                    {
                        var existingDetails = _db.DetailSuratPerbaikans.Where(d => d.SPId == SPId.Value).ToList();
                        _db.DetailSuratPerbaikans.RemoveRange(existingDetails);
                    }

                    // Add detail rows
                    foreach (var row in _details)
                    {
                        var det = new TblDetailSuratPerbaikan
                        {
                            SPId = header.SPId,
                            NoUrut = row.NoUrut,
                            KodeInventaris = row.KodeInventaris,
                            NamaBarang = row.NamaBarang,
                            Jumlah = row.Jumlah,
                            Satuan = row.Satuan,
                            Keterangan = row.Keterangan,
                            CreatedAt = DateTime.UtcNow,
                            CreatedBy = ControllerStaticVariables.controllerUser.user.UserID,
                            UpdatedAt = DateTime.UtcNow,
                            UpdatedBy = ControllerStaticVariables.controllerUser.user.UserID
                        };
                        _db.DetailSuratPerbaikans.Add(det);
                    }

                    // Write log
                    if (isNew)
                    {
                        _db.SuratPerbaikanLogs.Add(new TblSuratPerbaikanLog
                        {
                            SPId = header.SPId,
                            EventType = "CREATED",
                            EventAt = DateTime.UtcNow,
                            EventBy = ControllerStaticVariables.controllerUser.user.UserID
                        });
                    }
                    else if (header.Status != cbStatus.SelectedItem.ToString())
                    {
                        _db.SuratPerbaikanLogs.Add(new TblSuratPerbaikanLog
                        {
                            SPId = header.SPId,
                            EventType = "STATUS_CHANGED",
                            EventAt = DateTime.UtcNow,
                            EventBy = ControllerStaticVariables.controllerUser.user.UserID,
                            Note = $"From {header.Status} to {cbStatus.SelectedItem}"
                        });
                    }

                    _db.SaveChanges();
                    tran.Commit();

                    MessageBox.Show("Data saved successfully.");
                    DialogResult = DialogResult.OK;
                    Close();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show("Error saving data: " + ex.Message);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }



    }
}
