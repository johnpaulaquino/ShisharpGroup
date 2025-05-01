using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using BrgyMs.backend.models.admin_model;
using BrgyMs.backend.models.base_model;
using BrgyMs.backend.models.secretary_model;
using BrgyMs.backend.utils;
using BrgyMs.database.connector;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using MySqlX.XDevAPI.Relational;


namespace BrgyMs.backend.database.repositories {
    public class AdminRepository : BaseRepository {
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
        public async Task<MySqlDataAdapter> GetUserInformation(int limit) {

            string stmt = @"Select u.id as 'ID', u.email as 'Email', u.username as 'Username', Concat(UPPER(Left(u.role, 1)), LOWER(SUBSTRING(u.role FROM 2))) as 'Role', "
            + "CONCAT_WS(' ', p.firstname, (CASE WHEN p.middlename IS NULL OR p.middlename = '' THEN NULL ELSE  CONCAT(LEFT(p.middlename, 1), '.') END)  " +
            ", p.lastname, NULLIF(p.suffix, '') ) as 'Fullname', p.gender as 'Gender', " +
            "ai.birth_day as 'Birthday', ai.age as 'Age', ai.contact_number as 'Contact No' "
            + "From users u "
            + "Left Join personal_info p "
            + "On u.id = p.user_id "
            + "Left join additional_info ai " +
            "ON u.id = ai.user_id "
            + "Where u.role IN(@role1, @role2) AND u.status = @status " +
            "Limit @limit";
            try {
                var connection = await conn.getConnection();
                var adapter = new MySqlDataAdapter(stmt, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@role1", "secretary");
                adapter.SelectCommand.Parameters.AddWithValue("@role2", "users");
                adapter.SelectCommand.Parameters.AddWithValue("@status", "1");
                adapter.SelectCommand.Parameters.AddWithValue("@limit", limit);
                return adapter;

            }
            catch (System.Exception e) {

                throw;
            }
        } // End of getUserInformation


        //Use for searching
        public async Task<MySqlDataAdapter> GetUserInformation(int limit, string keyword) {
            string stmt = @"Select u.id as 'ID', u.email as 'Email', u.username as 'Username', Concat(UPPER(Left(u.role, 1)), LOWER(SUBSTRING(u.role FROM 2))) as 'Role', "
            + "CONCAT_WS(' ', p.firstname, (CASE WHEN p.middlename IS NULL OR p.middlename = '' THEN NULL ELSE  CONCAT(LEFT(p.middlename, 1), '.') END)  " +
            ", p.lastname, NULLIF(p.suffix, '') ) as 'Fullname', p.gender as 'Gender', " +
            "ai.birth_day as 'Birthday', ai.age as 'Age', ai.contact_number as 'Contact No' "
            + "From users u "
            + "Left Join personal_info p "
            + "On u.id = p.user_id "
            + "Left join additional_info ai " +
            "ON u.id = ai.user_id "
            + "Where u.role IN(@role1, @role2) AND u.status = @status  AND " +
             "(p.firstname Like @keyword OR p.lastname Like @keyword) Limit @limit";


            try {
                var connection = await conn.getConnection();
                var cmd = new MySqlDataAdapter(stmt, connection);
                cmd.SelectCommand.Parameters.AddWithValue("@role1", "users");
                cmd.SelectCommand.Parameters.AddWithValue("@role2", "secretary");
                cmd.SelectCommand.Parameters.AddWithValue("@status", "1");
                cmd.SelectCommand.Parameters.AddWithValue("@keyword", $"%{keyword}%");
                cmd.SelectCommand.Parameters.AddWithValue("@limit", limit);
                return cmd;

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

        /// <summary>
        /// Get logs froms all users
        /// </summary>
        /// <param name="limit">to limit the number of records to return</param>
        /// 
        /// <returns> MysqlAdapter taht will use later for the filling the table</returns>
        public async Task<MySqlDataAdapter> GetAllUsersLogs(int limit) {
            string stmt = "SELECT la.id as 'ID', la.user_id as 'User ID', u.username as 'Username', CONCAT(UPPER(LEFT(u.role, 1)),LOWER(SUBSTRING(u.role FROM 2))) as 'Role', " +
                "la.actions_made as 'Actions Made' ,la.details as 'Description', DATE_FORMAT(la.date_performed, '%W, %M %d, %Y %r' ) as 'Date Performed' " +
                "FROM users u " +
                "Right join action_logs la " +
                "ON u.id = la.user_id " +
                "ORDER by la.date_performed ASC LIMIT @limit ";

            try {
                var connection = await conn.getConnection();
                var adapter = new MySqlDataAdapter(stmt, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@limit", limit);

                return adapter;

            }
            catch (Exception) {
                throw;
            }
        } // End of function

        /// <summary>
        /// Use to get all the users for verification
        /// </summary>
        /// <returns></returns>
        public async Task<MySqlDataAdapter> GetInActiveResidentUser() {
            string stmt = @"Select u.id as 'ID', u.email as 'Email', CONCAT_WS(' ', p.firstname, (CASE WHEN p.middlename " +
                " IS NULL OR p.middlename = '' " +
                " THEN NULL ELSE  CONCAT(LEFT(p.middlename, 1), '.') END), " +
                " p.lastname, NULLIF(p.suffix, '') ) as 'Fullname', " +
                "p.gender as 'Gender', CONCAT_WS(', ', ad.house_number, ad.street, " +
                "IFNULL(ad.lot_number, ''), IFNULL(ad.block_number, ''), IFNULL(ad.subdivision, '')) as 'Address' " +
                "FROM users u " +
                "LEFT join personal_info p " +
                "On u.id = p.user_id " +
                "LEFT JOIN address ad " +
                "ON u.id = ad.user_id " +
                "WHERE u.status = @status LIMIT @limit";

            var connection = await conn.getConnection();
            var adapter = new MySqlDataAdapter(stmt, connection);
            adapter.SelectCommand.Parameters.AddWithValue("@status", "0");
            adapter.SelectCommand.Parameters.AddWithValue("@limit", 15);

            return adapter;
        }

        //Get the total resident of the barangay
        public async Task<DbDataReader> TotalResidentPopulation() {
            string stmt = "Select count(id) as total From users WHERE role = @role ";
            try {
                var connection = await conn.getConnection();
                var cmd = new MySqlCommand(stmt, connection);
                cmd.Parameters.AddWithValue("@role", "users");
                return await cmd.ExecuteReaderAsync();
            }
            catch (Exception) {
                throw;
            }
        }// end of function


        //Get the total households
        public async Task<DbDataReader> TotalHouseHolds() {
            string stmt = "Select count(u.id) as total " +
                "From users u " +
                "INNER JOIN address a " +
                "ON u.id = a.user_id " +
                "WHERE u.role = @role AND u.status = @status " +
                "GROUP BY a.house_number";
            try {
                var connection = await conn.getConnection();
                var cmd = new MySqlCommand(stmt, connection);
                cmd.Parameters.AddWithValue("@role", "users");
                cmd.Parameters.AddWithValue("@status", "1");
                return await cmd.ExecuteReaderAsync();
            }
            catch (Exception) {
                throw;
            }
        }// end of function


        //Get the total blotter in brangay
        public async Task<DbDataReader> TotalBlotter() {
            string stmt = "Select count(id) as total " +
                "From blotters";
            try {
                var connection = await conn.getConnection();
                var cmd = new MySqlCommand(stmt, connection);
                return await cmd.ExecuteReaderAsync();
            }
            catch (Exception) {
                throw;
            }
        }// end of function

    }
}