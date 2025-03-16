using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BMS.database.connection;
using BMS.backend.utils;
using BMS.backend.models;
using MySql.Data.MySqlClient;

namespace BMS.backend.database.repositories {
    public class ITRepository {
        private readonly MySqlConnection conn;
        private readonly AuthUtils authUtils = new AuthUtils();

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
                using var cmd = new MySqlCommand(stmt, conn);
                cmd.Parameters.AddWithValue("id", admin.id);
                cmd.Parameters.AddWithValue("username", admin.username);
                cmd.Parameters.AddWithValue("email", admin.email);
                cmd.Parameters.AddWithValue("password", authUtils.hashedPassword(admin.password));
                cmd.Parameters.AddWithValue("role", admin.role.ToString());

                int row = cmd.ExecuteNonQuery();

                if (row < 0) {
                    Console.WriteLine("Failed to insert data!");
                }
                Console.WriteLine("Successfully insert data!");

            }

            catch (MySqlException e) {
                throw new Exception(e.Message);
            }
        } // End of the funtion insert admin

        public void deleteAdminUser(string email) {
            Dictionary<string, string> data = getInfoByEmail(email);
            if (data.Count < 0) {
                throw new Exception("Can't delete this, because user not found!");
            }
            string deleteStmt = "Delete from admin_users "
            + "Where id = ?";
            using var cmd = new MySqlCommand(deleteStmt, conn);
            cmd.Parameters.AddWithValue("id", data["id"]);

            cmd.ExecuteNonQuery();
            Console.WriteLine("Successully deleted admin user");

        }// End of delett function

        public void updateAdminInfo(AdminUser admin, string email) {
            string updateStmt = "Update admin_users "
            + "set username = ?, password = ?, email = ? "
            + "Where id = ?";
            Dictionary<string, string> id = getInfoByEmail(email);

            if (id.Count == 0) {
                throw new Exception("No user found!");
            }

            using (var cmd = new MySqlCommand(updateStmt, conn)) {
                cmd.Parameters.AddWithValue("username", admin.username);
                cmd.Parameters.AddWithValue("password", authUtils.hashedPassword(admin.password));
                cmd.Parameters.AddWithValue("email", admin.email);
                cmd.Parameters.AddWithValue("id", id["id"]);
                cmd.ExecuteNonQuery();

                Console.WriteLine("Successfully update information");
            }
        }
        public Dictionary<string, string> getInfoByEmail(string email) {
            Dictionary<string, string> data = new Dictionary<string, string>();
            string selectStmt = "Select * from admin_users "
            + "Where email = ?";
            try {
                using var cmd = new MySqlCommand(selectStmt, conn);
                cmd.Parameters.AddWithValue("email", email);
                using var reader = cmd.ExecuteReader();
                if (reader.Read()) {
                    data.Add("id", reader.GetString("id"));
                    data.Add("password", reader.GetString("password"));
                    data.Add("role", reader.GetString("role"));
                }
            }
            catch (MySqlException e) {

                Console.WriteLine(e.Message);
            }
            return data;
        }
    }
}