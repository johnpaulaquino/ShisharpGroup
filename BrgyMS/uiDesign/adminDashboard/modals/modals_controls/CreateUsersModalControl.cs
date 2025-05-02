using BrgyMs.backend.models.base_model;
using BrgyMs.backend.services;
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
        private AdminServices _AdminServices = new();



        public CreateUsersModalControl() {
            InitializeComponent();
        }

        private async void btnMcCreate_Click(object sender, EventArgs e) {

            // Create Account
            try {

                string email = txtMcEmail.Text;
                string username = txtMcUsername.Text;
                string password = txtMcPassword.Text;
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
                Cursor = Cursors.WaitCursor;

                await _AdminServices.CreateUser(user);
                Invoke(new Action(() =>
                {
                    MessageBox.Show("Succssfully created account!");
                    ClearFields();

                }));
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            finally {
                Cursor = Cursors.Default;
            }
        }

        private void cbMcShowPass_CheckedChanged(object sender, EventArgs e) {
            if (cbMcShowPass.Checked) {
                txtMcPassword.PasswordChar = (char)0;
                cbMcShowPass.Text = "Hide Password";
            }
            else {
                txtMcPassword.PasswordChar = '●';
                cbMcShowPass.Text = "Show Password";
            }
        }

        private void ClearFields() {
            txtMcEmail.Text = "";
            txtMcPassword.Text = "";
            txtMcUsername.Text = "";
            cbMcSecretary.Checked = false;
            cbMcShowPass.Checked = false;
        }
    }
}
