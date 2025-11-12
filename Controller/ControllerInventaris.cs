using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Master.Master;
using Inventaris.Model;
using System.Data;
using Master.Controller;
using SupportIT.Model;

namespace Inventaris.Controller
{
    public class ControllerInventaris
    {
        #region properties

        private string query;
        public DBConnectionClass objConnection;
        public InventarisKomputer InventarisKomputer;
        public DetailInventarisKomputer detailInventarisKomputer;
        public ControllerInventarisForCUD controllerInventarisForCUD;
        private DataTable dt;

        #endregion

        #region Function

        public DataTable getAllInventarisKomputerV2()
        {
            query = "Select * from GetInventarisKomp() ";
            dt = objConnection.objsqlconnection.Filldatatable(query);
            return dt;
        }


        /// <summary>
        /// get semua kolom pada tabel master.InventarisKomputer dimana kode tahun inventaris sama dengan tahun yang dipilih
        /// </summary>
        /// <returns></returns>
        /// 
        public DataTable getAllInventarisKomputer()
        {
            query = "Select * from GetInventarisKomp() where SUBSTRING(KodeInventaris,LEN(KodeInventaris) - 6,2) = " + ClsFungsi.C2Q(ControllerStaticVariables.tahun.ToString().Substring(2,2));
            dt = objConnection.objsqlconnection.Filldatatable(query);
            return dt;
        }

        public DataTable getAllInventarisKomputer2()
        {
            query = "Select * from GetInventarisKomp() ";
            dt = objConnection.objsqlconnection.Filldatatable(query);
            return dt;
        }

        public DataSet getAllInventarisWith2Parm(string KodeKategori, string KodeKebun , string Status)
        {
            query = "Select * from GetInventarisKomp() where KodeKategori like " + ClsFungsi.C2Q(KodeKategori + "%") + " and KodeKebun like " + ClsFungsi.C2Q(KodeKebun + "%") + " and Status like " + ClsFungsi.C2Q("%" + Status + "%");
            return ControllerStaticVariables.objConnection.objsqlconnection.LoadData2PK(query, "Master.TblInventarisKomputer",2);
        }

        public DataSet getAllInventarisWith2ParmV2(string KodeKategori, string KodeKebun, string Status)
        {
            
            query = "Select * from GetInventarisKomp() where KodeKategori like " + ClsFungsi.C2Q(KodeKategori + "%") + " and KodeKebun like " + ClsFungsi.C2Q(KodeKebun + "%") + " and " + "SUBSTRING(KodeInventaris,LEN(KodeInventaris) - 6,2) = " + ClsFungsi.C2Q(ControllerStaticVariables.tahun.ToString().Substring(2, 2)) + " and Status like " + ClsFungsi.C2Q("%" + Status + "%");
            return ControllerStaticVariables.objConnection.objsqlconnection.LoadData2PK(query, "Master.TblInventarisKomputer",2);
        }

        /// <summary>
        /// get detail inventaris per KodeInventaris
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public DataTable getDetailInventarisKomputer (string ID)
        {
            query = "Select top 1 " +
                    "KodeBagian, " +
                    " Master.TblDetailInventarisKomputer.Penguna as Pengguna, " +
                    "Spesifikasi, " +
                    "Kebutuhan, " +
                    "Keterangan, " +
                    "MacAddress1, " +
                    "MacAddress2, " +
                     "MacAddress3, " +
                    " IP1, " +
                    "IP2, " +
                    "IP3, " +
                    "ActiveUser " +
                    "from " +
                    "Master.TblDetailInventarisKomputer " +
                    "where KodeInventaris = '" + ID.ToString() + "' Order By Tgl desc";
            dt = objConnection.objsqlconnection.Filldatatable(query);
            return dt;
        }

        /// <summary>
        /// get semua history Inventaris sesuai dengan kode Inventaris pada parameter
        /// </summary>
        /// <param name="KodeInventaris"></param>
        /// <returns></returns>
        public DataTable getAllHistoryDetailInventaris(string KodeInventaris)
        {
            query = "Select * From Master.TblDetailInventarisKomputer where KodeInventaris ='" + KodeInventaris+ "' Order By Tgl Desc";
            return objConnection.objsqlconnection.Filldatatable(query);
        }

