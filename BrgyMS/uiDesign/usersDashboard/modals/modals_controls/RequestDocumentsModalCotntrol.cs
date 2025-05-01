using BrgyMs.backend.data_validation;
using BrgyMs.backend.models.residents_model;
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

namespace BrgyMS.uiDesign.usersDashboard.modals {
    public partial class RequestDocumentsModalCotntrol : UserControl {
        private readonly UIAdminUtils uiadmin = new();
        private readonly Utils utils = new();
        private bool isActivted = false;
        private AdminAccountVerification accverifyControl = new();
        private bool isFirstTimeSeeker = false;
        private ResidentServices _ResidentServices = new();
        private BaseServices _BaseServices = new();

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

        private UserInfoValidation validation = new();


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

        private void cboDocsType_SelectedValueChanged(object sender, EventArgs e) {
            WhenClickedPurposes();
        }

        private async void btnSubmitRequest_Click(object sender, EventArgs e) {
            string forJobSeeker = "NBI/Police Clearance Application";

            try {
                string userId = utils.ReadUserIdInFile();
                ResidentDocumentRequest requestDocs = new ResidentDocumentRequest(userId,
                    cboDocsType.SelectedItem.ToString(),
                    cboPurposes.SelectedItem.ToString());


                validation.ValdiateRequestDocs(requestDocs); // validate the request
                string docsType = cboDocsType.SelectedItem.ToString();
              
                var option = MessageBox.Show("Are you sure you want to request this document?",
               "Personal Information", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);


                // to  not interrupt the other UI background while processing the data
                await Task.Run(async () =>
                {
                    string id = await _BaseServices.GenerateLogsId(); // generate id for logs
                    await _ResidentServices.CreateResidentDocument(requestDocs); // request docs
                    Logs logs = new Logs(id, userId, "Request", DateTime.Now

                        )
                    { Details = $"Requested {docsType}." };
                    await _BaseServices.LogUserActions(logs);
                });


                Invoke(new Action(() =>
                {
                    MessageBox.Show("Successfully requested documents, we will notify you once it is processed.");
                }));


            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboPurposes_SelectedIndexChanged(object sender, EventArgs e) {
            if (string.Equals(cboPurposes.SelectedItem.ToString(), "NBI/Police Clearance Application")) {
                cbFirstTimeJobSeeker.Enabled = true;

            }
            else {
                cbFirstTimeJobSeeker.Enabled = false;
                cbFirstTimeJobSeeker.Checked = false;
            }
        } // end of the function



    }


}
