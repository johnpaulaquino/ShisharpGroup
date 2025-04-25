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
using System.Dynamic;
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

        //for account management table
        public void SetWidthToAccountManagementTable(DataGridView dataGridView) {
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



        //for main form
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
        public async Task SetUserAndSecInfo(DataGridView table, int limit) {


            try {
                table.SuspendLayout();

                var dt = new DataTable();
                using var userInfo = await _AdminServices.GetUserInformation(limit);
                userInfo.Fill(dt);

                table.Columns.Clear();
                table.DataSource = dt;

                SetWidthToAccountManagementTable(table);


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


                userIno.Fill(dt);

                table.Columns.Clear();

                table.DataSource = dt;

                SetWidthToAccountManagementTable(table);


            }
            catch (System.Exception e) {
                MessageBox.Show(e.Message);
            }
            finally {
                table.ResumeLayout();
            }

        }// End 

        //for users logs table
        public void SetWidthToUsersLogsTable(DataGridView dataGridView) {
            dataGridView.Columns[0].Width = 90;
            dataGridView.Columns[1].Width = 90;
            dataGridView.Columns[2].Width = 150;
            dataGridView.Columns[3].Width = 90;
            dataGridView.Columns[4].Width = 100;
            dataGridView.Columns[5].Width = 200;
            dataGridView.Columns[6].Width = 200;
        }

        //users logs
        public async Task SetUserLogsToTable(DataGridView table, int limit) {
            try {
                using var adapter = await _AdminServices.GetAllLogs(limit);


                table.SuspendLayout();

                var dt = new DataTable();

                adapter.Fill(dt);


                table.Columns.Clear();

                table.DataSource = dt;


                SetWidthToUsersLogsTable(table);

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                System.Diagnostics.Debug.WriteLine(ex.StackTrace);
            }
            finally {
                table.ResumeLayout();
            }
        }
        //for users Account verification table
        public void SetWidthToAccVerificationtable(DataGridView dataGridView) {
            dataGridView.Columns[0].Width = 90;
            dataGridView.Columns[1].Width = 150;
            dataGridView.Columns[2].Width = 150;
            dataGridView.Columns[3].Width = 90;
            dataGridView.Columns[4].Width = 200;

        }
        public async Task SetInActiveUsersInTable(DataGridView table) {
            try {
                using var adapter = await _AdminServices.GetInActiveResidentUser();
                table.SuspendLayout();

                var dt = new DataTable();

                adapter.Fill(dt);


                table.Columns.Clear();

                table.DataSource = dt;


                SetWidthToAccVerificationtable(table);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                System.Diagnostics.Debug.WriteLine(ex.StackTrace);
            }
            finally {
                table.ResumeLayout();
            }
        }

    }
}
