using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Master.Interfaces;
using Master.Master;
using Inventaris.Model;
using System.Data;
using Master.Controller;

namespace Inventaris.Controller
{
    public class ControllerKategori
    {
        #region properties

        public string query;
        public Kategori objKategori;
        public DBConnectionClass objConnection;
        public DataTable dt = new DataTable();
        public ControllerKategoriForCUD controllerKategoriForCUD;

        #endregion

        #region function

        /// <summary>
        /// Get semua kolom pada tabel kategori dan return dalam bentuk datatable
        /// </summary>
        /// <returns></returns>
        public DataTable getAllKategori()
        {
            query = "Select * From Master.TblKategori";
            //dt = objConnection.objsqlconnection.Filldatatable(query);
            dt = ControllerStaticVariables.objConnection.objsqlconnection.Filldatatable(query);
            return dt;
        }

        /// <summary>
        /// set kodekategori dan nama kategori ke objek kategori pada class controller kategori
        /// </summary>
        /// <param name="KodeKategori"></param>
        /// <param name="NamaKategori"></param>
        public void setKategori(string KodeKategori, string NamaKategori)
        {
            objKategori = new Kategori(KodeKategori, NamaKategori);
        }

        /// <summary>
        /// get 1 record Kategori dari tabel master.TblKategori
        /// </summary>
        /// <param name="KodeKategori"></param>
        /// <returns></returns>
        public Kategori getOnerecord(string KodeKategori)
        {
            query = "Select * From Master.TblKategori where KodeKategori = '" + KodeKategori + "'";
            //dt = objConnection.objsqlconnection.Filldatatable(query);
            dt = ControllerStaticVariables.objConnection.objsqlconnection.Filldatatable(query);
            objKategori = new Kategori(dt.Rows[0]["KodeKategori"].ToString(), dt.Rows[0]["NamaKategori"].ToString());
            return objKategori;
        }
        

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor Kosong
        /// </summary>
        public ControllerKategori() { }

        /// <summary>
        /// Constructor dengan parameter menggunakan objkoneksi database
        /// </summary>
        /// <param name="objConnection"></param>
        public ControllerKategori(DBConnectionClass objConnection)
        {
            this.objConnection = objConnection;
            this.controllerKategoriForCUD = new ControllerKategoriForCUD(objConnection);
        }

        #endregion
    }

    /// <summary>
    /// Class untuk controller kategori melakukan proses create, update dan delete data pada TabelKategori
    /// </summary>
    public class ControllerKategoriForCUD {

        #region properties

        public string query;
        public Kategori objKategori;
        public DBConnectionClass objConnection;
        public DataTable dt = new DataTable();

        #endregion

        #region function

        /// <summary>
        /// Insert one record for Kategori
        /// </summary>
        /// <param name="kategori"></param>
        public void Insert(Kategori kategori)
        {
            query = "Insert Into Master.TblKategori (KodeKategori, NamaKategori) " +
                "values " +
                "('" + kategori.KodeKategori + "','"+ kategori.NamaKategori +"') ";
            //objConnection.objSqlServerIUDClass.ExecuteNonQuery(query);
            ControllerStaticVariables.objConnection.objSqlServerIUDClass.ExecuteNonQuery(query);
        }

        /// <summary>
        /// Update Kategori ke tabel Master.TblKategori dengan menggunakan objek kategori dan parameter kedua merupakan kode kategori yang akan diubah
        /// </summary>
        /// <param name="kategori"></param>
        /// <param name="OldKodeKategori"></param>
        public void Update(Kategori kategori)
        {
            query = "Update Master.TblKategori " +
                    "set NamaKategori = '"+ kategori.NamaKategori +"' " +
                    "where KodeKategori = '"+ kategori.KodeKategori +"'";
            //objConnection.objSqlServerIUDClass.ExecuteNonQuery(query);
            ControllerStaticVariables.objConnection.objSqlServerIUDClass.ExecuteNonQuery(query);
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor Kosong
        /// </summary>
        public ControllerKategoriForCUD() { }

        /// <summary>
        /// ControllerKategori untuk proses Create Update dan Delete
        /// </summary>
        /// <param name="objConnection"></param>
        public ControllerKategoriForCUD(DBConnectionClass objConnection)
        {
            this.objConnection = objConnection;
        }

        #endregion
    }
}
