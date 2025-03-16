using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

using BMS.database.connector;
using BMS.backend.models;

namespace BMS.database.respositories {
    public class UserRepository {
        private readonly MySqlConnection conn;
        public UserRepository() {
            conn = new Connector().getConnection();
        }



    }


}