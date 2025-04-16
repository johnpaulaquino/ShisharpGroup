using BrgyMs.backend.services;
using BrgyMs.backend.variables;
using DotNetEnv;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BrgyMs.uiDesign
{
    public partial class LoginForm : Form
    {
        private readonly AuthServices _Authervices = new AuthServices();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }



        private void btnLogin_Click_1(object sender, EventArgs e)
        {

        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {


            string username = txtUsername.Text.ToString();
            string password = txtPassword.Text.ToString();
            try
            {
                bool isLoggedIn = await _Authervices.AuthenticateUser(username, password);

                if (isLoggedIn)
                {
                    MessageBox.Show("Successfully Login!");
                    this.Hide();
                    new Homepage().Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPass.Checked)
            {
                txtPassword.PasswordChar = (char)0;
                cbShowPass.Text = "Hide Password";
            }
            else
            {
                txtPassword.PasswordChar = '*';
                cbShowPass.Text = "Show Password";
            }
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SignUpForm().Show();
        }
    }
}
