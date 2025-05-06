using BrgyMs.database.connector;
using LiveCharts.Wpf;
using MySql.Data.MySqlClient;
using shisharp.bms.backend.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shisharp.bms.backend.database.repository {
    public class ChartRepository {
        private Connector conn = new Connector();
        public ChartRepository() { }


        public async Task<List<ChartsModel>> GetTotalMaleAndFemale() {
            string stmt = "SELECT count(p.gender)as total, p.gender as gender " +
                "FROM personal_info p " +
                "LEFT JOIN address a " +
                "ON p.user_id = a.user_id " +
                "GROUP BY p.gender ";

            try {
                using (var connection = await conn.getConnection()) {
                    List<ChartsModel> totalList = new List<ChartsModel>();
                    using (var cmd = new MySqlCommand(stmt, connection)) {
                        using (var reader = await cmd.ExecuteReaderAsync()) {
                            while (await reader.ReadAsync()) {
                                totalList.Add(
                                    new ChartsModel
                                    {
                                        Value = reader.GetInt32(reader.GetOrdinal("total")),
                                        LabelName = reader.GetString(reader.GetOrdinal("gender"))
                                    }
                                    );
                            }
                            return totalList;
                        }
                    }
                }
                return null;
            }
            catch (Exception ex) {
                throw;
            }
        } // end 

        public async Task<List<ChartsModel>> GetTotalHouseHold() {
            string stmt = "Select count(u.id) as Total, a.street as Street " +
                "FROM users u " +
                "LEFT JOIN address a " +
                "ON u.id = a.user_id " +
                "WHERE u.role = @role and u.status = @status " +
                "GROUP BY a.house_number, a.street";

            try {
                List<ChartsModel> listData = new List<ChartsModel>();
                using (var connection = await conn.getConnection()) {
                    using (var cmd = new MySqlCommand(stmt, connection)) {
                        cmd.Parameters.AddWithValue("@role", "users");
                        cmd.Parameters.AddWithValue("@status", "1");

                        using (var reader = await cmd.ExecuteReaderAsync()) {
                            while (await reader.ReadAsync()) {
                                listData.Add(
                                   new ChartsModel()
                                   {
                                       LabelName = reader.GetString(reader.GetOrdinal("Street")),
                                       Value = reader.GetInt32(reader.GetOrdinal("Total"))
                                   }
                                    );
                            }
                            return listData;
                        }
                    }
                    return null;
                }
            }
            catch (Exception) {
                throw;
            }
        } // end

        public async Task<List<int>> GetTotalVoters() {
            try {
                string stmt = "SELECT count(age) as TotalAge, count(is_voter) TotalVoter " +
                    "FROM additional_info " +
                    "WHERe age >= @age and is_voter = @is_voter ";
                List<int> data = new List<int>();
                using (var connection = await conn.getConnection()) {
                    using (var cmd = new MySqlCommand(stmt, connection)) {
                        cmd.Parameters.AddWithValue("@age", "18");
                        cmd.Parameters.AddWithValue("@is_voter", '1');
                        using (var reader = await cmd.ExecuteReaderAsync()) {
                            if (await reader.ReadAsync()) {
                                data.Add(reader.GetInt32(reader.GetOrdinal("TotalAge")));
                                data.Add(reader.GetInt32(reader.GetOrdinal("TotalVoter")));
                            }
                            return data;
                        }
                    }
                }

            }
            catch (Exception ex) { throw; }

        }

    }
}
