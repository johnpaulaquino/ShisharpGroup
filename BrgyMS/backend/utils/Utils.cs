using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using BrgyMs.database.connector;
using MySql.Data.MySqlClient;

namespace BrgyMs.backend.utils {
    public class Utils {
        private string fileDirectory = "";
        private string filename = "/tempId.tmp";
        public int calculateAge(DateTime birthDate) {

            DateTime todayDate = DateTime.Today;

            int yearToday = todayDate.Year;
            int monthToday = todayDate.Month;
            int dayToday = todayDate.Day;

            int yearBday = birthDate.Year;
            int monthBday = birthDate.Month;
            int dayBday = birthDate.Day;

            int age = yearToday - yearBday;

            if (monthToday < monthBday && dayToday < dayBday) {
                age -= 1;
            }
            return age;

        }// End of calculateAge funtion

        public string FormatFullname(string fName,
            string mName, string lName, string suffix) {

            string fullname = fName;
            if (String.IsNullOrEmpty(mName) && string.IsNullOrEmpty(suffix)) {
                fullname += " " + lName;
            }
            else if (string.IsNullOrEmpty(mName)) {
                fullname += " " + lName + " " + suffix;
            }
            else if (string.IsNullOrEmpty(suffix)) {
                fullname += " " + mName[0].ToString().ToUpper() + ". " + lName;
            }
            else {
                fullname += mName[0].ToString().ToUpper() + ". " + lName + " " + suffix;
            }

            return fullname;
        }

        public String FormatRoles(string role) {
            string formattedRole = "";
            if (string.IsNullOrEmpty(formattedRole)) {
                return formattedRole;
            }
            formattedRole = string.Concat(role[0].ToString().ToUpper(), role.Substring(1));

            return formattedRole;
        }
        public string FormatDate(DateTime date) {
            string formattedDate = "";
            if (string.IsNullOrEmpty(date.ToString())) {
                return formattedDate;
            }
            formattedDate = date.ToString("MMMM, dd, yyyy");

            return formattedDate;
        }


        public void PutIdOnFile(String UserId) {
            //get the curr directory and add info directory
            fileDirectory = Path.Combine(Directory.GetCurrentDirectory(), "../../../tempid");


            //check if not exist, then create
            if (!Directory.Exists(fileDirectory)) {
                Directory.CreateDirectory(fileDirectory);

            }
            //// check if not exist, then create
            String filepath = fileDirectory +  filename;
            FileStream fileWriter = File.Create(filepath);
            fileWriter.Close();

            using (FileStream fs = new FileStream(filepath, FileMode.Create, FileAccess.Write, FileShare.Write)) {
                using (StreamWriter writer = new StreamWriter(fs)) {

                    writer.Write(UserId);
                }
            }

        }

        //Read temporary file to get the user ids
        public string ReadUserIdInFile() {
            string UserId = "";
            fileDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../tempid");
            string fileLocation = fileDirectory +  filename;


            //then read

            if (File.Exists(fileLocation)) {
                using (var fs = new FileStream(fileLocation, FileMode.Open, FileAccess.Read, FileShare.None)) {
                    using (var reader = new StreamReader(fs)) {
                        UserId = reader.ReadToEnd();

                    }
                }
            }


            return UserId;
        }

        //Delete temporary file
        public void DeleteUserIdAfterCloseTheModal() {
            fileDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../tempid");
            string fileLocation = fileDirectory + filename;
            if (File.Exists(fileLocation)) {
                using var fs = new FileStream(fileLocation, FileMode.Open, FileAccess.Read, FileShare.Delete);
                File.Delete(fileLocation);

            }
        }
    }
}