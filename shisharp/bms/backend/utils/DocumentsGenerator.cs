
using BrgyMs.backend.models.base_model;
using BrgyMs.backend.utils;
using BrgyMS.backend.services;
using FastReport;
using Microsoft.Reporting.WinForms;
using Org.BouncyCastle.Pqc.Crypto.Lms;
using Org.BouncyCastle.Utilities.IO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BrgyMS.backend.utils {

    public class DocumentsGenerator {
        private BaseServices _BaseServices = new BaseServices();
        private Utils utils = new Utils();
        private string filePath = "";
        private string fileLoc;
        public void generateReport() {

        }

        public async void GenerateIndigencyDocument(string userId) {
            try {
                await Task.Run(async () =>
                 {
                     List<object> userInfo = await _BaseServices.GetAllUserInformations(userId);

                     if (userInfo != null) {

                         var personalInfo = (PersonalInformation)userInfo[1];
                         var addInfo = (AdditionalInfo)userInfo[2];

                         string fullname = utils.FormatFullname(personalInfo.Firstname,
                             personalInfo.Middlename,
                             personalInfo.Lastname,
                             personalInfo.Suffix);
                         string age = addInfo.Age.ToString();
                         string civilStatus = addInfo.CivilStatus;



                         var folderPath = Path.Combine(Directory.GetCurrentDirectory(), "../../bms/docs_templates");
                         filePath = folderPath + "/IndigencyTemplate.rdlc";
                         fileLoc = folderPath + "/IndigencyTemplate.pdf";

                         if (!Directory.Exists(folderPath)) {
                             Directory.CreateDirectory(folderPath);
                         }

                         LocalReport report = new LocalReport();
                         report.ReportPath = filePath;

                         report.SetParameters(new[]
                   {
            new ReportParameter("Fullname", fullname),
            new ReportParameter("age", age),
            new ReportParameter("civilStatus", civilStatus),
            new ReportParameter("dayToday", "Minimal Report"),
             new ReportParameter("monthToday", "Minimal Report"),
            new ReportParameter("yearToday", "Minimal Report"),
         });
                         byte[] data = report.Render("PDF");

                         File.WriteAllBytes(fileLoc, data);

                     }
                 });
            }
            catch (Exception ex) {
                throw;
            }
        } // end

        public string GetIndigencyLocation() {
            var folderPath = Path.Combine(Directory.GetCurrentDirectory(), "../../bms/docs_templates");
            fileLoc = folderPath + "/IndigencyTemplate.pdf";
            return fileLoc;
        }
    }


}
