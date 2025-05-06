using BrgyMs.backend.database.repositories;
using BrgyMs.backend.utils;
using BrgyMs.uiDesign;
using BrgyMS.backend.models;
using BrgyMS.backend.services;
using BrgyMS.uiDesign.adminDashboard.controls;
using BrgyMS.uiDesign.uiUtils.uiAdminUtils;
using BrgyMS.uiDesign.usersDashboard.modals;
using BrgyMS.uiDesign.usersDashboard.secretary_controls;
using Google.Protobuf.Reflection;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BrgyMS.uiDesign.adminDashboard {
    public partial class AdminDashboardForm : Form {
        private UIAdminUtils uiadmin = new UIAdminUtils();
        private AuthUtils _AuthUtils = new AuthUtils();

        private BaseServices _BaseServices = new BaseServices();
        private string userId = "";



        public AdminDashboardForm() {
            InitializeComponent();
            string token = _AuthUtils.ReadTokenInFile();
            var user = _AuthUtils.ValidateToken(token);
            userId = user.UserId;
        }



        private void picAccountVerification_Click_1(object sender, EventArgs e) {
            AdminAccountVerification verificationcontrol = new AdminAccountVerification();
            pnlMainContentHolder1.Controls.Clear();
            pnlMainContentHolder1.Controls.Add(verificationcontrol);
            verificationcontrol.Dock = DockStyle.Fill;
        }

        private void picAccountManagement_Click_1(object sender, EventArgs e) {
            AdminAccountManagementControl accountcontrol = new AdminAccountManagementControl();
            pnlMainContentHolder1.Controls.Clear();
            pnlMainContentHolder1.Controls.Add(accountcontrol);
            accountcontrol.Dock = DockStyle.Fill;
        }

        private void picBlotter_Click(object sender, EventArgs e) {
            AdminBlotterControl control = new AdminBlotterControl();

            pnlMainContentHolder1.Controls.Clear();
            pnlMainContentHolder1.Controls.Add(control);

            control.Dock = DockStyle.Fill;
        }
        private void AdminDashboardForm_Load_1(object sender, EventArgs e) {
            AdminDashboardControl dashcontrol = new AdminDashboardControl();
            uiadmin.SetUserLabel(lblRole, lblUsername);
            pnlMainContentHolder1.Controls.Clear();

            pnlMainContentHolder1.Controls.Add(dashcontrol);
            dashcontrol.Dock = DockStyle.Fill;


        }

        private void picAnnouncements_Click(object sender, EventArgs e) {
            AdminAnnouncementsControl acnnoucnecontrol = new AdminAnnouncementsControl();
            pnlMainContentHolder1.Controls.Clear();
            pnlMainContentHolder1.Controls.Add(acnnoucnecontrol);
            acnnoucnecontrol.Dock = DockStyle.Fill;
        }

        private void picOfficials_Click(object sender, EventArgs e) {
            AdminOfficialsManagementControl officialsControl = new AdminOfficialsManagementControl();
            try {
                Cursor = Cursors.WaitCursor;
                pnlMainContentHolder1.Controls.Clear();

                pnlMainContentHolder1.Controls.Add(officialsControl);

                officialsControl.Dock = DockStyle.Fill;

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            finally {
                Cursor = Cursors.Default;



            }
        }

        private void picLogs_Click_1(object sender, EventArgs e) {
            AdminUserLogsControl logscontrol = new AdminUserLogsControl();
            pnlMainContentHolder1.Controls.Clear();
            pnlMainContentHolder1.Controls.Add(logscontrol);
            logscontrol.Dock = DockStyle.Fill;

        }

        private void picDashboardIcon_Click_1(object sender, EventArgs e) {
            AdminDashboardControl dashcontrol = new AdminDashboardControl();
            pnlMainContentHolder1.Controls.Clear();
            pnlMainContentHolder1.Controls.Add(dashcontrol);
            dashcontrol.Dock = DockStyle.Fill;
        }



        private async void AdminDashboardForm_FormClosing(object sender, FormClosingEventArgs e) {
            var option = MessageBox.Show("Are you sure you wan to logout?", "Logout",
           MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (option == DialogResult.Yes) {

                string logsId = await _BaseServices.GenerateLogsId();

                Logs logs = new Logs(logsId, userId, "Logout")
                {
                    DatePerformed = DateTime.Now,
                    Details = $"Logout user."
                };

                await Task.Run(async () =>
                {
                    await _BaseServices.LogUserActions(logs);

                });

                _AuthUtils.DeleteTokeAfterLogoutOrCloseTheFrom();
                LoginForm login = new LoginForm();

                login.Show();
                this.FormClosing -= AdminDashboardForm_FormClosing;

                this.Close(); // Now close safely
            }
            else {
                e.Cancel = true;
            }
        }
    }
}
