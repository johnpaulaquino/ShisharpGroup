

using BackEnd.database.models;
using BackEnd.database.respositories;
using BackEnd.utils;

class MyProgram{
    public static void Main(string[] args){
          var auth = new Repository();

         auth.getUsers();

    }
}
