using BrgyMs.backend.models.base_model;
using BrgyMS.backend.services;
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
    public partial class CreateUsersModalControl : UserControl {
        public List<User> userModals = new List<User>();
        private readonly UIAdminUtils uiadmin = new();
        private BaseServices _BaseServices = new();


        public CreateUsersModalControl() {
            InitializeComponent();
        }

        private void btnMcCreate_Click(object sender, EventArgs e) {
            string email = txtMcEmail.Text;
            string username = txtMcUsername.Text;
            string password = txtMcUsername.Text;
            string role = "users";
            bool status = true;

            if (cbMcSecretary.Checked) {
                role = "secretary";
            }


            User user = new User(email, username)
            {
                Password = password,
                Role = role,
                Status = status
            };
        }
    }
}
