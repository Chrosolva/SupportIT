using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Master.Master;
using SupportIT.Model;

namespace SupportIT.Controller
{
    public class ControllerUser
    {
        #region properties

        public User objUser;
        public string query;
        public ClsCryptoRijndael objcrypto;
        public DBConnectionClass objConnection;

        #endregion

        #region Function

        public bool login(string UserID, string Password) {
            query = "Select * From Legal.TblUser where USERID = '" + UserID + "'";
            DataTable dt;
            dt = objConnection.objsqlconnection.Filldatatable(query);

            if(dt!= null)
            {
                foreach (DataRow x in dt.Rows)
                {
                    objUser = new User(x["USERID"].ToString(), x["Password"].ToString(), x["KodeBagian"].ToString(), Convert.ToBoolean(x["Admin"]), Convert.ToBoolean(x["Aktif"]));
                }

                if (Password == objUser.Password)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        #endregion

        #region Constructor

        public ControllerUser(string database, string server)
        {
            this.objConnection = new DBConnectionClass(database, server);
        }

        #endregion
    }
}
