using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace SupportIT
{
    public static class DataGridViewHelper
    {
        // ------------ THEME MODEL ------------
        public sealed class GridTheme
        {
            public Color Surface;            // grid background
            public Color SurfaceAlt;         // alternating rows
            public Color TextPrimary;
            public Color TextSecondary;
            public Color HeaderBack;
            public Color HeaderText;
            public Color GridLines;
            public Color SelectionBack;
            public Color SelectionText;
            public Color ReadonlyBack;       // read-only cell background
            public Color ReadonlyHeaderBack; // read-only header background
            public Color Accent;             // accent (focus border)
            public Font BodyFont;
            public Font HeaderFont;

            // Row-header (left strip)
            public Color RowHeaderBack;
            public Color RowHeaderText;
            public Color RowHeaderSelectBack;
        }

        // ------------ BLUE (CALM, DARK) ------------
        public static readonly GridTheme BlueCalmDark = new GridTheme
        {
            // Surfaces
            Surface = Color.FromArgb(12, 16, 24),
            SurfaceAlt = Color.FromArgb(14, 20, 28),

            // Text
            TextPrimary = Color.FromArgb(228, 235, 245),
            TextSecondary = Color.FromArgb(168, 180, 196),

            // Headers
            HeaderBack = Color.FromArgb(24, 34, 48),
            HeaderText = Color.White,
            ReadonlyHeaderBack = Color.FromArgb(32, 48, 72),

            // Lines
            GridLines = Color.FromArgb(28, 40, 56),

            // Selection
            SelectionBack = Color.FromArgb(120, 59, 130, 246),
            SelectionText = Color.White,

            // Readonly cells
            ReadonlyBack = Color.FromArgb(18, 26, 38),

            // Accent / focus outline
            Accent = Color.FromArgb(59, 130, 246),

            // Fonts
            BodyFont = new Font("Segoe UI", 10f, FontStyle.Regular),
            HeaderFont = new Font("Segoe UI", 10f, FontStyle.Bold),

            // Row header
            RowHeaderBack = Color.FromArgb(24, 34, 48),
            RowHeaderText = Color.White,
            RowHeaderSelectBack = Color.FromArgb(20, 30, 44),
        };

        // ------------ TEAL + ORANGE (DARK) ------------
        public static readonly GridTheme TealOrangeDark = new GridTheme
        {
            Surface = Color.FromArgb(12, 24, 22),
            SurfaceAlt = Color.FromArgb(16, 32, 30),
            TextPrimary = Color.FromArgb(230, 240, 238),
            TextSecondary = Color.FromArgb(170, 186, 182),
            HeaderBack = Color.FromArgb(19, 78, 74),
            HeaderText = Color.White,
            GridLines = Color.FromArgb(28, 54, 51),
            SelectionBack = Color.FromArgb(151, 249, 115, 22),
            SelectionText = Color.White,
            ReadonlyBack = Color.FromArgb(24, 48, 45),
            ReadonlyHeaderBack = Color.FromArgb(15, 118, 110),
            Accent = Color.FromArgb(249, 115, 22),
            BodyFont = new Font("Segoe UI", 10f, FontStyle.Regular),
            HeaderFont = new Font("Segoe UI", 10f, FontStyle.Bold),
            RowHeaderBack = Color.FromArgb(19, 78, 74),
            RowHeaderText = Color.White,
            RowHeaderSelectBack = Color.FromArgb(24, 48, 45)
        };

        // ------------ BLUE (CALM, LIGHT) ------------
        public static readonly GridTheme BlueCalmLight = new GridTheme
        {
            // Base surfaces
            Surface = Color.FromArgb(248, 250, 255),
            SurfaceAlt = Color.FromArgb(240, 244, 252),

            // Text
            TextPrimary = Color.FromArgb(30, 40, 55),
            TextSecondary = Color.FromArgb(90, 100, 120),

            // Headers
            HeaderBack = Color.FromArgb(222, 230, 245),
            HeaderText = Color.FromArgb(25, 40, 65),
            ReadonlyHeaderBack = Color.FromArgb(210, 225, 245),

            // Lines
            GridLines = Color.FromArgb(220, 225, 235),

            // Selection
            SelectionBack = Color.FromArgb(210, 227, 255),
            SelectionText = Color.FromArgb(25, 40, 65),

            // Readonly cells
            ReadonlyBack = Color.FromArgb(235, 238, 245),

            // Accent
            Accent = Color.FromArgb(59, 130, 246),

            // Fonts
            BodyFont = new Font("Segoe UI", 10f, FontStyle.Regular),
            HeaderFont = new Font("Segoe UI", 10f, FontStyle.Bold),

            // Row headers
            RowHeaderBack = Color.FromArgb(222, 230, 245),
            RowHeaderText = Color.FromArgb(25, 40, 65),
            RowHeaderSelectBack = Color.FromArgb(210, 225, 245)
        };


        // ------------ PUBLIC API (old-call compatible) ------------

        // Default: BlueCalmLight theme
        public static void ApplyDefaultStyle(DataGridView dgv)
        {
            ApplyDefaultStyleInternal(dgv, BlueCalmLight, true, false);
        }

        public static void ApplyDefaultStyle(DataGridView dgv, bool readOnly, bool multiSelect)
        {
            ApplyDefaultStyleInternal(dgv, BlueCalmLight, readOnly, multiSelect);
        }

        public static void ApplyDefaultStyleThemed(DataGridView dgv, GridTheme theme, bool readOnly, bool multiSelect)
        {
            if (theme == null) theme = BlueCalmDark;
            ApplyDefaultStyleInternal(dgv, theme, readOnly, multiSelect);
        }

        /// <summary>
        /// MODE 1 (COMPACT): auto-fit columns to content once, with max width clamp.
        /// Good for dense, compact grids – some long text may still truncate.
        /// </summary>
        public static void FitOnceThenUnlock(DataGridView dgv)
        {
            if (dgv == null || dgv.Columns.Count == 0) return;

            const int minWidth = 56;
            const int maxWidth = 420;
            const int extraPadding = 12;

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgv.PerformLayout();

            foreach (DataGridViewColumn c in dgv.Columns)
            {
                int w = c.Width + extraPadding;
                if (w < minWidth) w = minWidth;
                if (w > maxWidth) w = maxWidth;

                c.MinimumWidth = minWidth; // safety so they never collapse
                c.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                c.Width = w;
                c.Resizable = DataGridViewTriState.True;
            }

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgv.ScrollBars = ScrollBars.Both;
        }

        /// <summary>
        /// MODE 2 (FULL CONTENT, SAFE): use AllCells autosizing.
        /// Lets DataGridView compute widths so full content is visible.
        /// Horizontal scroll will appear when needed.
        /// </summary>
        public static void EnableFullContentSizing(DataGridView dgv)
        {
            if (dgv == null) return;

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv.ScrollBars = ScrollBars.Both;
            dgv.PerformLayout();

            // Optional: set a reasonable minimum so columns don't collapse
            foreach (DataGridViewColumn c in dgv.Columns)
            {
                if (c.MinimumWidth < 40)
                    c.MinimumWidth = 40;
                c.Resizable = DataGridViewTriState.True;
            }
        }

        public static void StyleReadOnlyColumns(DataGridView dgv, params string[] columnNames)
        {
            StyleReadOnlyColumns(dgv, BlueCalmDark, columnNames);
        }

        public static void StyleReadOnlyColumns(DataGridView dgv, GridTheme theme, params string[] columnNames)
        {
            if (dgv == null || theme == null || dgv.Columns.Count == 0 || columnNames == null) return;

            foreach (string name in columnNames)
            {
                if (!dgv.Columns.Contains(name)) continue;

                DataGridViewColumn col = dgv.Columns[name];
                col.ReadOnly = true;
                col.DefaultCellStyle.BackColor = theme.ReadonlyBack;
                col.DefaultCellStyle.ForeColor = theme.TextSecondary;

                if (!string.IsNullOrEmpty(col.HeaderText) &&
                    col.HeaderText.IndexOf("🔒", StringComparison.Ordinal) < 0)
                {
                    col.HeaderText = "🔒 " + col.HeaderText;
                }

                Font baseFont = dgv.DefaultCellStyle.Font ?? new Font("Segoe UI", 10f, FontStyle.Regular);
                col.DefaultCellStyle.Font = new Font(baseFont, FontStyle.Italic);
            }
        }

        // ------------ INTERNAL CORE ------------

        private static void ApplyDefaultStyleInternal(DataGridView dgv, GridTheme theme, bool readOnly, bool multiSelect)
        {
            if (dgv == null) return;
            if (theme == null) theme = BlueCalmDark;

            dgv.SuspendLayout();

            // General Appearance
            dgv.EnableHeadersVisualStyles = false;
            dgv.Font = theme.BodyFont;
            dgv.BackgroundColor = theme.Surface;
            dgv.GridColor = theme.GridLines;
            dgv.BorderStyle = BorderStyle.None;
            dgv.RowHeadersWidth = 28;
            dgv.RowTemplate.Height = 28;
            dgv.ColumnHeadersHeight = 34;
            dgv.MultiSelect = multiSelect;
            dgv.ScrollBars = ScrollBars.Both;

            // Header Style
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = theme.HeaderBack;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = theme.HeaderText;
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = theme.HeaderBack;
            dgv.ColumnHeadersDefaultCellStyle.SelectionForeColor = theme.HeaderText;
            dgv.ColumnHeadersDefaultCellStyle.Font = theme.HeaderFont;
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            // Row Style
            dgv.DefaultCellStyle.BackColor = theme.Surface;
            dgv.DefaultCellStyle.ForeColor = theme.TextPrimary;

            // Ensure selection color is opaque (alpha can cause black on some systems)
            Color sel = theme.SelectionBack;
            if (sel.A != 255) sel = Color.FromArgb(255, sel.R, sel.G, sel.B);

            dgv.DefaultCellStyle.SelectionBackColor = sel;
            dgv.DefaultCellStyle.SelectionForeColor = theme.SelectionText;
            dgv.DefaultCellStyle.WrapMode = DataGridViewTriState.False; // keep rows compact

            dgv.AlternatingRowsDefaultCellStyle.BackColor = theme.SurfaceAlt;
            dgv.AlternatingRowsDefaultCellStyle.ForeColor = theme.TextPrimary;

            // Row header (left strip)
            dgv.RowHeadersVisible = true;
            dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv.RowHeadersDefaultCellStyle.BackColor = theme.RowHeaderBack;
            dgv.RowHeadersDefaultCellStyle.ForeColor = theme.RowHeaderText;
            dgv.RowHeadersDefaultCellStyle.SelectionBackColor = theme.RowHeaderSelectBack;
            dgv.RowHeadersDefaultCellStyle.SelectionForeColor = theme.RowHeaderText;

            if (dgv.TopLeftHeaderCell != null)
            {
                dgv.TopLeftHeaderCell.Style.BackColor = theme.RowHeaderBack;
                dgv.TopLeftHeaderCell.Style.ForeColor = theme.RowHeaderText;
            }

            // Grid Lines
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.GridColor = theme.GridLines;

            // Behavior
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None; // we choose mode after binding
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeColumns = true;
            dgv.AllowUserToResizeRows = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgv.ReadOnly = readOnly;
            dgv.EditMode = readOnly
                ? DataGridViewEditMode.EditProgrammatically
                : DataGridViewEditMode.EditOnEnter;

            // Focus cue (accent outline)
            AttachFocusCueHandlers(dgv, theme);

            // Performance
            EnableDoubleBuffering(dgv);

            dgv.ResumeLayout(true);
        }

        private static void EnableDoubleBuffering(DataGridView dgv)
        {
            try
            {
                typeof(DataGridView).InvokeMember(
                    "DoubleBuffered",
                    BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                    null,
                    dgv,
                    new object[] { true });
            }
            catch
            {
                // ignore on runtimes that disallow it
            }
        }

        // Store handler references so we don't add duplicates if ApplyDefaultStyle is called again
        private class FocusHandlers
        {
            public PaintEventHandler PaintHandler;
            public EventHandler FocusHandler;
        }

        private static void AttachFocusCueHandlers(DataGridView dgv, GridTheme theme)
        {
            FocusHandlers existing = dgv.Tag as FocusHandlers;
            if (existing != null)
                return;

            FocusHandlers fh = new FocusHandlers();

            fh.PaintHandler = delegate (object sender, PaintEventArgs e)
            {
                if (dgv.Focused || dgv.ContainsFocus)
                {
                    using (Pen pen = new Pen(theme.Accent, 2))
                    {
                        Rectangle r = dgv.ClientRectangle;
                        r.Width -= 1;
                        r.Height -= 1;
                        e.Graphics.DrawRectangle(pen, r);
                    }
                }
            };

            fh.FocusHandler = delegate (object sender, EventArgs e)
            {
                dgv.Invalidate();
            };

            dgv.Paint += fh.PaintHandler;
            dgv.GotFocus += fh.FocusHandler;
            dgv.LostFocus += fh.FocusHandler;

            if (dgv.Tag == null || dgv.Tag is FocusHandlers)
                dgv.Tag = fh;

            dgv.Disposed += delegate
            {
                try { dgv.Paint -= fh.PaintHandler; } catch { }
                try { dgv.GotFocus -= fh.FocusHandler; } catch { }
                try { dgv.LostFocus -= fh.FocusHandler; } catch { }
            };
        }
    }
}
