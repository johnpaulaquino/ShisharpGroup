using BrgyMs.backend.database.repositories;
using BrgyMs.backend.services;
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

namespace BrgyMS.uiDesign.adminDashboard.controls {
    public partial class AdminUserLogsControl : UserControl {
        private UIAdminUtils uiAdmin = new UIAdminUtils();
        private AdminServices _AdminServices = new AdminServices();
        public AdminUserLogsControl() {
            InitializeComponent();
        }

        private async void AdminUserLogsControl_Load(object sender, EventArgs e) {
            try {

                await uiAdmin.SetUserLogsToTable(dataGridAdminDashboard);

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
