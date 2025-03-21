using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using BMS.database.connector;

using System.Data.Common;
using BMS.backend.database.repositories;
using BMS.backend.models.bo_model;
using BMS.backend.models.base_model;

namespace BMS.backend.database.repositories {
    public class ResidentRepository : BaseRepository {
        private readonly MySqlConnection conn;

        public ResidentRepository() {
            conn = new Connector().getConnection();
        }


        public async Task<Dictionary<string, string>> FindResidentById(string id) {
            string stmt = "Select id from personal_info "
            + "Where id = ?";
            Dictionary<string, string> data = new Dictionary<string, string>();
            try {
                using (var cmd = new MySqlCommand(stmt, conn)) {
                    cmd.Parameters.AddWithValue("id", id);
                    using (var reader = await cmd.ExecuteReaderAsync()) {
                        if (reader.Read()) {
                            data.Add("id", reader.GetString(0));
                            data.Add("email", reader.GetString(1));
                        }
                    }
                }
                return data;
            }
            catch (System.Exception) {
                throw;
            }
        }// End of the FindByEmail
        public async Task<Dictionary<string, string>> FindResidentByEmail(string email) {
            string stmt = "Select id, email from personal_info "
            + "Where email = ?";
            Dictionary<string, string> data = new Dictionary<string, string>();
            try {
                using (var cmd = new MySqlCommand(stmt, conn)) {
                    cmd.Parameters.AddWithValue("email", email);
                    using (var reader = await cmd.ExecuteReaderAsync()) {
                        if (reader.Read()) {
                            data.Add("id", reader.GetString(0));
                            data.Add("email", reader.GetString(1));
                        }
                    }
                }
                return data;
            }
            catch (System.Exception) {
                throw;
            }
        }

        public async Task<DbDataReader> GetResidentInfo(string category) {
            string stmt = "Select p.email, p.firstname, p.middlename, p.lastname, p.gender, p.display_id, "
            + "a.street, a.house_number, a.subdivision, a.block_number, "
            + "ai.profile_image, ai.is_voter, ai.martial_status, ai.educational_attaintment, ai.birth_day, ai.age "
            + "from personal_info p "
            + "inner join address a "
            + "On p.id = a.resident_info_id "
            + "inner join additional_info ai "
            + "On p.id = ai.resident_info_id "
            + "Where p.category = ?";
            try {
                var cmd = new MySqlCommand(stmt, conn);
                cmd.Parameters.AddWithValue("category", category);
                return await cmd.ExecuteReaderAsync();
            }
            catch (MySqlException) {

                throw;
            }
        }
        public async Task AddOfficialsInfo(OfficialsInfo _OfficialsInfo,
            ElectionHistories ElecHistories, string p_info_id) {

            string stmt = "Insert into officials(p_info_id, term_start, term_end, position, election_histories) "
            + "Values(?,?,?,?,?)";
            string EelcHisto = JsonConvert.SerializeObject(ElecHistories, Formatting.Indented);


            try {
                using (var cmd = new MySqlCommand(stmt, conn)) {
                    cmd.Parameters.AddWithValue("p_info_id", p_info_id);
                    cmd.Parameters.AddWithValue("term_start", _OfficialsInfo.TermStart.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("term_end", _OfficialsInfo.TermEnd.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("position", _OfficialsInfo.Position);
                    cmd.Parameters.AddWithValue("election_histories", EelcHisto);

                    await cmd.ExecuteNonQueryAsync();
                    Console.WriteLine("Successfully add officials info");
                }
            }
            catch (MySqlException) {
                throw;
            }

        }//End of Function

        public async Task AddUser(User user) {
            string stmt = "Insert into users (id, email, password, role, status) "
            + "Values(?,?,?,?,?)";

            try {
                using (var cmd = new MySqlCommand(stmt, conn)) {
                    cmd.Parameters.AddWithValue("id", user.id);
                    cmd.Parameters.AddWithValue("email", user.Email);
                    cmd.Parameters.AddWithValue("password", user.Password);
                    cmd.Parameters.AddWithValue("role", user.Role);
                    cmd.Parameters.AddWithValue("status", user.Status);

                    await cmd.ExecuteNonQueryAsync();
                }
            }
            catch (System.Exception) {

                throw;
            }
        }

    }
}