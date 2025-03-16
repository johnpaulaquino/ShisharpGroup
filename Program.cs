using System;
using BMS.database.respositories;
using BMS.backend.utils;
using BMS.backend.database.repositories;
using BMS.backend.models;
using BMS.backend.services;
using System.Threading.Tasks;
using BMS.backend.database.models;


class MyProgram {
  public static async Task Main(string[] args) {
    var auUtils = new AuthUtils();
    var adminRepo = new AdminReposiroty();
    var utils = new Utils();
    var authServices = new AuthServices();
    var ItServices = new ItServices();
    var adminServices = new AdminServices();
    var residetInfo = new ResidentInfo("John Paul", "Castro",
    "Aquino", "Paul@gmail.com", Gender.Male);
    var residentAddress = new ResidentAddress("Gumamela", 110, "", 0);
    DateTime bday = new DateTime(2003, 07, 23);
    var residentAddInfo = new ResidentAdditionalInfo(true, bday.Date,
    "UnEmployed", "College", "Single");
    var admin = new AdminUser("John Paul", "paulohn123@gmail.com", "paul123");
    Dictionary<string, string> data = new Dictionary<string, string>();


  }
}
