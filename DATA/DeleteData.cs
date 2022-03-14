using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA {
    public class DeleteData {

        Connection connection = new Connection();   

        public string DeleteUser(int idUser) {
            connection.Connect.Open();

            MySqlCommand command = new MySqlCommand("pa_eliminarUsuario", connection.Connect);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@pidusuario", idUser);

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
