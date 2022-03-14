using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC {
    public class LogicalDelete {
        DATA.DeleteData deletedata = new DATA.DeleteData();

        public string deleteUser(int idUser) {
            return deletedata.DeleteUser(idUser);
        }

    }
}
