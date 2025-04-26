using BrgyMs.backend.utils;
using BrgyMS.uiDesign.uiUtils.uiAdminUtils;
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
        public AccountVerificationModalControl() {
            InitializeComponent();
        }

        private async void btnAvVerify_Click(object sender, EventArgs e) {
            isActivted = true;
            string userId = utils.ReadUserIdInFile();
            var option = MessageBox.Show("Are you sure you want to activate this? ",
                "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try {
                if (option == DialogResult.Yes) {
                    await uiadmin.ActivateUserAccount(userId, isActivted);
                    MessageBox.Show("Successfully activated account!");
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                System.Diagnostics.Debug.WriteLine(ex.Message);

            }
        }

        private async void AccountVerificationModalControl_Load(object sender, EventArgs e) {
            await uiadmin.SetuserInformationToVerificationControl(
                picAvProfilePicture, 
                txtAvFname,
                txtxAvaddress,
                txtAvBday,
                txtAvGender,
                txtAvAge,
                picAvProofOfResidency
                );
        }
    }
}
