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
using BrgyMs.backend.models.base_model;
using Krypton.Toolkit;
using Stimulsoft.Controls.Win.DotNetBar;
using Microsoft.VisualBasic.ApplicationServices;
using Mysqlx.Crud;

namespace BrgyMS.uiDesign.usersDashboard.user_controls {
    public partial class RequestDocumentsControls : UserControl {
        private UIResidentUtils uioResident = new UIResidentUtils();
        private Utils utils = new Utils();
        private AuthUtils _Authutils = new AuthUtils();
        private ResidentServices _residentServices = new ResidentServices();

        public RequestDocumentsControls() {
            InitializeComponent();
        }

        private void btnLogin_Click_1(object sender, EventArgs e) {

            UsersModal docs = new UsersModal();
            RequestDocumentsModalCotntrol control = new RequestDocumentsModalCotntrol();

            control.btnSubmitRequest.BringToFront();
            docs.pnlContainer.Controls.Clear();
            docs.pnlContainer.Controls.Add(control);
            control.Dock = DockStyle.Fill;

            docs.ShowDialog(this);
        }

        private async void RequestDocumentsControls_Load_1(object sender, EventArgs e) {

            string token = _Authutils.ReadTokenInFile();

            BrgyMs.backend.models.base_model.User user = _Authutils.ValidateToken(token);

            string UserId = user.UserId;

            Cursor = Cursors.WaitCursor;
            // when in UI thread
            await uioResident.SetRequestDocumentsControlsTable(dataGridAdminDashboard, UserId);
            Cursor = Cursors.Default;

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e) {

        }

        private async void updateRequestDocumentToolStripMenuItem_Click(object sender, EventArgs e) {
            UsersModal docs = new UsersModal();
            string token = _Authutils.ReadTokenInFile();

            var user = _Authutils.ValidateToken(token);
            string UserId = user.UserId;

            RequestDocumentsModalCotntrol control = new RequestDocumentsModalCotntrol();
         
            string dcoId = utils.ReadIdInFile();
            docs.pnlContainer.Controls.Clear();
            control.btnSaveChanges.BringToFront();
            docs.pnlContainer.Controls.Add(control);
            control.Dock = DockStyle.Fill;

            await SetExisitngData(control.cboDocsType, control.cboPurposes, control.txtOtherPurpose
                , control.cbFirstTimeJobSeeker);

            docs.ShowDialog(this);
            //refresh table after close the modal
            await uioResident.SetRequestDocumentsControlsTable(dataGridAdminDashboard, UserId);
        }

        private void dataGridAdminDashboard_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right) {
                var hit = dataGridAdminDashboard.HitTest(e.X, e.Y); // get the location where clicked
                if (hit.RowIndex >= 0) {


                    dataGridAdminDashboard.ClearSelection();
                    dataGridAdminDashboard.Rows[hit.RowIndex].Selected = true; // set selection where the mouse clicked

                    string userId = dataGridAdminDashboard.Rows[hit.RowIndex].Cells[0].Value?.ToString();
                    try {
                        utils.PutIdOnFile(userId);

                        //show the context
                        ctxResidentRequestDocs.Show(this, dataGridAdminDashboard.PointToScreen(e.Location));
                    }
                    catch (Exception ex) {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        } // end

        public async Task SetExisitngData(KryptonComboBox cboDocType,
            KryptonComboBox cboPurpose, KryptonTextBox otherPurpose,
            KryptonCheckBox isFirsttime) {
            try {
                string token = _Authutils.ReadTokenInFile();

                var user = _Authutils.ValidateToken(token);
                string UserId = user.UserId;
                var dt = await _residentServices.GetRequestDocs(UserId);

                if (InvokeRequired) {
                    Invoke(new Action(() =>
                    {
                        foreach (DataRow item in dt.Rows) {
                            if ((int)item["fjob_seeker"] == 1) {
                                isFirsttime.Checked = true;
                            }
                            cboDocType.SelectedItem = (string)item["document_type"];
                            cboPurpose.SelectedItem = (string)item["purpose"];
                            otherPurpose.Text = (string)item["other_purposes"];
                        }

                    }));
                }

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
