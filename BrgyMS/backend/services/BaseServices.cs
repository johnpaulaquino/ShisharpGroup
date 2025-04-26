using BrgyMs.backend.database.repositories;
using BrgyMS.backend.models;
using System;
using System.Collections.Generic;
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
        }
    }
}
