using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Master.Master;
using System.Data;

namespace SupportIT.Controller
{
    public class ControllerImport
    {
        #region properties

        public string query;
        public DBConnectionClass objConnection;
        public DataTable dt = new DataTable();

        #endregion

        #region Constructor

        public ControllerImport(DBConnectionClass objConnection)
        {
            this.objConnection = objConnection;
        }

        #endregion

        #region function

        public string Import(string filepath)
        {
            string tabelinventaris = "Master.TblInventarisKomputer";
            string tabeldetailinventaris = "Master.TblDetailInventarisKomputer";
            string hasil1, hasil2;
            hasil1 = objConnection.objSqlServerIUDClass.ImportDataFromExcel(filepath, tabelinventaris, "Sheet1");
            hasil2 = objConnection.objSqlServerIUDClass.ImportDataFromExcel(filepath, tabeldetailinventaris, "Sheet2");
            //hasil2 = objConnection.objSqlServerIUDClass.ImportDataFromExcel(filepath, tabeldetailinventaris, "Sheet2");

            return hasil2;
        }

        #endregion
    }
}