        /// <summary>
        /// set object InventarisKomputer
        /// </summary>
        /// <param name="KodeInventaris"></param>
        /// <param name="KodeKategori"></param>
        /// <param name="KodeKebun"></param>
        /// <param name="Aktif"></param>
        /// <param name="NoPO"></param>
        /// <param name="TglBeli"></param>
        /// <param name="NamaBarang"></param>
        public void setInventaris(string KodeInventaris, string KodeKategori, string KodeKebun, bool Aktif, string NoPO, DateTime TglBeli, string NamaBarang, string Status, string KodeInv, string kodePT, string KeteranganAfkir)
        {
            this.InventarisKomputer = new InventarisKomputer(KodeInventaris, KodeKategori, KodeKebun, Aktif, NoPO, TglBeli, NamaBarang, Status, KodeInv, kodePT, KeteranganAfkir);
        }

        /// <summary>
        /// set objek DetailInventarisKomputer
        /// </summary>
        /// <param name="KodeInventaris"></param>
        /// <param name="Tgl"></param>
        /// <param name="Kebun"></param>
        /// <param name="KodeBagian"></param>
        /// <param name="Pengguna"></param>
        /// <param name="Spesifikasi"></param>
        /// <param name="Kebutuhan"></param>
        /// <param name="Keterangan"></param>
        /// <param name="Mac1"></param>
        /// <param name="Mac2"></param>
        /// <param name="Mac3"></param>
        /// <param name="IP1"></param>
        /// <param name="IP2"></param>
        /// <param name="IP3"></param>
        /// <param name="ActiveUser"></param>
        public void setDetailInventaris(string KodeInventaris, DateTime Tgl, string Kebun, string KodeBagian, string Pengguna, string Spesifikasi, string Kebutuhan,string Keterangan, string Mac1, string Mac2, string Mac3, string IP1, string IP2, string IP3, string ActiveUser)
        {
            this.detailInventarisKomputer = new DetailInventarisKomputer(KodeInventaris, Tgl, Kebun, KodeBagian, Pengguna, Spesifikasi, Kebutuhan, Keterangan, Mac1, Mac2, Mac3, IP1, IP2, IP3, ActiveUser);
        }
        
        public InventarisKomputer getOneRecordInventaris(string KodeInventaris)
        {
            query = "Select * From Master.TblInventarisKomputer where KodeInventaris = " + ClsFungsi.C2Q(KodeInventaris);
            dt = objConnection.objsqlconnection.Filldatatable(query);
            DateTime tmp;
            if(dt.Rows[0]["TglBeli"].ToString().Length <= 2)
            {
                tmp = new DateTime(1901, 1, 1);
            } 
            else
            {
                tmp = Convert.ToDateTime(dt.Rows[0]["TglBeli"]);
            }
            this.InventarisKomputer = new InventarisKomputer(dt.Rows[0]["KodeInventaris"].ToString(), dt.Rows[0]["KodeKategori"].ToString(), dt.Rows[0]["KodeKebun"].ToString(), Convert.ToBoolean(dt.Rows[0]["Aktif"]), dt.Rows[0]["NoPO"].ToString(), tmp, dt.Rows[0]["NamaBarang"].ToString(), dt.Rows[0]["Status"].ToString(), dt.Rows[0]["KodeInvLama"].ToString(), dt.Rows[0]["KodePT"].ToString(), dt.Rows[0]["KeteranganAfkir"].ToString());
            return this.InventarisKomputer;
        }

