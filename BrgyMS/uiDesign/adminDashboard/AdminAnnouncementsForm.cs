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
    public partial class AdminAnnouncementsForm : Form {
        private UIAdminUtils uiadmin = new UIAdminUtils();
        private bool isClicked = true;
        private int limit = 0;
        public AdminAnnouncementsForm() {
            InitializeComponent();


        }

        private async void AdminForm_Load(object sender, EventArgs e) {
            uiadmin.setAdminDashboardTableWitdth(dataGridAdminDashboard);
            uiadmin.SetUserInformation(lblRole, lblUsername);
            limit = (int)nudLimit.Value;
            await uiadmin.SetUserAndSecInfo(dataGridAdminDashboard, limit, txtSearch.Text);

        }
        private async void nudLimit_ValueChanged(object sender, EventArgs e) {

            limit = (int)nudLimit.Value + 1;
            await uiadmin.SetUserAndSecInfo(dataGridAdminDashboard, limit, txtSearch.Text);
        }

        private void txtSearch_Enter(object sender, EventArgs e) {
            if (string.Equals(txtSearch.Text, "Search")) {
                txtSearch.Text = "";
                txtSearch.ForeColor = System.Drawing.ColorTranslator.FromHtml("#21130d");
            }
        }

        private async void txtSearch_TextChanged(object sender, EventArgs e) {
            try {
                uiadmin.SearchRecords(dataGridAdminDashboard, limit, txtSearch.Text.ToString());
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);

            }
        }

        private void picDashboardIcon_Click(object sender, EventArgs e) {
            AdminDashboardForm form = new AdminDashboardForm();
            form.Owner = this;
            this.Hide();
            form.Show();
        }

        private void picAccountManagement_Click(object sender, EventArgs e) {
            AdminAccountManagementForm form = new AdminAccountManagementForm();
            form.Owner = this;
            this.Hide();
            form.Show();
        }

        private void picLogs_Click(object sender, EventArgs e) {
            AdminUsersLogsForm form = new AdminUsersLogsForm();
            form.Owner = this;
            this.Hide();
            form.Show();
        }

        private void picAnnouncements_Click(object sender, EventArgs e) {
            AdminAnnouncementsForm form = new AdminAnnouncementsForm();
            form.Owner = this;
            this.Hide();
            form.Show();
        }
    }
}
