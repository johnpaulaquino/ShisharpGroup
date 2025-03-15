using System;
using BackEnd.database.respositories;
using BackEnd.utils;
using CSharpBackEnd.backend.database.repositories;
using CSharpBackEnd.backend.models;
using CSharpBackEnd.backend.utils;
class MyProgram {
  public static void Main(string[] args) {
    var repo = new UserRepository();
    var itRepo = new ITRepository();
    var auUtils = new AuthUtils();
    var utils = new Utils();
    var admin = new AdminUser("paul", "pauljohn@gmail.com", "Pasul123");
  }
}
