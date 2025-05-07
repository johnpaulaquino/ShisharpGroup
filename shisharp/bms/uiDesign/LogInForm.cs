using BrgyMs.backend.models.base_model;
using BrgyMs.backend.services;
using BrgyMs.backend.utils;
using BrgyMs.database.connector;
using BrgyMs.uiDesign.uiLoginUtils;
using DotNetEnv;
using MySql.Data.MySqlClient;
using shisharp.bms.uiDesign;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BrgyMs.uiDesign {
    public partial class LoginForm : Form {
        private AuthUtils _AuthUtils = new AuthUtils();
        private AuthServices _Authervices = new AuthServices();
        private UILoginUtils uilogin = new UILoginUtils();
        private bool isCLicked = true;
        private EmailServices emailservices = new EmailServices();
        private AuthUtils authUtils = new AuthUtils();
        public LoginForm() {
            InitializeComponent();
        }

        private async void btnLogin_Click_1(object sender, EventArgs e) {

            if (isCLicked) {
                isCLicked = false;
                string username = txtUsername.Text.ToString();
                string password = txtPassword.Text.ToString();
                try {
                    Cursor = Cursors.WaitCursor;
                    bool isLoggedIn = await Task.Run(() =>
                    {
                        return _Authervices.AuthenticateUser(username, password);
                    });

                    if (isLoggedIn) {

                        MessageBox.Show("Successfully Login!");

                        uilogin.Homepage(this, _Authervices.GetStatus());
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
                finally {
                    isCLicked = true;
                    Cursor = Cursors.Default;

                }

            }
        }

        private void btnSignup_Click_1(object sender, EventArgs e) {
            SignUpForm signupForm = new SignUpForm();
            if (isCLicked) {
                isCLicked = false;
                Hide();
                signupForm.Show();
                signupForm.StartPosition = FormStartPosition.CenterScreen;
            }
        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e) {
            if (cbShowPass.Checked) {
                txtPassword.PasswordChar = (char)0;
                cbShowPass.Text = "Hide Password";
            }
            else {
                txtPassword.PasswordChar = '*';
                cbShowPass.Text = "Show Password";
            }
        }

        private void kryptonLinkLabel1_LinkClicked(object sender, EventArgs e) {
            try {
                ResetPasswordForm modal = new ResetPasswordForm();
                modal.StartPosition = FormStartPosition.CenterScreen;
                modal.ShowDialog(this);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

