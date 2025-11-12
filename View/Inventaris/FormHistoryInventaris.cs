using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventaris.Controller;

namespace Inventaris.View
{
    public partial class FormHistoryInventaris : Form
    {
        #region properties

        public DataTable dt;

        #endregion

        #region Constructor

        public FormHistoryInventaris()
        {
            InitializeComponent();
        }

        public FormHistoryInventaris(DataTable dt) 
        {
            InitializeComponent();
            this.dt = dt;
            
        }

        #endregion

        private void FormHistoryInventaris_Load(object sender, EventArgs e)
        {
            DgvForHistory.DataSource = dt;
            DgvForHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }
    }
}
