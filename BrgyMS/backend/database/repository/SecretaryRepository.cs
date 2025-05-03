using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BrgyMs.database.connector;
using BrgyMs.backend.utils;
using BrgyMs.backend.models.admin_model;
using MySql.Data.MySqlClient;
using BrgyMs.backend.models.secretary_model;
using System.Data;
using BrgyMS.backend.models.base_model;
using System.Reflection.Metadata;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Org.BouncyCastle.Math.EC.Endo;
using BrgyMS.backend.models;

namespace BrgyMs.backend.database.repositories {
    public class SecretaryRepository : BaseRepository {
        private readonly Connector conn;
        private readonly AuthUtils authUtils = new AuthUtils();

        public SecretaryRepository() {
            conn = new Connector();
        }
        public async Task InsertSecretaryUser(SecretaryUser _Secretary) {

            /// <summary>
            /// Create a admin user and insert into database
            /// </summary>
            /// <param name="(Admin">is an admin object that created in model</param>
            /// <returns></returns>
            string stmt = "Insert into users (id, email,password, role,status) "
            + "Values (?,?,?,?,?)";
            try {
                using var connection = await conn.getConnection();
                using (var cmd = new MySqlCommand(stmt, await conn.getConnection())) {
                    cmd.Parameters.AddWithValue("id", _Secretary.Id);
                    cmd.Parameters.AddWithValue("email", _Secretary.Email);
                    cmd.Parameters.AddWithValue("password", authUtils.hashedPassword(_Secretary.Password));
                    cmd.Parameters.AddWithValue("role", _Secretary.Role.ToString());
                    cmd.Parameters.AddWithValue("status", _Secretary.Status);

                    int row = await cmd.ExecuteNonQueryAsync();

                    if (row < 0) {
                        Console.WriteLine(" Failed to insert data!");
                    }
                    Console.WriteLine("Successfully insert data!");

                }
            }


            catch (System.Exception e) {
                throw;
            }
        } // End of the funtion insert admin


        //Retrieve the requestDocuments of residents
        public async Task<DataTable> GetResidentRequestDocs() {

            string stmt = "Select id as 'Transaction Id', document_type as 'Document Type', " +
               "status as Status, request_date as 'Request Date', purpose as 'Purpose'" +
               "FROM request_document " +
               "Where status = @status";

            DataTable dt = new DataTable();

            try {
                using var connection = await conn.getConnection();
                using var adapter = new MySqlDataAdapter(stmt, connection);

                adapter.SelectCommand.Parameters.AddWithValue("@status", "pending");

                await adapter.FillAsync(dt);

                return dt;
            }
            catch (Exception) {

            }
            return null;
        } //end of function



        //To blotter resident or insert a blotter in db. for secretary
        public async Task BlotterResident(BlotterInformation blotter) {
            using var connecetion = await conn.getConnection();
            var transact = await connecetion.BeginTransactionAsync();
            try {
                string stmt = "INSERT INTO blotters (id, complainant_id, respondent_id, statements, status, date_filed, complainant_name, respondent_name) " +
                    "VALUES(@id, @complainant_id, @respondent_id, @statements, @status, @date_filed, @complainant_id, @respondent_id)";


                using var cmd = new MySqlCommand(stmt, connecetion);

                cmd.Parameters.AddWithValue("@id", blotter.Id);
                cmd.Parameters.AddWithValue("@complainant_id", blotter.ComplainantId);
                cmd.Parameters.AddWithValue("@respondent_id", blotter.RespondentId);
                cmd.Parameters.AddWithValue("@statements", blotter.Statements);
                cmd.Parameters.AddWithValue("@status", blotter.Status);
                cmd.Parameters.AddWithValue("@date_filed", blotter.DateFiled);
                cmd.Parameters.AddWithValue("@complainant_name", blotter.ComplainantName);
                cmd.Parameters.AddWithValue("@respondent_name", blotter.RespondentName);


                await cmd.ExecuteNonQueryAsync();
                await transact.CommitAsync();
            }
            catch (Exception) {
                await transact.RollbackAsync();
                throw;
            }
        }


        //get the blotter with a limit
        public async Task<DataTable> GetBlotters() {
            string stmt = "Select id as ID,complainant_id as 'Complainant ID', respondent_id as 'Respondent ID', " +
                "status as Status, statements as Statement, DATE_FORMAT(date_filed, '%W, %M %d, %Y %r') as 'Date Filed' " +
                "From blotters " +
                " limit 10 ";

            try {
                DataTable table = new DataTable();
                using var connection = await conn.getConnection();
                using var adapter = new MySqlDataAdapter(stmt, connection);

                await adapter.FillAsync(table);

                return table;

            }
            catch (Exception) {
                throw;
            }

        }
        //Get all active announcements. Will add offset here
        public async Task<DataTable> GetAnnouncement() {
            string stmt = "SELECT id as ID, title  as Title, DATE_FORMAT(date_post,  '%W, %M %d, %Y %r') as 'Date Post', details as Details " +
                "FROM annoucenments where status = @status Limit 10";

            try {
                using var connection = await conn.getConnection();
                using var adapater = new MySqlDataAdapter(stmt, connection);
                adapater.SelectCommand.Parameters.AddWithValue("@status", "1");
                DataTable dt = new DataTable();

                await adapater.FillAsync(dt);

                return dt;
            }
            catch (Exception) {
                throw;
            }
        }
        //Get announcements to get data for updating
        public async Task<AnnouncementsModel> GetAnnouncement(String id) {
            string stmt = "SELECT id , title , date_post , details, attachment, status " +
                "From annoucenments " +
                "WHERE id =@id";
            AnnouncementsModel announcement = new();
            try {
                using var connection = await conn.getConnection();
                using var adapater = new MySqlCommand(stmt, connection);

                adapater.Parameters.AddWithValue("@id", id);
                using var reader = await adapater.ExecuteReaderAsync();

                if (await reader.ReadAsync()) {
                    announcement = new()
                    {
                        Attachments = (byte[])reader["attachment"],
                        DatePost = reader.GetDateTime("date_post"),
                        Details = reader.GetString("details"),
                        Status = reader.GetBoolean("status"),
                        Title = reader.GetString("title")
                    };

                }
                return announcement;

            }
            catch (Exception) {
                throw;
            }
        }

        public async Task CreateAnnouncement(AnnouncementsModel annoucenment) {
            try {
                string stmt = "INSERT INTO annoucenments(id , title, date_post, details, attachment, status ) " +
                    "VALUES (@id, @title, @datePost, @details, @attachment, @status) ";

                using var connection = await conn.getConnection();
                using var cmd = new MySqlCommand(stmt, connection);

                cmd.Parameters.AddWithValue("@id", annoucenment.Id);
                cmd.Parameters.AddWithValue("@title", annoucenment.Title);
                cmd.Parameters.AddWithValue("@datePost", annoucenment.DatePost);
                cmd.Parameters.AddWithValue("@details", annoucenment.Details);
                cmd.Parameters.AddWithValue("@attachment", annoucenment.Attachments);
                cmd.Parameters.AddWithValue("@status", annoucenment.Status);

                await cmd.ExecuteNonQueryAsync();
            }
            catch (Exception e) {
                throw;
            }
        }// end



    }
}