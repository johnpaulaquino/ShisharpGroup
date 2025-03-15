using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackEnd.database.connection;
using CSharpBackEnd.backend.models;
using MySql.Data.MySqlClient;

namespace CSharpBackEnd.backend.database.repositories {
    public class ITRepository {
        private MySqlConnection conn;

        public ITRepository() {
            this.conn = new Connector().getConnection();
        }
        public void insertAdminUser(AdminUser admin) {

            /// <summary>
            /// Create a admin user and insert into database
            /// </summary>
            /// <param name="(Admin">is an admin object that created in model</param>
            /// <returns></returns>
            string stmt = "Insert into admin_users (id, username, email,password, role) "
            + "Values (?,?,?,?,?)";
            try {
                using (var cmd = new MySqlCommand(stmt, this.conn)) {
                    cmd.Parameters.AddWithValue("id", admin.id);
                    cmd.Parameters.AddWithValue("username", admin.username);
                    cmd.Parameters.AddWithValue("email", admin.email);
                    cmd.Parameters.AddWithValue("password", admin.password);
                    cmd.Parameters.AddWithValue("role", admin.role.ToString());

                    int row = cmd.ExecuteNonQuery();

                    if (row < 0) {
                        Console.WriteLine("Failed to insert data!");
                    }

                }
            }
            catch (MySqlException e) {
                throw new Exception(e.Message);
            }
        } // End of the funtion insert admin

    }
}