        public DetailInventarisKomputer getOneRecordDetailInventaris (string KodeInventaris)
        {
            query = " Select top 1 * " +
                    " from " +
                    " Master.TblDetailInventarisKomputer " +
                    " where KodeInventaris = '" + KodeInventaris + "'  Order By Tgl desc ";
            dt = objConnection.objsqlconnection.Filldatatable(query);
            this.detailInventarisKomputer = new DetailInventarisKomputer(dt.Rows[0]["KodeInventaris"].ToString(), Convert.ToDateTime(dt.Rows[0]["Tgl"]), dt.Rows[0]["Kebun"].ToString(), dt.Rows[0]["KodeBagian"].ToString(), dt.Rows[0]["Penguna"].ToString(), dt.Rows[0]["Spesifikasi"].ToString(), dt.Rows[0]["Kebutuhan"].ToString(), dt.Rows[0]["Keterangan"].ToString(), dt.Rows[0]["MacAddress1"].ToString(), dt.Rows[0]["MacAddress2"].ToString(), dt.Rows[0]["MacAddress3"].ToString(), dt.Rows[0]["IP1"].ToString(), dt.Rows[0]["IP2"].ToString(), dt.Rows[0]["IP3"].ToString(), dt.Rows[0]["ActiveUser"].ToString());
            return this.detailInventarisKomputer;
        }
        
        public DataSet LoadDataSetInventarisKomputer(List<string> listKodeInv)
        {
            DataSet ds = new DataSet();

            DataTable TblInventaris = new DataTable();
            string tmp = "(";
            foreach(string x in listKodeInv)
            {
                tmp += ClsFungsi.C2Q(x) + ",";
            }
            tmp = tmp.Substring(0, tmp.Length - 1);
            tmp += ")";
            string query = "Select IK.KodeInventaris, IK.KodeKategori, IK.KodeKebun, IK.Aktif, IK.TglBeli, " +
                            " IK.NamaBarang, IK.Status, DI.Tgl, DI.KodeBagian, DI.Penguna, DI.Spesifikasi, " +
                            " DI.Kebutuhan, DI.Keterangan, DI.MacAddress1, DI.MacAddress2, DI.MacAddress3, " +
                            " DI.IP1,DI.IP2,DI.IP3, DI.ActiveUser , KB.NamaKebun" +
                            " from " +
                            " (Select * from Master.TblInventarisKomputer) as IK " + 
                            " left join " +
                            " (Select KodeInventaris, Tgl, KodeBagian, Penguna, Spesifikasi, Kebun, " +
                            " Kebutuhan, Keterangan, MacAddress1, MacAddress2, MacAddress3, " +
                            " IP1, IP2, IP3, ActiveUser, ROW_NUMBER() over(Partition by KodeInventaris order by Tgl desc) as baris " +
                            " from Master.TblDetailInventarisKomputer ) as DI " +
                            " on IK.KodeInventaris = DI.KodeInventaris  " + 
                            " left join Umum.TblKebun as KB on DI.Kebun = KB.KodeKebun" + 
                            " where DI.baris = 1 and IK.KodeInventaris in " + tmp +" " + 
                            " Order by DI.Tgl ";

            TblInventaris = objConnection.objsqlconnection.Filldatatable(query);
            TblInventaris.TableName = "InventarisKomputer";
            ds.Tables.Add(TblInventaris);

            return ds;
        }

        public DataSet LoadListQRCodes (List<byte[]> listQrcodes, List<string> listKodeInv)
        {
            DataSet ds = new DataSet();

            DataTable TblQRCode = new DataTable();
            TblQRCode.TableName = "TblQRCode";
            TblQRCode.Columns.Add("KodeInventaris", typeof(string));
            TblQRCode.Columns.Add("QRCode", typeof(byte[]));
            for(int i =0; i< listKodeInv.Count; i++)
            {
                DataRow row = TblQRCode.NewRow();
                row["KodeInventaris"] = listKodeInv[i];
                row["QRCode"] = listQrcodes[i];
                TblQRCode.Rows.Add(row);
            }

            ds.Tables.Add(TblQRCode);
            string tmp = "(";
            foreach (string x in listKodeInv)
            {
                tmp += ClsFungsi.C2Q(x) + ",";
            }
            tmp = tmp.Substring(0, tmp.Length - 1);
            tmp += ")";
            DataTable TblInventaris = new DataTable();
            string query = "Select IK.KodeInventaris, IK.KodeKategori, IK.KodeKebun, IK.Aktif, IK.TglBeli, " +
                            " IK.NamaBarang, IK.Status, DI.Tgl, DI.KodeBagian, DI.Penguna, DI.Spesifikasi, " +
                            " DI.Kebutuhan, DI.Keterangan, DI.MacAddress1, DI.MacAddress2, DI.MacAddress3, " +
                            " DI.IP1,DI.IP2, IK.NoPO  as IP3, DI.ActiveUser , KB.NamaKebun" +
                            " from " +
                            " (Select * from Master.TblInventarisKomputer) as IK " +
                            " left join " +
                            " (Select KodeInventaris, Tgl, KodeBagian, Penguna, Spesifikasi, Kebun, " +
                            " Kebutuhan, Keterangan, MacAddress1, MacAddress2, MacAddress3, " +
                            " IP1, IP2, IP3, ActiveUser, ROW_NUMBER() over(Partition by KodeInventaris order by Tgl desc) as baris " +
                            " from Master.TblDetailInventarisKomputer ) as DI " +
                            " on IK.KodeInventaris = DI.KodeInventaris  " +
                            " left join Umum.TblKebun as KB on DI.Kebun = KB.KodeKebun" +
                            " where DI.baris = 1 and IK.KodeInventaris in " + tmp + " " +
                            " Order by DI.Tgl ";

            TblInventaris = objConnection.objsqlconnection.Filldatatable(query);
            TblInventaris.TableName = "InventarisKomputer";
            ds.Tables.Add(TblInventaris);
            return ds;
        }

