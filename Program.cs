using System;
using BMS.database.respositories;
using BMS.backend.utils;
using BMS.backend.database.repositories;
using BMS.backend.models;
using BMS.backend.services;

class MyProgram {
  public static void Main(string[] args) {
    var repo = new UserRepository();
    var itRepo = new ITRepository();
    var adminRepo = new AdminReposiroty();
    var auUtils = new AuthUtils();
    var utils = new Utils();
    var authServices = new AuthServices();
    var admin = new AdminUser("john", "pauljohn@gmail.com", "Pasul123");
    Dictionary<string, string> data = new Dictionary<string, string>();


  }
}
