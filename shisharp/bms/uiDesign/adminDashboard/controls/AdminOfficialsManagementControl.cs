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
using BrgyMS.backend.models.base_model;
using Mysqlx.Crud;
using BrgyMs.backend.models.base_model;
using BrgyMS.uiDesign.usersDashboard.secretary_controls;

namespace BrgyMS.uiDesign.adminDashboard.controls {
    public partial class AdminOfficialsManagementControl : UserControl {
        private UIAdminUtils uiAdmin = new UIAdminUtils();
        private Utils utils = new Utils();
        private UsersModal modal = new UsersModal();
        private SecretaryServices _Secretary = new SecretaryServices();
        private AdminServices _AdminServices = new AdminServices();
        private AnnouncementsModalControl announceModalControl = new AnnouncementsModalControl();
        private SecretaryRepository _SedcretaryRepo = new SecretaryRepository();
        private OfficialsModalControl offcialsCotntrol = new OfficialsModalControl();

        public AdminOfficialsManagementControl() {
            InitializeComponent();
        }
        //          if (offcialsCotntrol == null) {
        //                offcialsCotntrol = new OfficialsModalControl();
        //    }
        //            if (modal == null) {
        //                modal = new UsersModal();
        //}

        //modal.pnlContainer.Controls.Clear();
        //modal.StartPosition = FormStartPosition.CenterScreen;
        //modal.pnlContainer.Controls.Add(offcialsCotntrol);

        //offcialsCotntrol.Dock = DockStyle.Fill;
        //modal.ShowDialog(this);

        private async void updateBlotterToolStripMenuItem_Click_1(object sender, EventArgs e) {
            try {
                offcialsCotntrol = new OfficialsModalControl();
                Cursor = Cursors.WaitCursor;

                modal.pnlContainer.Controls.Clear();
                modal.pnlContainer.Controls.Add(offcialsCotntrol);
                offcialsCotntrol.Dock = DockStyle.Fill;

                offcialsCotntrol.txtAccom.Enabled = true;

                offcialsCotntrol.txtAchievements.Enabled = true;
                offcialsCotntrol.btnAddAccom.Enabled = true;
                offcialsCotntrol.btnAddAchievement.Enabled = true;
                offcialsCotntrol.btnOfficialsSaveChanges.BringToFront();
                offcialsCotntrol.cboDateRange.Enabled = true;
                offcialsCotntrol.cboStatus.Enabled = true;
                offcialsCotntrol.cboAcom.Enabled = true;
                offcialsCotntrol.cboAchievements.Enabled = true;

                offcialsCotntrol.cboPosition.Enabled = false;
                offcialsCotntrol.dtpkEndTerm.Enabled = false;
                offcialsCotntrol.dtpkStartTerm.Enabled = false;


                //set the data into officials modal
                await uiAdmin.SetOfficialsDataInModal(offcialsCotntrol.txtAccom,
                    offcialsCotntrol.txtAchievements, offcialsCotntrol.cboStatus, offcialsCotntrol.cboPosition,
                    offcialsCotntrol.cboDateRange, offcialsCotntrol.cboAcom, offcialsCotntrol.cboAchievements);

                modal.ShowDialog(this);
                Cursor = Cursors.WaitCursor;

                await uiAdmin.SetOfficialsInTable(dataGridOFficialsable);


            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            finally {
                Cursor = Cursors.Default;
            }
        }

        private async void deleteBlotterToolStripMenuItem_Click_1(object sender, EventArgs e) {
            try {
                string userid = utils.ReadIdInFile();
                var option = MessageBox.Show("Are you sure you want to delete this permanently?", "Delete",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (option == DialogResult.Yes) {
                    await _AdminServices.DeleteOfficials(userid);
                }

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridOFficialsable_MouseDown_1(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right) {
                var hit = dataGridOFficialsable.HitTest(e.X, e.Y); // get the location where clicked
                if (hit.RowIndex > 0) {


                    dataGridOFficialsable.ClearSelection();
                    dataGridOFficialsable.Rows[hit.RowIndex].Selected = true; // set selection where the mouse clicked

                    string userId = dataGridOFficialsable.Rows[hit.RowIndex].Cells[0].Value?.ToString();
                    try {
                        utils.PutIdOnFile(userId);

                        //show the context
                        ctxOfficials.Show(this, dataGridOFficialsable.PointToScreen(e.Location));
                    }
                    catch (Exception ex) {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private async void AdminOfficialsManagementControl_Load_1(object sender, EventArgs e) {
            try {
                Cursor = Cursors.Default;

                await uiAdmin.SetOfficialsInTable(dataGridOFficialsable);
            }
            catch (Exception ex) {
                throw;
            }
            finally {
                Cursor = Cursors.Default;
            }
        }
    }
}
