using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BMS.database.connection;
using BMS.backend.models;
using MySql.Data.MySqlClient;
using BMS.backend.database.models;
using Mysqlx.Sql;

namespace BMS.backend.database.repositories {
    public class AdminReposiroty : ITRepository {
        private readonly MySqlConnection conn;
        public AdminReposiroty() {
            conn = new Connector().getConnection();
        }
        public async Task AddResidentInformation(ResidentInfo _ResidentInfo) {
            string stmt1 = "Insert Into resident_info (id, email, firstname, middlename"
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
            string stmt1 = "Insert Into resident_additional_info (id, profile_image, is_voter, resident_info_id,"
                          + "martial_status, educational_attaintment,birth_day, age) "
                          + "Values (?,?,?,?,?,?,?,?)";
            try {
                using (var cmd = new MySqlCommand(stmt1, conn)) {
                    cmd.Parameters.AddWithValue("id", _ResidenAddtInfo.id);
                    cmd.Parameters.AddWithValue("is_voter", _ResidenAddtInfo.isVoter);
                    cmd.Parameters.AddWithValue("profile_image", MySqlDbType.LongBlob).Value = _ResidenAddtInfo.profileImage;
                    cmd.Parameters.AddWithValue("resident_info_id", residentInfoId);
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
            string stmt1 = "Insert Into resident_address (id, resident_info_id, street, house_number"
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
            string stmt = "Select id from resident_info "
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
            string stmt = "Select id from resident_info "
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
    }
}