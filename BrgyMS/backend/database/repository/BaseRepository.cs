using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using BrgyMs.backend.models.base_model;
using BrgyMs.backend.utils;
using BrgyMs.database.connector;
using BrgyMS.backend.models;
using MySql.Data.MySqlClient;

namespace BrgyMs.backend.database.repositories {
    public class BaseRepository {
        private Connector conn;
        private readonly Utils util;
        public BaseRepository() {
            conn = new Connector();
            util = new Utils();
        }


        public async Task InsertUserPersonalInformation(PersonalInformation _ResidentInfo, string UserId) {
            string stmt1 = "Insert Into personal_info (id,user_id, firstname, middlename"
                          + ",lastname, suffix, gender) "
                          + "Values (?,?,?,?,?,?,?)";
            try {
                using var connection = await conn.getConnection();
                using (var cmd = new MySqlCommand(stmt1, connection)) {
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
            catch (System.Exception e) {

                throw;
            }

        }// End of Add ResidentINformation function
        public async Task InsertUserAddinfo(AdditionalInfo _AdditionalInfo,
                                        string UserId) {
            string stmt1 = "Insert Into additional_info (id, user_id, is_voter,"
                          + "civil_status, educational_attaintment, employment_status,resident_type, religion, birth_day, age, contact_number, profile_image, proof_of_residency ) "
                          + "Values (?,?,?,?,?,?,?,?,?,?,?,?,?)";

            int Age = util.calculateAge(_AdditionalInfo.BirthDate);

            try {
                using var connection = await conn.getConnection();
                using (var cmd = new MySqlCommand(stmt1, connection)) {
                    cmd.Parameters.AddWithValue("id", _AdditionalInfo.Id);
                    cmd.Parameters.AddWithValue("user_id", UserId);
                    cmd.Parameters.AddWithValue("is_voter", _AdditionalInfo.IsVoter);
                    cmd.Parameters.AddWithValue("civil_status", _AdditionalInfo.CivilStatus);
                    cmd.Parameters.AddWithValue("educational_attaintment", _AdditionalInfo.EducAttain);
                    cmd.Parameters.AddWithValue("employment_status", _AdditionalInfo.EmpStatus);
                    cmd.Parameters.AddWithValue("resident_type", _AdditionalInfo.ResidentType);
                    cmd.Parameters.AddWithValue("religion", _AdditionalInfo.Religion);
                    cmd.Parameters.AddWithValue("birth_day", _AdditionalInfo.BirthDate.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("age", Age);
                    cmd.Parameters.AddWithValue("contact_number", _AdditionalInfo.ContactNo);
                    cmd.Parameters.AddWithValue("profile_image", _AdditionalInfo.ProfileImage);
                    cmd.Parameters.AddWithValue("proof_of_residency", _AdditionalInfo.ProofOfResidency);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
            catch (System.Exception e) {

                throw;
            }
        }// End of Add ResidentAddInformation function


        public async Task InsertUserAddress(Address _ResidenAddress,
                                      string UserId) {
            string stmt1 = "Insert Into address (id, user_id, street, house_number"
                          + ", subdivision, block_number) "
                          + "Values (?,?,?,?,?,?)";
            try {
                using var connection = await conn.getConnection();
                using (var cmd = new MySqlCommand(stmt1, connection)) {
                    cmd.Parameters.AddWithValue("id", _ResidenAddress.Id);
                    cmd.Parameters.AddWithValue("user_id", UserId);
                    cmd.Parameters.AddWithValue("street", _ResidenAddress.Street);
                    cmd.Parameters.AddWithValue("house_number", _ResidenAddress.HouseNumber);
                    cmd.Parameters.AddWithValue("subdivision", _ResidenAddress.SubdivisionName);
                    cmd.Parameters.AddWithValue("block_number", _ResidenAddress.BlockNumber);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
            catch (System.Exception e) {

                throw;
            }
        }// End of Add ResidentAddInformation function

        public async Task LogUserActions(Logs logs) {
            string stmt = "INSERT INTO action_logs(id, user_id, date_performed, " +
                "actions_made, affected_table) " +
                "VALUES(@id, @userId, @dtPerformed, @actionmade,@affectedtable ) ";

            try {
                using var connection = await conn.getConnection();
                using var cmd = new MySqlCommand(stmt, connection);
                cmd.Parameters.AddWithValue("@id", logs.Id);
                cmd.Parameters.AddWithValue("@userId", logs.UserId);
                cmd.Parameters.AddWithValue("@dtPerformed", logs.DatePerformed);
                cmd.Parameters.AddWithValue("@actionmade", logs.ActionsMade);
                cmd.Parameters.AddWithValue("@affectedtable", logs.AffectedTable);

                await cmd.ExecuteNonQueryAsync();
            }
            catch (Exception) {
                throw;

            }
        }
        public async Task<string> GenerateLogsId() {
            string id = "";
            string stmt = "SELECT LPAD(IFNULL(MAX(id), 0) + 1, 4, '0') as nextId from action_logs";
            using var connection = await conn.getConnection();
            using (var cmd = new MySqlCommand(stmt, connection)) {
                using (var reader = await cmd.ExecuteReaderAsync()) {
                    if (reader.Read()) {
                        id = reader.GetString("nextId");
                    }
                }
                return id;
            }
        }
    }
}