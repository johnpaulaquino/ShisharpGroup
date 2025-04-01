using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using BMS.backend;
using MySql.Data.MySqlClient;

namespace BMS.database.connector {
    public class Connector {
        private MySqlConnection conn;
        private string DB_URL;
        private Settings settings;
        public Connector() {
            settings = new Settings();
            DB_URL = $"Server=localhost;Database={settings.DB_NAME}" +
        ";User=root;Password=\"\";";
            conn = new MySqlConnection(DB_URL);

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