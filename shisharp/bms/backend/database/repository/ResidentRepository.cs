using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using BrgyMs.database.connector;
using BrgyMs.backend.models.bo_model;
using BrgyMs.backend.models.base_model;


using BrgyMs.backend.utils;
using System.Data;
using System.Data.Common;
using BrgyMs.backend.models.residents_docs;
using System.Windows.Forms;
using Mysqlx.Sql;
using BrgyMS.backend.models;



namespace BrgyMs.backend.database.repositories {
    public class ResidentRepository : BaseRepository {
        private Connector conn;
        private AuthUtils _AuthUtils;

        public ResidentRepository() {
            conn = new Connector();
            _AuthUtils = new AuthUtils();
        }

        public async Task<bool> CheckOfficialsIfExists(string id) {
            try {
                string stmt = "SELECT * from officials " +
                    "Where user_id = @user_id and status = @status ";

                using (var connection = await conn.getConnection()) {
                    using (var cmd = new MySqlCommand(stmt, connection)) {
                        cmd.Parameters.AddWithValue("@user_id", id);
                        cmd.Parameters.AddWithValue("@status", "Active");

                        using (var reader = await cmd.ExecuteReaderAsync()) {
                            if (await reader.ReadAsync()) {
                                MessageBox.Show("true");
                                return true; // return true if exist

                            }
                            return false;
                        }
                    }
                }

            }
            catch (Exception) {
                throw;
            }
        }
        //This section is for setters
        public async Task AddOfficialsInfo(OfficialsInfo _OfficialsInfo) {

            string stmt = "Insert into officials(id, user_id,position, status, start_term, end_term) "
            + "Values(@id, @user_id,@position,@status, @start_term,@end_term)";


            try {

                using (var connection = await conn.getConnection()) {

                    using (var cmd = new MySqlCommand(stmt, connection)) {
                        cmd.Parameters.AddWithValue("@user_id", _OfficialsInfo.UserId);
                        cmd.Parameters.AddWithValue("@position", _OfficialsInfo.Position);
                        cmd.Parameters.AddWithValue("@status", _OfficialsInfo.Status);
                        cmd.Parameters.AddWithValue("@id", _OfficialsInfo.Id);
                        cmd.Parameters.AddWithValue("@end_term", _OfficialsInfo.TermEnd);
                        cmd.Parameters.AddWithValue("@start_term", _OfficialsInfo.TermStart);
                        await cmd.ExecuteNonQueryAsync();
                    }
                }
            }
            catch (Exception) {
                throw;
            }

        }//End of Function


        public async Task<bool> IsUserRequested(string userId) {
            string stmt = "Select id from request_document where user_id = @userid and status = @status ";

            try {
                using (var connection = await conn.getConnection()) {
                    using (var cmd = new MySqlCommand(stmt, connection)) {
                        cmd.Parameters.AddWithValue("@userid", userId);
                        cmd.Parameters.AddWithValue("@status", "pending");
                        using (var reader = await cmd.ExecuteReaderAsync()) {
                            if (await reader.ReadAsync()) {
                                return true;
                            }
                        }
                        return false;
                    }
                }
            }
            catch (Exception) {
                throw;
            }
        }

