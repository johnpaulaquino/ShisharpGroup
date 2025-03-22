using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BMS.backend.models.base_model;
using BMS.backend.models.residents_model;
using BMS.backend.utils;
using BMS.database.connector;
using MySql.Data.MySqlClient;

namespace BMS.backend.database.repositories {
    public class BaseRepository {
        private readonly MySqlConnection conn;
        private readonly Utils util;
        public BaseRepository() {
            conn = new Connector().getConnection();
            util = new Utils();
        }


        public async Task AddResidentInformation(PersonalInformation _ResidentInfo, string UserId) {
            string stmt1 = "Insert Into personal_info (id,user_id, firstname, middlename"
                          + ",lastname, suffix, gender) "
                          + "Values (?,?,?,?,?,?, ?)";
            try {
                using (var cmd = new MySqlCommand(stmt1, conn)) {
                    cmd.Parameters.AddWithValue("id", _ResidentInfo.Id);
                    cmd.Parameters.AddWithValue("user_id", UserId);
                    cmd.Parameters.AddWithValue("firstname", _ResidentInfo.Firstname);
                    cmd.Parameters.AddWithValue("middlename", _ResidentInfo.Middlename);
                    cmd.Parameters.AddWithValue("lastname", _ResidentInfo.Lastname);
                    cmd.Parameters.AddWithValue("suffix", _ResidentInfo.Suffix);
                    cmd.Parameters.AddWithValue("gender", _ResidentInfo.Gender);

                    await cmd.ExecuteNonQueryAsync();
                }
            }
            catch (System.Exception) {

                throw;
            }

        }// End of Add ResidentINformation function
        public async Task AddResidentAddInfo(ResidentAdditionalInfo _ResidenAddtInfo,
                                        string residentInfoId) {
            string stmt1 = "Insert Into additional_info (resident_info_id, profile_image, is_voter,"
                          + "martial_status, educational_attaintment,religion, birth_day, age, contact_number, proof_of_residency ) "
                          + "Values (?,?,?,?,?,?,?,?,?,?)";

            int Age = util.calculateAge(_ResidenAddtInfo.BirthDate);

            try {
                using (var cmd = new MySqlCommand(stmt1, conn)) {
                    cmd.Parameters.AddWithValue("resident_info_id", residentInfoId);
                    cmd.Parameters.AddWithValue("profile_image", _ResidenAddtInfo.ProfileImage);
                    cmd.Parameters.AddWithValue("is_voter", _ResidenAddtInfo.IsVoter);
                    cmd.Parameters.AddWithValue("martial_status", _ResidenAddtInfo.MaritalStatus.ToString());
                    cmd.Parameters.AddWithValue("educational_attaintment", _ResidenAddtInfo.EducAttain.ToString());
                    cmd.Parameters.AddWithValue("age", _ResidenAddtInfo.Religion);
                    cmd.Parameters.AddWithValue("birth_day", _ResidenAddtInfo.BirthDate.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("religion", Age);
                    cmd.Parameters.AddWithValue("contact_number", _ResidenAddtInfo.ContactNo);
                    cmd.Parameters.AddWithValue("proof_of_residency", _ResidenAddtInfo.ProofOfResidency);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
            catch (System.Exception) {

                throw;
            }
        }// End of Add ResidentAddInformation function


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
        }// End of Add ResidentAddInformation function

    }
}