using BrgyMs.backend.models.base_model;
using BrgyMS.uiDesign.uiUtils.uiAdminUtils;
using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrgyMS.uiDesign.adminDashboard.modals.modals_controls {
    public partial class UserInformationModalControl : UserControl {
        public List<User> userModals = new List<User>();
        private readonly UIAdminUtils uiadmin = new();


        public UserInformationModalControl() {
            InitializeComponent();
        }

        private async void btnMcLogin_Click(object sender, EventArgs e) {
           
            string userId = txtMcUserId.Text;
            // call the function
            await uiadmin.UpdateAccountInfo(
                txtMcUsername,
                txtMcEmail,
                txtMcPassword,
                cbMcStatus,
                cbMcSecretary,
                userId,
                userModals
                );
        } 
    }
}
