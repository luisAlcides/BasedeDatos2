using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA {
    public class UserData {
        
        // CRUD for the entity user
        Connection connection = new Connection();

        public string AddUser(string user, string password) {
            connection.Connect.Open(); // OPEN CONNECTION

            MySqlCommand command = new MySqlCommand("pa_agregarusuario", connection.Connect);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@pusuario", user);
            command.Parameters.AddWithValue("@pcontrasenia", password);

            command.Parameters.Add("@pmensaje", MySqlDbType.VarChar, 100);
            command.Parameters["@pmensaje"].Direction = ParameterDirection.Output;

            try {
                command.ExecuteNonQuery();
                string message = Convert.ToString(command.Parameters["@pmensaje"].Value);
                return message;
            } catch (Exception ex) {
                return ex.ToString();
            } finally { 
                connection.Connect.Close();
            }
        }

    }
}