        public DataTable SearchInventaris (string option, string value, string KodeKategori, string KodeKebun, string Status)
        {
            query = "Select * from GetInventarisKomp() where " + option + " like '%" + value + "%' and " + "SUBSTRING(KodeInventaris,LEN(KodeInventaris) - 6,2) = " + ClsFungsi.C2Q(ControllerStaticVariables.tahun.ToString().Substring(2, 2)) + " and KodeKategori like " + ClsFungsi.C2Q(KodeKategori + "%") + " and KodeKebun like " + ClsFungsi.C2Q(KodeKebun + "%") +  " and Status like " + ClsFungsi.C2Q("%" + Status + "%");
            dt = ControllerStaticVariables.objConnection.objsqlconnection.Filldatatable(query);
            return dt;
        }

        public DataTable SearchInvntaris2 (string option, string value , string KodeKategori, string KodeKebun, string Status)
        {
            query = "Select * from GetInventarisKomp() where " + option + " like '%" + value + "%'" + " and KodeKategori like " + ClsFungsi.C2Q(KodeKategori + "%") + " and KodeKebun like " + ClsFungsi.C2Q(KodeKebun + "%") + " and Status like " + ClsFungsi.C2Q("%" + Status + "%");
            dt = ControllerStaticVariables.objConnection.objsqlconnection.Filldatatable(query);
            return dt;
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor with objConnection Parameter
        /// </summary>
        /// <param name="objConnection"></param>
        public ControllerInventaris (DBConnectionClass objConnection)
        {
            this.objConnection = objConnection;
            this.controllerInventarisForCUD = new ControllerInventarisForCUD(objConnection);
        }

        public ControllerInventaris () 
        {
            this.objConnection = ControllerStaticVariables.objConnection;
            this.controllerInventarisForCUD = new ControllerInventarisForCUD();
            
        }

        #endregion
    }

    public class ControllerInventarisForCUD
    {
        #region properties

        private string query;
        public DBConnectionClass objConnection;
        private ControllerBatasInventaris controllerBatasInventaris;
        private DataTable dt;

        #endregion

        #region Function

        /// <summary>
        /// cek batas inventaris untuk memastikan jumlah yang ada lebih kecil dari max
        /// </summary>
        /// <param name="KodeBagian"></param>
        /// <param name="KodeKategori"></param>
        /// <param name="KodeKebun"></param>
        /// <returns></returns>
        public string checkBatas(string KodeBagian, string KodeKategori, string KodeKebun)
        {
            query = "Select * from dbo.GetAllBatasInventaris() where KodeBagian = '" +
                    KodeBagian + "' and KodeKategori ='" + KodeKategori +
                    "' and KodeKebun ='" + KodeKebun + "'";
            dt = objConnection.objsqlconnection.Filldatatable(query);
            if (dt.Rows.Count <= 0)
            {
                return "Batas Inventaris Belum Dibuat!";
            }
            else
            {
                if(Convert.ToInt32(dt.Rows[0]["Jumlahyangada"].ToString()) < Convert.ToInt32(dt.Rows[0]["JumlahMax"].ToString()))
                {
                    return "Lanjut";
                }
                else
                {
                    return "Melebihi Jumlah Max";
                }
            }
        }

