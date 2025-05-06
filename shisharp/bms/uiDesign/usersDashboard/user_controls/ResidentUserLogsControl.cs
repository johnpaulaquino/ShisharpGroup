using BrgyMs.backend.database.repositories;
using BrgyMs.backend.models.base_model;
using BrgyMs.backend.services;
using BrgyMs.backend.utils;
using BrgyMS.backend.services;
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

namespace BrgyMS.uiDesign.usersDashboard.user_controls {
    public partial class ResidentUserLogsControl : UserControl {
        private UIResidentUtils uiAdmin = new UIResidentUtils();
        private AdminServices _AdminServices = new AdminServices();
        private BaseServices _BaseServices = new BaseServices();
        private AuthServices _AuthServices = new AuthServices();
        private AuthUtils _AuthUtils = new AuthUtils();
        private Utils _Utils = new Utils();

        public ResidentUserLogsControl() {
            InitializeComponent();
        }

        private async void ResidentUserLogsControl_Load(object sender, EventArgs e) {
            try {
                string token = _AuthUtils.ReadTokenInFile();
                User user = _AuthUtils.ValidateToken(token);

                Cursor = Cursors.WaitCursor;
                var dt = await _BaseServices.GetUserlogs(user.UserId);
                dataGridAdminDashboard.Columns.Clear();
                dataGridAdminDashboard.DataSource = dt;

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            finally {
                Cursor = Cursors.Default;
            }

        }
    }
}
