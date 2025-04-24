using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using BrgyMs.backend.models.admin_model;
using BrgyMs.backend.models.base_model;
using BrgyMs.backend.models.secretary_model;
using BrgyMs.backend.utils;
using BrgyMs.database.connector;
using BrgyMS.backend.database.connection.models;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;


namespace BrgyMs.backend.database.repositories {
    public class AdminRepository {
        private Connector conn;
        private readonly AuthUtils authUtils = new AuthUtils();

        public AdminRepository() {
            conn = new Connector();
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
                using var connection = await conn.getConnection();
                using (var cmd = new MySqlCommand(stmt, connection)) {
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


            catch (System.Exception e) {
                throw;
            }
        } // End of the funtion insert admin


        public async Task UpdateAdminInfo(Dictionary<string, string> Id, AdminUser admin) {
            string updateStmt = "Update admin_users "
            + "set password = ?, email = ? "
            + "Where id = ?";
            using var connection = await conn.getConnection();
            using (var cmd = new MySqlCommand(updateStmt, connection)) {
                cmd.Parameters.AddWithValue("password", authUtils.hashedPassword(admin.Password));
                cmd.Parameters.AddWithValue("email", admin.Email);
                cmd.Parameters.AddWithValue("id", Id["id"]);
                await cmd.ExecuteNonQueryAsync();

                Console.WriteLine("Successfully update information!");
            }
        }// end of updateADminInfo


        // to set data in table in admin dashboard
        public async Task<List<GetUserInformationResult>> GetUserInformation(int limit) {
            string stmt = "Select u.id, u.email, u.status, u.role, "
            + "p.firstname, p.middlename, p.lastname, p.suffix, p.gender, " +
            "ai.resident_type, ai.birth_day,ai.age, ai.contact_number "
            + "From users u "
            + "Left Join personal_info p "
            + "On u.id = p.user_id "
            + "Left join additional_info ai " +
            "ON u.id = ai.user_id "
            + "Where u.role IN(@role1, @role2) AND u.status = @status " +
            "Limit @limit";
            List<GetUserInformationResult> userInfo = new List<GetUserInformationResult>();
            try {
                using (var connection = await conn.getConnection()) {
                    using (var cmd = new MySqlCommand(stmt, connection)) {
                        cmd.Parameters.AddWithValue("@role1", "secretary");
                        cmd.Parameters.AddWithValue("@role2", "users");
                        cmd.Parameters.AddWithValue("@status", "1");
                        cmd.Parameters.AddWithValue("@limit", limit);
                        using (var dataReader = await cmd.ExecuteReaderAsync()) {

                            while ( dataReader.Read()) {
                                //Get the firstname, middlename, lastname and the suffix
                                string fName = (string)dataReader["firstname"];
                                string? mName = (string)dataReader["middlename"];
                                string lName = (string)dataReader["lastname"];
                                string? suffix = (string)dataReader["suffix"];

                                userInfo.Add(new GetUserInformationResult()
                                {
                                    Id = (string)dataReader["id"],
                                    Email = (string)dataReader["email"],
                                    Role = dataReader.GetString(dataReader.GetOrdinal("role")),
                                    Firstname = fName,
                                    Middelanme = mName,
                                    Lastname = lName,
                                    Suffix = suffix,
                                    Gender = (string)dataReader["gender"],
                                    BirthDate = (DateTime)dataReader["birth_day"],
                                    Age = (int)dataReader["age"],
                                    ContactNo = (string)dataReader["contact_number"],
                                    ResidentType = (string)dataReader["resident_type"]
                                });
                            }
                            return userInfo;
                        }
                    }
                }
            }
            catch (System.Exception e) {

                throw;
            }
        } // End of getUserInformation


        public async Task<DbDataReader> GetUserInformation(int limit, string keyword) {
            string stmt = "Select DISTINCT  u.id, u.email, u.status, u.role, "
            + "p.firstname, p.middlename, p.lastname, p.suffix, p.gender, " +
            "ai.resident_type, ai.birth_day,ai.age, ai.contact_number "
            + "From users u "
            + "Left Join personal_info p "
            + "On u.id = p.user_id "
            + "Left join additional_info ai " +
            "ON u.id = ai.user_id "
            + "Where u.role IN (@role1, @role2) AND u.status = @status AND " +
            "(firstname Like @keyword OR lastname Like @keyword) Limit @limit";

            try {
                var connection = await conn.getConnection();
                var cmd = new MySqlCommand(stmt, connection);
                cmd.Parameters.AddWithValue("@role1", "users");
                cmd.Parameters.AddWithValue("@role2", "secretary");
                cmd.Parameters.AddWithValue("@status", "1");
                cmd.Parameters.AddWithValue("@keyword", $"%{keyword}%");
                cmd.Parameters.AddWithValue("@limit", limit);
                var dataReader = await cmd.ExecuteReaderAsync();
                return dataReader;

            }
            catch (System.Exception e) {

                throw;
            }
        } // End of getUserInformation

        public async Task<int> getTotalNUmberOfUsers() {
            int total = 0;
            string stmt = "SeLECT count(id) as total from users " +
                "where role IN (@role1, @role2) AND " +
                "status = @status ";

            try {
                using (var connection = await conn.getConnection()) {
                    using var cmd = new MySqlCommand(stmt, connection);
                    cmd.Parameters.AddWithValue("@role1", "secretary");
                    cmd.Parameters.AddWithValue("@role2", "users");
                    cmd.Parameters.AddWithValue("@status", "1");
                    using var reader = await cmd.ExecuteReaderAsync();
                    if (await reader.ReadAsync()) {
                        total = reader.GetInt32("total");
                    }
                    return total;
                }
            }
            catch (Exception e) {
                throw;
            }
        }


    }
}