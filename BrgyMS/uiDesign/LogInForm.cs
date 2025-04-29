using BrgyMs.backend.services;
using BrgyMs.backend.utils;
using BrgyMs.database.connector;
using BrgyMs.uiDesign.IndexUtils;
using DotNetEnv;
using MySql.Data.MySqlClient;
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
        private readonly AuthServices _Authervices = new AuthServices();
        private readonly UILoginUtils logUtils = new UILoginUtils();
        private bool isCLicked = true;
        public LoginForm() {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e) {


            if (isCLicked) {
                isCLicked = false;
                string username = txtUsername.Text.ToString();
                string password = txtPassword.Text.ToString();
                SuspendLayout();


                try {

                    bool isLoggedIn = await Task.Run(() =>
                    {
                        return _Authervices.AuthenticateUser(username, password);
                    });


                    if (isLoggedIn) {

                        MessageBox.Show("Successfully Login!");

                        logUtils.Homepage(this, _Authervices.GetStatus());
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                    System.Diagnostics.Debug.WriteLine(ex.StackTrace);
                }
                finally {
                    isCLicked = true;
                    ResumeLayout();
                }

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

        private void btnSignup_Click(object sender, EventArgs e) {
            SignUpForm signupForm = new SignUpForm();
            if (isCLicked) {
                isCLicked = false;
                Hide();
                signupForm.Show();
                signupForm.StartPosition = FormStartPosition.CenterScreen;
            }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e) {

        }
    }
}
