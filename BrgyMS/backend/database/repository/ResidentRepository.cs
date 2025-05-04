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



namespace BrgyMs.backend.database.repositories {
    public class ResidentRepository : BaseRepository {
        private Connector conn;
        private readonly AuthUtils _AuthUtils;

        public ResidentRepository() {
            conn = new Connector();
            _AuthUtils = new AuthUtils();
        }


        public async Task<bool> CheckOfficialsIfExists(string id) {
            try {
                string stmt = "SELECT * from officials " +
                    "Where user_id = @user_id and status = @status ";

                using var connection = await conn.getConnection();
                using var cmd = new MySqlCommand(stmt, connection);

                cmd.Parameters.AddWithValue("@user_id", id);
                cmd.Parameters.AddWithValue("@status", "Active");

                using var reader = await cmd.ExecuteReaderAsync();

                if (await reader.ReadAsync()) {
                    MessageBox.Show("true");
                    return true; // return true if exist

                }
                return false;
            }
            catch (Exception) {
                throw;
            }
        }
        //This section is for setters
        public async Task AddOfficialsInfo(OfficialsInfo _OfficialsInfo,
            String ElecHistories) {

            string stmt = "Insert into officials(id, user_id,position, election_histories, status) "
            + "Values(@id, @user_id,@position,@election_histories,@status)";

            try {
                using (var cmd = new MySqlCommand(stmt, await conn.getConnection())) {
                    cmd.Parameters.AddWithValue("@user_id", _OfficialsInfo.UserId);
                    cmd.Parameters.AddWithValue("@position", _OfficialsInfo.Position);
                    cmd.Parameters.AddWithValue("@status", _OfficialsInfo.Status);
                    cmd.Parameters.AddWithValue("@election_histories", ElecHistories);
                    cmd.Parameters.AddWithValue("@id", _OfficialsInfo.Id);
                    await cmd.ExecuteNonQueryAsync();

                }
            }
            catch (Exception) {
                throw;
            }

        }//End of Function


        public async Task AddRequestDocuments(ResidentDocumentRequest _RequestDocu) {
            string stmt = "INSERT INTO request_document(id, user_id, document_type, status, "
            + "purpose) "
            + "Values(?,?,?,?,?)";
            try {
                using (var cmd = new MySqlCommand(stmt, await conn.getConnection())) {
                    cmd.Parameters.AddWithValue("id", _RequestDocu.Id);
                    cmd.Parameters.AddWithValue("user_id", _RequestDocu.UserId);
                    cmd.Parameters.AddWithValue("document_type", _RequestDocu.DocumentType);
                    cmd.Parameters.AddWithValue("status", _RequestDocu.Status);
                    cmd.Parameters.AddWithValue("purpose", _RequestDocu.Purpose);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
            catch (Exception e) {
                throw new Exception(e.Message);
            }
        }


        //get the records of the request documents
        public async Task<MySqlDataAdapter> GetRequestedDocs(string userId, int limit) {
            string stmt = "Select id as 'Transaction Id', document_type as 'Document Type', " +
                "status as Status, request_date as 'Request Date', purpose as 'Purpose'" +
                "FROM request_document " +
                "Where user_id = @userid LIMIT @limit";

            try {
                var connection = await conn.getConnection();
                var adapter = new MySqlDataAdapter(stmt, connection);

                adapter.SelectCommand.Parameters.AddWithValue("@userid", userId);
                adapter.SelectCommand.Parameters.AddWithValue("@limit", limit);

                return adapter;
            }
            catch (Exception) {
                throw;
            }
        }


        public async Task<Dictionary<string, string>> GetElectionHistories() {
            string stmt = "SELECT * FROM officials";
            Dictionary<string, string> data = new Dictionary<string, string>();
            using var connection = await conn.getConnection();
            using (var cmd = new MySqlCommand(stmt, connection)) {
                int i = 0;

                using (var reader = await cmd.ExecuteReaderAsync()) {
                    while (reader.Read()) {
                        data.Add($"election_histories{i}", reader.GetString(5));
                        i++;
                    }
                    return data;
                }
            }
        } // end of the function


        public async Task<MySqlDataAdapter> GetUserLogs(int limit) {
            string stmt = "SELECT la.id as 'ID', la.user_id as 'User ID', u.username as 'Username', CONCAT(UPPER(LEFT(u.role, 1)),LOWER(SUBSTRING(u.role FROM 2))) as 'Role', " +
                 "la.actions_made as 'Actions Made' ,la.details as 'Description', DATE_FORMAT(la.date_performed, '%W, %M %d, %Y %r' ) as 'Date Performed' " +
                 "FROM users u " +
                 "Right join action_logs la " +
                 "ON u.id = la.user_id " +
                 "WHERE u.role = @role" +
                 "ORDER by la.date_performed ASC LIMIT @limit ";

            try {
                var connection = await conn.getConnection();
                var adapter = new MySqlDataAdapter(stmt, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@role", "users");
                adapter.SelectCommand.Parameters.AddWithValue("@limit", limit);
                return adapter;

            }
            catch (Exception) {
                throw;
            }

        }

    }
}