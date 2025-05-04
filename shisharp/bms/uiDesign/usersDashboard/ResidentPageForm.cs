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
using BrgyMS.uiDesign.usersDashboard.user_controls;

namespace BrgyMS.uiDesign.usersDashboard {
    public partial class ResidentPageForm : Form {
        private UIAdminUtils uiadmin = new UIAdminUtils();
        private AuthUtils _AuthUtils = new AuthUtils();
        private BaseRepository _BaseRepo = new BaseRepository();
        private ResidentDashboardControls dashboard;
        private RequestDocumentsControls docs;
        private ResidentUserLogsControl logsControl;
        private AccountSettingsDataHolderController dataHolder;

        public ResidentPageForm() {
            InitializeComponent();

        }
     
        private void picUserDashboardIcon_Click_1(object sender, EventArgs e) {
            if (dashboard == null) {
                dashboard = new ResidentDashboardControls();
            }
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
            if (logsControl == null) {
                logsControl = new ResidentUserLogsControl();
            }
            Cursor = Cursors.WaitCursor;
            pnlMainContentHolder.Controls.Clear();
            pnlMainContentHolder.Controls.Add(logsControl);
            logsControl.Dock = DockStyle.Fill;
            Cursor = Cursors.Default;
        }

        private void picUserRequestDocs_Click_1(object sender, EventArgs e) {
            if (docs == null) {
                docs = new RequestDocumentsControls();
            }
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
    }
}
