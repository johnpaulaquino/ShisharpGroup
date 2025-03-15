using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

using BackEnd.database.connection;
using CSharpBackEnd.backend.models;

namespace BackEnd.database.respositories {
    public class UserRepository {
        private MySqlConnection conn;
        public UserRepository() {
            this.conn = new Connector().getConnection();

        }

    }


}