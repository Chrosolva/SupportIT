using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using SupportIT.Data;
using SupportIT.Model;
using SupportIT.Model.ReadModels;

namespace SupportIT.Services
{
    public class SuratPerbaikanService : IDisposable
    {
        private readonly DBMISPEUKDContext _db;

        public SuratPerbaikanService(DBMISPEUKDContext ctx = null)
        {
            _db = ctx ?? new DBMISPEUKDContext();
        }

        // 5.1 List headers with filters
        public List<TblSuratPerbaikan> ListHeaders(DateTime from, DateTime to, string status, string pic, string kodePT, string term)
        {
            var q = _db.SuratPerbaikans.AsNoTracking().Where(x => x.TglSP >= from && x.TglSP <= to);

            if (!string.IsNullOrWhiteSpace(status) && !status.Equals("ALL", StringComparison.OrdinalIgnoreCase))
                q = q.Where(x => x.Status == status);

            if (!string.IsNullOrWhiteSpace(pic) && !pic.Equals("ALL", StringComparison.OrdinalIgnoreCase))
                q = q.Where(x => x.PIC == pic);

            if (!string.IsNullOrWhiteSpace(kodePT) && !kodePT.Equals("ALL", StringComparison.OrdinalIgnoreCase))
                q = q.Where(x => x.KodePT == kodePT);

            if (!string.IsNullOrWhiteSpace(term))
                q = q.Where(x =>
                        x.NoSP.Contains(term) ||
                        x.Kepada.Contains(term) ||
                        x.Lokasi.Contains(term));

            return q.OrderByDescending(x => x.TglSP).ThenBy(x => x.NoSP).ToList();
        }

        // 5.2 Get details for an SPId
        public List<TblDetailSuratPerbaikan> GetDetails(int spId)
        {
            return _db.DetailSuratPerbaikans.AsNoTracking()
                .Where(d => d.SPId == spId)
                .OrderBy(d => d.NoUrut)
                .ToList();
        }

        // 5.3 Get last 10 timeline rows
        public List<TblSuratPerbaikanLog> GetTimeline(int spId, int take = 10)
        {
            return _db.SuratPerbaikanLogs.AsNoTracking()
                .Where(l => l.SPId == spId)
                .OrderByDescending(l => l.EventAt)
                .Take(take)
                .ToList();
        }

        // 5.4 History (temporal) — header
        public List<SuratPerbaikanHistoryRow> GetHeaderHistory_All(int spId)
        {
            // FOR SYSTEM_TIME ALL
            var sql = @"
                    SELECT SPId, NoSP, TglSP, Kepada, Lokasi, Status, PIC, KodePT,
                           CreatedAt, CreatedBy, UpdatedAt, UpdatedBy,
                           ValidFrom, ValidTo
                    FROM Master.TblSuratPerbaikan
                    FOR SYSTEM_TIME ALL
                    WHERE SPId = @spId
                    ORDER BY ValidFrom;";

            return _db.Database.SqlQuery<SuratPerbaikanHistoryRow>(
                sql, new SqlParameter("@spId", spId)).ToList();
        }

        // 5.5 History (temporal) — details as of a moment
        public List<DetailSuratPerbaikanAsOfRow> GetDetails_AsOf(int spId, DateTime asOfUtc)
        {
            // NOTE: your DB stores SYSUTCDATETIME() — pass UTC here
            var sql = @"
                    SELECT SPId, NoUrut, KodeInventaris, NamaBarang, Jumlah, Satuan, Keterangan,
                           ValidFrom, ValidTo
                    FROM Master.TblDetailSuratPerbaikan
                    FOR SYSTEM_TIME AS OF @asOf
                    WHERE SPId = @spId
                    ORDER BY NoUrut;";

            return _db.Database.SqlQuery<DetailSuratPerbaikanAsOfRow>(
                sql,
                new SqlParameter("@asOf", asOfUtc),
                new SqlParameter("@spId", spId)).ToList();
        }

        public void Dispose() => _db?.Dispose();
    }
}
