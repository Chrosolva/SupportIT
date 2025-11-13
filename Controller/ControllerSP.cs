using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Master.Master;
using SupportIT.Model;
using System.Data;
using Master.Controller;
using SupportIT.Model;

namespace SupportIT.Controller
{
    public class ControllerSP
    {
        #region properties

        public string query;
        public DataTable dt;
        public SuratPengantar SP;
        public List<DetailSuratPengantar> listDetSP;
        public DetailSuratPengantar DetSP;

        #endregion

        #region constructor 

        public ControllerSP()
        {

        }

        #endregion

        #region function

        public DataSet LoadDataSP()
        {
            query = "Select * From TblSuratPengantar";
            return ControllerStaticVariables.objConnection.objsqlconnection.LoadData(query, "TblSuratPengantar");
        }

        public DataSet LoadDataDetSP (string NoSP)
        {
            query = "Select * From TblDetSuratPengantar where NoSP = " + ClsFungsi.C2Q(NoSP);
            return ControllerStaticVariables.objConnection.objsqlconnection.LoadData2PK(query, "TblDetSuratPengantar", 1);
        }

        public void SetSuratPengantar (string NoSP, DateTime TglSP, string Bagian, string Kepada, string Lokasi)
        {
            this.SP = new SuratPengantar(NoSP, TglSP, Bagian, Kepada, Lokasi);
            this.listDetSP = new List<DetailSuratPengantar>();
        }

        public void SetDetailSuratPengantar (string NoSP, int NoUrut, string KodeInventaris, string Uraian, int Jumlah, string Satuan, string Keterangan)
        {
            this.DetSP = new DetailSuratPengantar(NoSP, NoUrut, KodeInventaris, Uraian, Jumlah, Satuan, Keterangan);
            this.listDetSP.Add(this.DetSP);
        }

        public void TambahSuratPengantar(SuratPengantar SP)
        {
            query = "Insert Into TblSuratPengantar( NoSP, TglSP, Bagian, Kepada, Lokasi) " +
                    " values " +
                    " (" + ClsFungsi.C2Q(SP.NoSP) + ", " + ClsFungsi.C2QTime(SP.TglSP) + ", " + ClsFungsi.C2Q(SP.Bagian) + ", " + ClsFungsi.C2Q(SP.Kepada) + ", " + ClsFungsi.C2Q(SP.Lokasi) + ") ";
            ControllerStaticVariables.objConnection.objSqlServerIUDClass.ExecuteNonQuery(query);
        }

        public void TambahDetailSuratPengantar (List<DetailSuratPengantar> listDetSP)
        {
            foreach (DetailSuratPengantar DetSP in listDetSP)
            {
                query = "Insert Into TblDetSuratPengantar (NoSP, NoUrut,KodeInventaris,Uraian,Jumlah,Satuan, Keterangan) " +
                    " values " +
                    " (" + ClsFungsi.C2Q(DetSP.NoSP) + ", " + ClsFungsi.C2Q(DetSP.NoUrut) + ", " + ClsFungsi.C2Q(DetSP.KodeInventaris) + ", " + ClsFungsi.C2Q(DetSP.Uraian) + ", " + ClsFungsi.C2Q(DetSP.Jumlah) + ", " + ClsFungsi.C2Q(DetSP.Satuan) + ", " + ClsFungsi.C2Q(DetSP.Keterangan) + ") ";
                ControllerStaticVariables.objConnection.objSqlServerIUDClass.ExecuteNonQuery(query);
            }
        }

        public void DeleteSuratPengantar (string NoSP)
        {
            query = " Delete from TblSuratPengantar where NoSP = " + ClsFungsi.C2Q(NoSP);
            ControllerStaticVariables.objConnection.objSqlServerIUDClass.ExecuteNonQuery(query);
        }

        public DataSet LoadDataDocSP(string NoSP)
        {
            DataSet ds = new DataSet();

            DataTable TblSuratPengantar = new DataTable();

            string query = "Select * from TblSuratPengantar where NoSP = " + ClsFungsi.C2Q(NoSP);

            TblSuratPengantar = ControllerStaticVariables.objConnection.objsqlconnection.Filldatatable(query);
            TblSuratPengantar.TableName = "TblSuratPengantar";
            ds.Tables.Add(TblSuratPengantar);

            DataTable TblDetSuratPengantar = new DataTable();

            query = "Select * From TblDetSuratPengantar where NoSP = " + ClsFungsi.C2Q(NoSP);

            TblDetSuratPengantar = ControllerStaticVariables.objConnection.objsqlconnection.Filldatatable(query);
            TblDetSuratPengantar.TableName = "TblDetSuratPengantar";
            ds.Tables.Add(TblDetSuratPengantar);

            return ds;
        }

        #endregion
    }
}
