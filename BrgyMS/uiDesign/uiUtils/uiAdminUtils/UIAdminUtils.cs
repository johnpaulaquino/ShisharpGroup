using BrgyMs.backend.database.repositories;
using BrgyMs.backend.utils;
using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BrgyMS.uiDesign.uiUtils.uiAdminUtils {
    class UIAdminUtils {
        private AuthUtils _AuthUtils = new AuthUtils();
        private AdminRepository _AdminRepo = new AdminRepository();
        public UIAdminUtils() {


        }
        public void setAdminDashboardTableWitdth(DataGridView dataGridView) {
            dataGridView.Columns["id"].Width = 50;
            dataGridView.Columns["colemail"].Width = 200;
            dataGridView.Columns["colrole"].Width = 100;
            dataGridView.Columns["colfullname"].Width = 200;
            dataGridView.Columns["colgender"].Width = 100;
            dataGridView.Columns["colbday"].Width = 200;
            dataGridView.Columns["colage"].Width = 50;
            dataGridView.Columns["colcontact"].Width = 150;
            dataGridView.Columns["colrtype"].Width = 150;
        }

        public void SetUserInformation(KryptonLabel lblRole,
            KryptonLabel lblusername) {
            string token = _AuthUtils.ReadTokenInFile();
            var principal = _AuthUtils.ValidateToken(token);
            if (principal != null) {
                string? username = principal.FindFirst("username")?.Value;
                string? userId = principal.FindFirst("userId")?.Value;
                string? role = principal.FindFirst(ClaimTypes.Role)?.Value;
                string? roleInit = role?.ToUpper();
                lblRole.Text = roleInit?[0] + role?.Substring(1);
                lblusername.Text = "Hi, " + username;
            }
        }
        public async void SetUserAndSecInfo(DataGridView table, int limit) {

            using (var dataReader = await _AdminRepo.GetUserInformation(limit)) {

                table.Rows.Clear();

                while (dataReader.Read()) {
                    if (limit <= dataReader.GetInt32("counter_limit")) {
                        string fName = (string)dataReader["firstname"];
                        string? mName = (string)dataReader["middlename"];
                        string lName = (string)dataReader["lastname"];
                        string? suffix = (string)dataReader["suffix"];
                        string fullname = "";

                        if (String.IsNullOrEmpty(mName) && string.IsNullOrEmpty(suffix)) {
                            fullname = mName + " " + lName;
                        }
                        else if (string.IsNullOrEmpty(mName)) {
                            fullname = mName + " " + lName + " " + suffix;
                        }
                        else if (string.IsNullOrEmpty(suffix)) {
                            fullname = mName + " " + mName[0].ToString().ToUpper() + ". " + lName;
                        }
                        else {
                            fullname = fullname = mName + mName[0].ToString().ToUpper() + " " + lName + " " + suffix;
                        }

                        string role = (string)dataReader["role"];
                        string roleInit = string.Concat(role[0].ToString().ToUpper(), role.Substring(1));
                        DateTime bday = (DateTime)dataReader["birth_day"];
                        String formattedBday = bday.ToString("MMMM, dd, yyyy");

                        table.Rows.Add(dataReader["id"],
                         dataReader["email"], roleInit, fullname,
                         dataReader["gender"],
                         formattedBday,
                         dataReader["age"],
                         dataReader["contact_number"],
                         dataReader["resident_type"]);
                    }

                }
            }
        }
    }
}
