using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using BrgyMs.backend.models.admin_model;
using BrgyMs.backend.models.base_model;
using BrgyMs.backend.models.bo_model;
using BrgyMs.backend.models.secretary_model;
using BrgyMs.backend.utils;
using BrgyMs.database.connector;
using BrgyMS.backend.models;
using BrgyMS.backend.models.base_model;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using Mysqlx.Sql;
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
                using (var connection = await conn.getConnection()) {
                    using (var cmd = new MySqlCommand(stmt, connection)) {
                        cmd.Parameters.AddWithValue("id", admin.Id);
                        cmd.Parameters.AddWithValue("email", admin.Email);
                        cmd.Parameters.AddWithValue("password", authUtils.HashedPassword(admin.Password));
                        cmd.Parameters.AddWithValue("role", admin.Role.ToString());

                        int row = await cmd.ExecuteNonQueryAsync();

                        if (row < 0) {
                            Console.WriteLine(" Failed to insert data!");
                        }
                        Console.WriteLine("Successfully insert data!");
                    }

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
            using (var connection = await conn.getConnection()) {
                using (var cmd = new MySqlCommand(updateStmt, connection)) {
                    cmd.Parameters.AddWithValue("password", authUtils.HashedPassword(admin.Password));
                    cmd.Parameters.AddWithValue("email", admin.Email);
                    cmd.Parameters.AddWithValue("id", Id["id"]);
                    await cmd.ExecuteNonQueryAsync();

                    Console.WriteLine("Successfully update information!");
                }
            }// end of updateADminInfo
        }



        //this will get the total records for User information, to use in offset
        public async Task<int> GetTotalCountForUserAccount() {
            string stmt = "Select count(id) as total FROM users " +
                "WHERE role IN(@role1, @role2) AND status = @status";


            try {
                using (var connection = await conn.getConnection()) {
                    using (var cmd = new MySqlCommand(stmt, connection)) {

                        cmd.Parameters.AddWithValue("@role1", "secretary");
                        cmd.Parameters.AddWithValue("@role2", "users");
                        cmd.Parameters.AddWithValue("@status", "1");
                        using (var reader = await cmd.ExecuteReaderAsync()) {
                            if (await reader.ReadAsync()) {
                                return reader.GetInt32(reader.GetOrdinal("total"));
                            }
                        }
                        return 0;
                    }
                }
            }
            catch (Exception) {
                throw;
            }
        }

        // to set data in table in admin dashboard
        public async Task<DataTable> GetUserInformation1() {

            string stmt = @"Select u.id as 'ID', u.email as 'Email', u.username as 'Username', Concat(UPPER(Left(u.role, 1)), LOWER(SUBSTRING(u.role FROM 2))) as 'Role', "
            + "CONCAT_WS(' ', p.firstname, (CASE WHEN p.middlename IS NULL OR p.middlename = '' THEN NULL ELSE  CONCAT(LEFT(p.middlename, 1), '.') END)  " +
            ", p.lastname, NULLIF(p.suffix, '') ) as 'Fullname', p.gender as 'Gender', " +
            "ai.birth_day as 'Birthday', ai.age as 'Age', ai.contact_number as 'Contact No' "
            + "From users u "
            + "Left Join personal_info p "
            + "On u.id = p.user_id "
            + "Left join additional_info ai " +
            "ON u.id = ai.user_id "
            + "Where u.role IN(@role1, @role2) AND u.status = @status ";
            try {
                DataTable dt = new DataTable();
                using (var connection = await conn.getConnection()) {
                    using (var adapter = new MySqlDataAdapter(stmt, connection)) {
                        adapter.SelectCommand.Parameters.AddWithValue("@role1", "secretary");
                        adapter.SelectCommand.Parameters.AddWithValue("@role2", "users");
                        adapter.SelectCommand.Parameters.AddWithValue("@status", "1");

                        await adapter.FillAsync(dt);
                        return dt;
                    }
                }

            }
            catch (System.Exception e) {

                throw;
            }
        } // End of getUserInformation

        // to set data in table in blotterDashboard but wihtout limit
        public async Task<DataTable> GetUserInformation() {
            string stmt = @"Select u.id as 'ID', u.email as 'Email', u.username as 'Username', Concat(UPPER(Left(u.role, 1)), LOWER(SUBSTRING(u.role FROM 2))) as 'Role', "
            + "CONCAT_WS(' ', p.firstname, (CASE WHEN p.middlename IS NULL OR p.middlename = '' THEN NULL ELSE  CONCAT(LEFT(p.middlename, 1), '.') END)  " +
            ", p.lastname, NULLIF(p.suffix, '') ) as 'Fullname', p.gender as 'Gender', " +
            "ai.birth_day as 'Birthday', ai.age as 'Age', ai.contact_number as 'Contact No' "
            + "From users u "
            + "Left Join personal_info p "
            + "On u.id = p.user_id "
            + "Left join additional_info ai " +
            "ON u.id = ai.user_id "
            + "Where u.role = @role2 AND u.status = @status ";
            try {
                DataTable dt = new DataTable();
                using (var connection = await conn.getConnection()) {
                    using (var adapter = new MySqlDataAdapter(stmt, connection)) {
                        adapter.SelectCommand.Parameters.AddWithValue("@role2", "users");
                        adapter.SelectCommand.Parameters.AddWithValue("@status", "1");

                        await adapter.FillAsync(dt);
                        return dt;
                    }
                }

            }
            catch (System.Exception e) {

                throw;
            }
        } // End of getUserInformation


        //Use for searching
        public async Task<MySqlDataAdapter> GetUserInformation(string keyword) {
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
             "(p.firstname Like @keyword OR p.lastname Like @keyword)";


            try {
                var connection = await conn.getConnection();
                var cmd = new MySqlDataAdapter(stmt, connection);
                cmd.SelectCommand.Parameters.AddWithValue("@role1", "users");
                cmd.SelectCommand.Parameters.AddWithValue("@role2", "secretary");
                cmd.SelectCommand.Parameters.AddWithValue("@status", "1");
                cmd.SelectCommand.Parameters.AddWithValue("@keyword", $"%{keyword}%");

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
                    using (var cmd = new MySqlCommand(stmt, connection)) {

                        cmd.Parameters.AddWithValue("@role1", "secretary");
                        cmd.Parameters.AddWithValue("@role2", "users");
                        cmd.Parameters.AddWithValue("@status", "1");
                        using (var reader = await cmd.ExecuteReaderAsync()) {
                            if (await reader.ReadAsync()) {
                                total = reader.GetInt32(reader.GetOrdinal("total"));
                            }
                            return total;
                        }

                    }
                }
            }
            catch (Exception e) {
                throw;
            }
        }



        //get the total records
        public async Task<int> GetTotalRecordsInLogs() {
            int total = 0;
            string stmt = "SElecT count(id) as total FROM action_logs ";

            using (var connection = await conn.getConnection()) {
                using (var cmd = new MySqlCommand(stmt, connection)) {
                    using (var reader = await cmd.ExecuteReaderAsync()) {
                        if (await reader.ReadAsync()) {
                            return reader.GetInt32(reader.GetOrdinal("total"));
                        }
                    }
                    return 0;
                }
            }
        }

        /// <summary>
        /// Get logs froms all users
        /// </summary>
        /// <param name="limit">to limit the number of records to return</param>
        /// 
        /// <returns> MysqlAdapter taht will use later for the filling the table</returns>
        public async Task<MySqlDataAdapter> GetAllUsersLogs() {
            string stmt = "SELECT la.id as 'ID', la.user_id as 'User ID', u.username as 'Username', CONCAT(UPPER(LEFT(u.role, 1)),LOWER(SUBSTRING(u.role FROM 2))) as 'Role', " +
                "la.actions_made as 'Actions Made' ,la.details as 'Description', DATE_FORMAT(la.date_performed, '%W, %M %d, %Y %r' ) as 'Date Performed' " +
                "FROM users u " +
                "Right join action_logs la " +
                "ON u.id = la.user_id " +
                "ORDER by la.date_performed ASC ";

            try {
                var connection = await conn.getConnection();
                var adapter = new MySqlDataAdapter(stmt, connection);


                return adapter;

            }
            catch (Exception) {
                throw;
            }
        } // End of function


        public async Task<int> GetTotalRecordsInActiveuser() {
            try {
                string stmt = "Select COUNT(id) as total From users " +
                    "WHERe status = @status ";
                using (var connection = await conn.getConnection()) {
                    using (var cmd = new MySqlCommand(stmt, connection)) {
                        cmd.Parameters.AddWithValue("@status", "0");
                        using (var reader = await cmd.ExecuteReaderAsync()) {

                            if (await reader.ReadAsync()) {
                                return reader.GetInt32(reader.GetOrdinal("total"));
                            }
                        }
                    }

                }
                return 0;

            }
            catch (Exception e) { throw; }
        }

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
                "WHERE u.status = @status";

            var connection = await conn.getConnection();
            var adapter = new MySqlDataAdapter(stmt, connection);
            adapter.SelectCommand.Parameters.AddWithValue("@status", "0");

            return adapter;
        }


        //Get the total blotter, population and households
        public async Task<List<string>> GetTotalBlotterPopHouseholds() {
            string stmt = @"Select " +
                "(Select count(id) As totalBlotter From blotters) As totalBlotter, " +

                "(SELect count(id) as  totalRequestUser FROM users " +
                "Where status = @userstatus ) as totalRequestUser, " +

                "(Select count(id) From users WHERE role = @role and status = @status ) as totalPopulation;";
            try {
                List<string> data = new List<string>();
                using (var connection = await conn.getConnection()) {
                    using (var cmd = new MySqlCommand(stmt, connection)) {
                        cmd.Parameters.AddWithValue("@userstatus", "0");
                        cmd.Parameters.AddWithValue("@role", "users");
                        cmd.Parameters.AddWithValue("@status", "1");

                        var reader = await cmd.ExecuteReaderAsync();
                        if (await reader.ReadAsync()) {
                            data.Add(reader.GetInt32(reader.GetOrdinal("totalPopulation")).ToString());
                            data.Add(reader.GetInt32(reader.GetOrdinal("totalBlotter")).ToString());
                            data.Add(reader.GetInt32(reader.GetOrdinal("totalRequestUser")).ToString());

                            return data;
                        }
                        return null;
                    }
                }

            }
            catch (Exception) {
                throw;
            }
        }// end of function


        //update blotter
        public async Task UpdateBlotter(string blotterId,
             string status) {
            using (var conenction = await conn.getConnection()) {
                try {
                    string stmt = "Update blotters set status = @status " +
                        "WHere id = @id ";

                    using (var cmd = new MySqlCommand(stmt, conenction)) {
                        cmd.Parameters.AddWithValue("@id", blotterId);
                        cmd.Parameters.AddWithValue("@status", status);

                        await cmd.ExecuteNonQueryAsync();
                    }

                }
                catch (Exception) {
                    throw;
                }
            }

        }

        //Delete specific blotter
        public async Task DeleteBlotter(string id) {
            using (var conenction = await conn.getConnection()) {
                string stmt = "Delete From blotters WHere id = @id ";

                try {
                    using (var cmd = new MySqlCommand(stmt, conenction)) {
                        cmd.Parameters.AddWithValue("@id", id);
                        await cmd.ExecuteNonQueryAsync();
                    }
                }
                catch (Exception) {
                    throw;
                }
            }

        }// ends


        //Get blotter that returns BLotter object, will use in update blotter for admin
        public async Task<BlotterInformation> GetBlotter(string id) {
            string stmt = "Select id, complainant_id, respondent_id , " +
                "statements , date_filed " +
                "From blotters " +
                "Where id = @id ";

            try {
                DataTable table = new DataTable();
                using (var connection = await conn.getConnection()) {
                    using (var adapter = new MySqlCommand(stmt, connection)) {
                        adapter.Parameters.AddWithValue("@id", id);
                        using (var reader = await adapter.ExecuteReaderAsync()) {
                            BlotterInformation blotter;
                            if (await reader.ReadAsync()) {
                                blotter = new BlotterInformation()
                                {
                                    Id = reader.GetString(reader.GetOrdinal("id")),
                                    ComplainantId = reader.GetString(reader.GetOrdinal("complainant_id")),
                                    RespondentId = reader.GetString(reader.GetOrdinal("respondent_id")),
                                    Statements = reader.GetString(reader.GetOrdinal("statements")),
                                    DateFiled = reader.GetDateTime(reader.GetOrdinal("date_filed")),
                                };

                                return blotter;
                            }
                            return null;
                        }

                    }
                }
            }
            catch (Exception) {
                throw;
            }

        } // end

        //get blotter for update
        public async Task<DataTable> GetBlotterForUpdate(string id) {
            string stmt = "SELECT b.id as ID, " +
                "b.complainant_id as Complainant, b.respondent_id as Respondent, b.statements as Statements, " +
                "b.status as Status, b.date_filed as 'Date Filed', b.complainant_name as 'Complainant Name',  b.respondent_name as 'Respondent Name' " +
                "FROM blotters b " +
                "WHERE b.id = @id";

            try {
                DataTable table = new DataTable();
                using (var connection = await conn.getConnection()) {
                    using (var adapter = new MySqlDataAdapter(stmt, connection)) {
                        adapter.SelectCommand.Parameters.AddWithValue("@id", id);
                        DataTable dt = new DataTable();

                        await adapter.FillAsync(dt);
                        return dt;
                    }
                }
            }
            catch (Exception) {
                throw;
            }
        } // 

        //To update announcements
        public async Task UpdateAnnouncement(AnnouncementsModel annoucnement, string id) {
            string stmt = "Update annoucenments set title = @title, details = @details, attachment = @attachment, status = @status " +
                "Where id =@id";

            try {
                using (var connection = await conn.getConnection()) {
                    using (var cmd = new MySqlCommand(stmt, connection)) {
                        cmd.Parameters.AddWithValue("@title", annoucnement.Title);
                        cmd.Parameters.AddWithValue("@details", annoucnement.Details);
                        cmd.Parameters.AddWithValue("@attachment", annoucnement.Attachments);
                        cmd.Parameters.AddWithValue("@status", annoucnement.Status);
                        cmd.Parameters.AddWithValue("@id", id);

                        await cmd.ExecuteNonQueryAsync();
                    }

                }


            }
            catch (Exception) {
                throw;
            }
        }// end

        public async Task DeleteAnnoucenments(string id) {
            string stmt = "Delete FROM annoucenments WHERE id = @id";
            try {
                using (var connection = await conn.getConnection()) {
                    using (var cmd = new MySqlCommand(stmt, connection)) {
                        cmd.Parameters.AddWithValue("@id", id);

                        await cmd.ExecuteNonQueryAsync();
                    }
                }

            }
            catch (Exception) {
                throw;
            }
        } // end 

        public async Task DeleteOfficials(string id) {
            try {
                string stmt = "Delete from  Officials WHERe user_id = @userid";

                using (var connection = await conn.getConnection()) {
                    using (var cmd = new MySqlCommand(stmt, connection)) {
                        cmd.Parameters.AddWithValue("@userid", id);

                        await cmd.ExecuteNonQueryAsync();
                    }
                }

            }
            catch (Exception ex) {
                throw;
            }
        }// end

        public async Task UpdateOfficialsInfo(OfficialsInfo officials) {
            try {
                string stmt = "Update officials Set position = @position, status = @status, " +
                    "start_term = @startterm, end_term =@endterm";

                using (var connection = await conn.getConnection()) {
                    using (var cmd = new MySqlCommand(stmt, connection)) {
                        cmd.Parameters.AddWithValue("@position", officials.Position);
                        cmd.Parameters.AddWithValue("@status", officials.Status);
                        cmd.Parameters.AddWithValue("@startterm", officials.TermStart.Date);
                        cmd.Parameters.AddWithValue("@endterm", officials.TermEnd.Date);

                        await cmd.ExecuteNonQueryAsync();
                    }
                }
            }
            catch (Exception ex) {
                throw;
            }
        }
    }
}