        /// <summary>
        /// generate KodeInventaris
        /// </summary>
        /// <param name="KodeKategori"></param>
        /// <param name="KodeKebun"></param>
        /// <param name="thn"></param>
        /// <returns></returns>
        public string hitungIndex( string KodeKategori, int thn)
        {
            query = "Select Count(KodeInventaris) from Master.TblInventarisKomputer where KodeInventaris like '"+ ControllerStaticVariables.NamaPT + "-" +KodeKategori+"-"+thn.ToString()+"%'";
            int indexcount = Convert.ToInt32(objConnection.objsqlconnection.ExecuteScalar(query))+1;
            string Index = indexcount.ToString("D4");
            return ControllerStaticVariables.NamaPT + "-" + KodeKategori + "-" + thn.ToString()+"."+Index;
        }   

        public string hitungIndex(string NamaPT ,string KodeKategori, int thn)
        {
            query = "Select Count(KodeInventaris) from Master.TblInventarisKomputer where KodeInventaris like '" + NamaPT + "-" + KodeKategori + "-" + thn.ToString() + "%'";
            int indexcount = Convert.ToInt32(objConnection.objsqlconnection.ExecuteScalar(query)) + 1;
            string Index = indexcount.ToString("D4");
            return NamaPT + "-" + KodeKategori + "-" + thn.ToString() + "." + Index;
        }

        public void Insert(InventarisKomputer inventarisKomputer, DetailInventarisKomputer detailInventaris)
        {
            query = "Insert Into Master.TblInventarisKomputer " +
                    " (KodeInventaris, KodeKategori, KodeKebun, Aktif, NoPO, TglBeli, NamaBarang, Status, KodeInvLama, KodePT, KeteranganAfkir) " +
                    " values " +
                    " ('"+ inventarisKomputer.KodeInventaris +"', '" + inventarisKomputer.KodeKategori + "', '"+
                    inventarisKomputer.KodeKebun + "', '" + Convert.ToBoolean(inventarisKomputer.Aktif) + "', '" + inventarisKomputer.NoPO + 
                    "', " + ClsFungsi.C2QTime(inventarisKomputer.TglBeli) +  ", '" + inventarisKomputer.NamaBarang + "', " + ClsFungsi.C2Q(inventarisKomputer.Status) + ","+ ClsFungsi.C2Q(inventarisKomputer.KodeInvLama)+ "," + ClsFungsi.C2Q(inventarisKomputer.KodePT) + "," + ClsFungsi.C2Q(inventarisKomputer.KeteranganAfkir) + ")";
            objConnection.objSqlServerIUDClass.ExecuteNonQuery(query);
            query = "Insert Into Master.TblDetailInventarisKomputer " +
                    " (KodeInventaris, Tgl, Kebun, KodeBagian, Penguna, Spesifikasi, Kebutuhan, Keterangan, MacAddress1, MacAddress2, MacAddress3, IP1, IP2, IP3, ActiveUser)" +
                    " values " +
                    " ('" + detailInventaris.KodeInventaris + "', GETDATE(), '" + detailInventaris.Kebun + "', '" + detailInventaris.KodeBagian + "', '" + detailInventaris.Pengguna + "', '" + detailInventaris.Spesifikasi + "', '" + detailInventaris.Kebutuhan + "'," +
                    " '" + detailInventaris.Keterangan + "', '" + detailInventaris.MacAddress1 + "', '" + detailInventaris.MacAddress2 + "', '" + detailInventaris.MacAddress3 + "'" +
                    " , '" + detailInventaris.IP1 + "', '" + detailInventaris.IP2 + "', '" + detailInventaris.IP3 + "', '" + detailInventaris.ActiveUser + "')";
            objConnection.objSqlServerIUDClass.ExecuteNonQuery(query);
        }

