using BrgyMs.backend.database.repositories;
using BrgyMs.backend.utils;
using BrgyMS.backend.services;
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
    public partial class EmailVerification : UserControl {

        private BaseServices _baseServices = new BaseServices();
        private ResidentRepository _Residentrepo = new ResidentRepository();
        private EmailServices _EmailServices = new EmailServices();
        private AuthUtils _AuthUtils = new AuthUtils();
        private Utils _Utils = new Utils();
        private int timeer = 60;
        private bool isclicked = true;
        public EmailVerification() {
            InitializeComponent();
        }

        private void EmailVerification_Load(object sender, EventArgs e) {

        }


        private void timer1_Tick_1(object sender, EventArgs e) {
            timeer--;

            if (timeer > 0) {
                lblTimer.Text = $"OTP expires in: {timeer}s";
            }
            else {
                timer1.Stop();
                lblTimer.Text = "OTP expired!";
                btnResend.Enabled = true;

            }
        }
        private void kryptonLabel1_Click(object sender, EventArgs e) {

        }
        private void StartOtpCountdown() {
            timeer = 60;
            lblTimer.Text = $"OTP expires in: {timeer}s";

            if (timer1 == null) {
                timer1 = new System.Windows.Forms.Timer();
                timer1.Interval = 1000;
                timer1.Tick += timer1_Tick_1;
            }

            timer1.Start();
        }

        private async void btnResend_Click(object sender, EventArgs e) {
            try {

                isclicked = false;
                await Task.Run(async () =>
                {
                    string otp = _AuthUtils.GenerateOTP();
                    await _EmailServices.SendPlainEmail(
                  txtSOtpCode.Text.Trim(), "Email Verification", $"This is your OTP. {otp}.");
                    btnResend.Enabled = false;
                    StartOtpCountdown();
                });


            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);

            }

        }

        private async void btnSubmit_Click(object sender, EventArgs e) {
            try {
                if (isclicked) {
                    isclicked = false;
                    Dictionary<string, string> data = await _Residentrepo.GetEmail(txtSOtpCode.Text);
                    Cursor = Cursors.WaitCursor;
                    if (data == null) {
                        throw new Exception("Email address not found!");
                    }
                    _AuthUtils = new AuthUtils();

                    await Task.Run(async () =>
                    {
                        string otp = _AuthUtils.GenerateOTP();
                        await _EmailServices.SendPlainEmail(
                      txtSOtpCode.Text.Trim(), "Email Verification", $"This is your OTP. {otp}.");
                        StartOtpCountdown();
                    });
                    lblEmail.Visible = false;
                    txtSOtpCode.BringToFront();
                    btnVerifyCode.BringToFront();
                    lblOtpCode.Visible = true;
                    lblTimer.Visible = true;
                    btnResend.Visible = true;
                }

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            finally {
                Cursor = Cursors.Default;
                isclicked = true;
            }
        }

        private void btnVerifyCode_Click(object sender, EventArgs e) {
            ChangePassword controls = new ChangePassword();
            try {
                if (timeer > 0) { // then check the timer 
                    if (_AuthUtils.VerifyTOTP(txtSOtpCode.Text)) { // then check if the user inputed the correct otp
                        _Utils.PutDocumetntTypeInFile(txtEmail.Text);
                        this.Controls.Clear();
                        this.Controls.Add(controls);

                        controls.Dock = DockStyle.Fill;

                    }
                    else {
                        throw new Exception("Incorrect OTP"); // otehrwise Incorrect otp
                    }
                }
                else {
                    throw new Exception("OTP is Eexpired!"); // otherwise expired
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
