using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackEnd.database.connection;
using CSharpBackEnd.backend.models;
using MySql.Data.MySqlClient;

namespace CSharpBackEnd.backend.database.repositories {
    public class AdminReposiroty {
        private MySqlConnection conn;
        public AdminReposiroty() {
            this.conn = new Connector().getConnection();
        }

        public Dictionary<string, string> getUser(string username) {
            Dictionary<string, string> data = new Dictionary<string, string>();
            string stmt = "Select * from students WHERE student_id = ?";
            try {
                using (MySqlCommand cmd = new MySqlCommand(stmt, this.conn)) {
                    cmd.Parameters.AddWithValue("student_id", username);
                    using (var reader = cmd.ExecuteReader()) {
                        if (reader.Read()) {
                            data.Add("id", reader.GetString("id"));
                            data.Add("student_id", reader.GetString("student_id"));
                        }
                    }
                }

            }
            catch (System.Exception) {

                throw;
            }

            return data;
        }// End ot the getUser function


    }
}