        public void Update(InventarisKomputer inventarisKomputer, DetailInventarisKomputer detailInventaris)
        {
            query = "Update Master.TblInventarisKomputer " +
                    " set KodeKategori = '" + inventarisKomputer.KodeKategori + "', KodeKebun = '" + inventarisKomputer.KodeKebun + "', Aktif = '" + Convert.ToBoolean(inventarisKomputer.Aktif) + "', NoPO = '" + inventarisKomputer.NoPO + "', " +
                    " TglBeli =  " + ClsFungsi.C2QTime(inventarisKomputer.TglBeli) + ", NamaBarang = '" + inventarisKomputer.NamaBarang + "' ," + "Status = " + ClsFungsi.C2Q(inventarisKomputer.Status) + ", KodeInvLama = " + ClsFungsi.C2Q(inventarisKomputer.KodeInvLama) + " ,KodePT = " + ClsFungsi.C2Q(inventarisKomputer.KodePT) + ", KeteranganAfkir = " + ClsFungsi.C2Q(inventarisKomputer.KeteranganAfkir) + " " +
                    "where KodeInventaris = '" + inventarisKomputer.KodeInventaris + "'";
            objConnection.objSqlServerIUDClass.ExecuteNonQueryWithoutTransaction(query);
            query = "Insert Into Master.TblDetailInventarisKomputer " +
                    " (KodeInventaris, Tgl, Kebun, KodeBagian, Penguna, Spesifikasi, Kebutuhan, Keterangan, MacAddress1, MacAddress2, MacAddress3, IP1, IP2, IP3, ActiveUser)" +
                    " values " +
                    " ('" + detailInventaris.KodeInventaris + "', GETDATE(), '" + detailInventaris.Kebun + "', '" + detailInventaris.KodeBagian + "', '" + detailInventaris.Pengguna + "', '" + detailInventaris.Spesifikasi + "', '" + detailInventaris.Kebutuhan + "'," +
                    " '" + detailInventaris.Keterangan + "', '" + detailInventaris.MacAddress1 + "', '" + detailInventaris.MacAddress2 + "', '" + detailInventaris.MacAddress3 + "'" +
                    " , '" + detailInventaris.IP1 + "', '" + detailInventaris.IP2 + "', '" + detailInventaris.IP3 + "', '" + detailInventaris.ActiveUser + "')";
            objConnection.objSqlServerIUDClass.ExecuteNonQuery(query);
        }

        public void UpdateAfkir(string KodeInventaris)
        {
            query = "Update Master.TblInventarisKomputer " +
                    $" set Aktif = 0 ,Status = {ClsFungsi.C2Q("Afkir")}" +  
                    "where KodeInventaris = '" + KodeInventaris + "'";
            objConnection.objSqlServerIUDClass.ExecuteNonQueryWithoutTransaction(query);
        }

        public bool DeleteInventaris(string KodeInv)
        {
            query = "Delete from Master.TblDetailInventarisKomputer where KodeInventaris = " + ClsFungsi.C2Q(KodeInv);
            //query = "Select * From Master.TblDetailInventarisKomputer";
            try
            {
                ControllerStaticVariables.objConnection.objSqlServerIUDClass.ExecuteNonQuery(query);
                query = "Delete from Master.TblInventarisKomputer where KodeInventaris = " + ClsFungsi.C2Q(KodeInv);
                ControllerStaticVariables.objConnection.objSqlServerIUDClass.ExecuteNonQuery(query);
                return true;
            }
            catch (Exception e) {
                throw e;
            }
            
            
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor with objConnection Parameter
        /// </summary>
        /// <param name="objConnection"></param>
        public ControllerInventarisForCUD(DBConnectionClass objConnection)
        {
            this.objConnection = objConnection;
            this.controllerBatasInventaris = new ControllerBatasInventaris(objConnection);
        }

        public ControllerInventarisForCUD()
        {
            this.objConnection = ControllerStaticVariables.objConnection;
            this.controllerBatasInventaris = new ControllerBatasInventaris(this.objConnection);
        }
        #endregion
    }

    public class ControllerSupplierReparasi
    {
        #region properties

        public string query;
        public SupplierReparasi supplierrep;
        

        #endregion

        #region constructor



        #endregion

        #region function

