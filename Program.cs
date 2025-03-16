using System;
using BMS.database.respositories;
using BMS.backend.utils;
using BMS.backend.database.repositories;
using BMS.backend.models;
using BMS.backend.services;
using System.Threading.Tasks;
using CSharpBackEnd.backend.services;

class MyProgram {
  public static async Task Main(string[] args) {
    var auUtils = new AuthUtils();
    var utils = new Utils();
    var authServices = new AuthServices();
    var ItServices = new ItServices();
    var admin = new AdminUser("John Paul", "paulohn123@gmail.com", "paul123");
    Dictionary<string, string> data = new Dictionary<string, string>();

    try {
    }
    catch (System.Exception e) {

      Console.WriteLine(e.Message);
    }
  }
}
