using BrgyMs.backend.database.repositories;
using BrgyMs.backend.services;
using BrgyMs.backend.utils;
using BrgyMS.backend.database.connection.models;
using Google.Protobuf.Compiler;
using Krypton.Toolkit;
using Microsoft.VisualBasic.Devices;
using Mysqlx.Resultset;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrgyMS.uiDesign.uiUtils.uiAdminUtils {
    class UIAdminUtils {
        private readonly AuthUtils _AuthUtils = new AuthUtils();
        private AdminServices _AdminServices = new AdminServices();
        private readonly AdminRepository _admin = new AdminRepository();
        private readonly Utils utils = new Utils();
        public UIAdminUtils() {


        }
        public void setAdminDashboardTableWitdth(DataGridView dataGridView) {
            dataGridView.Columns[0].Width = 85;
            dataGridView.Columns[1].Width = 200;
            dataGridView.Columns[2].Width = 90;
            dataGridView.Columns[3].Width = 200;
            dataGridView.Columns[4].Width = 85;
            dataGridView.Columns[5].Width = 200;
            dataGridView.Columns[6].Width = 50;
            dataGridView.Columns[7].Width = 150;
            dataGridView.Columns[8].Width = 150;
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
        public async Task SetUserAndSecInfo(DataGridView table, int limit, string search) {
            try {
                table.SuspendLayout();
                var dt = new DataTable();
                using var userInfo = await _AdminServices.GetUserInformation(limit);
                if (userInfo != null) {
                    await userInfo.FillAsync(dt);
                    table.Columns.Clear();
                    table.DataSource = dt;
                    setAdminDashboardTableWitdth(table);

                }


            }
            catch (System.Exception e) {
                MessageBox.Show(e.Message);
            }
            finally {
                table.ResumeLayout();

            }
        }


        public async Task SearchRecords(DataGridView table, int limit, string keyword) {
            try {
                table.SuspendLayout();
                using var userIno = await _AdminServices.GetUserInformation(limit, keyword);

                var dt = new DataTable();
                if (userIno != null) {
                    await userIno.FillAsync(dt);
                    table.Columns.Clear();
                    table.DataSource = dt;
                    setAdminDashboardTableWitdth(table);

                }
                if (string.IsNullOrEmpty(keyword)) {
                   await SetUserAndSecInfo(table, limit, keyword);
                }
            }
            catch (System.Exception e) {
                MessageBox.Show(e.Message);
            }
            finally {
                table.ResumeLayout();
            }

        }
    }
}
