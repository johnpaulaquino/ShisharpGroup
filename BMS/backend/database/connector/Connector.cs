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
            conn = new MySqlConnection(DB_URL);

        }

        public MySqlConnection getConnection() {
            if (this.conn == null) {
                this.conn = new MySqlConnection(this.DB_URL);

            }
            if (this.conn.State != ConnectionState.Open) {
                this.conn.Open();
            }

            return this.conn;
        }
    }
}