        public DataSet LoadDataSupp ()
        {
            query = "Select * From Master.SPReparasi ";
            return ControllerStaticVariables.objConnection.objsqlconnection.LoadData(query, "Master.SPReparasi");
        }

        #endregion
    }

    public class ControllerTandaTerima
    {
        #region properties

        public string query;
        public DataTable dt = new DataTable();
        public TandaTerima tt = new TandaTerima();
        public List<DetailTandaTerima> listDetailTandaTerima = new List<DetailTandaTerima>();
        public DetailTandaTerima detailtt = new DetailTandaTerima();

        #endregion

        #region function

        public void getTandaTerima(string IDTT)
        {
            
            query = "Select * from Master.TblTandaTerima where IDTT = " + ClsFungsi.C2Q(IDTT);
            dt = ControllerStaticVariables.objConnection.objsqlconnection.Filldatatable(query); 
            foreach (DataRow row in dt.Rows)
            {
                this.setTT(row["IDTT"].ToString(), row["KodeSupp"].ToString(), row["NamaSupp"].ToString(), Convert.ToDateTime(row["TanggalPengajuan"]), Convert.ToDecimal(row["TotalBiaya"]), row["Keterangan"].ToString());
            }
        }

        public void getDetailTandaTerima(string IDTT)
        {
            this.listDetailTandaTerima.Clear();
            query = "Select * From Master.TbDetailTandaTerima where IDTT = " + ClsFungsi.C2Q(IDTT);
            dt = ControllerStaticVariables.objConnection.objsqlconnection.Filldatatable(query);
            foreach(DataRow row in dt.Rows)
            {
                this.listDetailTandaTerima.Add(new DetailTandaTerima(row["IDTT"].ToString(), row["KodeInventaris"].ToString() ?? " ", row["NamaBarang"].ToString(), Convert.ToDecimal(row["BiayaPerbaikan"]), Convert.ToDateTime(row["TanggalSelesai"].ToString()), row["Keterangan"].ToString() ?? " ")); 
            }


        }

        public string GetNextIDTT()
        {
            query = "Select Count(IDTT) from Master.TblTandaTerima "; 
            if ( Convert.ToInt32(ControllerStaticVariables.objConnection.objsqlconnection.ExecuteScalar(query)) == 0)
            {
                return "REP." + ControllerStaticVariables.tahun.ToString().Substring(2,2)+ "-" + 1.ToString("D3");
            }
            else
            {
                query = "Select top 1 IDTT from Master.TblTandaTerima order by IDTT desc";
                ControllerStaticVariables.IDTT = ControllerStaticVariables.objConnection.objsqlconnection.ExecuteScalar(query);
                int tmp = Convert.ToInt32(ControllerStaticVariables.IDTT.Substring(7, 3));
                return "REP." + ControllerStaticVariables.tahun.ToString().Substring(2, 2) + "-" + (tmp+1).ToString("D3");
            }
        }

        public DataSet LoadDataTT()
        {
            query = "Select * From Master.TblTandaTerima ";
            return ControllerStaticVariables.objConnection.objsqlconnection.LoadData(query, "Master.TblTandaTerima");
        }

        public DataSet LoadDataDetTT(string IDTT)
        {
            query = "Select * From Master.TbDetailTandaTerima where IDTT = " + ClsFungsi.C2Q(IDTT);
            return ControllerStaticVariables.objConnection.objsqlconnection.LoadData2PK(query, "Master.TbDetailTandaTerima", 1);
        }

        public void setTT (string IDTT, string KodeSupp, string NamaSupp, DateTime TglPengajuan, decimal totalbiaya, string keterangan)
        {
            this.tt = new TandaTerima(IDTT, KodeSupp, NamaSupp, TglPengajuan, totalbiaya, keterangan);
            this.listDetailTandaTerima.Clear();
        }

        public void setDetTT (string IDTT, string KodeInventaris, string NamaBarang, decimal biayaPerbaikan, DateTime TanggalSelesai, string Keterangan)
        {
            this.detailtt = new DetailTandaTerima(IDTT, KodeInventaris, NamaBarang, biayaPerbaikan, TanggalSelesai, Keterangan);
            this.listDetailTandaTerima.Add(this.detailtt);
        }

