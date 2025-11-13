using SupportIT.Data;
using SupportIT.Model;
using SupportIT.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        public TblInventarisKomputer SelectedInventaris { get; private set; }

        public FrmPilihInventaris()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _db = new DBMISPEUKDContext();
            _invSvc = new InventarisKomputerService(_db);

            // Populate filters from distinct values
            cbStatus.DataSource = _db.Set<TblInventarisKomputer>().Select(x => x.KodeKategori).Distinct().ToList();
            cbPIC.DataSource = _db.Set<TblInventarisKomputer>().Select(x => x.KodeKebun).Distinct().ToList();
            cbKodePT.DataSource = _db.Set<TblInventarisKomputer>().Select(x => x.KodePT).Distinct().ToList();

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

            // Wire up events
            btnFilter.Click += (s, ev) => { PerformSearch(); };
            btnSelect.Click += BtnSelect_Click;
            btnCancel.Click += (s, ev) => { SelectedInventaris = null; DialogResult = DialogResult.Cancel; Close(); };

            PerformSearch();
        }

        private void PerformSearch()
        {
            string kategori = cbStatus.SelectedItem?.ToString();
            string kebun = cbPIC.SelectedItem?.ToString();
            string kodePT = cbKodePT.SelectedItem?.ToString();
            string term = txtSearch.Text?.Trim();
            var list = _invSvc.Search(kategori, kebun, kodePT, term, onlyActive: true);
            dgvInventaris.DataSource = list;
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            if (dgvInventaris.CurrentRow == null)
            {
                MessageBox.Show("Select an item first.");
                return;
            }
            SelectedInventaris = dgvInventaris.CurrentRow.DataBoundItem as TblInventarisKomputer;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
