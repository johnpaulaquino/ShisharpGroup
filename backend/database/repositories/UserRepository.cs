using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

using BMS.database.connector;
using BMS.backend.models;
using BMS.backend.models.residents_model;
using System.Data.Common;

namespace BMS.database.respositories {
    public class UserRepository {
        private readonly MySqlConnection conn;
        public UserRepository() {
            conn = new Connector().getConnection();
        }

        public async Task AddResidentInformation(ResidentInfo _ResidentInfo) {
            string stmt1 = "Insert Into personal_info (id, email, firstname, middlename"
                          + ",lastname, gender) "
                          + "Values (?,?,?,?,?,?)";
            try {
                using (var cmd = new MySqlCommand(stmt1, conn)) {
                    cmd.Parameters.AddWithValue("id", _ResidentInfo.id);
                    cmd.Parameters.AddWithValue("email", _ResidentInfo.email);
                    cmd.Parameters.AddWithValue("firstname", _ResidentInfo.firstname);
                    cmd.Parameters.AddWithValue("middlename", _ResidentInfo.middlename);
                    cmd.Parameters.AddWithValue("lastname", _ResidentInfo.lastname);
                    cmd.Parameters.AddWithValue("gender", _ResidentInfo.gender);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
            catch (System.Exception) {

                throw;
            }
        }// End of the Add ResidentINformation function
        public async Task AddResidentAddInfo(ResidentAdditionalInfo _ResidenAddtInfo,
                                        string residentInfoId) {
            string stmt1 = "Insert Into additional_info (id, resident_info_id, profile_image, is_voter,"
                          + "martial_status, educational_attaintment,birth_day, age) "
                          + "Values (?,?,?,?,?,?,?,?)";
            try {
                using (var cmd = new MySqlCommand(stmt1, conn)) {
                    cmd.Parameters.AddWithValue("id", _ResidenAddtInfo.id);
                    cmd.Parameters.AddWithValue("resident_info_id", residentInfoId);
                    cmd.Parameters.AddWithValue("profile_image", MySqlDbType.LongBlob).Value = _ResidenAddtInfo.profileImage;
                    cmd.Parameters.AddWithValue("is_voter", _ResidenAddtInfo.isVoter);
                    cmd.Parameters.AddWithValue("martial_status", _ResidenAddtInfo.maritalStatus.ToString());
                    cmd.Parameters.AddWithValue("educational_attaintment", _ResidenAddtInfo.educAttain.ToString());
                    cmd.Parameters.AddWithValue("birth_day", _ResidenAddtInfo.birthDate);
                    cmd.Parameters.AddWithValue("age", _ResidenAddtInfo.age);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
            catch (System.Exception) {

                throw;
            }
        }// End of the Add ResidentAddInformation function
        public async Task AddResidentAddress(ResidentAddress _ResidenAddress,
                                      string resident_info_id) {
            string stmt1 = "Insert Into address (id, resident_info_id, street, house_number"
                          + ", subdivision, block_number) "
                          + "Values (?,?,?,?,?,?)";
            try {
                using (var cmd = new MySqlCommand(stmt1, conn)) {
                    cmd.Parameters.AddWithValue("id", _ResidenAddress.id);
                    cmd.Parameters.AddWithValue("resident_info_id", resident_info_id);
                    cmd.Parameters.AddWithValue("street", _ResidenAddress.street);
                    cmd.Parameters.AddWithValue("house_number", _ResidenAddress.houseNumber);
                    cmd.Parameters.AddWithValue("subdivision", _ResidenAddress.subdivisionName);
                    cmd.Parameters.AddWithValue("block_number", _ResidenAddress.blockNumber);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
            catch (System.Exception) {

                throw;
            }
        }// End of the Add ResidentAddInformation function

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

    }


}