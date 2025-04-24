using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using BrgyMs.backend.database.repositories;
using BrgyMs.backend.models.base_model;
using BrgyMs.backend.models.bo_model;
using System.Data.Common;
using BrgyMs.backend.data_validation;
using BrgyMS.backend.database.connection.models;

namespace BrgyMs.backend.services {
    public class AdminServices {
        private readonly AdminRepository _AdminRepository = new AdminRepository();


        public AdminServices() { }

        //for limiting records and when start the app
        public async Task<List<GetUserInformationResult>> GetUserInformation(int limit) {
            List<GetUserInformationResult> userInfo = await _AdminRepository.GetUserInformation(limit);
            int totalusers = await _AdminRepository.getTotalNUmberOfUsers();
            if (limit <= totalusers) {
                return userInfo;
            }
            return null;
        }

        //for searching data
        public async Task<List<GetUserInformationResult>> GetUserInformation(int limit, string keyword) {
            List<GetUserInformationResult> userInfo = new List<GetUserInformationResult>();
            using (var dataReader = await _AdminRepository.GetUserInformation(limit, keyword)) {
                int totalusers = await _AdminRepository.getTotalNUmberOfUsers();

                if (limit <= totalusers) {
                    while (dataReader.Read()) {
                        //Get the firstname, middlename, lastname and the suffix
                        string fName = (string)dataReader["firstname"];
                        string? mName = (string)dataReader["middlename"];
                        string lName = (string)dataReader["lastname"];
                        string? suffix = (string)dataReader["suffix"];
                        string fullname = "";

                    
                        userInfo.Add(new GetUserInformationResult()
                        {
                            Id = (string)dataReader["id"],
                            Email = (string)dataReader["email"],
                            Role = dataReader.GetString(dataReader.GetOrdinal("role")),
                            Firstname = fName,
                            Middelanme = mName,
                            Lastname = lName,
                            Suffix = suffix,
                            Gender = (string)dataReader["gender"],
                            BirthDate = (DateTime)dataReader["birth_day"],
                            Age = (int)dataReader["age"],
                            ContactNo = (string)dataReader["contact_number"],
                            ResidentType = (string)dataReader["resident_type"]
                        });
                
                    }
                    return userInfo;
                }
            }
            return null;
        }
    }

}