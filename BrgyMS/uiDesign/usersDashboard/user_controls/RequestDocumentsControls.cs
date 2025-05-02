using BrgyMs.backend.database.repositories;
using BrgyMs.backend.services;
using BrgyMs.backend.utils;
using BrgyMS.uiDesign.usersDashboard.modals;
using BrgyMS.uiDesign.uiUtils.ui_residents_utils;
using BrgyMS.uiDesign.uiUtils.uiAdminUtils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrgyMS.uiDesign.usersDashboard.user_controls {
    public partial class RequestDocumentsControls : UserControl {
        private UIResidentUtils uioResident = new UIResidentUtils();
        private Utils utils = new Utils();
        public RequestDocumentsControls() {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            UsersModal docs = new UsersModal();
            RequestDocumentsModalCotntrol control = new();


            docs.pnlContainer.Controls.Clear();
            docs.pnlContainer.Controls.Add(control);
            control.Dock = DockStyle.Fill;

            docs.ShowDialog(this);
        }

        private void RequestDocumentsControls_Load(object sender, EventArgs e) {
            string userid = utils.ReadUserIdInFile();
            int limit = (int)nudLimit.Value;
            Invoke(new Action(async () =>
            {
                Cursor = Cursors.WaitCursor;
                // when in UI thread
                await uioResident.SetRequestDocumentsControlsTable(dataGridAdminDashboard,
         limit, userid);
                Cursor = Cursors.Default;
            }));

        }
    }
}
