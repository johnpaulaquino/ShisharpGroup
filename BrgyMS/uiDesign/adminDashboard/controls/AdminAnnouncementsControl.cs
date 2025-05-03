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
    public partial class AdminAnnouncementsControl : UserControl {
        private UIAdminUtils uiAdmin = new UIAdminUtils();
        private Utils utils = new Utils();
        private UsersModal modal = new();
        private SecretaryServices _Secretary = new();
        private AdminServices _AdminServices = new();
        private AnnouncementsModalControl announceModalControl = new();
        SecretaryRepository _SedcretaryRepo = new();
        public bool isUpdate = false;

        public AdminAnnouncementsControl() {
            InitializeComponent();
        }

        private async void btnBlotter_Click(object sender, EventArgs e) {

            announceModalControl = new();

            // if blotter Control is nulll then initialze it


            if (modal == null) {
                modal = new();
            }

            modal.pnlContainer.Controls.Clear();
            modal.StartPosition = FormStartPosition.CenterScreen;
            modal.pnlContainer.Controls.Add(announceModalControl);

            announceModalControl.Dock = DockStyle.Fill;
            announceModalControl.btnSubmitAnnouncements.BringToFront();
            modal.ShowDialog(this);
            AnnouncementsRefreshTable();


        }


        private void dataGridBlotterTable_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right) {
                var hit = dataGridBlotterTable.HitTest(e.X, e.Y); // get the location where clicked
                if (hit.RowIndex >= 0) {


                    dataGridBlotterTable.ClearSelection();
                    dataGridBlotterTable.Rows[hit.RowIndex].Selected = true; // set selection where the mouse clicked

                    string? announceId = dataGridBlotterTable.Rows[hit.RowIndex].Cells[0].Value?.ToString();
                    try {
                        utils.PutIdOnFile(announceId);

                        //show the context
                        ctxBlotter.Show(this, dataGridBlotterTable.PointToScreen(e.Location));
                    }
                    catch (Exception ex) {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private async void deleteBlotterToolStripMenuItem_Click(object sender, EventArgs e) {

            try {

                string id = utils.ReadIdInFile();

                var option = MessageBox.Show("Are you sure you wan to delete this permanently?", "Delete Blotter",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (option == DialogResult.Yes) {
                    Cursor = Cursors.WaitCursor;

                    await Task.Run(async () =>
                    {
                        await _AdminServices.DeleteAnnuoncement(id); // delte the announcement
                    });


                    Cursor = Cursors.Default;
                    MessageBox.Show("Successfully deleted!");
                    AnnouncementsRefreshTable();
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            finally {
                Cursor = Cursors.Default;
            }
        }

        private async void updateBlotterToolStripMenuItem_Click(object sender, EventArgs e) {
            try {
                modal = new();
                announceModalControl = new();

                modal.pnlContainer.Controls.Clear();

                modal.pnlContainer.Controls.Add(announceModalControl);

                announceModalControl.Dock = DockStyle.Fill;

                //eneble update only

                announceModalControl.btnUpdateAnnouncements.BringToFront();
                Cursor = Cursors.WaitCursor;

                await SetDataWhenUpdatingAnnouncents();// set data in the mdoal

                Cursor = Cursors.Default;
                modal.ShowDialog(this);

                Cursor = Cursors.WaitCursor;
                //refresh table after the modal is close
                AnnouncementsRefreshTable();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            finally {
                Cursor = Cursors.Default;
            }

        }


        private void SecretaryBlotterControl_Load(object sender, EventArgs e) {
            try {

                Cursor = Cursors.WaitCursor;

                AnnouncementsRefreshTable();
            }
            catch (Exception ex) {

            }
            finally {
                Cursor = Cursors.Default;
            }

        }

        //Set the data in announcement when click update
        private async Task SetDataWhenUpdatingAnnouncents() {
            try {

                string id = utils.ReadIdInFile();

                var announcement = await _Secretary.GetAnnouncement(id);

                announceModalControl.cbHidePost.Enabled = true;
                announceModalControl.txtStatements.Text = announcement.Details;
                announceModalControl.txtTitle.Text = announcement.Title;

                MessageBox.Show(announcement.Title);

                if (announcement.Attachments != null) {
                    var ms = new MemoryStream(announcement.Attachments);
                    announceModalControl.picAttachment.Image = new Bitmap(ms);
                }


            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        //Table Resfresher


        public async void AnnouncementsRefreshTable() {
            try {
                int limit = (int)nudLimit.Value;
                await _Secretary.FillAnnouncementTable(dataGridBlotterTable);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
