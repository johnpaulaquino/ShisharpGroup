using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BrgyMs.database.connector;
using BrgyMs.backend.utils;
using BrgyMs.backend.models.admin_model;
using MySql.Data.MySqlClient;
using BrgyMs.backend.models.secretary_model;

namespace BrgyMs.backend.database.repositories {
    public class SecretaryRepository {
        private readonly MySqlConnection conn;
        private readonly AuthUtils authUtils = new AuthUtils();

        public SecretaryRepository() {
            conn = new Connector().getConnection();
        }
        public async Task InsertSecretaryUser(SecretaryUser _Secretary) {

            /// <summary>
            /// Create a admin user and insert into database
            /// </summary>
            /// <param name="(Admin">is an admin object that created in model</param>
            /// <returns></returns>
            string stmt = "Insert into users (id, email,password, role,status) "
            + "Values (?,?,?,?,?)";
            try {
                using (var cmd = new MySqlCommand(stmt, conn)) {
                    cmd.Parameters.AddWithValue("id", _Secretary.Id);
                    cmd.Parameters.AddWithValue("email", _Secretary.Email);
                    cmd.Parameters.AddWithValue("password", authUtils.hashedPassword(_Secretary.Password));
                    cmd.Parameters.AddWithValue("role", _Secretary.Role.ToString());
                    cmd.Parameters.AddWithValue("status", _Secretary.Status);

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


        public async Task UpdateSecretaryInfo(Dictionary<string, string> Id, SecretaryUser _Secretary) {
            string updateStmt = "Update users "
            + "set password = ?, email = ? "
            + "Where id = ?";

            using (var cmd = new MySqlCommand(updateStmt, conn)) {
                cmd.Parameters.AddWithValue("password", authUtils.hashedPassword(_Secretary.Password));
                cmd.Parameters.AddWithValue("email", _Secretary.Email);
                cmd.Parameters.AddWithValue("id", Id["id"]);
                await cmd.ExecuteNonQueryAsync();

                Console.WriteLine("Successfully update information!");
            }
        }
    }
}