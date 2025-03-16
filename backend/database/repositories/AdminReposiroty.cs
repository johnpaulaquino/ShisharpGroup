using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BMS.database.connection;
using BMS.backend.models;
using MySql.Data.MySqlClient;

namespace BMS.backend.database.repositories {
    public class AdminReposiroty : ITRepository {
        private readonly MySqlConnection conn;
        public AdminReposiroty() {
            conn = new Connector().getConnection();
        }
    }
}