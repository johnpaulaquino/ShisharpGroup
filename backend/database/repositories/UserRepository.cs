using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

using BMS.database.connection;
using BMS.backend.models;

namespace BMS.database.respositories {
    public class UserRepository {
        private MySqlConnection conn;
        public UserRepository() {
            conn = new Connector().getConnection();

        }

    }


}