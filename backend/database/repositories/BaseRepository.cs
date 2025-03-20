using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BMS.backend.models.residents_model;
using BMS.database.connector;
using MySql.Data.MySqlClient;

namespace BMS.backend.database.repositories {
    public class BaseRepository {
        private readonly MySqlConnection conn;
        public BaseRepository() {
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

    }
}