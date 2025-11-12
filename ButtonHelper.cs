using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SupportIT
{
    public static class ButtonHelper
    {
        public sealed class ButtonTheme
        {
            public Color BackNormal;
            public Color BackHover;
            public Color BackPressed;
            public Color Fore;
            public Color Border;
            public Font Font;
            public int CornerRadius;
        }

        // --- Light Blue Theme (soft, eye-friendly) ---
        public static readonly ButtonTheme BlueCalmLight = new ButtonTheme
        {
            BackNormal = Color.FromArgb(230, 240, 255),
            BackHover = Color.FromArgb(210, 225, 250),
            BackPressed = Color.FromArgb(180, 205, 245),
            Fore = Color.FromArgb(25, 40, 65),
            Border = Color.FromArgb(150, 180, 220),
            Font = new Font("Segoe UI", 10f, FontStyle.Regular), // ← use Regular, not Medium
            CornerRadius = 6
        };

        // --- Dark Blue Theme (optional) ---
        public static readonly ButtonTheme BlueCalmDark = new ButtonTheme
        {
            BackNormal = Color.FromArgb(24, 34, 48),
            BackHover = Color.FromArgb(40, 56, 80),
            BackPressed = Color.FromArgb(30, 46, 70),
            Fore = Color.White,
            Border = Color.FromArgb(70, 90, 120),
            Font = new Font("Segoe UI", 10f, FontStyle.Regular), // ← same here
            CornerRadius = 6
        };

        public static void Apply(Button btn, ButtonTheme theme)
        {
            if (btn == null || theme == null) return;

            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.ForeColor = theme.Fore;
            btn.Font = theme.Font;
            btn.BackColor = theme.BackNormal;
            btn.Tag = theme;

            btn.Paint += new PaintEventHandler(Btn_Paint);
            btn.MouseEnter += delegate { btn.BackColor = theme.BackHover; btn.Invalidate(); };
            btn.MouseLeave += delegate { btn.BackColor = theme.BackNormal; btn.Invalidate(); };
            btn.MouseDown += delegate (object s, MouseEventArgs e)
            {
                if (e.Button == MouseButtons.Left)
                {
                    btn.BackColor = theme.BackPressed;
                    btn.Invalidate();
                }
            };
            btn.MouseUp += delegate { btn.BackColor = theme.BackHover; btn.Invalidate(); };
        }

        private static void Btn_Paint(object sender, PaintEventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;
            ButtonTheme theme = btn.Tag as ButtonTheme;
            if (theme == null) return;

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle rect = new Rectangle(0, 0, btn.Width - 1, btn.Height - 1);
            int r = theme.CornerRadius;

            using (GraphicsPath path = RoundedRect(rect, r))
            using (SolidBrush brush = new SolidBrush(btn.BackColor))
            using (Pen pen = new Pen(theme.Border))
            {
                e.Graphics.FillPath(brush, path);
                e.Graphics.DrawPath(pen, path);
            }

            TextRenderer.DrawText(e.Graphics, btn.Text, theme.Font, rect, theme.Fore,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }

        private static GraphicsPath RoundedRect(Rectangle bounds, int radius)
        {
            int d = radius * 2;
            GraphicsPath path = new GraphicsPath();
            path.AddArc(bounds.X, bounds.Y, d, d, 180, 90);
            path.AddArc(bounds.Right - d, bounds.Y, d, d, 270, 90);
            path.AddArc(bounds.Right - d, bounds.Bottom - d, d, d, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}
