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
        private readonly AdminRepository _AdminRepo = new();
        private readonly BaseRepository _BaseRepo = new();
        private readonly ResidentRepository _ResidentRepo = new();
        private readonly SecretaryRepository _SecretaryRepo = new();

        public BaseServices() {

        }

        //Log user actions
        public async Task LogUserActions(Logs logs) {

            try {
                await _BaseRepo.LogUserActions(logs);
            }
            catch (Exception) {
                throw;
            }
        }


        //Generate unique id for logs
        public async Task<string> GenerateLogsId() {

            try {
                return await _BaseRepo.GenerateLogsId();
            }
            catch (Exception) {
                throw;
            }
        } // end of the line

        public async Task<List<object>> GetAllUserInformations(string userId) {
            try {
                List<object> usersInfo = new List<object>();

                using var dataReader = await _BaseRepo.GetUserAllInformation(userId);
                User user;
                PersonalInformation personalInfo;
                AdditionalInfo addInfo;
                Address address;
              
                if (dataReader.Read()) {
                    int status = dataReader.GetInt32("status");

                    //user info
                    user = new User(
                        dataReader.GetString("email"),
                        dataReader.GetString("username")

                        )
                    {
                        Role = dataReader.GetString("role"),
                        Password = dataReader.GetString("email"),
                        Status = dataReader.GetBoolean("status")
                    };

                    //Personal Information
                    personalInfo = new PersonalInformation(
                        dataReader.GetString("firstname"),
                        dataReader.GetString("middlename"),
                        dataReader.GetString("lastname"),
                        dataReader.GetString("gender"))
                    { Suffix = dataReader.GetString("suffix") };

                    //Additional Information


                    
                    byte[]? proofOfResidency = null;
                    byte[]? profileImg = null;
                    if (!dataReader.IsDBNull(dataReader.GetOrdinal("proof_of_residency"))) {
                        proofOfResidency = (byte[]?)dataReader["proof_of_residency"];
                    }
                    if (!dataReader.IsDBNull(dataReader.GetOrdinal("profile_image"))) {
                        profileImg = (byte[]?)dataReader["profile_image"];
                    }

                    
                    addInfo = new AdditionalInfo(dataReader.GetBoolean("is_voter"),
                        dataReader.GetDateTime("birth_day"),
                        dataReader.GetString("employment_status"),
                        dataReader.GetString("educational_attaintment"),
                        dataReader.GetString("civil_status"),
                        dataReader.GetString("resident_type"),
                        dataReader.GetString("contact_number"),
                        dataReader.GetString("religion"),
                        proofOfResidency)
                    { ProfileImage = profileImg, 
                    Age = dataReader.GetInt32("age")};

                    //Address
                    address = new Address(dataReader.GetString("street"),
                        dataReader.GetString("house_number")){ 
                    BlockNumber = dataReader.GetString("block_number"),
                    LotNo = dataReader.GetString("lot_number"),
                    SubdivisionName = dataReader.GetString("subdivision")
                    };


                    //add to the objects to the list
                    usersInfo.Add(user);
                    usersInfo.Add(personalInfo);
                    usersInfo.Add(addInfo);
                    usersInfo.Add(address);
                }
                // lastly return the list taht contains the info
                return usersInfo;
            }
            catch (Exception) {
                throw;
            }
        }
    }

}
