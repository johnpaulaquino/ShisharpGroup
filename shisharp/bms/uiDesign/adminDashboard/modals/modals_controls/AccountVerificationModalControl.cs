using BrgyMs.backend.models.base_model;
using BrgyMs.backend.utils;
using BrgyMS.backend.models;
using BrgyMS.backend.services;
using BrgyMS.uiDesign.adminDashboard.controls;
using BrgyMS.uiDesign.uiUtils.uiAdminUtils;
using Microsoft.VisualBasic;
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
    public partial class RequestDocumentsModalCotntrol : UserControl {
        private readonly UIAdminUtils uiadmin = new UIAdminUtils();
        private readonly Utils utils = new Utils();
        private readonly AuthUtils AuthUtils = new AuthUtils();
        private readonly BaseServices _BaseServices = new BaseServices();
        private bool isActivted = false;
        private AdminAccountVerification accverifyControl = new AdminAccountVerification();
        private string AdminId = "";
        public RequestDocumentsModalCotntrol() {
            InitializeComponent();
            string token = AuthUtils.ReadTokenInFile();
            User user = AuthUtils.ValidateToken(token);
            AdminId = user.UserId;
        }


        private async void btnAvDecline_Click_1(object sender, EventArgs e) {
            string userId = utils.ReadIdInFile();
            AdminModal modal = new AdminModal();
            var option = MessageBox.Show("Are you sure you want to decline this account? ",
                "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try {
                if (option == DialogResult.Yes) {
                    var reason = Interaction.InputBox("Reason for declining account: ", "Reason");
                    if (!string.IsNullOrEmpty(reason)) {
                        await uiadmin.ActivateUserAccount(userId, isActivted,
                            txtAvEmail.Text, txtAvFname.Text);

                        accverifyControl.Refresh();
                        accverifyControl.dataGridAmTable.Refresh(); // refresh the table after changes
                        string id = await _BaseServices.GenerateLogsId();
                        Logs logs = new Logs(id, AdminId, "Declined user")
                        {
                            DatePerformed = DateTime.Now,
                            Details = $"WE declined your account due to the: {reason}."
                        };
                        await Task.Run(async () =>
                        {
                            await _BaseServices.LogUserActions(logs);
                        });

                        ClearField();
                        MessageBox.Show("Successfully declined account!");
                        accverifyControl.RefreshTabke();
                    }
                    else {
                        throw new Exception("Please specify the reason: ");
                    }

                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                System.Diagnostics.Debug.WriteLine(ex.Message);

            }
        }

        private async void btnAvVerify_Click_1(object sender, EventArgs e) {
            isActivted = true;
            AdminModal modal = new AdminModal();


            string userId = utils.ReadIdInFile();
            var option = MessageBox.Show("Are you sure you want to activate this account? ",
                "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try {
                if (option == DialogResult.Yes) {

                    await uiadmin.ActivateUserAccount(userId, isActivted,
                                      txtAvEmail.Text, txtAvFname.Text);
                    string id = await _BaseServices.GenerateLogsId();
                    Logs logs = new Logs(id, AdminId, "Ativate user")
                    {
                        DatePerformed = DateTime.Now,
                        Details = "Activated User account."
                    };
                    await Task.Run(async () =>
                    {
                        await _BaseServices.LogUserActions(logs);
                    });
                    ClearField();
                    MessageBox.Show("Successfully activated account!");

                    accverifyControl.RefreshTabke();



                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                System.Diagnostics.Debug.WriteLine(ex.Message);

            }
        }

        private async void RequestDocumentsModalCotntrol_Load(object sender, EventArgs e) {
            await uiadmin.SetUserLabelToVerificationControl(
               picAvProfilePicture,
               txtAvFname,
               txtAvEmail,
               txtxAvaddress,
               txtAvBday,
               txtAvGender,
               txtAvAge,
               picAvProofOfResidency
               );
        }// 

        private void ClearField() {
            txtAvAge.Text = "";
            txtAvBday.Text = "";
            txtAvEmail.Text = "";
            txtxAvaddress.Text = "";
            txtAvFname.Text = "";
            txtAvGender.Text = "";
            picAvProfilePicture.Image = null;
            picAvProofOfResidency.Image = null;
        }
    }
}
