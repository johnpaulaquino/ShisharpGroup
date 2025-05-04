using BrgyMs.backend.database.repositories;
using BrgyMs.backend.services;
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

namespace BrgyMS.uiDesign.adminDashboard.controls {
    public partial class AdminUserLogsControl : UserControl {
        private UIAdminUtils uiAdmin = new UIAdminUtils();
        public AdminUserLogsControl() {
            InitializeComponent();
        }

        private async void AdminUserLogsControl_Load(object sender, EventArgs e) {
            int limit = (int)nudLimit.Value + 1;
            Cursor = Cursors.WaitCursor;
            SuspendLayout();
            await uiAdmin.SetUserLogsToTable(dataGridAdminDashboard, limit);
            ResumeLayout();
            Cursor = Cursors.Default;
        }

        private async void nudLimit_ValueChanged(object sender, EventArgs e) {
            int limit = (int)nudLimit.Value + 1;
            Cursor = Cursors.WaitCursor;
            SuspendLayout();
            await uiAdmin.SetUserLogsToTable(dataGridAdminDashboard, limit);
            ResumeLayout();
            Cursor = Cursors.Default;
        }
    }
}
