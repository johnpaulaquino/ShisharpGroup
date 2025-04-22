using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using BrgyMs.database.connector;

using System.Data.Common;
using BrgyMs.backend.database.repositories;
using BrgyMs.backend.models.bo_model;
using BrgyMs.backend.models.base_model;
using BrgyMs.backend.models.residents_model;
using System.Xml;
using BrgyMs.backend.utils;
using ZstdSharp.Unsafe;

namespace BrgyMs.backend.database.repositories {
    public class ResidentRepository : BaseRepository {
        private readonly MySqlConnection conn;
        private readonly AuthUtils _AuthUtils;

        public ResidentRepository() {
            conn = new Connector().getConnection();
            _AuthUtils = new AuthUtils();
        }

        //This section is for setters
        public async Task AddOfficialsInfo(OfficialsInfo _OfficialsInfo,
            ElectionHistories ElecHistories, string UserId) {

            string stmt = "Insert into officials(user_id, term_start, term_end, position, election_histories, status) "
            + "Values(?,?,?,?,?,?)";
            string EelcHisto = JsonConvert.SerializeObject(ElecHistories, Newtonsoft.Json.Formatting.Indented);

            try {
                using (var cmd = new MySqlCommand(stmt, conn)) {
                    cmd.Parameters.AddWithValue("user_id", UserId);
                    cmd.Parameters.AddWithValue("term_start", _OfficialsInfo.TermStart.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("term_end", _OfficialsInfo.TermEnd.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("position", _OfficialsInfo.Position);
                    cmd.Parameters.AddWithValue("election_histories", EelcHisto);
                    cmd.Parameters.AddWithValue("status", _OfficialsInfo.Status);
                    await cmd.ExecuteNonQueryAsync();
                    Console.WriteLine("Successfully add officials info");
                }
            }
            catch (MySqlException) {
                throw;
            }

        }//End of Function

        public async Task AddUser(User user) {
            string stmt = "Insert into users (id, email, password,username, role, status) "
            + "Values(?,?,?,?,?,?)";
            string Id = await this.GenerateId();
            try {
                using (var cmd = new MySqlCommand(stmt, conn)) {
                    cmd.Parameters.AddWithValue("id", Id);
                    cmd.Parameters.AddWithValue("email", user.Email);
                    cmd.Parameters.AddWithValue("password", _AuthUtils.hashedPassword(user.Password));
                    cmd.Parameters.AddWithValue("username", user.Username);
                    cmd.Parameters.AddWithValue("role", user.Role);
                    cmd.Parameters.AddWithValue("status", user.Status);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
            catch (System.Exception) {

                throw;
            }
        }

        public async Task AddRequestDocuments(ResidentDocumentRequest _RequestDocu) {
            string stmt = "INSERT INTO request_document(id, user_id, document_type, status, "
            + "purpose) "
            + "Values(?,?,?,?,?)";
            try {
                using (var cmd = new MySqlCommand(stmt, conn)) {
                    cmd.Parameters.AddWithValue("id", _RequestDocu.Id);
                    cmd.Parameters.AddWithValue("user_id", _RequestDocu.UserId);
                    cmd.Parameters.AddWithValue("document_type", _RequestDocu.DocumentType);
                    cmd.Parameters.AddWithValue("status", _RequestDocu.Status);
                    cmd.Parameters.AddWithValue("purpose", _RequestDocu.Purpose);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
            catch (System.Exception) {
                throw;
            }
        }

        // ----------------------------------------------------------//
        //This section is for getters
        public async Task<Dictionary<string, string>> GetEmail(string email) {
            string stmt = "Select id, email, password,username, role, status from users "
            + "Where email = ?";
            Dictionary<string, string> data = new Dictionary<string, string>();
            try {
                using (var cmd = new MySqlCommand(stmt, conn)) {
                    cmd.Parameters.AddWithValue("email", email);

                    using (var reader = await cmd.ExecuteReaderAsync()) {
                        if (reader.Read()) {

                            data.Add("userId", reader.GetString(reader.GetOrdinal("id")));
                            data.Add("email", reader.GetString(reader.GetOrdinal("email")));
                            data.Add("password", reader.GetString(reader.GetOrdinal("password")));
                            data.Add("status", Convert.ToString(reader.GetInt32(reader.GetOrdinal("status"))));
                            data.Add("role", reader.GetString(reader.GetOrdinal("role")));
                            data.Add("username", reader.GetString(reader.GetOrdinal("username")));
                        }
                    }
                }
                return data;
            }
            catch (System.Exception) {
                throw;
            }
        }// End of FindByEmail
        public async Task<string> GenerateId() {
            string id = "";
            string stmt = "SELECT LPAD(IFNULL(MAX(id), 0) + 1, 4, '0') as id from users";
            using (var cmd = new MySqlCommand(stmt, conn)) {
                using (var reader = await cmd.ExecuteReaderAsync()) {
                    if (reader.Read()) {
                        id = reader.GetString(0);
                    }
                }
                return id;
            }
        }
        // public async Task<DbDataReader> GetResidentNotVerified(int Status) {
        //     string stmt = "Select p.display_id, p.firstname, p.middlename, p.lastname "
        //     + "From users u "
        //     + "Left JOIN personal_info p "
        //     + "on u.id = p.user_id "
        //     + "where status = ? ";
        //     try {
        //         var cmd = new MySqlCommand(stmt, conn);
        //         cmd.Parameters.AddWithValue("status", Status);
        //         var reader = await cmd.ExecuteReaderAsync();
        //         return reader;
        //     }
        //     catch (System.Exception) {

        //         throw;
        //     }
        // }

       
        public async Task<Dictionary<string, string>> GetElectionHistories() {
            string stmt = "SELECT * FROM officials";
            Dictionary<string, string> data = new Dictionary<string, string>();
            using (var cmd = new MySqlCommand(stmt, conn)) {
                int i = 0;
                using (var reader = await cmd.ExecuteReaderAsync()) {
                    while (reader.Read()) {
                        data.Add($"election_histories{i}", reader.GetString(5));
                        i++;
                    }
                    return data;
                }
            }
        }

    }
}