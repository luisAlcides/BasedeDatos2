using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC {
    public class LogicalUser {

        DATA.UserData userdata = new DATA.UserData();

        public string LogicalAddUser(string username, string password) { 
            return userdata.AddUser(username, password);
        }
    }
}
