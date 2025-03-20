using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BMS.backend.models.base_model;
using BMS.backend.models.residents_model;
using BMS.database.connector;
using MySql.Data.MySqlClient;

namespace BMS.backend.database.repositories {
    public class BaseRepository {
        private readonly MySqlConnection conn;
        public BaseRepository() {
            conn = new Connector().getConnection();
        }
        public async Task AddResidentInformation(PersonalInformation _ResidentInfo) {
            string stmt1 = "Insert Into personal_info (id, firstname, middlename"
                          + ",lastname, gender, category) "
                          + "Values (?,?,?,?,?,?)";
            try {
                using (var cmd = new MySqlCommand(stmt1, conn)) {
                    cmd.Parameters.AddWithValue("id", _ResidentInfo.Id);
                    cmd.Parameters.AddWithValue("firstname", _ResidentInfo.Firstname);
                    cmd.Parameters.AddWithValue("middlename", _ResidentInfo.Middlename);
                    cmd.Parameters.AddWithValue("lastname", _ResidentInfo.Lastname);
                    cmd.Parameters.AddWithValue("gender", _ResidentInfo.Gender);
                    cmd.Parameters.AddWithValue("category", _ResidentInfo.Category);

                    await cmd.ExecuteNonQueryAsync();
                }
            }
            catch (System.Exception) {

                throw;
            }
        }// End of the Add ResidentINformation function
        public async Task AddResidentAddInfo(ResidentAdditionalInfo _ResidenAddtInfo,
                                        string residentInfoId) {
            string stmt1 = "Insert Into additional_info (resident_info_id, profile_image, is_voter,"
                          + "martial_status, educational_attaintment,birth_day, age) "
                          + "Values (?,?,?,?,?,?,?)";
            try {
                using (var cmd = new MySqlCommand(stmt1, conn)) {
                    cmd.Parameters.AddWithValue("resident_info_id", residentInfoId);
                    cmd.Parameters.AddWithValue("profile_image", MySqlDbType.LongBlob).Value = _ResidenAddtInfo.ProfileImage;
                    cmd.Parameters.AddWithValue("is_voter", _ResidenAddtInfo.IsVoter);
                    cmd.Parameters.AddWithValue("martial_status", _ResidenAddtInfo.MaritalStatus.ToString());
                    cmd.Parameters.AddWithValue("educational_attaintment", _ResidenAddtInfo.EducAttain.ToString());
                    cmd.Parameters.AddWithValue("birth_day", _ResidenAddtInfo.BirthDate);
                    cmd.Parameters.AddWithValue("age", _ResidenAddtInfo.Age);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
            catch (System.Exception) {

                throw;
            }
        }// End of the Add ResidentAddInformation function
        public async Task AddResidentAddress(Address _ResidenAddress,
                                      string resident_info_id) {
            string stmt1 = "Insert Into address (resident_info_id, street, house_number"
                          + ", subdivision, block_number) "
                          + "Values (?,?,?,?,?)";
            try {
                using (var cmd = new MySqlCommand(stmt1, conn)) {
                    cmd.Parameters.AddWithValue("resident_info_id", resident_info_id);
                    cmd.Parameters.AddWithValue("street", _ResidenAddress.Street);
                    cmd.Parameters.AddWithValue("house_number", _ResidenAddress.HouseNumber);
                    cmd.Parameters.AddWithValue("subdivision", _ResidenAddress.SubdivisionName);
                    cmd.Parameters.AddWithValue("block_number", _ResidenAddress.BlockNumber);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
            catch (System.Exception) {

                throw;
            }
        }// End of the Add ResidentAddInformation function

    }
}