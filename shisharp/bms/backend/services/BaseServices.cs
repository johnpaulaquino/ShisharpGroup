using BrgyMs.backend.database.repositories;
using BrgyMs.backend.models.base_model;
using BrgyMS.backend.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public async Task<List<object>> GetAllUserInformations(string userId) {
            _BaseRepo = new BaseRepository();
            List<object> usersInfo = new List<object>();
            try {

                using (var dataReader = await _BaseRepo.GetUserAllInformation(userId)) {


                    if (dataReader.Read()) {
                        User user;
                        PersonalInformation personalInfo;
                        AdditionalInfo addInfo;
                        Address address;

                        int status = dataReader.GetInt32(dataReader.GetOrdinal("status"));

                        //user info
                        user = new User(
                            dataReader.GetString(dataReader.GetOrdinal("email")),
                            dataReader.GetString(dataReader.GetOrdinal("username"))

                            )
                        {
                            Role = dataReader.GetString(dataReader.GetOrdinal("role")),
                            Password = dataReader.GetString(dataReader.GetOrdinal("email")),
                            Status = dataReader.GetBoolean(dataReader.GetOrdinal("status"))
                        };

                        //Personal Information
                        personalInfo = new PersonalInformation(
                            dataReader.GetString(dataReader.GetOrdinal("firstname")),
                            dataReader.GetString(dataReader.GetOrdinal("middlename")),
                            dataReader.GetString(dataReader.GetOrdinal("lastname")),
                            dataReader.GetString(dataReader.GetOrdinal("gender")))
                        { Suffix = dataReader.GetString(dataReader.GetOrdinal("suffix")) }
                        ;

                        //Additional Information

                        byte[] proofOfResidency = null;
                        byte[] profileImg = null;
                        if (!dataReader.IsDBNull(dataReader.GetOrdinal("proof_of_residency"))) {
                            proofOfResidency = (byte[])dataReader["proof_of_residency"];
                        }
                        if (!dataReader.IsDBNull(dataReader.GetOrdinal("profile_image"))) {
                            profileImg = (byte[])dataReader["profile_image"];
                        }


                        addInfo = new AdditionalInfo(dataReader.GetBoolean(dataReader.GetOrdinal("is_voter")),
                            dataReader.GetDateTime(dataReader.GetOrdinal("birth_day")),
                            dataReader.GetString(dataReader.GetOrdinal("employment_status")),
                            dataReader.GetString(dataReader.GetOrdinal("educational_attaintment")),
                            dataReader.GetString(dataReader.GetOrdinal("civil_status")),
                            dataReader.GetString(dataReader.GetOrdinal("resident_type")),
                            dataReader.GetString(dataReader.GetOrdinal("contact_number")),
                            dataReader.GetString(dataReader.GetOrdinal("religion")),
                            proofOfResidency)
                        {
                            ProfileImage = profileImg,
                            Age = dataReader.GetInt32(dataReader.GetOrdinal("age"))
                        }
                        ;

                        //Address
                        address = new Address(dataReader.GetString(dataReader.GetOrdinal("street")),
                            dataReader.GetString(dataReader.GetOrdinal("house_number")))
                        {
                            BlockNumber = dataReader.GetString(dataReader.GetOrdinal("block_number")),
                            LotNo = dataReader.GetString(dataReader.GetOrdinal("lot_number")),
                            SubdivisionName = dataReader.GetString(dataReader.GetOrdinal("subdivision"))
                        };


                        //add to the objects to the list
                        usersInfo.Add(user);
                        usersInfo.Add(personalInfo);
                        usersInfo.Add(addInfo);
                        usersInfo.Add(address);
                        // lastly return the list taht contains the info


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

        }
    }

}
