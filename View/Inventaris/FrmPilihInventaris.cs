using SupportIT.Data;
using SupportIT.Model;
using SupportIT.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupportIT.View.Inventaris
{
    public partial class FrmPilihInventaris : Form
    {
        private DBMISPEUKDContext _db;
        private InventarisKomputerService _invSvc;

        private System.Windows.Forms.Timer _searchTimer;

        public TblInventarisKomputer SelectedInventaris { get; private set; }

        public FrmPilihInventaris()
        {
            InitializeComponent();
        }

        private class CbItem
        {
            public string Code { get; set; }
            public string Name { get; set; }

            public string Display
            {
                get { return Code + " - " + Name; }
            }
        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _db = new DBMISPEUKDContext();
            _invSvc = new InventarisKomputerService(_db);

            // Populate filters from distinct values
            // Kategori = cbStatus (based on your designer)
            // ----- KATEGORI (cbKategori) -----
            var kategoriItems = new List<CbItem>();
            kategoriItems.Add(new CbItem { Code = "ALL", Name = "(Semua Kategori)" });

            var kategoriRows = _db.Set<Kategori>()
                                  .AsNoTracking()
                                  .OrderBy(x => x.KodeKategori)
                                  .ToList();

            foreach (var row in kategoriRows)
            {
                kategoriItems.Add(new CbItem
                {
                    Code = row.KodeKategori,
                    Name = row.NamaKategori
                });
            }

            cbKategori.DisplayMember = "Display";
            cbKategori.ValueMember = "Code";
            cbKategori.DataSource = kategoriItems;
            cbKategori.SelectedIndex = 0;

            // Kebun = cbPIC (based on your designer labels)
            // ----- KEBUN (cbKebun) -----
            var kebunItems = new List<CbItem>();
            kebunItems.Add(new CbItem { Code = "ALL", Name = "(Semua Kebun)" });

            var kebunRows = _db.Set<Kebun>()
                               .AsNoTracking()
                               .OrderBy(x => x.KodeKebun)
                               .ToList();

            foreach (var row in kebunRows)
            {
                kebunItems.Add(new CbItem
                {
                    Code = row.KodeKebun,
                    Name = row.NamaKebun
                });
            }

            cbKebun.DisplayMember = "Display";
            cbKebun.ValueMember = "Code";
            cbKebun.DataSource = kebunItems;
            cbKebun.SelectedIndex = 0;

            // KodePT filter on this form (if you have it)
            // Populate KodePT (this example pulls distinct values from the DB)
            var ptItems = new List<CbItem>();
            ptItems.Add(new CbItem { Code = "ALL", Name = "(Semua PT)" });
            ptItems.Add(new CbItem { Code = "PEU", Name = "PEU" });
            ptItems.Add(new CbItem { Code = "APMR", Name = "APMR" });
            ptItems.Add(new CbItem { Code = "BMML", Name = "BMML" });
            ptItems.Add(new CbItem { Code = "MMMA", Name = "MMMA" });
            ptItems.Add(new CbItem { Code = "SANR", Name = "SANR" });

            cbKodePT.DisplayMember = "Display";
            cbKodePT.ValueMember = "Code";
            cbKodePT.DataSource = ptItems;
            cbKodePT.SelectedIndex = 0;


            // Initialize grid columns (similar to SetupDetailGridColumns but simpler)
            dgvInventaris.AutoGenerateColumns = false;
            dgvInventaris.Columns.Clear();
            dgvInventaris.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(TblInventarisKomputer.KodeInventaris),
                HeaderText = "Kode Inventaris"
            });
            dgvInventaris.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(TblInventarisKomputer.KodeKategori),
                HeaderText = "Kategori"
            });
            dgvInventaris.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(TblInventarisKomputer.KodeKebun),
                HeaderText = "Kebun"
            });
            dgvInventaris.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(TblInventarisKomputer.NamaBarang),
                HeaderText = "Nama Barang",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            // --- debounce timer for auto search ---
            _searchTimer = new System.Windows.Forms.Timer();
            _searchTimer.Interval = 400; // milliseconds (0.4 second after last change)
            _searchTimer.Tick += SearchTimer_Tick;

            // Wire up change events for auto search
            txtSearch.TextChanged += AnyFilterChanged;
            cbKategori.SelectedIndexChanged += AnyFilterChanged;
            cbKebun.SelectedIndexChanged += AnyFilterChanged;
            cbKodePT.SelectedIndexChanged += AnyFilterChanged;

            // Wire up events
            btnFilter.Click += (s, ev) => { PerformSearch(); };
            btnSelect.Click += BtnSelect_Click;
            btnCancel.Click += (s, ev) => { SelectedInventaris = null; DialogResult = DialogResult.Cancel; Close(); };

            PerformSearch();
        }

        private void AnyFilterChanged(object sender, EventArgs e)
        {
            // Restart debounce timer whenever user changes filter or types
            if (_searchTimer != null)
            {
                _searchTimer.Stop();
                _searchTimer.Start();
            }
        }

        private void SearchTimer_Tick(object sender, EventArgs e)
        {
            if (_searchTimer != null)
            {
                _searchTimer.Stop();
            }

            PerformSearch();
        }


        private void PerformSearch()
        {
            string kategoriCode = cbKategori.SelectedValue as string;
            string kebunCode = cbKebun.SelectedValue as string;
            string kodePTCode = cbKodePT.SelectedValue as string;  // if you used CbItem; if not, keep SelectedItem as string

            if (string.IsNullOrEmpty(kategoriCode) || kategoriCode == "ALL") kategoriCode = null;
            if (string.IsNullOrEmpty(kebunCode) || kebunCode == "ALL") kebunCode = null;
            if (string.IsNullOrEmpty(kodePTCode) || kodePTCode == "ALL") kodePTCode = null;

            string term = (txtSearch.Text ?? "").Trim();

            var list = _invSvc.Search(
                kategoriCode,
                kebunCode,
                kodePTCode,
                term,
                true
            );

            dgvInventaris.DataSource = list;
        }


        private void BtnSelect_Click(object sender, EventArgs e)
        {
            if (dgvInventaris.CurrentRow == null)
            {
                MessageBox.Show("Select an item first."); return;
            }

            var selected = dgvInventaris.CurrentRow.DataBoundItem as TblInventarisKomputer;
            if (selected == null)
            {
                MessageBox.Show("Invalid selection."); return;
            }

            SelectedInventaris = selected;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void FrmPilihInventaris_Load(object sender, EventArgs e)
        {
            DataGridViewHelper.ApplyDefaultStyleThemed(dgvInventaris, DataGridViewHelper.BlueCalmLight, true, false);
        }

        private void dgvInventaris_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BtnSelect_Click(null, null);
        }
    }
}
