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
    public partial class SecretaryAnnouncementsControl : UserControl {
        private UIResidentUtils uioResident = new UIResidentUtils();
        private Utils utils = new Utils();
        private UsersModal modal = new();
        private SecretaryServices _Secretary = new();
        private AdminServices _AdminServices = new();
        private BlotterResidentModalCotntrol blotterModal = new();
        SecretaryRepository _SedcretaryRepo = new();
        public bool isUpdate = false;
        private AnnouncementsModalControl announceModalControl = new();


        public SecretaryAnnouncementsControl() {
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

        private void SecretaryAnnouncementsControl_Load(object sender, EventArgs e) {
            AnnouncementsRefreshTable();
        }
    }
}
