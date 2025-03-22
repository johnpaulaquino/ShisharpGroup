using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BMS.database.connector;
using MySql.Data.MySqlClient;

namespace BMS.backend.utils {
    public class Utils {
        public int calculateAge(DateOnly birthDate) {

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

    }
}
