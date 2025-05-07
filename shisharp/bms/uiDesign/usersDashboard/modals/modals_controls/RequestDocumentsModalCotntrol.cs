using BrgyMs.backend.data_validation;
using BrgyMs.backend.models.base_model;
using BrgyMs.backend.models.residents_docs;
using BrgyMs.backend.services;
using BrgyMs.backend.utils;
using BrgyMS.backend.models;
using BrgyMS.backend.services;
using BrgyMS.uiDesign.adminDashboard.controls;
using BrgyMS.uiDesign.adminDashboard.modals;
using BrgyMS.uiDesign.uiUtils.uiAdminUtils;
using Microsoft.VisualBasic;
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

namespace BrgyMS.uiDesign.usersDashboard.modals {
    public partial class RequestDocumentsModalCotntrol : UserControl {
        private ResidentServices _ResidentServices = new ResidentServices();
        private BaseServices _BaseServices = new BaseServices();
        private AuthUtils _AuthUtils = new AuthUtils();
        private Utils utils = new Utils();


        private string[] brgyClearancePurposes = { "Applying for a passport", "Registering a vehicle",
        "Applying for a marriage license", "Applying for a construction permit", "Government Transaction",
        "NBI/Police Clearance Application",
        "Application for Government Assistance"};

        private string[] brgyIndigencyPurposes = { "Educational Assistance", "Medical Assistance",
        "Financial Assistance", "Employment Requirements",
        "Housing Assistance",
        "Legal Aid",
        "Burial or Funeral Assistance","Livelihood Programs",
        "Social Pension Application",
        "Identity Verification", "Others"};

        private UserInfoValidation validation = new UserInfoValidation();


        public RequestDocumentsModalCotntrol() {
            InitializeComponent();

            cboDocsType.SelectedItem = "Barangay Certificate of Indigency";
        }

        private void WhenClickedPurposes() {
            cboPurposes.Enabled = true;

            if (string.Equals(cboDocsType.SelectedItem.ToString(), "Barangay Certificate of Indigency")) {
                cboPurposes.Items.Clear();
                foreach (var item in brgyIndigencyPurposes) {
                    cboPurposes.Items.Add(item);
                }
                cboPurposes.SelectedIndex = 0;
            }
            else if (string.Equals(cboDocsType.SelectedItem.ToString(), "Barangay Clearance")) {
                cboPurposes.Items.Clear();
                foreach (var item in brgyClearancePurposes) {
                    cboPurposes.Items.Add(item);
                }
                cboPurposes.SelectedIndex = 0;
            }
        }

        private async void btnSubmitRequest_Click_1(object sender, EventArgs e) {
            string forJobSeeker = "NBI/Police Clearance Application";

            try {

                string token = _AuthUtils.ReadTokenInFile();
                var user = _AuthUtils.ValidateToken(token);

                string purpose = cboPurposes.SelectedItem.ToString();

                //Check if purpose is others
                if (string.Equals(purpose, "Others")) {
                    if (string.IsNullOrEmpty(txtOtherPurpose.Text)) {
                        throw new Exception("Please state your purpose");
                    }
                }

                ResidentDocumentRequest requestDocs = new ResidentDocumentRequest()
                {
                    UserId = user.UserId,
                    DocumentType = cboDocsType.SelectedItem.ToString(),
                    Purpose = purpose,
                    OtherPurposes = txtOtherPurpose.Text
                };


                validation.ValidateRequestDocs(requestDocs); // validate the request
                string docsType = cboDocsType.SelectedItem.ToString();

                var option = MessageBox.Show("Are you sure you want to request this document?",
               "Personal Information", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);

                if (option == DialogResult.Yes) {
                    Cursor = Cursors.WaitCursor;
                    // to  not interrupt the other UI background while processing the data
                    await Task.Run(async () =>
                    {
                        string id = await _BaseServices.GenerateLogsId(); // generate id for logs
                        await _ResidentServices.CreateResidentDocument(requestDocs); // request docs
                        Logs logs = new Logs(id, user.UserId, "Request Docs", DateTime.Now)
                        { Details = $"Requested {docsType}." };
                        await _BaseServices.LogUserActions(logs);
                    });
                    MessageBox.Show("Successfully requested documents, we will notify you once it is processed.");

                    cboDocsType.SelectedItem = "Barangay Certificate of Indigency";
                    cboPurposes.SelectedIndex = 0;
                    txtOtherPurpose.Text = "";
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            finally {
                Cursor = Cursors.Default;
            }
        }

        private void cboDocsType_SelectedValueChanged_1(object sender, EventArgs e) {
            WhenClickedPurposes();
        }

        private void cboPurposes_SelectedValueChanged(object sender, EventArgs e) {
            if (string.Equals(cboPurposes.SelectedItem.ToString(), "Others")) {
                txtOtherPurpose.ReadOnly = false;
            }
            else {
                txtOtherPurpose.Text = "";
                txtOtherPurpose.ReadOnly = true;
            }
        }



        private async void btnSaveChanges_Click(object sender, EventArgs e) {
            try {
                string id = utils.ReadIdInFile();


                ResidentDocumentRequest dcs = new ResidentDocumentRequest()
                {
                    DocumentType = cboDocsType.SelectedItem.ToString(),
                    Purpose = cboPurposes.SelectedItem.ToString(),
                    OtherPurposes = txtOtherPurpose.Text
                };
                validation.ValidateRequestDocs(dcs);

                var option = MessageBox.Show("Are you sure you want to update this? ", "Update",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (option == DialogResult.Yes) {
                    await _ResidentServices.UpdateResidentRequestDocs(id,
                  dcs.DocumentType, dcs.Purpose, dcs.OtherPurposes);


                    string token = _AuthUtils.ReadTokenInFile();
                    var user = _AuthUtils.ValidateToken(token);

                    // to  not interrupt the other UI background while processing the data
                    await Task.Run(async () =>
                    {
                        string logsid = await _BaseServices.GenerateLogsId(); // generate id for logs

                        Logs logs = new Logs(logsid, user.UserId, "Update Docs", DateTime.Now

                            )
                        { Details = $"Update Requestd Docs." };
                        await _BaseServices.LogUserActions(logs);
                    });
                    MessageBox.Show("Successfully Updated!");
                }

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }


}
