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
            DataGridViewHelper.ApplyDefaultStyleThemed(dgvDetailSP, DataGridViewHelper.BlueCalmLight, false, true);
            ButtonHelper.Apply(btnSave, ButtonHelper.BlueCalmLight);
            ButtonHelper.Apply(btnCancel, ButtonHelper.BlueCalmLight);
            ButtonHelper.Apply(btnAddRow, ButtonHelper.BlueCalmLight);
            ButtonHelper.Apply(btnDeleteRow, ButtonHelper.BlueCalmLight);
            SetupDetailGridBehavior();

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
                ReindexDetailRows();
                EnsureBlankLastRow();

            }
            else
            {
                CreateNew();
            }

            SetupDetailGridColumns();
            EnsureBlankLastRow();
            dgvDetailSP.DataSource = _details;

            // Register grid event handlers
            dgvDetailSP.UserDeletingRow += DgvDetailSP_UserDeletingRow;
            //dgvDetailSP.CellDoubleClick += DgvDetailSP_CellDoubleClick;
            dgvDetailSP.CellEndEdit += DgvDetailSP_CellEndEdit;
            // Register grid event handlers
            dgvDetailSP.UserDeletingRow += DgvDetailSP_UserDeletingRow;
            // dgvDetailSP.CellDoubleClick += DgvDetailSP_CellDoubleClick; // sudah tidak perlu
            dgvDetailSP.CellEndEdit += DgvDetailSP_CellEndEdit;
            dgvDetailSP.CellContentClick += DgvDetailSP_CellContentClick;
            dgvDetailSP.KeyDown += DgvDetailSP_KeyDown;
            dgvDetailSP.UserDeletingRow += DgvDetailSP_UserDeletingRow;

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
            textBox1.Text = ControllerStaticVariables.currentuser.UserID;

            _details = new BindingList<TblDetailSuratPerbaikan>();

            // Tambah satu baris kosong default
            //var det = new TblDetailSuratPerbaikan();
            //det.NoUrut = 1;
            //det.Jumlah = 1;
            //det.Satuan = "BH";
            //det.Keterangan = "";   // biar tidak perlu diisi dulu
            //_details.Add(det);
        }

        private void EnsureBlankLastRow()
        {
            if (_details == null)
                return;

            // 1) Hapus blank rows ekstra, sisakan maksimal 1 di paling bawah
            //    (blank = KodeInventaris, NamaBarang, Keterangan semua kosong)
            for (int i = _details.Count - 1; i >= 0; i--)
            {
                bool isBlank =
                    string.IsNullOrWhiteSpace(_details[i].KodeInventaris) &&
                    string.IsNullOrWhiteSpace(_details[i].NamaBarang) &&
                    string.IsNullOrWhiteSpace(_details[i].Keterangan);

                // kalau blank tapi bukan row terakhir, hapus
                if (isBlank && i != _details.Count - 1)
                {
                    _details.RemoveAt(i);
                }
            }

            // 2) Kalau tidak ada satupun row, buat satu row kosong default
            if (_details.Count == 0)
            {
                var det = new TblDetailSuratPerbaikan();
                det.NoUrut = 1;
                det.Jumlah = 1;
                det.Satuan = "BH";
                det.Keterangan = "";
                _details.Add(det);
                return;
            }

            // 3) Cek row terakhir saat ini: kalau SUDAH berisi, tambahkan satu blank row baru.
            var last = _details[_details.Count - 1];
            bool lastHasData =
                !string.IsNullOrWhiteSpace(last.KodeInventaris) ||
                !string.IsNullOrWhiteSpace(last.NamaBarang) ||
                !string.IsNullOrWhiteSpace(last.Keterangan);

            if (lastHasData)
            {
                var det = new TblDetailSuratPerbaikan();
                det.NoUrut = _details.Count + 1;
                det.Jumlah = 1;
                det.Satuan = "BH";
                det.Keterangan = "";
                _details.Add(det);
            }
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

        private void SetupDetailGridBehavior()
        {
            dgvDetailSP.ReadOnly = false;
            dgvDetailSP.AllowUserToAddRows = false;
            dgvDetailSP.AllowUserToDeleteRows = true;
            dgvDetailSP.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // ⬅️ full row
            dgvDetailSP.MultiSelect = false;
            dgvDetailSP.EditMode = DataGridViewEditMode.EditOnEnter;
            dgvDetailSP.RowHeadersVisible = true; // ensure row-header (leftmost) is visible
        }


        private void SetupDetailGridColumns()
        {
            dgvDetailSP.Columns.Clear();
            dgvDetailSP.AutoGenerateColumns = false;
            dgvDetailSP.AllowUserToAddRows = false;   // ⬅️ keep false here too
            dgvDetailSP.AllowUserToDeleteRows = true;
            dgvDetailSP.EditMode = DataGridViewEditMode.EditOnEnter;

            // NoUrut (read-only)
            var colNoUrut = new DataGridViewTextBoxColumn
            {
                Name = "NoUrut",
                DataPropertyName = "NoUrut",
                HeaderText = "No.",
                ReadOnly = true,
                Width = 40,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Resizable = DataGridViewTriState.False
            };
            dgvDetailSP.Columns.Add(colNoUrut);

            // KodeInventaris
            var colKode = new DataGridViewTextBoxColumn
            {
                Name = "KodeInventaris",
                DataPropertyName = "KodeInventaris",
                HeaderText = "Kode Inventaris",
                ReadOnly = false,
                Width = 140
            };
            dgvDetailSP.Columns.Add(colKode);

            // === Button pilih inventaris ===
            var colBtnPilih = new DataGridViewButtonColumn
            {
                Name = "PilihInventaris",
                HeaderText = "",
                Text = "...",
                UseColumnTextForButtonValue = true,
                Width = 40,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Resizable = DataGridViewTriState.False
            };
            dgvDetailSP.Columns.Add(colBtnPilih);

            // NamaBarang
            var colNama = new DataGridViewTextBoxColumn
            {
                Name = "NamaBarang",
                DataPropertyName = "NamaBarang",
                HeaderText = "Nama Barang",
                ReadOnly = false,
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

        private void DeleteCurrentDetailRow()
        {
            if (_details == null || _details.Count == 0)
                return;

            if (dgvDetailSP.CurrentRow == null)
                return;

            int index = dgvDetailSP.CurrentRow.Index;
            if (index < 0 || index >= _details.Count)
                return;

            // Jangan hapus satu-satunya baris kosong (helper row)
            bool onlyOne = _details.Count == 1;
            TblDetailSuratPerbaikan det = _details[index];

            bool isBlank =
                string.IsNullOrWhiteSpace(det.KodeInventaris) &&
                string.IsNullOrWhiteSpace(det.NamaBarang) &&
                string.IsNullOrWhiteSpace(det.Keterangan) &&
                det.Jumlah <= 0;

            if (onlyOne && isBlank)
                return;

            if (MessageBox.Show("Hapus baris yang dipilih?", "Konfirmasi",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            _details.RemoveAt(index);
            ReindexDetailRows();
            EnsureBlankLastRow();
            dgvDetailSP.Refresh();
        }


        private void DgvDetailSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var col = dgvDetailSP.Columns[e.ColumnIndex];
            if (col == null) return;
            if (col.Name != "PilihInventaris") return;   // only handle button column

            using (var frm = new FrmPilihInventaris())
            {
                if (frm.ShowDialog() == DialogResult.OK && frm.SelectedInventaris != null)
                {
                    var selected = frm.SelectedInventaris;

                    if (_details == null)
                        _details = new BindingList<TblDetailSuratPerbaikan>();

                    TblDetailSuratPerbaikan det;

                    // Pastikan index valid -> kalau user klik di baris di luar range, anggap last row
                    if (e.RowIndex >= 0 && e.RowIndex < _details.Count)
                    {
                        det = _details[e.RowIndex];
                    }
                    else
                    {
                        det = new TblDetailSuratPerbaikan();
                        det.NoUrut = _details.Count + 1;
                        det.Jumlah = 1;
                        det.Satuan = "BH";
                        det.Keterangan = "";
                        _details.Add(det);
                    }

                    // Isi data dari inventaris
                    det.KodeInventaris = selected.KodeInventaris;
                    det.NamaBarang = selected.NamaBarang;

                    if (det.Jumlah <= 0) det.Jumlah = 1;
                    if (string.IsNullOrEmpty(det.Satuan)) det.Satuan = "BH";
                    if (det.Keterangan == null) det.Keterangan = "";

                    ReindexDetailRows();
                    EnsureBlankLastRow();   // pastikan selalu ada baris kosong di bawahnya
                    dgvDetailSP.Refresh();
                }
            }
        }

        private void DgvDetailSP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DeleteCurrentDetailRow();
                e.Handled = true;
            }
        }


        //private void DgvDetailSP_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex < 0) return;

        //    // Only handle double-clicks on the KodeInventaris column
        //    var colName = dgvDetailSP.Columns[e.ColumnIndex].DataPropertyName;
        //    if (colName != nameof(TblDetailSuratPerbaikan.KodeInventaris)) return;

        //    using (var frm = new FrmPilihInventaris())
        //    {
        //        if (frm.ShowDialog() == DialogResult.OK)
        //        {
        //            var selected = frm.SelectedInventaris;
        //            var row = dgvDetailSP.Rows[e.RowIndex];
        //            row.Cells[nameof(TblDetailSuratPerbaikan.KodeInventaris)].Value = selected.KodeInventaris;
        //            row.Cells[nameof(TblDetailSuratPerbaikan.NamaBarang)].Value = selected.NamaBarang;
        //            // If you store Satuan in inventory, set it here:
        //            // row.Cells[nameof(TblDetailSuratPerbaikan.Satuan)].Value = selected.Satuan;
        //        }
        //    }
        //}

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
            e.Cancel = true;              // batalkan delete bawaan DGV
            dgvDetailSP.CurrentCell = e.Row.Cells[0];
            DeleteCurrentDetailRow();     // pakai logika kita sendiri
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
                    TblSuratPerbaikan originalHeader = null;

                    if (!isNew)
                    {
                        // Get a fresh copy from DB (detached)
                        originalHeader = _db.SuratPerbaikans
                                            .AsNoTracking()
                                            .First(x => x.SPId == SPId.Value);
                    }

                    if (isNew)
                    {
                        header = new TblSuratPerbaikan
                        {
                            CreatedAt = DateTime.Now,
                            CreatedBy = ControllerStaticVariables.currentuser.UserID
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
                    header.PIC = ControllerStaticVariables.currentuser.UserID;
                    header.KodePT = cbKodePT.SelectedItem?.ToString();
                    header.UpdatedAt = DateTime.Now;
                    header.UpdatedBy = ControllerStaticVariables.currentuser.UserID;

                    // Persist header and get SPId
                    _db.SaveChanges();
                    SPId = header.SPId;

                    // Remove existing details if editing
                    if (!isNew)
                    {
                        var existingDetails = _db.DetailSuratPerbaikans.Where(d => d.SPId == SPId.Value).ToList();
                        _db.DetailSuratPerbaikans.RemoveRange(existingDetails);

                        
                    }


                    // Add detail rows (skip helper blank row)
                    foreach (var row in _details)
                    {
                        // skip pure blank helper row
                        if (IsBlankDetailRow(row))
                            continue;

                        var det = new TblDetailSuratPerbaikan
                        {
                            SPId = header.SPId,
                            NoUrut = row.NoUrut,
                            KodeInventaris = row.KodeInventaris,
                            NamaBarang = row.NamaBarang,
                            Jumlah = row.Jumlah,
                            Satuan = row.Satuan,
                            Keterangan = row.Keterangan,
                            CreatedAt = DateTime.Now,
                            CreatedBy = ControllerStaticVariables.currentuser.UserID,
                            UpdatedAt = DateTime.Now,
                            UpdatedBy = ControllerStaticVariables.currentuser.UserID
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
                            EventBy = ControllerStaticVariables.currentuser.UserID
                    });
                    }
                    else if (!isNew && originalHeader != null)
                    {
                        LogChange("NoSP", originalHeader.NoSP, header.NoSP, header.SPId);
                        LogChange("TglSP", originalHeader.TglSP.ToString("yyyy-MM-dd HH:mm:ss"),
                                              header.TglSP.ToString("yyyy-MM-dd HH:mm:ss"), header.SPId);
                        LogChange("Kepada", originalHeader.Kepada, header.Kepada, header.SPId);
                        LogChange("Lokasi", originalHeader.Lokasi, header.Lokasi, header.SPId);
                        LogChange("Status", originalHeader.Status, header.Status, header.SPId);
                        LogChange("PIC", originalHeader.PIC, header.PIC, header.SPId);
                        LogChange("KodePT", originalHeader.KodePT, header.KodePT, header.SPId);
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

        public void LogChange(string fieldName, string oldValue, string newValue, int ID)
        {
            if (oldValue != newValue)
            {
                _db.SuratPerbaikanLogs.Add(new TblSuratPerbaikanLog
                {
                    SPId = ID,
                    EventType = "UPDATED",
                    EventAt = DateTime.UtcNow,
                    EventBy = ControllerStaticVariables.currentuser.UserID,
                    Note = $"{fieldName}: '{oldValue}' → '{newValue}'"
                });
            }
        }

        /// <summary>
        /// Returns true if this detail row is just the blank helper row
        /// and should NOT be saved.
        /// KodeInventaris may be null (for items without code),
        /// so we only treat as blank if ALL these are empty:
        /// - KodeInventaris
        /// - NamaBarang
        /// - Keterangan
        /// </summary>
        private bool IsBlankDetailRow(TblDetailSuratPerbaikan row)
        {
            if (row == null) return true;

            bool noKode = string.IsNullOrWhiteSpace(row.KodeInventaris);
            bool noNama = string.IsNullOrWhiteSpace(row.NamaBarang);
            bool noKet = string.IsNullOrWhiteSpace(row.Keterangan);

            // Jumlah and Satuan are ignored here because you default them (1, "BH")
            return noKode && noNama && noKet;
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAddRow_Click(object sender, EventArgs e)
        {
            EnsureBlankLastRow();
        }

        private void btnDeleteRow_Click(object sender, EventArgs e)
        {
            DeleteCurrentDetailRow();
        }
    }
}
