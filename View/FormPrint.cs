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
using CrystalDecisions.CrystalReports.Engine;
using SupportIT.Reports;
using SupportIT.Controller;
using Master.Controller;

namespace SupportIT.View
{
    public partial class FormPrint : Form
    {
        #region properties

        public ControllerInventaris controllerInventaris;
        public ControllerTandaTerima controllerTT = new ControllerTandaTerima();
        public ControllerSP controllerSP = new ControllerSP();
        public DataSet ds;
        private List<string> listKodeInv;
        private List<byte[]> listQrCodes;
        private ReportDocument reportDoc = new ReportDocument();
        private string IDTT;
        private string NoSP;
        private string PK;

        #endregion

        #region constructor

        public FormPrint()
        {
            InitializeComponent();
        }

        public FormPrint(List<string> listKodeInv)
        {
            InitializeComponent();
            this.controllerInventaris = new ControllerInventaris(ControllerStaticVariables.objConnection);
            this.listKodeInv = listKodeInv;
        }

        public FormPrint(string PK)
        {
            InitializeComponent();
            this.controllerTT = new ControllerTandaTerima();
            this.controllerSP = new ControllerSP();
            this.PK = PK;
        }

        public FormPrint(List<byte[]> listQrCodes, List<string> listKodeInv)
        {
            InitializeComponent();
            this.controllerInventaris = new ControllerInventaris(ControllerStaticVariables.objConnection);
            this.listQrCodes = new List<byte[]>();
            this.listQrCodes = listQrCodes;
            this.listKodeInv = listKodeInv;
        }

        #endregion

        private void FormPrint_Load(object sender, EventArgs e)
        {
            
            if(this.Tag.ToString() == "Inventaris")
            {
                this.ds = this.controllerInventaris.LoadDataSetInventarisKomputer(this.listKodeInv);
                reportDoc = new PrintInventaris();
                reportDoc.SetDataSource(ds);
                crViewer.ReportSource = reportDoc;
                crViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            }
            else if (this.Tag.ToString() == "TandaTerima")
            {
                this.IDTT = this.PK;
                this.ds = this.controllerTT.LoadDataDocTT(this.IDTT);
                reportDoc = new PrintTandaTerima();
                reportDoc.SetDataSource(ds);
                crViewer.ReportSource = reportDoc;
                crViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            }
            else if (this.Tag.ToString() == "SuratPengantar")
            {
                this.NoSP = this.PK;
                this.ds = this.controllerSP.LoadDataDocSP(this.NoSP);
                reportDoc = new PrintSuratPengantar();
                reportDoc.SetDataSource(ds);
                crViewer.ReportSource = reportDoc;
                crViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            }
            else if (this.Tag.ToString() == "InventarisQR")
            {
                this.ds = this.controllerInventaris.LoadListQRCodes(this.listQrCodes, listKodeInv);
                reportDoc = new PrintQRcodes();
                reportDoc.SetDataSource(ds);
                crViewer.ReportSource = reportDoc;
                crViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            }
        }
    }
}
