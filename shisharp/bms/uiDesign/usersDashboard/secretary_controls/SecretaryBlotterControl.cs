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

namespace BrgyMS.uiDesign.usersDashboard.secretary_controls {
    public partial class SecretaryBlotterControl : UserControl {
        private UIResidentUtils uioResident = new UIResidentUtils();
        private Utils utils = new Utils();
        private UsersModal modal = new UsersModal();
        private SecretaryServices _Secretary = new SecretaryServices();
        private AdminServices _AdminServices = new AdminServices();
        private BlotterResidentModalCotntrol blotterModal = new BlotterResidentModalCotntrol();
        SecretaryRepository _SedcretaryRepo = new SecretaryRepository();
        public bool isUpdate = false;

        public SecretaryBlotterControl() {
            InitializeComponent();
        }


        private async Task SetDataWhenUpdatingBlotter() {
            try {

                string id = utils.ReadIdInFile();

                List<BlotterInformation> data = await _AdminServices.GetBlotterAndPersonalInfo(id);
                BlotterInformation blotter = (BlotterInformation)data[0];

                string complainantId = $"{blotter.ComplainantName} ({blotter.ComplainantId})";

                string respondedntId = $"{blotter.RespondentName} ({blotter.RespondentId})";

                blotterModal.cboComplainantName.SelectedItem = complainantId;
                blotterModal.cboRespondentName.SelectedItem = respondedntId;

                blotterModal.cboStatus.SelectedItem = blotter.Status;
                blotterModal.txtStatements.Text = blotter.Statements;


            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        //Table Resfresher
        public async void BlotterTableResfresher() {
            try {
                int limit = (int)nudLimit.Value;
                await _Secretary.FillBlotterTable(dataGridBlotterTable);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBlotter_Click_1(object sender, EventArgs e) {

            blotterModal = new BlotterResidentModalCotntrol();

            // if blotter Control is nulll then initialze it


            if (modal == null) {
                modal = new UsersModal();
            }

            modal.pnlContainer.Controls.Clear();
            modal.StartPosition = FormStartPosition.CenterScreen;
            modal.pnlContainer.Controls.Add(blotterModal);

            blotterModal.Dock = DockStyle.Fill;
            blotterModal.btnSubmitBlotter.BringToFront();
            modal.ShowDialog(this);
            BlotterTableResfresher();
        }

        private async void updateBlotterToolStripMenuItem_Click_1(object sender, EventArgs e) {
            modal = new UsersModal();
            blotterModal = new BlotterResidentModalCotntrol();
            string id = utils.ReadIdInFile();

            modal.pnlContainer.Controls.Clear();
            modal.pnlContainer.Controls.Add(blotterModal);

            blotterModal.Dock = DockStyle.Fill;

            //eneble update only
            blotterModal.cboStatus.Enabled = true;
            blotterModal.cboComplainantName.Enabled = false;
            blotterModal.cboRespondentName.Enabled = false;
            blotterModal.txtStatements.ReadOnly = true;


            blotterModal.btnUpdateBlotter.BringToFront();
            Cursor = Cursors.WaitCursor;
            await SetDataWhenUpdatingBlotter();
            Cursor = Cursors.Default;
            modal.ShowDialog(this);
            BlotterTableResfresher();
        }

        private async void deleteBlotterToolStripMenuItem_Click_1(object sender, EventArgs e) {
            try {

                SecretaryBlotterControl bControl = new SecretaryBlotterControl();

                string id = utils.ReadIdInFile();

                var option = MessageBox.Show("Are you sure you wan to delete this permanently?", "Delete Blotter",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (option == DialogResult.Yes) {
                    Cursor = Cursors.WaitCursor;
                    await _AdminServices.DeleteBlotter(id);
                    Cursor = Cursors.Default;
                    MessageBox.Show("Successfully deleted!");


                    await _Secretary.FillBlotterTable(dataGridBlotterTable);
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridBlotterTable_MouseDown_1(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right) {
                var hit = dataGridBlotterTable.HitTest(e.X, e.Y); // get the location where clicked
                if (hit.RowIndex >= 0) {


                    dataGridBlotterTable.ClearSelection();
                    dataGridBlotterTable.Rows[hit.RowIndex].Selected = true; // set selection where the mouse clicked

                    string userId = dataGridBlotterTable.Rows[hit.RowIndex].Cells[0].Value?.ToString();
                    try {
                        utils.PutIdOnFile(userId);

                        //show the context
                        ctxBlotter.Show(this, dataGridBlotterTable.PointToScreen(e.Location));
                    }
                    catch (Exception ex) {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        private void SecretaryBlotterControl_Load_1(object sender, EventArgs e) {
            BlotterTableResfresher();
        }
    }
}
