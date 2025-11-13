using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportIT.Model
{
    public class User
    {
        #region properties

        public string USERID { get; set; }
        public string Password { get; set; }
        public string KodeBagian { get; set; }
        public bool Admin { get; set; }
        public bool Aktif { get; set; }

        #endregion

        #region Constructor

        public User(string UserId, string password, string kodebagian, bool Admin, bool Aktif)
        {
            this.USERID = UserId;
            this.Password = password;
            this.KodeBagian = kodebagian;
            this.Admin = Admin;
            this.Aktif = Aktif;
        }

        #endregion
    }
}
