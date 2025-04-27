using BrgyMs.backend.utils;
using BrgyMS.uiDesign.adminDashboard.modals;
using BrgyMS.uiDesign.adminDashboard.modals.modals_controls;
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
    public partial class AdminAccountManagementControl : UserControl {
        private UIAdminUtils uiAdmin = new UIAdminUtils();
        private Utils utils = new Utils();
        private AdminModal modal = new AdminModal();
        public bool isUpdated = false;
        public AdminAccountManagementControl() {
            InitializeComponent();

        }

        private async void nudLimit_ValueChanged(object sender, EventArgs e) {
            int limit = (int)nudAmLimit.Value + 1;
            Cursor = Cursors.WaitCursor;
            SuspendLayout();
            await uiAdmin.SetInfoInAdminAccountTable(dataGridAmTableAdmin, limit);
            ResumeLayout();
            Cursor = Cursors.Default;
        }

        private async void txtSearch_TextChanged(object sender, EventArgs e) {
            int limit = (int)nudAmLimit.Value + 1;
            string keyword = txtSearch.Text;
            Cursor = Cursors.WaitCursor;

            SuspendLayout();
            await uiAdmin.SetInfoInAdminAccountTable(dataGridAmTableAdmin, limit);
            ResumeLayout();
            Cursor = Cursors.Default;
        }

        private async void AdminAccountManagementControl_Load(object sender, EventArgs e) {
            Refresh();
            dataGridAmTableAdmin.Refresh();
            int limit = (int)nudAmLimit.Value + 1;
            Cursor = Cursors.WaitCursor;
            SuspendLayout();
            await uiAdmin.SetInfoInAdminAccountTable(dataGridAmTableAdmin, limit);
            ResumeLayout();
            Cursor = Cursors.Default;
        }


        private async void tsmShowInformation_Click(object sender, EventArgs e) {


        }

        private void dataGridAdminDashboard_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right) {
                var hit = dataGridAmTableAdmin.HitTest(e.X, e.Y); // get the location where clicked
                if (hit.RowIndex >= 0) {


                    dataGridAmTableAdmin.ClearSelection();
                    dataGridAmTableAdmin.Rows[hit.RowIndex].Selected = true; // set selection where the mouse clicked

                    string? userId = dataGridAmTableAdmin.Rows[hit.RowIndex].Cells[0].Value?.ToString();
                    try {
                        utils.PutIdOnFile(userId);

                        //show the context
                        ctxmenuAccManagement.Show(this, dataGridAmTableAdmin.PointToScreen(e.Location));
                    }
                    catch (Exception ex) {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private async void actionsToolStripMenuItem_Click(object sender, EventArgs e) {
            UserInformationModalControl control = new();
            modal.StartPosition = FormStartPosition.CenterScreen;

            modal.pnlModalMainContent.Controls.Add(control);
            control.Dock = DockStyle.Fill;

            await uiAdmin.SetUserInfoInuserInfromationModal(control,
                control.txtMcUserId,
                control.txtMcEmail,
                control.txtMcPassword,
                control.txtMcUsername);

            DialogResult result = modal.ShowDialog(this);
        }
    }
}
