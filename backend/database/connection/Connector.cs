using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BMS.database.connector {
    public class Connector {
        private MySqlConnection conn;
        private String DB_URL;
        public Connector() {
            DB_URL = "Server=localhost;Database=BarangayMS" +
        ";User=root;Password=\"\";";
            conn = new(DB_URL);

        }

        public MySqlConnection getConnection() {
            if (conn == null) {
                conn = new MySqlConnection(DB_URL);

            }
            if (conn.State != ConnectionState.Open) {
                conn.Open();
            }
            return conn;
        }
    }
}