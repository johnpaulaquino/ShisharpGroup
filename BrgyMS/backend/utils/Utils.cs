using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using BrgyMs.backend.database.repositories;
using BrgyMs.backend.services;
using BrgyMs.database.connector;
using BrgyMS.backend.services;
using MySql.Data.MySqlClient;

namespace BrgyMs.backend.utils {

    public class Utils {
        private string fileDirectory = "";
        private string filename;
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

            if (age <= 0) {
                age = 1;
            }
            return age;

        }// End of calculateAge funtion

        //to format the name in a fullname
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

        //to format roles as Capital First
        public String FormatRoles(string role) {
            string formattedRole = "";
            if (string.IsNullOrEmpty(role)) {
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
            formattedDate = date.ToString("MMMM, dd, yyyy"); // format the date

            return formattedDate;
        }

        //to write the id on the file
        public void PutIdOnFile(String UserId) {
            //get the curr directory and add info directory
            fileDirectory = Path.Combine(Directory.GetCurrentDirectory(), "../../../../tempid");


            //check if not exist, then create
            if (!Directory.Exists(fileDirectory)) {
                Directory.CreateDirectory(fileDirectory);

            }
            filename = "/tempId.tmp";
            //// check if not exist, then create
            String filepath = fileDirectory + filename; // location of the file the file
            FileStream fileWriter = File.Create(filepath); // generate the file
            fileWriter.Close(); //close the current file

            using (FileStream fs = new FileStream(filepath, FileMode.Create, FileAccess.Write, FileShare.Write)) {
                using (StreamWriter writer = new StreamWriter(fs)) {

                    writer.Write(UserId);
                }
            }

        }//end of function

        //Read temporary file to get the user id
        public string ReadUserIdInFile() {
            filename = "/tempId.tmp";
            string UserId = "";
            fileDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../../tempid"); // location of the folder

            string fileLocation = fileDirectory + filename; // the location of the file to read
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
            filename = "/tempId.tmp";
            fileDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../../tempid");
            string fileLocation = fileDirectory + filename;
            if (File.Exists(fileLocation)) {
                using var fs = new FileStream(fileLocation, FileMode.Open, FileAccess.Read, FileShare.Delete);
                File.Delete(fileLocation);

            }
        } // End of function




        //Put blotter id on file
        public void PutBlotterIdOnFile(String UserId) {
            filename = "/tempblotterId.tmp";
            //get the curr directory and add info directory
            fileDirectory = Path.Combine(Directory.GetCurrentDirectory(), "../../../../tempid");


            //check if not exist, then create
            if (!Directory.Exists(fileDirectory)) {
                Directory.CreateDirectory(fileDirectory);

            }
            //// check if not exist, then create
            String filepath = fileDirectory + filename; // location of the file the file
            FileStream fileWriter = File.Create(filepath); // generate the file
            fileWriter.Close(); //close the current file

            using (FileStream fs = new FileStream(filepath, FileMode.Create, FileAccess.Write, FileShare.Write)) {
                using (StreamWriter writer = new StreamWriter(fs)) {

                    writer.Write(UserId);
                }
            }

        }//end of function

        //Read temporary file to get the blotter id
        public string ReadBlotterIdInFile() {
            filename = "/tempblotterId.tmp";
            string UserId = "";
            fileDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../../tempid"); // location of the folder
            string fileLocation = fileDirectory + filename; // the location of the file to read
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
        public void DeleteBlotterIdAfterCloseTheModal() {
            filename = "/tempblotterId.tmp";
            fileDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../../tempid");
            string fileLocation = fileDirectory + filename;
            if (File.Exists(fileLocation)) {
                using var fs = new FileStream(fileLocation, FileMode.Open, FileAccess.Read, FileShare.Delete);
                File.Delete(fileLocation);

            }
        } // End of function
    }
}