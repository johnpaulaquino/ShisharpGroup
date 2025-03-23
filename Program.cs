using System;
using Newtonsoft.Json;
using BMS.backend.utils;
using BMS.backend.database.repositories;
using BMS.backend.models;
using BMS.backend.services;
using System.Threading.Tasks;
using BMS.backend.models.residents_model;
using BMS.backend.models.admin_model;
using BMS.backend.models.base_model;
using BMS.backend.models.bo_model;


class MyProgram {
  public static async Task Main(string[] args) {
    List<string> Accomplished = new List<string>();
    List<string> Awards = new List<string>();
    byte[] ProfileImage;
    var ResidentServe = new ResidentServices();


    using (var img = new FileStream("/home/pj/Desktop/CSharpBackEnd/sampleimage/noImage.jpg", FileMode.Open, FileAccess.Read)) {
      var repo = new ResidentRepository();
      var adminServices = new AdminServices();
      ProfileImage = new byte[img.Length];

      await img.ReadExactlyAsync(ProfileImage);

      var user = new User("paul@yahoo1.com", "123", "Resident", false);
      var personal = new PersonalInformation("John Paul", "Castro", "Aquino", "Male");
      var elecHisto = new ElectionHistories(new DateOnly(2003, 07, 23), new DateOnly(2006, 07, 23), Accomplished, Awards);
      string json = JsonConvert.SerializeObject(elecHisto, Formatting.Indented);
      var officials = new OfficialsInfo(new DateOnly(2003, 07, 23), new DateOnly(2006, 07, 23), "Secretary", json);
      var address = new Address("Gumamela", "110");
      var addInfo = new ResidentAdditionalInfo(true, new DateOnly(2003, 07, 23), "Self-Employed", "College", "09998614418", "Single", "Chrstian") { ProfileImage = ProfileImage };


    }
  }
}
