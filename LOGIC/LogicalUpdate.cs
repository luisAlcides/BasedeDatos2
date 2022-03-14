using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC {
    public class LogicalUpdate {

        DATA.UpdateData updatedata = new DATA.UpdateData();

        public string LogicalUpdateUser(int iduser, string user, string password, string status) {
            return updatedata.UpdateUser(iduser, user, password, status);
        }

    }
}
