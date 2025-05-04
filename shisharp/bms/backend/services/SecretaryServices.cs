using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BrgyMs.backend.data_validation;
using BrgyMs.backend.database.repositories;
using BrgyMs.backend.models.base_model;
using BrgyMs.backend.models.bo_model;
using BrgyMS.backend.models;
using BrgyMS.backend.models.base_model;
using BrgyMS.backend.services;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;

namespace BrgyMs.backend.services {
    public class SecretaryServices : BaseServices {
        private ResidentRepository _ResidentRepo = new ResidentRepository();
        private UserInfoValidation _Validation = new UserInfoValidation();
        private SecretaryRepository _SecretaryRepo = new SecretaryRepository();
        private UserInfoValidation validation = new UserInfoValidation();

        public SecretaryServices() {

        }

        // to set the data in table for approval documents in the secretary approval documents
        public async Task SetDataForApproveDocumentsTable(DataGridView table) {

            if (_SecretaryRepo == null) {
                _SecretaryRepo = new SecretaryRepository();
            }
            try {


                DataTable dt = await _SecretaryRepo.GetResidentRequestDocs();
                table.Columns.Clear();

                table.DataSource = dt;
            }
            catch (Exception) {
                throw;
            }
        }

        //Show all blotters from table
        public async Task FillBlotterTable(DataGridView table) {
            try {
                var dt = await _SecretaryRepo.GetBlotters();
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
                     await _SecretaryRepo.BlotterResident(blotter);
                 });

            }
            catch (Exception) {
                throw;
            }
        } //end

        public async Task CreateAnnouncemrnts(AnnouncementsModel announce) {
            try {
                validation.ValidateAnnoucnement(announce); // validate first
                await _SecretaryRepo.CreateAnnouncement(announce); // then insert if no found error
            }
            catch (Exception) {
                throw;
            }
        } // end

        public async Task FillAnnouncementTable(DataGridView table) {
            try {
                var dt = await _SecretaryRepo.GetAnnouncement();

                table.Columns.Clear();
                table.DataSource = dt;

            }
            catch (Exception) {
                throw;
            }
        } // end

        //Gte the annoucnement for updatng annoucnement
        public async Task<AnnouncementsModel> GetAnnouncement(string id) {
            try {

                AnnouncementsModel announce = await Task.Run(async () =>
                {
                    return await _SecretaryRepo.GetAnnouncement(id);
                });

                return announce;

            }
            catch (Exception) {
                throw;
            }
        }// end 


        //Add the officials
        public async Task AddBarangayOfficials(OfficialsInfo officialsInfo) {
            try {
                validation.ValidatebarangayOfficials(officialsInfo); // validate first 

                string EelcHisto = JsonConvert.SerializeObject(officialsInfo.ElectionHistories, Newtonsoft.Json.Formatting.Indented); // serialize the object
                await Task.Run(async () =>
                {
                    bool isExist = await _ResidentRepo.CheckOfficialsIfExists(officialsInfo.UserId);
                    if (isExist) {
                        throw new Exception("Already added as Barangay Officials!");
                    }

                    await _ResidentRepo.AddOfficialsInfo(officialsInfo, EelcHisto); // then insert if no error
                });


            }
            catch (Exception) {
                throw;
            }
        } // end

        public async Task<DataTable> GetOFficialsInfo() {
            try {

                var dt = await _SecretaryRepo.GetOfficials();
                return dt;
            }
            catch (Exception) {
                throw;
            }
        } //end

        public async Task<DataTable> GetOFficialsInfo(string id) {
            try {

                var dt = await _SecretaryRepo.GetOfficials(id);
                return dt;
            }
            catch (Exception) {
                throw;
            }
        } //end


    }
}