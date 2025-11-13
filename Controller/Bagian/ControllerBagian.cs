using SupportIT.Model;
using Master.Master;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Master.Controller;

namespace SupportIT.Controller
{
    public class ControllerBagian
    {
        #region properties

        public string query;
        public Bagian bagian;
        public DBConnectionClass objConnection;
        public DataTable dt = new DataTable();
        public ControllerBagianforCUD ControllerBagianforCUD;

        #endregion

        #region function

        /// <summary>
        /// Get semua kolom pada tabel umum.TblKebun
        /// </summary>
        /// <returns></returns>
        public DataTable getAllBagian()
        {
            query = "Select * From Master.TblBagian";
            dt = this.objConnection.objsqlconnection.Filldatatable(query);
            return dt;
        }

        public DataTable getAllBagian( string StatusKebun)
        {
            query = "Select distinct TB.KodeBagian, Tb.NamaBagian, Tb.Status From master.TblBagian as TB left join Umum.TblKebun TK on TB.Status = TK.Status where TB.Status = " + ClsFungsi.C2Q(StatusKebun);
            dt = ControllerStaticVariables.objConnection.objsqlconnection.Filldatatable(query);
            return dt;
        }

        /// <summary>
        /// set 1 objek class bagian
        /// </summary>
        /// <param name="KodeBagian"></param>
        /// <param name="NamaBagian"></param>
        /// <param name="Asisten"></param>
        /// <param name="Grup"></param>
        public void setBagian(string KodeBagian, string NamaBagian, string Asisten, string Grup)
        {
            this.bagian = new Bagian(KodeBagian, NamaBagian, Asisten, Grup);
        }

        /// <summary>
        /// get 1 record berdasarkan kodebagian
        /// </summary>
        /// <param name="KodeBagian"></param>
        /// <returns></returns>
        public Bagian getOnerecord(string KodeBagian)
        {
            query = "Select * From Master.TblBagian where KodeBagian = '" + KodeBagian + "'";
            dt = objConnection.objsqlconnection.Filldatatable(query);
            this.bagian = new Bagian(dt.Rows[0]["KodeBagian"].ToString(), dt.Rows[0]["NamaBagian"].ToString(), dt.Rows[0]["Asisten"].ToString(), dt.Rows[0]["Grup"].ToString());
            return this.bagian;
        }

        #endregion

        #region Constructor
        /// <summary>
        /// Controller Kebun Kosong
        /// </summary>
        public ControllerBagian()
        {

        }

        /// <summary>
        /// Constructor dengan menggunakan parameter class objconnection
        /// </summary>
        /// <param name="objConnection"></param>
        public ControllerBagian(DBConnectionClass objConnection)
        {
            this.objConnection = objConnection;
            this.ControllerBagianforCUD = new ControllerBagianforCUD(objConnection);
        }

        #endregion
    }

    /// <summary>
    /// Class special for create update and delete Bagian
    /// </summary>
    public class ControllerBagianforCUD
    {
        #region properties

        public string query;
        public Bagian bagian;
        public DBConnectionClass objConnection;
        public DataTable dt = new DataTable();

        #endregion

        #region function

        public void Insert(Bagian bagian)
        {
            query = "Insert into Master.TblBagian(KodeBagian, NamaBagian, Asisten, Grup) " +
                    "values " +
                    "('" + bagian.KodeBagian + "', '" + bagian.NamaBagian + "', '" + bagian.Asisten + "', '" + bagian.Grup+ "')";
            this.objConnection.objSqlServerIUDClass.ExecuteNonQuery(query);

        }

        public void Update(Bagian bagian)
        {
            query = "Update Master.TblBagian " +
                    " set NamaBagian = '" + bagian.NamaBagian + "', Asisten = '" + bagian.Asisten + "', Grup = '" + bagian.Grup + "' " +
                    " where KodeBagian = '" + bagian.KodeBagian + "' ";
            this.objConnection.objSqlServerIUDClass.ExecuteNonQuery(query);
        }

        #endregion

        #region Constructor
        /// <summary>
        /// Controller Kebun Kosong
        /// </summary>
        public ControllerBagianforCUD()
        {

        }

        public ControllerBagianforCUD(DBConnectionClass objConnection)
        {
            this.objConnection = objConnection;
        }

        #endregion
    }
}
