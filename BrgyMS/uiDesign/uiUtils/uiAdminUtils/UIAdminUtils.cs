using BrgyMs.backend.database.repositories;
using BrgyMs.backend.models.base_model;
using BrgyMs.backend.services;
using BrgyMs.backend.utils;
using BrgyMS.backend.database.connection.models;
using BrgyMS.uiDesign.adminDashboard.modals;
using BrgyMS.uiDesign.adminDashboard.modals.modals_controls;
using Google.Protobuf.Compiler;
using Krypton.Toolkit;
using Microsoft.VisualBasic.Devices;
using Mysqlx.Resultset;
using MySqlX.XDevAPI.Relational;
using Org.BouncyCastle.Asn1.Cmp;
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
            dataGridView.Columns[1].Width = 150;
            dataGridView.Columns[2].Width = 85;
            dataGridView.Columns[3].Width = 150;
            dataGridView.Columns[4].Width = 150;
            dataGridView.Columns[5].Width = 85;
            dataGridView.Columns[6].Width = 150;
            dataGridView.Columns[7].Width = 50;
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
            dataGridView.Columns[0].Width = 50;
            dataGridView.Columns[1].Width = 50;
            dataGridView.Columns[2].Width = 150;
            dataGridView.Columns[3].Width = 90;
            dataGridView.Columns[4].Width = 100;
            dataGridView.Columns[5].Width = 100;
            dataGridView.Columns[6].Width = 250;
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
            dataGridView.Columns[0].Width = 85;
            dataGridView.Columns[1].Width = 100;
            dataGridView.Columns[2].Width = 100;
            dataGridView.Columns[3].Width = 100;
            dataGridView.Columns[4].Width = 250;

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
        } // end of function 


        //User information 
        public async Task SetUserInfoInuserInfromationModal(
            UserInformationModalControl userinfoControl,
            KryptonTextBox txtUserId,
            KryptonTextBox txtEmail,
            KryptonTextBox txtpassword,
            KryptonTextBox txtUsername
            ) {

            string UserIdInFile = utils.ReadUserIdInFile(); // Read  the user id that write in file after click the 
            // show information in Account management.


            // Get the user 
            try {
                List<User> user = await _AdminServices.GetUserAllInformation(UserIdInFile);
                userinfoControl.userModals = user;
                foreach (var item in user) {
                    txtUserId.Text = UserIdInFile;
                    txtEmail.Text = item.Email;
                    txtUsername.Text = item.Username;
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                System.Diagnostics.Debug.WriteLine(ex.StackTrace);
            } 

        }// end of function


        //User Information Modal Control. It will use in the button which save cahnges
        public async Task UpdateAccountInfo(KryptonTextBox txtMUsername,
            KryptonTextBox txtEmail,
            KryptonTextBox txtPassword, 
            KryptonCheckBox cbMStatus,
            KryptonCheckBox cbUSecretary,
            string userId,
            List<User> userModals) {


            string username = txtMUsername.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            string role = "users"; // in default role is users

            bool isActivated = true; // user is activated in default

            //if not checked then deactivate user
            if (!cbMStatus.Checked) {
                isActivated = false;
            }

            //check if the user modal is not null
            if (userModals != null) {
                // then check if the password in this control is empty
                if (string.IsNullOrEmpty(password)) {
                    //then no changes for password
                    foreach (var item in userModals) {
                        password = item.Password;
                    }
                }
            }

            //if secretary is checked then set role as secretary
            if (cbUSecretary.Checked) {
                role = "secretary";
            }

            // create the user
            var userModel = new User(
                email, password, username)
            { Role = role, Status = isActivated };

            try {
                await _AdminServices.UpdateAccountInfo(userModel, userId);
                MessageBox.Show("Successfully updated account info!");
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        } // End of the function


    }
}
