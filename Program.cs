using System;
using BMS.database.respositories;
using BMS.backend.utils;
using BMS.backend.database.repositories;
using BMS.backend.models;
using BMS.backend.services;
using System.Threading.Tasks;
using BMS.backend.models.residents_model;
using BMS.backend.models.admin_model;


class MyProgram {
  public static async Task Main(string[] args) {
    var auUtils = new AuthUtils();
    var adminRepo = new AdminReposiroty();
    var stdRepo = new UserRepository();
    var utils = new Utils();
    var authServices = new AuthServices();
    var ItServices = new ItServices();
    var adminServices = new AdminServices();

    var residetInfo = new ResidentInfo("Paul@gmail.com", "John Paul", "Castro",
    "Aquino", Gender.Male);
    var residentAddress = new ResidentAddress("Gumamela", 110, "", 0);
    DateTime bday = new DateTime(2003, 07, 23);
    var residentAddInfo = new ResidentAdditionalInfo(true, bday.Date,
    "UnEmployed", "College", "Single");
    var admin = new AdminUser("John Paul", "paulohn123@gmail.com", "paul123");
    Dictionary<string, string> data = new Dictionary<string, string>();

  }
}
