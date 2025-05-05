using BrgyMs.backend.services;
using BrgyMs.backend.utils;
using BrgyMS.uiDesign.adminDashboard.modals;
using BrgyMS.uiDesign.adminDashboard.modals.modals_controls;
using BrgyMS.uiDesign.uiUtils.uiAdminUtils;
using BrgyMS.uiDesign.usersDashboard.modals;
using BrgyMS.uiDesign.usersDashboard.secretary_controls;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrgyMS.uiDesign.adminDashboard.controls {
    public partial class AdminAccountManagementControl : UserControl {
        private UIAdminUtils uiAdmin = new UIAdminUtils();
        private Utils utils = new Utils();
        private AdminModal modal = new AdminModal();
        public bool isUpdated = false;
        public bool isCliked = false;
        private UsersModal Officialmodal = new UsersModal();
        private AdminServices _AdminServices = new AdminServices();
        public AdminAccountManagementControl() {
            InitializeComponent();
            AfterInit();

        }

        public async void AfterInit() {
            // Resfresh the table content
            Cursor = Cursors.WaitCursor;
            try {


                await uiAdmin.SetInfoInAdminAccountTable(dataGridAmTableAdmin);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            finally {
                Cursor = Cursors.Default;
            }

        }



        private void addAsBarangayOfficialsToolStripMenuItem_Click_1(object sender, EventArgs e) {
            try {
                OfficialsModalControl control = new OfficialsModalControl();

                Officialmodal.pnlContainer.Controls.Clear();
                Officialmodal.pnlContainer.Controls.Add(control);

                control.Dock = DockStyle.Fill;
                Officialmodal.ShowDialog(this);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            finally {
                Cursor = Cursors.Default;

            }
        }

        private void btnCreateSec_Click_1(object sender, EventArgs e) {
            try {
                isCliked = true; // to avoid multiple clicked and avoid error in showing modals
                if (isCliked) {
                    CreateUsersModalControl control = new CreateUsersModalControl();
                    modal.pnlModalMainContent.Controls.Clear();
                    modal.pnlModalMainContent.Controls.Add(control);

                    control.Dock = DockStyle.Fill;
                    modal.ShowDialog(this);
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            finally {
                isCliked = false;
            }
        }

        private async void actionsToolStripMenuItem_Click_1(object sender, EventArgs e) {
            isCliked = true;// to avoid multiple clicked and avoid error in showing modals
            try {
                if (isCliked) {
                    UserInformationModalControl control = new UserInformationModalControl();
                    modal.StartPosition = FormStartPosition.CenterScreen;

                    modal.pnlModalMainContent.Controls.Add(control);
                    control.Dock = DockStyle.Fill;

                    await uiAdmin.SetUserInfoInuserInfromationModal(control,
                        control.txtMcUserId,
                        control.txtMcEmail,
                        control.txtMcPassword,
                        control.txtMcUsername);

                    modal.ShowDialog(this);


                    await uiAdmin.SetInfoInAdminAccountTable(dataGridAmTableAdmin);

                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            finally {
                isCliked = false;
            }
        }

        private void dataGridAmTableAdmin_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right) {
                var hit = dataGridAmTableAdmin.HitTest(e.X, e.Y); // get the location where clicked
                if (hit.RowIndex >= 0) {


                    dataGridAmTableAdmin.ClearSelection();
                    dataGridAmTableAdmin.Rows[hit.RowIndex].Selected = true; // set selection where the mouse clicked

                    string userId = dataGridAmTableAdmin.Rows[hit.RowIndex].Cells[0].Value?.ToString();
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

        private async void AdminAccountManagementControl_Load_1(object sender, EventArgs e) {

            try {

                Cursor = Cursors.WaitCursor;

                await uiAdmin.SetInfoInAdminAccountTable(dataGridAmTableAdmin);


            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            finally {
                Cursor = Cursors.Default;
            }
        }

        private async void txtSearch_TextChanged_1(object sender, EventArgs e) {
            try {

                Cursor = Cursors.WaitCursor;


                await uiAdmin.SetInfoInAdminAccountTable(dataGridAmTableAdmin);
                ResumeLayout();

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            finally {
                Cursor = Cursors.Default;
            }

        }

        private async void nudAmLimit_ValueChanged(object sender, EventArgs e) {
            try {

                await uiAdmin.SetInfoInAdminAccountTable(dataGridAmTableAdmin);

                Cursor = Cursors.Default;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
