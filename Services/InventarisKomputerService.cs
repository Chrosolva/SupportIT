using System;
using System.Collections.Generic;
using System.Linq;
using SupportIT.Data;
using SupportIT.Model;
using SupportIT.Model;

namespace SupportIT.Services
{
    /// <summary>
    /// Service to query Master.TblInventarisKomputer via Entity Framework.
    /// You can use this class in FrmPilihInventaris to search and select
    /// inventory items. It’s independent of your older DBConnectionClass,
    /// so both can co-exist.
    /// </summary>
    public class InventarisKomputerService : IDisposable
    {
        private readonly DBMISPEUKDContext _db;

        public InventarisKomputerService(DBMISPEUKDContext ctx = null)
        {
            // If you pass in a context, this service will reuse it; otherwise it creates its own.
            _db = ctx ?? new DBMISPEUKDContext();
        }

        /// <summary>
        /// Returns a filtered list of inventory assets.
        /// All filters are optional; passing null/empty ignores that filter.
        /// Only records with Aktif = true are returned by default.
        /// </summary>
        public List<TblInventarisKomputer> Search(
            string kategori = null,
            string kebun = null,
            string kodePT = null,
            string searchTerm = null,
            bool onlyActive = true)
        {
            var q = _db.Set<TblInventarisKomputer>().AsNoTracking().AsQueryable();

            if (onlyActive)
                q = q.Where(i => i.Aktif);

            if (!string.IsNullOrWhiteSpace(kategori) && !kategori.Equals("ALL", StringComparison.OrdinalIgnoreCase))
                q = q.Where(i => i.KodeKategori == kategori);

            if (!string.IsNullOrWhiteSpace(kebun) && !kebun.Equals("ALL", StringComparison.OrdinalIgnoreCase))
                q = q.Where(i => i.KodeKebun == kebun);

            if (!string.IsNullOrWhiteSpace(kodePT) && !kodePT.Equals("ALL", StringComparison.OrdinalIgnoreCase))
                q = q.Where(i => i.KodePT == kodePT);

            if (!string.IsNullOrWhiteSpace(searchTerm))
                q = q.Where(i =>
                        i.KodeInventaris.Contains(searchTerm) ||
                        i.NamaBarang.Contains(searchTerm) ||
                        i.NoPO.Contains(searchTerm));

            // Limit to a reasonable number; remove Take() if you prefer all results
            return q.OrderBy(i => i.KodeInventaris).Take(500).ToList();
        }

        /// <summary>
        /// Look up a specific asset by its KodeInventaris.
        /// Returns null if nothing matches.
        /// </summary>
        public TblInventarisKomputer FindByKode(string kode)
        {
            if (string.IsNullOrWhiteSpace(kode)) return null;
            return _db.Set<TblInventarisKomputer>().AsNoTracking()
                      .FirstOrDefault(i => i.KodeInventaris == kode);
        }

        public void Dispose()
        {
            _db?.Dispose();
        }
    }
}
