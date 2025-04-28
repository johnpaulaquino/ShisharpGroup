using BrgyMs.backend.utils;
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
    public partial class AccountVerificationModalControl : UserControl {
        private readonly UIAdminUtils uiadmin = new();
        private readonly Utils utils = new();
        private bool isActivted = false;
        private AdminAccountVerification accverifyControl = new();

        public AccountVerificationModalControl() {
            InitializeComponent();
        }

        private async void btnAvVerify_Click(object sender, EventArgs e) {
            isActivted = true;
            AdminModal modal = new AdminModal();


            string userId = utils.ReadUserIdInFile();
            var option = MessageBox.Show("Are you sure you want to activate this account? ",
                "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try {
                if (option == DialogResult.Yes) {

                    await uiadmin.ActivateUserAccount(userId, isActivted,
                                      txtAvEmail.Text, txtAvFname.Text);

                    accverifyControl.Refresh();
                    accverifyControl.dataGridAmTable.Refresh(); // refresh the table after changes

                    MessageBox.Show("Successfully activated account!");

                    accverifyControl.RefreshTabke();


                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                System.Diagnostics.Debug.WriteLine(ex.Message);

            }
        } // end of the function

        private async void AccountVerificationModalControl_Load(object sender, EventArgs e) {
            await uiadmin.SetuserInformationToVerificationControl(
                picAvProfilePicture,
                txtAvFname,
                txtAvEmail,
                txtxAvaddress,
                txtAvBday,
                txtAvGender,
                txtAvAge,
                picAvProofOfResidency
                );
        }

        private async void btnAvDecline_Click(object sender, EventArgs e) {
            string userId = utils.ReadUserIdInFile();
            AdminModal modal = new();
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
                        MessageBox.Show("Successfully declined account!");
                        modal.Hide();
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

    }
}
