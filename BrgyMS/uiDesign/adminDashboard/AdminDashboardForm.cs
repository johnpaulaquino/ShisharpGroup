using BrgyMs.backend.database.repositories;
using BrgyMs.backend.utils;
using BrgyMs.uiDesign;
using BrgyMS.uiDesign.adminDashboard.controls;
using BrgyMS.uiDesign.uiUtils.uiAdminUtils;
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

        private void picDashboardIcon_Click(object sender, EventArgs e) {
            AdminDashboardControl dashcontrol = new AdminDashboardControl();
            pnlMainContentHolder1.Controls.Clear();
            pnlMainContentHolder1.Controls.Add(dashcontrol);
            dashcontrol.Dock = DockStyle.Fill;
        }

        private void picLogs_Click(object sender, EventArgs e) {
            AdminUserLogsControl logscontrol = new AdminUserLogsControl();
            pnlMainContentHolder1.Controls.Clear();
            pnlMainContentHolder1.Controls.Add(logscontrol);
            logscontrol.Dock = DockStyle.Fill;
        }

        private void picAnnouncements_Click(object sender, EventArgs e) {
            AdminAnnouncementsControl acnnoucnecontrol = new AdminAnnouncementsControl();
            pnlMainContentHolder1.Controls.Clear();
            pnlMainContentHolder1.Controls.Add(acnnoucnecontrol);
            acnnoucnecontrol.Dock = DockStyle.Fill;
        }

        private void AdminDashboardForm_Load(object sender, EventArgs e) {
            AdminDashboardControl dashcontrol = new AdminDashboardControl();
            uiadmin.SetUserLabel(lblRole, lblUsername);
            pnlMainContentHolder1.Controls.Clear();

            pnlMainContentHolder1.Controls.Add(dashcontrol);
            dashcontrol.Dock = DockStyle.Fill;

        }

        private void picAccountManagement_Click(object sender, EventArgs e) {
            ResidentAccountSetting accountcontrol = new ResidentAccountSetting();
            pnlMainContentHolder1.Controls.Clear();
            pnlMainContentHolder1.Controls.Add(accountcontrol);
            accountcontrol.Dock = DockStyle.Fill;
        }

        private void picAccountVerification_Click(object sender, EventArgs e) {
            AdminAccountVerification verificationcontrol = new AdminAccountVerification();
            pnlMainContentHolder1.Controls.Clear();
            pnlMainContentHolder1.Controls.Add(verificationcontrol);
            verificationcontrol.Dock = DockStyle.Fill;
        }

        private void picLogout_Click(object sender, EventArgs e) {
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
