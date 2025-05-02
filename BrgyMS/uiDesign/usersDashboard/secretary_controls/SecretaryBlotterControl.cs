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
    public partial class SecretaryBlotterControl : UserControl {
        private UIResidentUtils uioResident = new UIResidentUtils();
        private Utils utils = new Utils();
        private UsersModal modal = new();
        public SecretaryBlotterControl() {
            InitializeComponent();
        }

        private void btnBlotter_Click(object sender, EventArgs e) {


            BlotterResidentModalCotntrol blotterModal = new(); // if blotter Control is nulll then initialze it


            if (modal == null) {
                modal = new();
            }

            modal.pnlContainer.Controls.Clear();
            modal.StartPosition = FormStartPosition.CenterScreen;
            modal.pnlContainer.Controls.Add(blotterModal);

            blotterModal.Dock = DockStyle.Fill;
            modal.ShowDialog(this);


        }
    }
}
