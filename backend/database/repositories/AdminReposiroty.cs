using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BMS.database.connector;
using MySql.Data.MySqlClient;


namespace BMS.backend.database.repositories {
    public class AdminReposiroty : ITRepository {
        private readonly MySqlConnection conn;
        public AdminReposiroty() {
            conn = new Connector().getConnection();
        }

        public async Task DeleteAdminUser(string Id) {
            Dictionary<string, string> data = await GetInfoById(Id);
            try {
                if (data.Count < 0) {
                    throw new Exception("Can't delete this, because user not found!");
                }
                string deleteStmt = "Delete from admin_users "
                + "Where id = ?";
                using (var cmd = new MySqlCommand(deleteStmt, conn)) {
                    cmd.Parameters.AddWithValue("id", data["id"]);
                    await cmd.ExecuteNonQueryAsync();
                    Console.WriteLine("Successully deleted admin user");
                }
            }
            catch (System.Exception) {

                throw;
            }



        }// End of delett function
    }
}