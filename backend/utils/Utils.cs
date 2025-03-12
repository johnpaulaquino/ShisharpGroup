using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpBackEnd.backend.utils
{
    public class Utils{
        public Utils(){

    }
    public int getAge(DateTime birthDate){

        DateTime todayDate = DateTime.Today;

        int yearToday = todayDate.Year;
        int monthToday = todayDate.Month;
        int dayToday = todayDate.Day;

        int yearBday = birthDate.Year;
        int monthBday = birthDate.Month;
        int dayBday = birthDate.Day;

        int age = yearToday - yearBday;

        if (monthToday < monthBday){
            age -= 1;

        }else if(monthToday < monthBday && dayToday < dayToday){
            age -= 1;
        }
    

        

        return age;
    }
}
}
    