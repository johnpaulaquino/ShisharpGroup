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
        private readonly AuthUtils _AuthUtils = new();
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
                          + ", subdivision, block_number, lot_number) "
                          + "Values (?,?,?,?,?,?,?)";
            try {
                using var connection = await conn.getConnection();
                using (var cmd = new MySqlCommand(stmt1, connection)) {
                    cmd.Parameters.AddWithValue("id", _ResidenAddress.Id);
                    cmd.Parameters.AddWithValue("user_id", UserId);
                    cmd.Parameters.AddWithValue("street", _ResidenAddress.Street);
                    cmd.Parameters.AddWithValue("house_number", _ResidenAddress.HouseNumber);
                    cmd.Parameters.AddWithValue("subdivision", _ResidenAddress.SubdivisionName);
                    cmd.Parameters.AddWithValue("block_number", _ResidenAddress.BlockNumber);
                    cmd.Parameters.AddWithValue("lot_number", _ResidenAddress.BlockNumber);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
            catch (System.Exception e) {

                throw;
            }
        }// End of Add ResidentAddInformation function

        public async Task AddUser(User user) {
            string stmt = "Insert into users (id, email, password,username, role, status) "
            + "Values(?,?,?,?,?,?)";
            string Id = await this.GenerateUsersId();
            try {
                using (var cmd = new MySqlCommand(stmt, await conn.getConnection())) {
                    cmd.Parameters.AddWithValue("id", Id);
                    cmd.Parameters.AddWithValue("email", user.Email);
                    cmd.Parameters.AddWithValue("password", _AuthUtils.hashedPassword(user.Password));
                    cmd.Parameters.AddWithValue("username", user.Username);
                    cmd.Parameters.AddWithValue("role", user.Role);
                    cmd.Parameters.AddWithValue("status", user.Status);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
            catch (Exception e) {

                throw new Exception(e.Message);
            }
        }

        //log user actions
        public async Task LogUserActions(Logs logs) {
            string stmt = "INSERT INTO action_logs(id, user_id, date_performed, " +
                "actions_made, details) " +
                "VALUES(@id, @userId, @dateperformed, @actionmade, @details ) ";

            try {
                using var connection = await conn.getConnection();
                using var cmd = new MySqlCommand(stmt, connection);
                cmd.Parameters.AddWithValue("@id", logs.Id);
                cmd.Parameters.AddWithValue("@userId", logs.UserId);
                cmd.Parameters.AddWithValue("@dateperformed", logs.DatePerformed);
                cmd.Parameters.AddWithValue("@actionmade", logs.ActionsMade);
                cmd.Parameters.AddWithValue("@details", logs.Details);

                await cmd.ExecuteNonQueryAsync();
            }
            catch (Exception) {
                throw;

            }
        }

        //Get all the information of the specific user 
        public async Task<DbDataReader> GetUserAllInformation(string UserId) {
            string stmt = "SELECT u.id, u.email, u.username, u.password, u.role, u.status, " +
                "p.firstname, p.middlename, p.lastname, p.suffix, p.gender," +
                "ai.is_voter, ai.civil_status, ai.educational_attaintment, ai.employment_status, " +
                "ai.resident_type, ai.religion, ai.birth_day, ai.age, ai.contact_number, " +
                "ai.profile_image, ai.proof_of_residency, " +
                "a.house_number, a.street, a.subdivision, a.block_number, a.lot_number " +
                "FROM users u " +
                "LEFT JOIN personal_info p " +
                "ON u.id = p.user_id " +
                "LEFT JOIN additional_info ai " +
                "ON u.id = ai.user_id " +
                "LEFT JOIN address a " +
                "ON u.id = a.user_id " +
                "Where u.id = @userid ";
            try {
                var connection = await conn.getConnection();
                var cmd = new MySqlCommand(stmt, connection);
                cmd.Parameters.AddWithValue("@userid", UserId);
                var reader = await cmd.ExecuteReaderAsync();

                return reader;

            }
            catch (Exception) {
                throw;
            } // end of function
        }

        public async Task<DbDataReader> GetInactiveUserInformation(String UserId) {
            string stmt = "SELECT u.id, u.email, u.username, u.password, u.role, u.status, " +
                "p.firstname, p.middlename, p.lastname, p.suffix, p.gender," +
                "ai.is_voter, ai.civil_status, ai.educational_attaintment, ai.employment_status, " +
                "ai.resident_type, ai.religion, ai.birth_day, ai.age, ai.contact_number, " +
                "ai.profile_image, ai.proof_of_residency, " +
                "a.house_number, a.street, a.subdivision, a.block_number, a.lot_number " +
                "FROM users u " +
                "LEFT JOIN personal_info p " +
                "ON u.id = p.user_id " +
                "LEFT JOIN additional_info ai " +
                "ON u.id = ai.user_id " +
                "LEFT JOIN address a " +
                "ON u.id = a.user_id " +
                "Where u.id = @userid AND u.status = @status ";
            try {
                var connection = await conn.getConnection();
                var cmd = new MySqlCommand(stmt, connection);
                cmd.Parameters.AddWithValue("@userid", UserId);
                cmd.Parameters.AddWithValue("@status", "0");
                var reader = await cmd.ExecuteReaderAsync();

                return reader;

            }
            catch (Exception) {
                throw;
            } // end of function
        }


        //Generate id for users
        public async Task<string> GenerateUsersId() {
            string id = "";
            string stmt = "SELECT LPAD(IFNULL(MAX(id), 0) + 1, 4, '0') as nextId from users";
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

        //Generate Id that are base on the id of logs.
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
        } //End of funciton


        //Update account info, only admin can do this
        public async Task UpdateAccountInfo(User user, string userId) {
            string stmt = "UPDATE users set email = @email, username = @username, " +
                "password = @password, role = @role, status = @status " +
                "WHERE id = @id";

            try {
                using var connection = await conn.getConnection();
                using var cmd = new MySqlCommand(stmt, connection);

                cmd.Parameters.AddWithValue("@email", user.Email);
                cmd.Parameters.AddWithValue("@username", user.Username);
                cmd.Parameters.AddWithValue("@password", user.Password);
                cmd.Parameters.AddWithValue("@role", user.Role);
                cmd.Parameters.AddWithValue("@status", user.Status);
                cmd.Parameters.AddWithValue("@id", userId);

                await cmd.ExecuteNonQueryAsync();
            }
            catch (Exception) {
                throw;
            }

        }//end of function


        //GEt the email of the user
        public async Task<Dictionary<string, string>> GetEmail(string email) {
            string stmt = "Select id, email, password,username, role, status from users "
            + "Where email = ?";

            try {
                Dictionary<string, string> data = new Dictionary<string, string>();
                using (var connection = await conn.getConnection()) {
                    using (var cmd = new MySqlCommand(stmt, connection)) {
                        cmd.Parameters.AddWithValue("email", email);

                        using (var reader = await cmd.ExecuteReaderAsync()) {
                            if (await reader.ReadAsync()) {

                                data.Add("userId", reader.GetString(reader.GetOrdinal("id")));
                                data.Add("email", reader.GetString(reader.GetOrdinal("email")));
                                data.Add("password", reader.GetString(reader.GetOrdinal("password")));
                                data.Add("status", Convert.ToString(reader.GetInt32(reader.GetOrdinal("status"))));
                                data.Add("role", reader.GetString("role"));
                                data.Add("username", reader.GetString(reader.GetOrdinal("username")));

                                return data;
                            }
                        }
                    }
                    return null;
                }
            }
            catch (System.Exception) {
                throw;
            }
        }// End of FindByEmail

        //Activate user account by setting the the status to 1 or equal to true
        public async Task ActivateUserAccount(string userId) {
            string stmt = "UPDATE users set status = @status WHERE id = @id";
            string stmt1 = "UPDATE additional_info set proof_of_residency = @proof WHERE user_id = @pid";

            try {

                using var connection = await conn.getConnection();

                using var cmd = new MySqlCommand(stmt, connection);
                using var cmd1 = new MySqlCommand(stmt1, connection);

                cmd.Parameters.AddWithValue("@status", true);
                cmd.Parameters.AddWithValue("@id", userId);

                cmd1.Parameters.AddWithValue("@proof", null);
                cmd1.Parameters.AddWithValue("@pid", userId);

                await cmd.ExecuteNonQueryAsync();
                int row = await cmd1.ExecuteNonQueryAsync();
                MessageBox.Show((row == 0).ToString());
            }
            catch (Exception) {
                throw;
            }

        }// end of function


        //Delete the user permanently
        public async Task DeleteUserPermanently(string userId) {
            string stmt = "DELETE FROM users WHERE id = @id";

            try {
                using var connection = await conn.getConnection();
                using var cmd = new MySqlCommand(stmt, connection);

                cmd.Parameters.AddWithValue("@id", userId);

                await cmd.ExecuteNonQueryAsync();
            }
            catch (Exception) {
                throw;
            }

        }// end of function



        //To update Perosnal Information of specific user
        public async Task UpdateUserInformations(PersonalInformation pInfo,
            AdditionalInfo addInfo,
             Address address, string userId) {
            using var connection = await conn.getConnection();
            using MySqlTransaction transaction = connection.BeginTransaction();
            try {

                //Query for personal info
                string stmt = "UPDATE personal_info SET firstname = @firstname, middlename = @middlename," +
                    "lastname = @lastname, suffix = @suffix, gender = @gender where user_id = @puser_id ";
                //Query reader for Personal Info
                using var cmd1 = new MySqlCommand(stmt, connection);

                //Parameters
                cmd1.Parameters.AddWithValue("@firstname", pInfo.Firstname);
                cmd1.Parameters.AddWithValue("@middlename", pInfo.Middlename);
                cmd1.Parameters.AddWithValue("@lastname", pInfo.Lastname);
                cmd1.Parameters.AddWithValue("@gender", pInfo.Gender);
                cmd1.Parameters.AddWithValue("@puser_id", userId);
                cmd1.Parameters.AddWithValue("@suffix", pInfo.Suffix);


                //Query for additional info
                string stmt1 = "UPDATE additional_info SET is_voter = @is_voter, civil_status = @civil_status, " +
                   "educational_attaintment = @educational_attaintment, employment_status = @employment_status, " +
                   " resident_type = @resident_type, religion = @religion, birth_day = @birth_day, age = @age, " +
                   "contact_number = @contact_number, profile_image = @profile_image " +
                   "where user_id = @aiuser_id ";

                //Query reader for Additional Info
                using var cmd2 = new MySqlCommand(stmt1, connection);

                //Parameters
                cmd2.Parameters.AddWithValue("@is_voter", addInfo.IsVoter);
                cmd2.Parameters.AddWithValue("@civil_status", addInfo.CivilStatus);
                cmd2.Parameters.AddWithValue("@educational_attaintment", addInfo.EducAttain);
                cmd2.Parameters.AddWithValue("@employment_status", addInfo.EmpStatus);
                cmd2.Parameters.AddWithValue("@resident_type", addInfo.ResidentType);
                cmd2.Parameters.AddWithValue("@religion", addInfo.Religion);
                cmd2.Parameters.AddWithValue("@birth_day", addInfo.BirthDate);
                cmd2.Parameters.AddWithValue("@age", addInfo.Age);
                cmd2.Parameters.AddWithValue("@contact_number", addInfo.ContactNo);
                cmd2.Parameters.AddWithValue("@profile_image", addInfo.ProfileImage);
                cmd2.Parameters.AddWithValue("@aiuser_id", userId);


                //query for address
                string stmt2 = "UPDATE address SET street = @street, house_number = @house_number, " +
                   "subdivision = @subdivision, block_number = @block_number, lot_number = @lot_no " +
                   "where user_id = @auser_id ";

                //Query reader for address
                using var cmd3 = new MySqlCommand(stmt2, connection);

                //Parameters
                cmd3.Parameters.AddWithValue("@street", address.Street);
                cmd3.Parameters.AddWithValue("@house_number", address.HouseNumber);
                cmd3.Parameters.AddWithValue("@subdivision", address.SubdivisionName);
                cmd3.Parameters.AddWithValue("@block_number", address.BlockNumber);
                cmd3.Parameters.AddWithValue("@lot_no", address.LotNo);
                cmd3.Parameters.AddWithValue("@auser_id", userId);

                //Execute queries
                await cmd1.ExecuteNonQueryAsync();
                await cmd2.ExecuteNonQueryAsync();
                await cmd3.ExecuteNonQueryAsync();

                //commit the transactions
                await transaction.CommitAsync();

            }
            catch (Exception) {
                await transaction.RollbackAsync(); // Rollback the transaction, if there is an eror 
                throw;
            }
        }
    }
}