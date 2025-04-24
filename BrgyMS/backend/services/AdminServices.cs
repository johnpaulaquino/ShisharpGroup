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

namespace BrgyMs.backend.services {
    public class AdminServices {
        private readonly AdminRepository _AdminRepository = new AdminRepository();


        public AdminServices() { }

        //for limiting records and when start the app
        public async Task<MySqlDataAdapter> GetUserInformation(int limit) {
            var userInfo = await _AdminRepository.GetUserInformation(limit);
            int totalusers = await _AdminRepository.getTotalNUmberOfUsers();
            if (limit <= totalusers) {
                return userInfo;
            }
            return null;
        }

        //for searching data
        public async Task<MySqlDataAdapter> GetUserInformation(int limit, string keyword) {

            var dataReader = await _AdminRepository.GetUserInformation(limit, keyword);
            int totalusers = await _AdminRepository.getTotalNUmberOfUsers();

            if (limit <= totalusers) {
                return dataReader;
            }

            return null;
        }
    }

}