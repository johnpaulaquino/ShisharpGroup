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

namespace BrgyMS.uiDesign {
    public partial class AdminForm : Form {
        private UIAdminUtils uiadmin = new UIAdminUtils();
        public AdminForm() {
            InitializeComponent();


        }

        private void AdminForm_Load(object sender, EventArgs e) {
            uiadmin.setAdminDashboardTableWitdth(dataGridAdminDashboard);
            uiadmin.SetUserInformation(lblRole, lblUsername);
            uiadmin.SetUserAndSecInfo(dataGridAdminDashboard, ((int)nudLimit.Value));

        }

        private void picProfilePic_Click(object sender, EventArgs e) {

        }

        

        private void nudLimit_ValueChanged(object sender, EventArgs e) {
            uiadmin.SetUserAndSecInfo(dataGridAdminDashboard, ((int)nudLimit.Value));

        }
    }
}
