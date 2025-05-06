using BrgyMs.backend.models.base_model;
using BrgyMs.backend.services;
using BrgyMs.backend.utils;
using BrgyMS.backend.models;
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

namespace BrgyMS.uiDesign.adminDashboard.modals.modals_controls {
    public partial class CreateUsersModalControl : UserControl {
        public List<BrgyMs.backend.models.base_model.User> userModals = new List<BrgyMs.backend.models.base_model.User>();
        private readonly UIAdminUtils uiadmin = new UIAdminUtils();
        private BaseServices _BaseServices = new BaseServices();
        private AdminServices _AdminServices = new AdminServices();
        private AuthUtils _AuthUtils = new AuthUtils();
        private string userId = "";



        public CreateUsersModalControl() {
            InitializeComponent();

            string token = _AuthUtils.ReadTokenInFile();
            BrgyMs.backend.models.base_model.User user = _AuthUtils.ValidateToken(token);
            userId = user.UserId;
        }

        private void ClearFields() {
            txtMcEmail.Text = "";
            txtMcPassword.Text = "";
            txtMcUsername.Text = "";
            cbMcSecretary.Checked = false;
            cbMcShowPass.Checked = false;
        }

        private async void btnMcCreate_Click_1(object sender, EventArgs e) {

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

                BrgyMs.backend.models.base_model.User user = new BrgyMs.backend.models.base_model.User(email, username)
                {
                    Password = password,
                    Role = role,
                    Status = status
                };


                Cursor = Cursors.WaitCursor;
                var option = MessageBox.Show("Are you sure you want to create this account?", "Create User",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                if (option == DialogResult.Yes) {
                    await _AdminServices.CreateUser(user);


                    string id = await _BaseServices.GenerateLogsId();

                    Logs logs = new Logs(id, userId, "Create")
                    {
                        DatePerformed = DateTime.Now,
                        Details = $"Create {user.Role} account."
                    };
                    await Task.Run(async () =>
                    {
                        await _BaseServices.LogUserActions(logs);
                    });

                    MessageBox.Show("Succssfully created account!");
                    ClearFields();
                }

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
    }
}
