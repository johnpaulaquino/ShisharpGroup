using BrgyMs.backend.database.repositories;
using BrgyMs.backend.utils;
using BrgyMs.uiDesign;
using BrgyMS.uiDesign.usersDashboard.user_controls;
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
using Krypton.Toolkit;
using BrgyMs.backend.models.base_model;
using BrgyMS.backend.models;
using BrgyMS.backend.services;
using Microsoft.VisualBasic.ApplicationServices;

namespace BrgyMS.uiDesign.usersDashboard {
    public partial class ResidentPageForm : Form {
        private UIAdminUtils uiadmin = new UIAdminUtils();
        private AuthUtils _AuthUtils = new AuthUtils();
        private BaseRepository _BaseRepo = new BaseRepository();
        private ResidentDashboardControls dashboard;
        private RequestDocumentsControls docs;
        private ResidentUserLogsControl logsControl;
        private AccountSettingsDataHolderController dataHolder;
        private Utils utils = new Utils();
        private string userId = "";

        private BaseServices _BaseServices = new BaseServices();
        public ResidentPageForm() {
            InitializeComponent();
            string token = _AuthUtils.ReadTokenInFile();
            var user = _AuthUtils.ValidateToken(token);
            userId = user.UserId;
        }

        private void picUserDashboardIcon_Click_1(object sender, EventArgs e) {

            dashboard = new ResidentDashboardControls();

            Cursor = Cursors.WaitCursor;
            pnlMainContentHolder.Controls.Clear();
            pnlMainContentHolder.Controls.Add(dashboard);
            dashboard.Dock = DockStyle.Fill;
            Cursor = Cursors.Default;
        }

        private void picUserAccountManagement_Click_1(object sender, EventArgs e) {
            if (dataHolder == null) {
                dataHolder = new AccountSettingsDataHolderController();
            }
            Cursor = Cursors.WaitCursor;
            pnlMainContentHolder.Controls.Clear();
            pnlMainContentHolder.Controls.Add(dataHolder);
            dataHolder.Dock = DockStyle.Fill;
            Cursor = Cursors.Default;
        }

        private void picUserLogs_Click_1(object sender, EventArgs e) {

            logsControl = new ResidentUserLogsControl();

            Cursor = Cursors.WaitCursor;
            pnlMainContentHolder.Controls.Clear();
            pnlMainContentHolder.Controls.Add(logsControl);
            logsControl.Dock = DockStyle.Fill;
            Cursor = Cursors.Default;
        }

        private void picUserRequestDocs_Click_1(object sender, EventArgs e) {

            docs = new RequestDocumentsControls();

            Cursor = Cursors.WaitCursor;
            pnlMainContentHolder.Controls.Clear();
            pnlMainContentHolder.Controls.Add(docs);
            docs.Dock = DockStyle.Fill;
            Cursor = Cursors.Default;
        }

        private void kryptonPictureBox1_Click(object sender, EventArgs e) {
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

        private void ResidentPageForm_Load(object sender, EventArgs e) {
            SetUserLabel(lblRole, lblUsername);

            dashboard = new ResidentDashboardControls();

            Cursor = Cursors.WaitCursor;
            pnlMainContentHolder.Controls.Clear();
            pnlMainContentHolder.Controls.Add(dashboard);
            dashboard.Dock = DockStyle.Fill;
            Cursor = Cursors.Default;
        }
        public void SetUserLabel(KryptonLabel lblRole,
         KryptonLabel lblusername) {

            string token = _AuthUtils.ReadTokenInFile();
            BrgyMs.backend.models.base_model.User user = _AuthUtils.ValidateToken(token);

            string role = utils.FormatRoles(user.Role);

            lblRole.Text = role;
            lblusername.Text = "Hi, " + user.Username;
        }

        private async void ResidentPageForm_FormClosing(object sender, FormClosingEventArgs e) {
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
                this.FormClosing -= ResidentPageForm_FormClosing;

                this.Close(); // Now close safely
            }
            else {
                e.Cancel = true;
            }
        }
    }
}
