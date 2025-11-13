using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SupportIT.Model;
using Master.Master;
using Master.Controller;


namespace SupportIT.Controller
{
    /// <summary>
    /// main controller kebun
    /// </summary>
    public class ControllerKebun
    {
        #region properties

        public string query;
        public Kebun kebun;
        public DBConnectionClass objConnection;
        public DataTable dt = new DataTable();
        public ControllerKebunForCUD controllerKebunForCUD;

        #endregion

        #region function

        /// <summary>
        /// Get semua kolom pada tabel umum.TblKebun
        /// </summary>
        /// <returns></returns>
        public DataTable getAllKebun()
        {
            query = "Select * From Umum.TblKebun";
            dt = ControllerStaticVariables.objConnection.objsqlconnection.Filldatatable(query);
            return dt;
        }

        /// <summary>
        /// set objek kebun
        /// </summary>
        /// <param name="KodeKebun"></param>
        /// <param name="NamaKebun"></param>
        /// <param name="Alamat"></param>
        /// <param name="NamaSingkat"></param>
        /// <param name="Kota"></param>
        /// <param name="KodePos"></param>
        /// <param name="Telp"></param>
        /// <param name="Fax"></param>
        /// <param name="Status"></param>
        public void setKebun(string KodeKebun, string NamaKebun, string Alamat, string NamaSingkat, string Kota, string KodePos, string Telp, string Fax, string Status)
        {
            this.kebun = new Kebun(KodeKebun, NamaKebun, Alamat, NamaSingkat, Kota, KodePos, Telp, Fax, Status);
        }

        /// <summary>
        /// get one record kebun dari tabel Umum.TblKebun
        /// </summary>
        /// <param name="KodeKebun"></param>
        /// <returns></returns>
        public Kebun getOneRecord(string KodeKebun)
        {
            query = "Select* From Umum.TblKebun where KodeKebun = '"+KodeKebun+"'";
            dt = objConnection.objsqlconnection.Filldatatable(query);
            this.kebun = new Kebun(dt.Rows[0]["KodeKebun"].ToString(), dt.Rows[0]["NamaKebun"].ToString(), dt.Rows[0]["Alamat"].ToString(), dt.Rows[0]["NamaSingkat"].ToString(), dt.Rows[0]["Kota"].ToString(), dt.Rows[0]["KodePos"].ToString(), dt.Rows[0]["Telp"].ToString(), dt.Rows[0]["Fax"].ToString(), dt.Rows[0]["Status"].ToString());
            return this.kebun;
        }

        #endregion

        #region Constructor
        /// <summary>
        /// Controller Kebun Kosong
        /// </summary>
        public ControllerKebun()
        {

        }

        /// <summary>
        /// Constructor dengan 2 parameter database dan server yang digunakan untuk membentuk connection string
        /// </summary>
        /// <param name="Database"></param>
        /// <param name="Server"></param>
        public ControllerKebun(string Database, string Server)
        {
            this.objConnection = new DBConnectionClass(Database, Server);
        }

        /// <summary>
        /// Parameter Obj Koneksi Database
        /// </summary>
        /// <param name="objConnection"></param>
        public ControllerKebun(DBConnectionClass objConnection)
        {
            this.objConnection = objConnection;
            this.controllerKebunForCUD = new ControllerKebunForCUD(objConnection);
        }

        #endregion


    }

    /// <summary>
    /// controller kebun untuk proses create update delete
    /// </summary>
    public class ControllerKebunForCUD
    {
        #region properties

        public string query;
        public Kebun kebun;
        public DBConnectionClass objConnection;
        public DataTable dt = new DataTable();

        #endregion

        #region function

        public void Insert(Kebun kebun)
        {
            query = " Insert into Umum.TblKebun " +
                    "(KodeKebun, NamaKebun, Alamat, NamaSingkat, Kota, KodePos, Telp, Fax, Status) " +
                    "Values " +
                    "('" + kebun.KodeKebun + "', '" + kebun.NamaKebun + "', '" + kebun.Alamat + "', '" + kebun.NamaSingkat + "'" +
                    ", '" + kebun.Kota + "', '" + kebun.KodePos + "', '" + kebun.Telp + "', '" + kebun.Fax + "', '" + kebun.Status + "')";
            this.objConnection.objSqlServerIUDClass.ExecuteNonQuery(query);
        }

        /// <summary>
        /// Update record Kebun
        /// </summary>
        /// <param name="kebun"></param>
        /// <returns></returns>
        public void Update(Kebun kebun)
        {
            query = "Update Umum.TblKebun " +
                    " set NamaKebun = '"+ kebun.NamaKebun + "', Alamat = '" + kebun.Alamat + "', NamaSingkat = '" + kebun.NamaSingkat + "', " +
                    " Kota = '" + kebun.Kota + "', KodePos = '" + kebun.KodePos + "', Telp = '" + kebun.Telp + "', Fax = '" + kebun.Fax + "', Status = '" + kebun.Status + "' " +
                    " where KodeKebun = '" + kebun.KodeKebun + "'";
            objConnection.objSqlServerIUDClass.ExecuteNonQuery(query);
        }

        #endregion

        #region Constructor

        public ControllerKebunForCUD(DBConnectionClass objConnection)
        {
            this.objConnection = objConnection;
        }

        #endregion
    }
}
