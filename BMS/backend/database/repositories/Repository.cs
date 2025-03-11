using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

using BackEnd.database.connection;

namespace BackEnd.database.respositories
{
    public class Repository
    {
        private MySqlConnection conn ; 
        public Repository(){
            this.conn = new Connector().getConnection();

        }

        public void getUsers(){
            String stmt = "Select * From students";
            try
            {
                using(MySqlCommand cmd = new MySqlCommand(stmt, this.conn)){
                    using(var reader = cmd.ExecuteReader()){
                        while(reader.Read()){
                            Console.WriteLine(reader.GetString("student_name"));
                        }
                    }
                }
                
            }
            catch (System.Exception)
            {
                
                throw;
            }
            
        }
        
    }
}