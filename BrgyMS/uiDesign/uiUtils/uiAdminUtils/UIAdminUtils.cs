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
            dataGridView.Columns[0].Width = 50;
            dataGridView.Columns[1].Width = 200;
            dataGridView.Columns[2].Width = 100;
            dataGridView.Columns[3].Width = 100;
            dataGridView.Columns[4].Width = 200;
            dataGridView.Columns[5].Width = 100;
            dataGridView.Columns[6].Width = 200;
            dataGridView.Columns[7].Width = 100;
            dataGridView.Columns[8].Width = 200;
            dataGridView.Columns[9].Width = 200;
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
        public async void SetUserAndSecInfo(DataGridView table) {

            using (var dataReader = await _AdminRepo.GetUserInformation()){
                DataTable dt = new DataTable();
            

                DataRow dr = dt.NewRow(); // for rows
                while (dataReader.Read()) {
                  
                }
                
            }
           



        }
    }
}
