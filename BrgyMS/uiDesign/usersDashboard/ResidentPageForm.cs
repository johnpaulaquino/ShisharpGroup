using BrgyMs.backend.database.repositories;
using BrgyMs.backend.utils;
using BrgyMs.uiDesign;
using BrgyMS.uiDesign.usersDashboard.controls;
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

namespace BrgyMS.uiDesign.usersDashboard {
    public partial class ResidentPageForm : Form {
        private UIAdminUtils uiadmin = new UIAdminUtils();
        private AuthUtils _AuthUtils = new AuthUtils();
        private BaseRepository _BaseRepo = new BaseRepository();
        private ResidentAccountSetting accountcontrol;

        public ResidentPageForm() {
            InitializeComponent();


        }

        private void picAccountManagement_Click(object sender, EventArgs e) {

            if (accountcontrol == null) {
                accountcontrol = new ResidentAccountSetting();
            }
            pnlMainContentHolder1.Controls.Clear();
            pnlMainContentHolder1.Controls.Add(accountcontrol);
            accountcontrol.Dock = DockStyle.Fill;
        }

        private void ResidentPageForm_Load(object sender, EventArgs e) {

            uiadmin.SetUserLabel(
                lblRole, lblUsername);

        }

        public async void AfterInitializeComponent() {

        }

        private void picLogs_Click(object sender, EventArgs e) {
            ResidentUserLogsControl control = new();

            Cursor = Cursors.WaitCursor;

            pnlMainContentHolder1.Controls.Clear();
            pnlMainContentHolder1.Controls.Add(control);
            control.Dock = DockStyle.Fill;

            Cursor = Cursors.Default;

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

        private void picRequestDocs_Click(object sender, EventArgs e) {
            RequestDocumentsControls control = new();
            pnlMainContentHolder1.Controls.Clear();
            pnlMainContentHolder1.Controls.Add(control);

            control.Dock = DockStyle.Fill;

        }

        private void pnlSidebar_Paint(object sender, PaintEventArgs e) {

        }
    }
}
