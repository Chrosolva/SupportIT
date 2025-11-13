using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SupportIT.Data;
using SupportIT.Services;
using SupportIT.Model;

namespace SupportIT.View.Inventaris
{
    public partial class FrmSuratPerbaikan : Form
    {
        private SuratPerbaikanService _svc;

        private TblSuratPerbaikan _current;

        public FrmSuratPerbaikan()
        {
            InitializeComponent();
        }

        private void FrmSuratPerbaikan_Load(object sender, EventArgs e)
        {
            // Pick sizes to your taste
            var appFonts = GlobalFontHelper.Resolve(
                bodySize: 11f,           // typical body
                headerSize: 11.5f,       // slightly larger headers
                headerStyle: FontStyle.Bold
            );

            // Apply to the main form (and all its current controls)
            GlobalFontHelper.Apply(this, appFonts);
            DataGridViewHelper.ApplyDefaultStyleThemed(dgvSuratPerbaikan, DataGridViewHelper.BlueCalmLight, true, true);
            DataGridViewHelper.ApplyDefaultStyleThemed(dgvDetailSP, DataGridViewHelper.BlueCalmLight, true, true);
            ButtonHelper.Apply(btnFilter, ButtonHelper.BlueCalmLight);

            _svc = new SuratPerbaikanService(new DBMISPEUKDContext());

            // initial filters
            dtpFrom.Value = DateTime.Today.AddDays(-7);
            dtpTo.Value = DateTime.Today.AddDays(1).AddSeconds(-1);

            cbStatus.SelectedIndex = 0; // ALL
            cbPIC.SelectedIndex = 0;    // ALL
            cbKodePT.SelectedIndex = 0; // ALL

            LoadHeaders();
            dgvSuratPerbaikan.SelectionChanged += dgvSuratPerbaikan_SelectionChanged;

        }

        private void LoadHeaders()
        {
            var list = _svc.ListHeaders(
                dtpFrom.Value, dtpTo.Value,
                cbStatus.Text, cbPIC.Text, cbKodePT.Text,
                txtSearch.Text?.Trim());

            dgvSuratPerbaikan.AutoGenerateColumns = true; // or configure columns manually
            dgvSuratPerbaikan.DataSource = list;

            if (list.Any())
                dgvSuratPerbaikan.Rows[0].Selected = true;
        }

        private void dgvSuratPerbaikan_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSuratPerbaikan.CurrentRow == null) return;
            _current = dgvSuratPerbaikan.CurrentRow.DataBoundItem as TblSuratPerbaikan;
            if (_current == null) return;

            // right panel labels
            lblNoSP.Text = _current.NoSP;
            lblStatus.Text = _current.Status;
            lblPIC.Text = _current.PIC;
            lblKodePT.Text = _current.KodePT;
            lblKepada.Text = _current.Kepada;
            lblLokasi.Text = _current.Lokasi;
            lblCreatedAt.Text = _current.CreatedAt.ToString("yyyy-MM-dd HH:mm:ss");
            lblCreatedBy.Text = _current.CreatedBy;
            lblUpdatedAt.Text = _current.UpdatedAt.ToString("yyyy-MM-dd HH:mm:ss");
            lblUpdatedBy.Text = _current.UpdatedBy;

            // detail grid
            dgvDetailSP.AutoGenerateColumns = true;
            dgvDetailSP.DataSource = _svc.GetDetails(_current.SPId);

            // timeline list (top 10)
            var evts = _svc.GetTimeline(_current.SPId, 10);
            lstTimeline.Items.Clear();
            foreach (var e2 in evts.OrderBy(x => x.EventAt))
                lstTimeline.Items.Add($"[{e2.EventAt:yyyy-MM-dd HH:mm}] {e2.EventType} by {e2.EventBy} {(string.IsNullOrEmpty(e2.Note) ? "" : ("- " + e2.Note))}");
        }

        private void btnFilter_Click(object sender, EventArgs e) => LoadHeaders();

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _svc?.Dispose();
            base.OnFormClosed(e);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmSuratPerbaikanEdit())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadHeaders();  // re‑load the main grid
                }
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvSuratPerbaikan.CurrentRow != null)
            {
                var header = dgvSuratPerbaikan.CurrentRow.DataBoundItem as TblSuratPerbaikan;
                using (var frm = new FrmSuratPerbaikanEdit(header.SPId))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        LoadHeaders();
                    }
                }
            }
        }
    }
}
