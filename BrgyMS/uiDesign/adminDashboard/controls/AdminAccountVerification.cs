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
    public partial class AdminAccountVerification : UserControl {
        private readonly Utils utils = new();
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

        private void dataGridAdminDashboard_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right) {
                var hit = dataGridAdminDashboard.HitTest(e.X, e.Y); // get the location where clicked
                if (hit.RowIndex >= 0) {


                    dataGridAdminDashboard.ClearSelection();
                    dataGridAdminDashboard.Rows[hit.RowIndex].Selected = true; // set selection where the mouse clicked

                    string? userId = dataGridAdminDashboard.Rows[hit.RowIndex].Cells[0].Value?.ToString();
                    try {
                        utils.PutIdOnFile(userId);

                        //show the context
                        ctxAccountVerification.Show(this, dataGridAdminDashboard.PointToScreen(e.Location));
                    }
                    catch (Exception ex) {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void atsVerfiyAccount_Click(object sender, EventArgs e) {
            AdminModal modal = new();
            AccountVerificationModalControl control = new();
            modal.StartPosition = FormStartPosition.CenterScreen;
            modal.pnlModalMainContent.Controls.Add(control);
            control.Dock = DockStyle.Fill;

            modal.ShowDialog(this);
        }
    }
}
