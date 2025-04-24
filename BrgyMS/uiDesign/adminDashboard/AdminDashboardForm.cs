using BrgyMs.backend.database.repositories;
using BrgyMS.uiDesign.uiUtils.uiAdminUtils;
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

namespace BrgyMS.uiDesign {
    public partial class AdminDashboardForm : Form {
        private UIAdminUtils uiadmin = new UIAdminUtils();
        private bool isClicked = true;
        private int limit = 0;
        public AdminDashboardForm() {
            InitializeComponent();


        }

        private void kryptonPictureBox1_Click(object sender, EventArgs e) {
            AdminAccountManagementForm account = new AdminAccountManagementForm();
            this.Hide();
            account.Owner = this;
            account.Show();
        }

        private void picDashboardIcon_Click(object sender, EventArgs e) {
            AdminDashboardForm form = new AdminDashboardForm();
            this.Hide();
            form.Owner = this;
            form.Show();
        }

        private void picLogs_Click(object sender, EventArgs e) {
            AdminUsersLogsForm form = new AdminUsersLogsForm();
            this.Hide();
            form.Owner = this;
            form.Show();
        }

        private void picAnnouncements_Click(object sender, EventArgs e) {
            AdminAnnouncementsForm form = new AdminAnnouncementsForm();
            this.Hide();
            form.Owner = this;
            form.Show();
        }

        private void AdminDashboardForm_Load(object sender, EventArgs e) {
            uiadmin.SetUserInformation(lblRole,lblUsername);
        }
    }
}
