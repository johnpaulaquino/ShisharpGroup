using BrgyMs.backend.models.base_model;
using BrgyMS.backend.models;
using BrgyMs.backend.services;
using BrgyMS.backend.services;
using BrgyMS.uiDesign.uiUtils.uiAdminUtils;
using Krypton.Toolkit;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BrgyMs.backend.utils;

namespace BrgyMS.uiDesign.adminDashboard.modals.modals_controls {
    public partial class UserInformationModalControl : UserControl {
        public List<BrgyMs.backend.models.base_model.User> userModals = new List<BrgyMs.backend.models.base_model.User>();
        private readonly UIAdminUtils uiadmin = new UIAdminUtils();
        private readonly AuthUtils _AuthUtils = new AuthUtils();
        private readonly BaseServices _BaseServices = new BaseServices();
        private string UserIdFromToken = "";
        public UserInformationModalControl() {

            InitializeComponent();
            string token = _AuthUtils.ReadTokenInFile();
            var user = _AuthUtils.ValidateToken(token);
            UserIdFromToken = user.UserId;
        }

        private async void btnMcLogin_Click_1(object sender, EventArgs e) {
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
