using System;
using Newtonsoft.Json;
using BMS.backend.utils;
using BMS.backend.database.repositories;
using BMS.backend.models;
using BMS.backend.services;
using System.Threading.Tasks;
using BMS.backend.models.base_model;
using BMS.backend.models.bo_model;
using DotNetEnv;



class MyProgram {
  public static async Task Main(string[] args) {
    List<string> Accomplished = new List<string>();
    List<string> Awards = new List<string>();
    byte[] ProfileImage;
    var ResidentServe = new ResidentServices();
    var _EmailServices = new EmailServices();


    using (var img = new FileStream("/home/pj/Desktop/CSharpBackEnd/sampleimage/noImage.jpg", FileMode.Open, FileAccess.Read)) {
      var repo = new ResidentRepository();
      var secretaryServices = new SecretaryServices();
      var _Authservices = new AuthServices();
      ProfileImage = new byte[img.Length];

      await img.ReadExactlyAsync(ProfileImage);

      var user = new User("Paul1@4gmail.com", "123asdsadasd") { Status = false };
      var personal = new PersonalInformation("John Paul", "Castro", "Aquino", "Male");
      var elecHisto = new ElectionHistories(new DateTime(2003, 07, 23), new DateTime(2006, 07, 23), Accomplished, Awards);
      string json = JsonConvert.SerializeObject(elecHisto, Formatting.Indented);
      var officials = new OfficialsInfo(new DateTime(2003, 07, 23), new DateTime(2006, 07, 23), "Secretary", json);
      var address = new Address("Gumamela", "110");
      var addInfo = new AdditionalInfo(true, new DateTime(2003, 07, 23), "Self-Employed", "College", "Single", "09998614418", "Chrstian") { ProofOfResidency = ProfileImage };

      // Dictionary<string, string> data = await repo.GetElectionHistories();
      // string electString = data["election_histories0"];

      // ElectionHistories elect = JsonConvert.DeserializeObject<ElectionHistories>(electString);

      // foreach (var item in elect.Achievements) {
      //   Console.WriteLine(item);
      // }
      await secretaryServices.CreateOfficialsInfo(user, personal, addInfo, address, officials, elecHisto);


    }
  }
}
