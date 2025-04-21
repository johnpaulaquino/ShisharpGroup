using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using BrgyMs.backend.models.admin_model;
using BrgyMs.backend.models.secretary_model;
using BrgyMs.backend.utils;
using BrgyMs.database.connector;
using MySql.Data.MySqlClient;


namespace BrgyMs.backend.database.repositories {
    public class AdminRepository {
        private readonly MySqlConnection conn;
        private readonly AuthUtils authUtils = new AuthUtils();

        public AdminRepository() {
            conn = new Connector().getConnection();
        }
        public async Task InsertAdminUser(SecretaryUser admin) {

            /// <summary>
            /// Create a admin user and insert into database
            /// </summary>
            /// <param name="(Admin">is an admin object that created in model</param>
            /// <returns></returns>
            string stmt = "Insert into users (id, email,password, role) "
            + "Values (?,?,?,?)";
            try {
                using (var cmd = new MySqlCommand(stmt, conn)) {
                    cmd.Parameters.AddWithValue("id", admin.Id);
                    cmd.Parameters.AddWithValue("email", admin.Email);
                    cmd.Parameters.AddWithValue("password", authUtils.hashedPassword(admin.Password));
                    cmd.Parameters.AddWithValue("role", admin.Role.ToString());

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
            + "set password = ?, email = ? "
            + "Where id = ?";

            using (var cmd = new MySqlCommand(updateStmt, conn)) {
                cmd.Parameters.AddWithValue("password", authUtils.hashedPassword(admin.Password));
                cmd.Parameters.AddWithValue("email", admin.Email);
                cmd.Parameters.AddWithValue("id", Id["id"]);
                await cmd.ExecuteNonQueryAsync();

                Console.WriteLine("Successfully update information!");
            }
        }// end of updateADminInfo

        public async Task<DbDataReader> GetUserInformation() {
            String stmt = "Select u.id, u.email, u.role, u.status, "
            + "p.firstname, p.middlename, p.lastname, p.suffix, p.gender "
            + "From users u "
            + "Left Join personal_info p "
            + "On u.id = p.user_id "
            + "Where u.role IN ({placeholders}) AND u.status = ?";
            try {
                var cmd = new MySqlCommand(stmt, conn);
                cmd.Parameters.AddWithValue("u.role1", "secretary");
                cmd.Parameters.AddWithValue("u.role2", "user");
                cmd.Parameters.AddWithValue("u.status", "1");
                var reader = await cmd.ExecuteReaderAsync();

                return reader;
            }
            catch (System.Exception) {

                throw;
            }
        } // End of getUserInformation


    }
}