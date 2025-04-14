using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using BrgyMs.backend.variables;
using MySql.Data.MySqlClient;

namespace BrgyMs.database.connector {
    public class Connector {
        private MySqlConnection conn;
        private string DB_URL;
        private Settings settings;
        public Connector() {
            settings = new Settings();
            DB_URL = $"Server=192.168.7.43;Port=3306;Database={settings.DB_NAME}" +
        ";User=remote_user;Password=1084;";
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