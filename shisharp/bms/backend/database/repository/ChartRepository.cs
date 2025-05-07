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
                "FROM users u " +
                "RIGHT JOIN personal_info p " +
                "ON u.id = p.user_id " +
                "RIGHT JOIN address a " +
                "ON u.id = a.user_id " +
                "WHERE u.status = @status " +
                "GROUP BY p.gender ";

            try {
                using (var connection = await conn.getConnection()) {
                    List<ChartsModel> totalList = new List<ChartsModel>();
                    using (var cmd = new MySqlCommand(stmt, connection)) {
                        cmd.Parameters.AddWithValue("@status", "1");
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
                }
            }
            catch (Exception) {
                throw;
            }
        } // end

        public async Task<List<int>> GetTotalVoters() {
            try {
                string stmt = @"SELECT 
            (SELECT  COUNT(u.id) AS Population from users u 
            LEFT JOIN additional_info p 
            ON u.id = p.user_id
            WHERE u.status = @status and p.age >= @age1) As Population, 
            
            (SELECT COUNT(u.id) FROM users u 
            LEFT JOIN additional_info p ON u.id = p.user_id
            WHERE u.status = @status1 AND age >= @age) AS Population";

                List<int> data = new List<int>();
                using (var connection = await conn.getConnection()) {
                    using (var cmd = new MySqlCommand(stmt, connection)) {
                        cmd.Parameters.AddWithValue("@status", 1);
                        cmd.Parameters.AddWithValue("@status1", 1);
                        cmd.Parameters.AddWithValue("@age", 18);
                        cmd.Parameters.AddWithValue("@age1", 18);

                        using (var reader = await cmd.ExecuteReaderAsync()) {
                            if (await reader.ReadAsync()) {
                                int population = reader.GetInt32(reader.GetOrdinal("Population"));
                                int totalVoter = reader.GetInt32(reader.GetOrdinal("Population"));
                                data.Add(population);
                                data.Add(totalVoter);
                            }

                        }
                    }
                    return data;
                }

            }

            catch (Exception ex) { throw; }

        }

    }
}
