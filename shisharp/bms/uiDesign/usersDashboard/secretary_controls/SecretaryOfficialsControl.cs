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
using shisharp.bms.uiDesign.usersDashboard.user_controls;

namespace BrgyMS.uiDesign.usersDashboard.secretary_controls {
    public partial class SecretaryOfficialsControl : UserControl {
        private UIResidentUtils uioResident = new UIResidentUtils();
        private Utils utils = new Utils();
        private OfficialsModalControl officalsModalC = new OfficialsModalControl();
        private UsersModal modal = new UsersModal();
        public SecretaryOfficialsControl() {
            InitializeComponent();
        }

        private void btnAddOfficials_Click(object sender, EventArgs e) {
            if (officalsModalC == null) {
                officalsModalC = new OfficialsModalControl();
            }
            if (modal == null) {
                modal = new UsersModal();
            }

            modal.pnlContainer.Controls.Clear();
            modal.StartPosition = FormStartPosition.CenterScreen;
            modal.pnlContainer.Controls.Add(officalsModalC);

            officalsModalC.Dock = DockStyle.Fill;
            modal.ShowDialog(this);
        }

        private void addAsRToolStripMenuItem_Click(object sender, EventArgs e) {
            try {
                UsersModal Officialmodal = new UsersModal();

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

        private void dataGridOfficalsTable_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right) {
                var hit = dataGridOfficalsTable.HitTest(e.X, e.Y); // get the location where clicked
                if (hit.RowIndex >= 0) {


                    dataGridOfficalsTable.ClearSelection();
                    dataGridOfficalsTable.Rows[hit.RowIndex].Selected = true; // set selection where the mouse clicked

                    string userId = dataGridOfficalsTable.Rows[hit.RowIndex].Cells[0].Value?.ToString();
                    try {
                        utils.PutIdOnFile(userId);

                        //show the context
                        ctcOfficials.Show(dataGridOfficalsTable, dataGridOfficalsTable.PointToScreen(e.Location));
                    }
                    catch (Exception ex) {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void officialsToolStripMenuItem_Click(object sender, EventArgs e) {
            OfficialsInfoModal modal = new OfficialsInfoModal();

            modal.ShowDialog(this);
        }

    }
}
