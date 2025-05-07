using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using BrgyMs.backend;
using MySql.Data.MySqlClient;

namespace BrgyMs.database.connector {
    public class Connector {
        private MySqlConnection conn;
        private string DB_URL;
        private Settings settings;
        public Connector() {
            settings = new Settings();
            DB_URL = $"Server={settings.DB_SERVER};User={settings.DB_USERNAME};" +
        $"Password={settings.DB_PASSWORD};database={settings.DB_NAME};Port={settings.DB_PORT}";
            conn = new MySqlConnection(DB_URL);
        }

        public async Task<MySqlConnection> getConnection() {
            var connection = new MySqlConnection(DB_URL);
            await connection.OpenAsync();
            return connection;
        } 

    }
}