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
        private UsersModal modal = new();
        private SecretaryServices _Secretary = new();
        private AdminServices _AdminServices = new();
        private AnnouncementsModalControl announceModalControl = new();
        private SecretaryRepository _SedcretaryRepo = new();
        private OfficialsModalControl offcialsCotntrol = new();

        public AdminOfficialsManagementControl() {
            InitializeComponent();
        }

        private void btnAddOfficials_Click(object sender, EventArgs e) {
            if (offcialsCotntrol == null) {
                offcialsCotntrol = new();
            }
            if (modal == null) {
                modal = new();
            }

            modal.pnlContainer.Controls.Clear();
            modal.StartPosition = FormStartPosition.CenterScreen;
            modal.pnlContainer.Controls.Add(offcialsCotntrol);

            offcialsCotntrol.Dock = DockStyle.Fill;
            modal.ShowDialog(this);
        }
    }
}