        // insert request docs
        public async Task AddRequestDocuments(ResidentDocumentRequest _RequestDocu) {
            string stmt = "INSERT INTO request_document(id, user_id, document_type, status, "
            + "purpose, other_purposes) "
            + "Values(@id, @user_id, @docs, @status, @purpose, @others)";
            try {
                using (var cmd = new MySqlCommand(stmt, await conn.getConnection())) {
                    cmd.Parameters.AddWithValue("@id", _RequestDocu.Id);
                    cmd.Parameters.AddWithValue("@user_id", _RequestDocu.UserId);
                    cmd.Parameters.AddWithValue("@docs", _RequestDocu.DocumentType);
                    cmd.Parameters.AddWithValue("@status", _RequestDocu.Status);
                    cmd.Parameters.AddWithValue("@others", _RequestDocu.OtherPurposes);
                    cmd.Parameters.AddWithValue("@purpose", _RequestDocu.Purpose);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
            catch (Exception e) {
                throw new Exception(e.Message);
            }
        }


        //get the records of the request documents
        public async Task<MySqlDataAdapter> GetRequestedDocs(string userId) {
            string stmt = "Select id as 'Transaction Id', document_type as 'Document Type', " +
                "status as Status, request_date as 'Request Date', purpose as 'Purpose'" +
                "FROM request_document " +
                "Where user_id = @userid ";

            try {
                var connection = await conn.getConnection();
                var adapter = new MySqlDataAdapter(stmt, connection);

                adapter.SelectCommand.Parameters.AddWithValue("@userid", userId);
                return adapter;
            }
            catch (Exception) {
                throw;
            }
        }



        public async Task<MySqlDataAdapter> GetUserLogs(string userId) {
            string stmt = "SELECT la.id as 'ID', la.user_id as 'User ID', u.username as 'Username', CONCAT(UPPER(LEFT(u.role, 1)),LOWER(SUBSTRING(u.role FROM 2))) as 'Role', " +
                 "la.actions_made as 'Actions Made' ,la.details as 'Description', DATE_FORMAT(la.date_performed, '%W, %M %d, %Y %r' ) as 'Date Performed' " +
                 "FROM users u " +
                 "Right join action_logs la " +
                 "ON u.id = la.user_id " +
                 "WHERE u.role = @role and la.user_id = @userid " +
                 "ORDER by la.date_performed ASC ";

            try {
                var connection = await conn.getConnection();
                var adapter = new MySqlDataAdapter(stmt, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@role", "users");
                adapter.SelectCommand.Parameters.AddWithValue("@userid", userId);

                return adapter;

            }
            catch (Exception) {
                throw;
            }

        } //end

        public async Task<int> GetTotalCOuntOfAnnouncements() {
            string stmt = "SELECT count(id) as total FROM announcements " +
                "WHERE status = @status ";
            try {
                using (var connection = await conn.getConnection()) {
                    using (var cmd = new MySqlCommand(stmt, connection)) {
                        cmd.Parameters.AddWithValue("@status", "1");

                        using (var reader = await cmd.ExecuteReaderAsync()) {
                            if (await reader.ReadAsync()) {
                                return reader.GetInt32(reader.GetOrdinal("total"));
                            }
                        }
                    }
                }
                return 0;

            }
            catch (Exception) {
                throw;
            }

        } /// end


        //get the announcements. This will use in the resident dashboard
        public async Task<List<AnnouncementsModel>> GetAnnouncement() {
            string stmt = "SELECT id as ID, title  as Title, date_post as 'Date Post', details as Details, " +
                "attachment as Attach " +
                "FROM annoucenments where status = @status";

            try {
                List<AnnouncementsModel> announce = new List<AnnouncementsModel>();
                using (var connection = await conn.getConnection()) {
                    using (var adapater = new MySqlCommand(stmt, connection)) {
                        adapater.Parameters.AddWithValue("@status", "1");

                        using (var reader = await adapater.ExecuteReaderAsync()) {
                            while (await reader.ReadAsync()) {
                                announce.Add(
                                    new AnnouncementsModel()
                                    {
                                        Attachments = (byte[])reader["Attach"],
                                        Title = reader.GetString(reader.GetOrdinal("Title")),
                                        DatePost = reader.GetDateTime(reader.GetOrdinal("Date Post")),
                                        Details = reader.GetString(reader.GetOrdinal("Details"))
                                    }
                                    );
                            }
                            return announce;
                        }
                    }
                }
            }
            catch (Exception) {
                throw;
            }
        } // end



        // get the request docs
        public async Task<DataTable> GetRequestedDocs1(string userId) {
            string stmt = "Select id document_type, " +
                "purpose ,fjob_seeker, other_purposes " +
                "FROM request_document " +
                "Where user_id = @userid";

            try {
                var connection = await conn.getConnection();
                var adapter = new MySqlDataAdapter(stmt, connection);

                adapter.SelectCommand.Parameters.AddWithValue("@userid", userId);
                var dt = new DataTable();

                await adapter.FillAsync(dt);

                return dt;
            }
            catch (Exception) {
                throw;
            }
        }

        //update resident Reslated docs
        public async Task UpdateRequestDocs(string id,
            string document_type,
            string purpose, string others) {
            try {
                string stmt = "UPDATE request_document SET document_type = @doc_type, purpose = @purpose, other_purposes = @others," +
                    "Where id = @id ";

                using (var connection = await conn.getConnection()) {
                    using (var cmd = new MySqlCommand(stmt, connection)) {
                        cmd.Parameters.AddWithValue("@doc_type", document_type);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@purpose", purpose);
                        cmd.Parameters.AddWithValue("@others", others);
                        await cmd.ExecuteNonQueryAsync();
                    }
                }
            }

            catch (Exception) {
                throw;
            }
        } // end

        public async Task UpdatePassword(string userid, string password) {
            _AuthUtils = new AuthUtils();
            string stmt = "UPDAte users set password =  @password Where id = @id";
            try {
                using (var connection = await conn.getConnection()) {
                    using (var cmd = new MySqlCommand(stmt, connection)) {
                        cmd.Parameters.AddWithValue("@password", _AuthUtils.HashedPassword(password));
                        cmd.Parameters.AddWithValue("@id", userid);

                        await cmd.ExecuteNonQueryAsync();

                    }
                }
            }
            catch (Exception) {
                throw;
            }
        }

    }
}