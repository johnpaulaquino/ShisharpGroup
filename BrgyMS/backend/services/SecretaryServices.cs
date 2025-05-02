using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using BrgyMs.backend.data_validation;
using BrgyMs.backend.database.repositories;
using BrgyMs.backend.models.base_model;
using BrgyMs.backend.models.bo_model;
using BrgyMS.backend.models.base_model;
using BrgyMS.backend.services;
using MySql.Data.MySqlClient;

namespace BrgyMs.backend.services {
    public class SecretaryServices : BaseServices {
        private ResidentRepository _ResidentRepo = new ResidentRepository();
        private UserInfoValidation _Validation = new UserInfoValidation();
        private SecretaryRepository _SedcretaryRepo = new();
        private UserInfoValidation validation = new();

        public SecretaryServices() {

        }

        // to set the data in table for approval documents in the secretary approval documents
        public async Task SetDataForApproveDocumentsTable(DataGridView table) {

            if (_SedcretaryRepo == null) {
                _SedcretaryRepo = new();
            }
            try {


                DataTable dt = await _SedcretaryRepo.GetResidentRequestDocs();
                table.Columns.Clear();

                table.DataSource = dt;
            }
            catch (Exception) {
                throw;
            }
        }

        //Show all blotters from table
        public async Task FillBlotterTable(DataGridView table, int limit = 10) {
            try {
                var dt = await _SedcretaryRepo.GetBlotters(limit);
                table.Columns.Clear();
                table.DataSource = dt;
            }
            catch (Exception) {
                throw;
            }
        } //end

        public async Task BlotterResident(BlotterInformation blotter) {
            try {
                validation.ValidateBlotter(blotter); // validate First before insert
                await Task.Run(async () =>
                 {
                     await _SedcretaryRepo.BlotterResident(blotter);
                 });

            }
            catch (Exception) {
                throw;
            }
        }


    }
}