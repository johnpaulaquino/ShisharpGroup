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

namespace BrgyMS.uiDesign.usersDashboard.secretary_controls {
    public partial class SecretaryApprovalDocumentsControls : UserControl {
        private UIResidentUtils uioResident = new UIResidentUtils();
        private SecretaryServices _SecServices = new SecretaryServices();
        private Utils utils = new Utils();
        public SecretaryApprovalDocumentsControls() {
            InitializeComponent();
        }

        private void approveDocumentsToolStripMenuItem_Click(object sender, EventArgs e) {
            // will insert 

        }

        private void SecretaryApprovalDocumentsControls_Load_1(object sender, EventArgs e) {
            try {
                if (_SecServices == null) {
                    _SecServices = new SecretaryServices();
                }

                Invoke(new Action(async () =>
                {
                    await _SecServices.SetDataForApproveDocumentsTable(dataGridApproveDocument);
                }));

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridApproveDocument_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right) {
                var hit = dataGridApproveDocument.HitTest(e.X, e.Y); // get the location where clicked
                if (hit.RowIndex >= 0) {


                    dataGridApproveDocument.ClearSelection();
                    dataGridApproveDocument.Rows[hit.RowIndex].Selected = true; // set selection where the mouse clicked

                    string userId = dataGridApproveDocument.Rows[hit.RowIndex].Cells[0].Value?.ToString();
                    try {
                        utils.PutIdOnFile(userId);

                        //show the context
                        ctxApproveDocuments.Show(this, dataGridApproveDocument.PointToScreen(e.Location));
                    }
                    catch (Exception ex) {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}
