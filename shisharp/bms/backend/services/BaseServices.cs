using BrgyMs.backend.database.repositories;
using BrgyMs.backend.models.base_model;
using BrgyMS.backend.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BrgyMS.backend.services {
    public class BaseServices {
        private AdminRepository _AdminRepo = new AdminRepository();
        private BaseRepository _BaseRepo = new BaseRepository();
        private ResidentRepository _ResidentRepo = new ResidentRepository();
        private SecretaryRepository _SecretaryRepo = new SecretaryRepository();

        public BaseServices() {

        }

        //Log user actions
        public async Task LogUserActions(Logs logs) {

            try {
                await Task.Run(() =>
                {
                    return _BaseRepo.LogUserActions(logs);
                });

            }
            catch (Exception) {
                throw;
            }
        }


        //Generate unique id for logs
        public async Task<string> GenerateLogsId() {

            try {
                var generateLogs = await _BaseRepo.GenerateLogsId();
                return generateLogs;
            }
            catch (Exception) {
                throw;
            }
        } // end of the line

        public async Task<int> GetTotalResidetnLogs(string userid) {
            try {
                return await _BaseRepo.GetTotalResidetnLogs(userid);
            }
            catch (Exception ex) {
                throw;
            }
        }

        public async Task<List<object>> GetAllUserInformations(string userId) {
            _BaseRepo = new BaseRepository();
            List<object> usersInfo = new List<object>();
            try {

                using (var dataReader = await _BaseRepo.GetUserAllInformation(userId)) {

                    if (await dataReader.ReadAsync()) {
                        string GetString(string column) => dataReader.IsDBNull(dataReader.GetOrdinal(column)) ? null : dataReader.GetString(dataReader.GetOrdinal(column));
                        int? GetInt(string column) => dataReader.IsDBNull(dataReader.GetOrdinal(column)) ? (int?)null : dataReader.GetInt32(dataReader.GetOrdinal(column));
                        bool? GetBool(string column) => dataReader.IsDBNull(dataReader.GetOrdinal(column)) ? (bool?)null : dataReader.GetBoolean(dataReader.GetOrdinal(column));
                        DateTime? GetDate(string column) => dataReader.IsDBNull(dataReader.GetOrdinal(column)) ? (DateTime?)null : dataReader.GetDateTime(dataReader.GetOrdinal(column));
                        byte[] GetBytes(string column) => dataReader.IsDBNull(dataReader.GetOrdinal(column)) ? null : (byte[])dataReader[column];

                        // User
                        var user = new User(GetString("email"), GetString("username"))
                        {
                            Role = GetString("role"),
                            Password = GetString("email"), // Probably meant to be a different field?
                            Status = GetBool("status") ?? false
                        };

                        // Personal Info
                        var personalInfo = new PersonalInformation(
                            GetString("firstname"),
                            GetString("middlename"),
                            GetString("lastname"),
                            GetString("gender")
                        )
                        {
                            Suffix = GetString("suffix")
                        };

                        // Additional Info
                        var addInfo = new AdditionalInfo(
                            GetBool("is_voter") ?? false,
                            GetDate("birth_day") ?? DateTime.MinValue,
                            GetString("employment_status"),
                            GetString("educational_attaintment"),
                            GetString("civil_status"),
                            GetString("resident_type"),
                            GetString("contact_number"),
                            GetString("religion"),
                            GetBytes("proof_of_residency")
                        )
                        {
                            ProfileImage = GetBytes("profile_image"),
                            Age = GetInt("age") ?? 0
                        };

                        // Address
                        var address = new Address(
                            GetString("street"),
                            GetString("house_number")
                        )
                        {
                            BlockNumber = GetString("block_number"),
                            LotNo = GetString("lot_number"),
                            SubdivisionName = GetString("subdivision")
                        };

                        // Add to list
                        usersInfo.Add(user);
                        usersInfo.Add(personalInfo);
                        usersInfo.Add(addInfo);
                        usersInfo.Add(address);
                    }
                    return usersInfo;
                }

            }
            catch (Exception) {
                throw;
            }

        } // end of the funtion

        //Update User Information 
        public async Task UpdateUserInformations(string userId,
            PersonalInformation pInfo, AdditionalInfo addInfo,
            Address address
            ) {
            try {
                await _BaseRepo.UpdateUserInformations(pInfo, addInfo, address, userId);
            }
            catch (Exception) {
                throw;
            }

        }// end

        public async Task<DataTable> GetOFficialsInfo() {
            try {

                var dt = await _SecretaryRepo.GetOfficials();
                return dt;
            }
            catch (Exception) {
                throw;
            }
        } //end


        public async Task<DataTable> GetUserlogs(string userid) {
            try {
                var dt = await Task.Run(async () =>
                {
                    return await _BaseRepo.GetUserlogs(userid);
                });

                return dt;
            }

            catch (Exception) {
                throw;
            }
        }
    }

}
