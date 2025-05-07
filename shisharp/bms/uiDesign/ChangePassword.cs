using BrgyMs.backend.services;
using BrgyMs.backend.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shisharp.bms.uiDesign {
    public partial class ChangePassword : UserControl {
        private ResidentServices _ResidentServices = new ResidentServices();
        private Utils _Utils = new Utils();
        public ChangePassword() {
            InitializeComponent();
        }




        private void cbSShowPass_CheckedChanged(object sender, EventArgs e) {
            if (cbSShowPass.Checked) {
                cbSShowPass.Text = "Hide Password";
                txtPassword.PasswordChar = (char)0;
                txtConfirmPass.PasswordChar = (char)0;
            }
            else {
                cbSShowPass.Text = "Show Password";
                txtPassword.PasswordChar = '●';
                txtConfirmPass.PasswordChar = '●';
            }
        }

        private async void btnSubmit_Click(object sender, EventArgs e) {
            try {
                var option = MessageBox.Show("Are you you sure to your new password?", "Chage password",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                string userid = _Utils.ReadIdInFile();
                Cursor = Cursors.WaitCursor;
                if (option == DialogResult.Yes) {
                    await _ResidentServices.UpdatePassword(userid, txtPassword.Text, txtConfirmPass.Text);

                }
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
