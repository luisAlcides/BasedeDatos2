using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA {
    public class UpdateData {
        Connection connection = new Connection();

        public string UpdateUser(int idUser, string user, string password, string status) {
            connection.Connect.Open();

            MySqlCommand command = new MySqlCommand("pa_actualizarUsuario", connection.Connect);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@pidusuario", idUser);
            command.Parameters.AddWithValue("@pusuario", user);
            command.Parameters.AddWithValue("@pcontrasenia", password);
            command.Parameters.AddWithValue("@pestado", status);

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