        public void InsertTT (TandaTerima TT)
        {
            query = " Insert into Master.TblTandaTerima (IDTT, KodeSupp, NamaSupp, TanggalPengajuan, TotalBiaya, Keterangan) " +
                    " values " +
                    " (" + ClsFungsi.C2Q(TT.IDTT) + "," + ClsFungsi.C2Q(TT.KodeSupp) + ", " + ClsFungsi.C2Q(TT.NamaSupp) + ", " + ClsFungsi.C2QTime(TT.TanggalPengajuan) + "," + ClsFungsi.C2Q(TT.TotalBiaya) + ", " + ClsFungsi.C2Q(TT.Keterangan) + ")";
            ControllerStaticVariables.objConnection.objSqlServerIUDClass.ExecuteNonQuery(query);
        }

        public void InsertDetTT (List<DetailTandaTerima> listdetailtt)
        {
            foreach (DetailTandaTerima DetTT in listdetailtt)
            {
                query = " Insert into Master.TbDetailTandaTerima (IDTT, KodeInventaris, NamaBarang, BiayaPerbaikan, TanggalSelesai, Keterangan) " +
                   " values " +
                   " (" + ClsFungsi.C2Q(DetTT.IDTT) + "," + ClsFungsi.C2Q(DetTT.KodeInventris) + ", " + ClsFungsi.C2Q(DetTT.NamaBarang) + ", " + ClsFungsi.C2Q(DetTT.BiayaPerbaikan) + "," + ClsFungsi.C2QTime(DetTT.TanggalSelesai) + ", " + ClsFungsi.C2Q(DetTT.Keterangan) + ")";
                ControllerStaticVariables.objConnection.objSqlServerIUDClass.ExecuteNonQuery(query);
            }
        }

        public void UpdateTT (string IDTT)
        {
            query = "Update Master.TblTandaTerima " +
                    " set KodeSupp = " + ClsFungsi.C2Q(this.tt.KodeSupp) + " , NamaSupp = " + ClsFungsi.C2Q(this.tt.NamaSupp) + " , TanggalPengajuan = " + ClsFungsi.C2QTime(this.tt.TanggalPengajuan) +  ", TotalBiaya = " + ClsFungsi.C2Q(this.tt.TotalBiaya) + ", Keterangan = " + ClsFungsi.C2Q(this.tt.Keterangan) + 
                    " where IDTT = " + ClsFungsi.C2Q(this.tt.IDTT);
            ControllerStaticVariables.objConnection.objSqlServerIUDClass.ExecuteNonQuery(query);
        }

        public void DeleteTT (string IDTT)
        {
            query = "Delete from Master.TblTandaTerima where IDTT = " + ClsFungsi.C2Q(IDTT);
            ControllerStaticVariables.objConnection.objSqlServerIUDClass.ExecuteNonQuery(query);
        }

        public void DeleteDetTT (string IDTT)
        {
            query = "Delete  from Master.TbDetailTandaTerima where IDTT = " + ClsFungsi.C2Q(IDTT);
            ControllerStaticVariables.objConnection.objSqlServerIUDClass.ExecuteNonQuery(query);
        }

        public DataSet LoadDataDocTT (string IDTT)
        {
            DataSet ds = new DataSet();

            DataTable TblTandaTerima = new DataTable();

            string query = "Select * from Master.TblTandaTerima where IDTT = " + ClsFungsi.C2Q(IDTT);

            TblTandaTerima = ControllerStaticVariables.objConnection.objsqlconnection.Filldatatable(query);
            TblTandaTerima.TableName = "TblTandaTerima";
            ds.Tables.Add(TblTandaTerima);

            DataTable TbDetailTandaTerima = new DataTable();

            query = "Select * From Master.TbDetailTandaTerima where IDTT = " + ClsFungsi.C2Q(IDTT); 

            TbDetailTandaTerima = ControllerStaticVariables.objConnection.objsqlconnection.Filldatatable(query);
            TbDetailTandaTerima.TableName = "TbDetailTandaTerima";
            ds.Tables.Add(TbDetailTandaTerima);

            return ds;
        }

        #endregion

        #region constructor 

        public ControllerTandaTerima()
        {

        }

        #endregion
    }
}
