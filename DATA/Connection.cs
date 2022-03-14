using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DATA {
    public class Connection {
        // Clase para crear la conexion al servidor de base de datos 
        // MYSQL > puerto 3306
        // SQL SERVER > 1433

        // HOST 
        // Name user
        // password
        // Name of base of data

        static string host = "127.0.0.1";
        static string username = "root";
        static string password = "ubuntu20-";
        static string database = "sifavi";

        //Para trabajar con mysql necesitamos los dll mysql.data

        //Para trabajar con SQL server, SYSTEM.DATA

        static string conn = $"datasource={host};username={username};" +
            $"password={password};database={database};";

        
       public MySqlConnection Connect = new MySqlConnection(conn);

    }
}
