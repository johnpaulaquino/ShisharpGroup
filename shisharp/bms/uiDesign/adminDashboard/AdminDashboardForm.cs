using BrgyMs.backend.database.repositories;
using BrgyMs.backend.utils;
using BrgyMs.uiDesign;
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



        public AdminDashboardForm() {
            InitializeComponent();

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
            SecretaryBlotterControl control = new SecretaryBlotterControl();

            pnlMainContentHolder1.Controls.Clear();
            pnlMainContentHolder1.Controls.Add(control);

            control.Dock = DockStyle.Fill;
        }
        private void AdminDashboardForm_Load_1(object sender, EventArgs e) {
            ResDashboard dashcontrol = new ResDashboard();
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
            ResDashboard dashcontrol = new ResDashboard();
            pnlMainContentHolder1.Controls.Clear();
            pnlMainContentHolder1.Controls.Add(dashcontrol);
            dashcontrol.Dock = DockStyle.Fill;
        }

        private void picLogout_Click_1(object sender, EventArgs e) {
            DialogResult option = MessageBox.Show("Are you sure you want to logout?", "Logout",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (option == DialogResult.Yes) {
                this.Hide();
                _AuthUtils.DeleteTokeAfterLogoutOrCloseTheFrom();
                LoginForm login = new LoginForm();
                login.Owner = this;
                login.Show();
            }
        }
    }
}
