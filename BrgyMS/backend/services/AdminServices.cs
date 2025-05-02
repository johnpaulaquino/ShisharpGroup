using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using BrgyMs.backend.database.repositories;
using BrgyMs.backend.models.base_model;
using BrgyMs.backend.models.bo_model;
using System.Data.Common;
using BrgyMs.backend.data_validation;
using MySql.Data.MySqlClient;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using BrgyMS.backend.services;
using System.Security.Cryptography.X509Certificates;
using BrgyMs.backend.utils;
using OtpNet;
using BrgyMS.backend.models.base_model;
using MySqlX.XDevAPI.Common;

namespace BrgyMs.backend.services {
    public class AdminServices : BaseServices {
        private readonly AdminRepository _AdminRepository = new AdminRepository();
        private readonly ResidentRepository _ResidentRepo = new ResidentRepository();
        private readonly UserInfoValidation uservalidation = new();
        private readonly EmailServices _EmailServices = new();
        private readonly UserInfoValidation validation = new();

        public AdminServices() { }

        //for limiting records and when start the app
        public async Task<DataTable> GetUserInformation(int limit) {

            var userInfo = Task.Run(() =>
            {
                return _AdminRepository.GetUserInformation(limit);

            });
            return await userInfo;

        }

        //for blotter Resident
        public async Task<DataTable> GetUserInformation() {

            try {
                return await _AdminRepository.GetUserInformation();
            }
            catch (Exception) {
                throw;
            }

        }

        //for searching data
        public async Task<MySqlDataAdapter> GetUserInformation(int limit, string keyword) {

            var dataReader = await _AdminRepository.GetUserInformation(limit, keyword);
            //int totalusers = await _AdminRepository.getTotalNUmberOfUsers();

            return dataReader;


        }

        //Get all logs
        public async Task<MySqlDataAdapter> GetAllLogs(int limit) {
            var dataAdapter = await _AdminRepository.GetAllUsersLogs(limit);
            //int totalusers = await _AdminRepository.getTotalNUmberOfUsers();

            return dataAdapter;


        }

        //Get all users who are inactive
        public async Task<MySqlDataAdapter> GetInActiveResidentUser() {

            var dataAdapter = await _AdminRepository.GetInActiveResidentUser();
            return dataAdapter;
        }


        public async Task<List<User>> GetUserBasicInfo(string UserId) {
            try {
                using var reader = await _AdminRepository.GetUserAllInformation(UserId);
                List<User> user = new List<User>();
                while (reader.Read()) {
                    bool status = false;

                    if (string.Equals(reader.GetInt32("status").ToString(), "1")) {
                        status = true;
                    }

                    user.Add(new User(reader.GetString("email"),

                    reader.GetString("username"))

                    {
                        Status = status,
                        Password = reader.GetString("password"),
                    }

                   );

                }
                return user;
            }
            catch (Exception) {
                throw;
            }
        } // End of function



        /// <summary>
        /// Update the account information of users
        /// </summary>
        /// <returns></returns>
        public async Task UpdateAccountInfo(User users, string userId) {
            try {
                // Validate first
                uservalidation.ValidateUser(users);
                //Update
                await _AdminRepository.UpdateAccountInfo(users, userId);
            }
            catch (Exception) {
                throw;
            }
        }// end of function

        public async Task ActivateUserAccount(string userId, bool isValidated, string email) {
            try {
                //check if the user is not approved by admin, then delete the user
                if (!isValidated) {

                    await _AdminRepository.DeleteUserPermanently(userId);
                    //Will notify the user via email. will implement soon
                    return;
                }
                await _AdminRepository.ActivateUserAccount(userId);
                //Will notify the user via email. will implement soon

            }
            catch (Exception) {
                throw;
            }

        }// end of funttion

        public async Task CreateUser(User user) {
            try {
                //check if the user is Exist
                await Task.Run(async () =>
                {
                    Dictionary<string, string> data = await _AdminRepository.GetEmail(user.Email);
                    if (data != null) {
                        throw new Exception("Email is already Exist!");
                    }

                });

                uservalidation.ValidateUser(user); // validate user

                await Task.Run(async () =>
                {
                    await _AdminRepository.AddUser(user); // then add if no encounter error
                });

            }
            catch (Exception) {
                throw;
            }
        }// end of function

        //Total population
        public async Task<List<string>> GetTotalBlotterPopHouseholds() {
            try {
                List<string> data = await _AdminRepository.GetTotalBlotterPopHouseholds();
                if (data != null) {
                    return data;
                }
                return null;
            }
            catch (Exception) {
                throw;
            }
        } // end

        //validate before update the blotter info
        public async Task UpdateBlotter(string id, BlotterInformation blotter) {
            try {
                validation.ValidateBlotter(blotter);

                await Task.Run(async () => { await _AdminRepository.UpdateBlotter(id, blotter); });

            }
            catch (Exception) {
                throw;
            }
        } // end

        public async Task DeleteBlotter(string id) {
            try {
                await Task.Run(async() =>
                {
                    await _AdminRepository.DeleteBlotter(id);
                });
            }
            catch (Exception) {
                throw;
            }
        }

    }

}