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
    public partial class AdminAccountVerification : UserControl {
        private UIAdminUtils uiAdmin = new UIAdminUtils();
        public AdminAccountVerification() {
            InitializeComponent();
        }

        private async void nudLimit_ValueChanged(object sender, EventArgs e) {
            int limit = (int)nudLimit.Value + 1;
            Cursor = Cursors.WaitCursor;
            SuspendLayout();
            await uiAdmin.SetInActiveUsersInTable(dataGridAdminDashboard);
            ResumeLayout();
            Cursor = Cursors.Default;
        }

        private async void txtSearch_TextChanged(object sender, EventArgs e) {
            int limit = (int)nudLimit.Value + 1;
            string keyword = txtSearch.Text;
            Cursor = Cursors.WaitCursor;

            SuspendLayout();
            await uiAdmin.SetInActiveUsersInTable(dataGridAdminDashboard);
            ResumeLayout();
            Cursor = Cursors.Default;
        }

        private async void AdminAccountManagementControl_Load(object sender, EventArgs e) {
            int limit = (int)nudLimit.Value + 1;
            Cursor = Cursors.WaitCursor;
            SuspendLayout();
            await uiAdmin.SetInActiveUsersInTable(dataGridAdminDashboard);
            ResumeLayout();
            Cursor = Cursors.Default;
        }
    }
}
