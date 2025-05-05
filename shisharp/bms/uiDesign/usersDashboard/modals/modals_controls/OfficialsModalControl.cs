using BrgyMs.backend.data_validation;
using BrgyMs.backend.models.bo_model;
using BrgyMs.backend.models.residents_docs;
using BrgyMs.backend.services;
using BrgyMs.backend.utils;
using BrgyMS.backend.models;
using BrgyMS.backend.services;
using BrgyMS.uiDesign.adminDashboard.controls;
using BrgyMS.uiDesign.adminDashboard.modals;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BrgyMS.uiDesign.usersDashboard.modals {
    public partial class OfficialsModalControl : UserControl {
        private readonly UIAdminUtils uiadmin = new UIAdminUtils();
        private readonly Utils utils = new Utils();
        private bool isActivted = false;
        private AdminAccountVerification accverifyControl = new AdminAccountVerification();
        private bool isFirstTimeSeeker = false;
        private ResidentServices _ResidentServices = new ResidentServices();
        private SecretaryServices _SecretaryServices = new SecretaryServices();
        private BaseServices _BaseServices = new BaseServices();
        private UserInfoValidation validation = new UserInfoValidation();
        private AdminServices _AdminServices = new AdminServices();
        private List<string> listAccom = new List<string>();

        public OfficialsModalControl() {
            InitializeComponent();
            cboPosition.Items.Insert(0, "--Select--");
            cboPosition.SelectedItem = "--Select--";

            cboStatus.Items.Insert(0, "--Select--");
            cboStatus.SelectedItem = "--Select--";
            cboStatus.SelectedItem = "Active";
        }
        private void CLearFields() {
            cboPosition.SelectedItem = "--Select--";
            dtpkStartTerm.Value = DateTime.Now;
            dtpkEndTerm.Format = DateTimePickerFormat.Custom;
        }

        private void dtpkEndTerm_ValueChanged_1(object sender, EventArgs e) {
            if (dtpkEndTerm.Checked) {
                dtpkEndTerm.Format = DateTimePickerFormat.Long;
            }
            else {
                dtpkEndTerm.Format = DateTimePickerFormat.Custom;
            }
        }

        private async void btnSubmitOfficials_Click_2(object sender, EventArgs e) {
            try {
                List<string> accomp = new List<string>();
                List<string> achievements = new List<string>();

                string userId = utils.ReadIdInFile();

                String formattedStartDate = dtpkStartTerm.Value.Date.ToString("yyyy-mm-dd");
                String formattedEndtDate = dtpkEndTerm.Value.Date.ToString("yyyy-mm-dd");
                OfficialsInfo officialsInfo = new OfficialsInfo()
                {

                    Position = cboPosition.SelectedItem.ToString(),
                    Status = cboStatus.SelectedItem.ToString(),
                    UserId = userId,
                    TermStart = dtpkStartTerm.Value.Date,
                    TermEnd = dtpkEndTerm.Value.Date
                };

                Cursor = Cursors.WaitCursor;
                await Task.Run(async () =>
                {
                    await _SecretaryServices.AddBarangayOfficials(officialsInfo);

                });
                MessageBox.Show("Successfully Created Officials!");
                CLearFields();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            finally {
                Cursor = Cursors.Default;
            }
        }

        private void dtpkEndTerm_ValueChanged(object sender, EventArgs e) {
            if (dtpkEndTerm.Checked) {
                dtpkEndTerm.Format = DateTimePickerFormat.Long;
            }
            else {
                dtpkEndTerm.Format = DateTimePickerFormat.Custom;
            }
        }

        private async void btnOfficialsSaveChanges_Click(object sender, EventArgs e) {
            try {

                OfficialsInfo officials = new OfficialsInfo
                {
                    Position = cboPosition.SelectedItem.ToString(),
                    Status = cboStatus.SelectedItem.ToString(),
                    TermEnd = dtpkEndTerm.Value.Date,
                    TermStart = dtpkStartTerm.Value.Date
                };
                var option = MessageBox.Show("Are you sure you want to update this? ", "Barangay officials",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (option == DialogResult.OK) {
                    await _AdminServices.UpdateOfficials(officials);
                }
            }
            catch (Exception Ex) {
                MessageBox.Show(Ex.Message);
            }
        }
    }


}
