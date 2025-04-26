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
using MySql.Data.MySqlClient;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BrgyMs.backend.services {
    public class AdminServices {
        private readonly AdminRepository _AdminRepository = new AdminRepository();
        private readonly UserInfoValidation uservalidation = new();

        public AdminServices() { }

        //for limiting records and when start the app
        public async Task<MySqlDataAdapter> GetUserInformation(int limit) {
            var userInfo = await _AdminRepository.GetUserInformation(limit);

            return userInfo;

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
        public async Task<List<User>> GetUserAllInformation(string UserId) {
            try {
                using var reader = await _AdminRepository.GetUserAllInformation(UserId);
                List<User> user = new List<User>();
                while (reader.Read()) {
                    bool status = false;

                    if (string.Equals(reader.GetInt32("status").ToString(), "1")) {
                        status = true;
                    }

                    user.Add(new User(reader.GetString("email"),
                    reader.GetString("password"),
                    reader.GetString("username"))

                    { Status = status }
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
        }

    }

}