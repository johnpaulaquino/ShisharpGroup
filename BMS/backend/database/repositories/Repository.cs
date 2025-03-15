using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

using BackEnd.database.connection;
using CSharpBackEnd.backend.models;

namespace BackEnd.database.respositories
{
    public class Repository
    {
        private MySqlConnection conn ; 
        public Repository(){
            this.conn = new Connector().getConnection();

        }

        public Dictionary<String, String> getUsers(){
            string stmt = "Select * From students";
            Dictionary<string, string> data = new Dictionary<string, string>();
            try
            {
                using(MySqlCommand cmd = new MySqlCommand(stmt, this.conn)){
                   
                    using(var reader = cmd.ExecuteReader()){
                        if(reader.Read()){
                            data.Add("name", reader.GetString("student_name"));
                        }
                    }
                }
                return data;
            }
            catch (System.Exception)
            {
                
                throw;
            }
            
        }

        public Dictionary<string, string> getUser(string username){
            Dictionary<string, string> data = new Dictionary<string, string>();
            string stmt = "Select * from students WHERE student_id = ?";
            try{
                  using (MySqlCommand cmd = new MySqlCommand(stmt, this.conn)){
                    cmd.Parameters.AddWithValue("student_id",username);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            data.Add("id", reader.GetString("id"));
                            data.Add("student_id", reader.GetString("student_id"));
                        }
                    }
            }
                
            } catch (System.Exception){
                
                throw;
            }
          
            return data;
        }
        public void insertAdminUser(AdminUser admin){
            string stmt = "Insert into admin_users (id, username, email,password, role) "
            +"Values (?,?,?,?,?)";
            try
            {
                using (var cmd = new MySqlCommand(stmt, this.conn))
                {
                cmd.Parameters.AddWithValue("id",admin.id);
                cmd.Parameters.AddWithValue("username",admin.username);
                cmd.Parameters.AddWithValue("email",admin.email);
                cmd.Parameters.AddWithValue("password",admin.password);
                cmd.Parameters.AddWithValue("role",admin.role.ToString());

                int row = cmd.ExecuteNonQuery();

                if(row < 0){
                    Console.WriteLine("Failed to insert data!");
                }

                }
            }
            catch (MySqlException e)
            {
                
                Console.WriteLine(e.Message);
            }
        }
    }

    
}