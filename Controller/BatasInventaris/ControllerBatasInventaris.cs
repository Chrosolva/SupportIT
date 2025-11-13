using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Master.Master;
using SupportIT.Model;
using System.Data;

namespace SupportIT.Controller
{
    public class ControllerBatasInventaris
    {
        #region properties

        private string query;
        public DBConnectionClass objConnection;
        private DataTable dt;
        public ControllerBIforCUD controllerBIforCUD;
        public BatasInventaris batasInventaris; 

        #endregion

        #region Function

        /// <summary>
        /// get All Batas Inventaris
        /// </summary>
        /// <returns></returns>
        public DataTable getAllBatasInventarisWithDetails()
        {
            query = "Select * from dbo.GetAllBatasInventaris()";
            return objConnection.objsqlconnection.Filldatatable(query);
        }


        public DataTable getAllBatasInventaris()
        {
            query = "Select * from Master.BatasInventaris";
            return objConnection.objsqlconnection.Filldatatable(query);
        }
        
        /// <summary>
        /// Filter Batas Inventaris dengan menggunakan parameter KodeBagian dan KodeKategori
        /// </summary>
        /// <param name="KodeBagian"></param>
        /// <param name="KodeKategori"></param>
        /// <returns></returns>
        public DataTable Filter2parm(string KodeBagian, string KodeKategori)
        {
            query = "select * from dbo.GetAllBatasInventarisWith2Parm('" + KodeBagian + "','" + KodeKategori + "')";
            return objConnection.objsqlconnection.Filldatatable(query);
        }

        /// <summary>
        /// Filter Batas Inventaris dengan menggunakan parameter KodeBagian, KodeKategori dan KodeKebun
        /// </summary>
        /// <param name="KodeBagian"></param>
        /// <param name="KodeKategori"></param>
        /// <param name="KodeKebun"></param>
        /// <returns></returns>
        public DataTable Filter3Parm(string KodeBagian, string KodeKategori, string KodeKebun)
        {
            query = "select * from dbo.GetAllBatasInventarisWithParm('" + KodeBagian + "','" + KodeKategori + "', '" + KodeKebun + "')";
            return objConnection.objsqlconnection.Filldatatable(query);
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor with objConnection Parameter
        /// </summary>
        /// <param name="objConnection"></param>
        public ControllerBatasInventaris(DBConnectionClass objConnection)
        {
            this.objConnection = objConnection;
            this.controllerBIforCUD = new ControllerBIforCUD(objConnection);
        }

        /// <summary>
        /// set 1 objek batas inventaris
        /// </summary>
        /// <param name="KodeBagian"></param>
        /// <param name="KodeKategori"></param>
        /// <param name="KodeKebun"></param>
        /// <param name="JumlahMax"></param>
        /// <param name="Keterangan"></param>
        public void setBatasInventaris(string KodeBagian,string KodeKategori, string KodeKebun,int JumlahMax, string Keterangan)
        {
            this.batasInventaris = new BatasInventaris(KodeBagian, KodeKategori, KodeKebun, JumlahMax, Keterangan);
        }

        /// <summary>
        /// mendapatkan 1 record batas inventaris berdasarkan parameter kodebagian, kodekategori dan kodekebun
        /// </summary>
        /// <param name="KodeBagian"></param>
        /// <param name="KodeKategori"></param>
        /// <param name="KodeKebun"></param>
        /// <returns></returns>
        public BatasInventaris getOneRecord(string KodeBagian, string KodeKategori, string KodeKebun)
        {
            query = "Select* From Master.BatasInventaris where KodeBagian = '" + KodeBagian + "' and KodeKategori = '" + KodeKategori + "' and KodeKebun = '" + KodeKebun + "'";
            dt = objConnection.objsqlconnection.Filldatatable(query);
            this.batasInventaris = new BatasInventaris(dt.Rows[0]["KodeBagian"].ToString(), dt.Rows[0]["KodeKategori"].ToString(), dt.Rows[0]["KodeKebun"].ToString(), Convert.ToInt32(dt.Rows[0]["JumlahMax"]), dt.Rows[0]["Keterangan"].ToString());
            return this.batasInventaris;
        }

        #endregion
    }

    public class ControllerBIforCUD
    {
        #region properties

        private string query;
        public DBConnectionClass objConnection;
        private DataTable dt;

        #endregion

        #region Function

        /// <summary>
        /// cek data batas inventaris sudah ada atau belum dari table batas inventaris
        /// </summary>
        /// <param name="KodeBagian"></param>
        /// <param name="KodeKategori"></param>
        /// <param name="KodeKebun"></param>
        /// <returns></returns>
        public bool checkRecord(string KodeBagian,string KodeKategori, string KodeKebun)
        {
            query = "Select * from Master.BatasInventaris where KodeBagian = '"+
                    KodeBagian +"' and KodeKategori ='" + KodeKategori +
                    "' and KodeKebun ='" + KodeKebun + "'";
            dt = objConnection.objsqlconnection.Filldatatable(query);
            if(dt.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Masukkan 1 record ke table batas Inventaris
        /// </summary>
        /// <param name="batasInventaris"></param>
        public void InsertRecord(BatasInventaris batasInventaris)
        {
            query = "Insert Into Master.BatasInventaris" +
                    " (KodeBagian, KodeKategori, KodeKebun, JumlahMax, Keterangan) " +
                    " values " +
                    " ('"+ batasInventaris.KodeBagian +"', '" + batasInventaris.KodeKategori + "', '" + batasInventaris.KodeKebun + "', " + batasInventaris.JumlahMax + ", '" + batasInventaris.Keterangan + "') ";
            this.objConnection.objSqlServerIUDClass.ExecuteNonQuery(query);
        }

        /// <summary>
        /// Update data 1 record ke table batas inventaris
        /// </summary>
        /// <param name="batasInventaris"></param>
        public void UpdateRecord(BatasInventaris batasInventaris)
        {
            query = "Update Master.BatasInventaris " +
                    " set JumlahMax = "+ batasInventaris.JumlahMax +", Keterangan = '" + batasInventaris.Keterangan + "' " +
                    " where KodeBagian = '" + batasInventaris.KodeBagian + "' and KodeKategori = '" + batasInventaris.KodeKategori + "' and KodeKebun = '" + batasInventaris.KodeKebun + "'";
            objConnection.objSqlServerIUDClass.ExecuteNonQuery(query);
        }
        
        #endregion

        #region Constructor

        /// <summary>
        /// Constructor with objConnection Parameter
        /// </summary>
        /// <param name="objConnection"></param>
        public ControllerBIforCUD(DBConnectionClass objConnection)
        {
            this.objConnection = objConnection;
        }

        #endregion
    }


}
