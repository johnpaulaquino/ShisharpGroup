using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BrgyMs.database.connector;
using MySql.Data.MySqlClient;

namespace BrgyMs.backend.utils {
    public class Utils {
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

    }
}