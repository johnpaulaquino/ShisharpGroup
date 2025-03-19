using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BMS.database.connector;
using BMS.backend.utils;
using BMS.backend.models.admin_model;
using MySql.Data.MySqlClient;

namespace BMS.backend.database.repositories {
    public class ITRepository {
        private readonly MySqlConnection conn;
        private readonly AuthUtils authUtils = new AuthUtils();

        public ITRepository() {
            conn = new Connector().getConnection();
        }
        public async Task InsertAdminUser(AdminUser admin) {

            /// <summary>
            /// Create a admin user and insert into database
            /// </summary>
            /// <param name="(Admin">is an admin object that created in model</param>
            /// <returns></returns>
            string stmt = "Insert into admin_users (id, username, email,password, role) "
            + "Values (?,?,?,?,?)";
            try {
                using (var cmd = new MySqlCommand(stmt, conn)) {
                    cmd.Parameters.AddWithValue("id", admin.id);
                    cmd.Parameters.AddWithValue("username", admin.username);
                    cmd.Parameters.AddWithValue("email", admin.email);
                    cmd.Parameters.AddWithValue("password", authUtils.hashedPassword(admin.password));
                    cmd.Parameters.AddWithValue("role", admin.role.ToString());

                    int row = await cmd.ExecuteNonQueryAsync();

                    if (row < 0) {
                        Console.WriteLine(" Failed to insert data!");
                    }
                    Console.WriteLine("Successfully insert data!");

                }
            }


            catch (MySqlException e) {
                throw new Exception(e.Message);
            }
        } // End of the funtion insert admin


        public async Task UpdateAdminInfo(Dictionary<string, string> Id, AdminUser admin) {
            string updateStmt = "Update admin_users "
            + "set username = ?, password = ?, email = ? "
            + "Where id = ?";

            using (var cmd = new MySqlCommand(updateStmt, conn)) {
                cmd.Parameters.AddWithValue("username", admin.username);
                cmd.Parameters.AddWithValue("password", authUtils.hashedPassword(admin.password));
                cmd.Parameters.AddWithValue("email", admin.email);
                cmd.Parameters.AddWithValue("id", Id["id"]);
                await cmd.ExecuteNonQueryAsync();

                Console.WriteLine("Successfully update information!");
            }
        }
        public async Task<Dictionary<string, string>> GetInfoByEmail(string email) {
            Dictionary<string, string> data = new Dictionary<string, string>();
            string selectStmt = "Select * from admin_users "
            + "Where email = ?";
            try {
                using var cmd = new MySqlCommand(selectStmt, conn);
                cmd.Parameters.AddWithValue("email", email);
                using var reader = await cmd.ExecuteReaderAsync();
                if (reader.Read()) {
                    data.Add("id", reader.GetString(0));
                    data.Add("username", reader.GetString(2));
                    data.Add("role", reader.GetString(4));
                }
            }
            catch (MySqlException e) {

                Console.WriteLine(e.Message);
            }
            return data;
        }// end of getInfo function

        public async Task<Dictionary<string, string>> GetInfoById(string id) {
            string stmt = "Select * from admin_users " +
            "Where id = ?";
            Dictionary<string, string> Data = new Dictionary<string, string>();
            try {
                using (var cmd = new MySqlCommand(stmt, conn)) {
                    cmd.Parameters.AddWithValue("id", id);
                    using (var reader = await cmd.ExecuteReaderAsync()) {
                        if (reader.Read()) {
                            Data.Add("id", reader.GetString(0));
                            Data.Add("username", reader.GetString(1));
                            Data.Add("role", reader.GetString(4));
                        }
                    }
                }
                return Data;
            }
            catch (System.Exception) {

                throw;
            }
        }// end of the GetInfoById function
    }
}