using BrgyMs.backend.data_validation;
using BrgyMs.backend.models.residents_docs;
using BrgyMs.backend.services;
using BrgyMs.backend.utils;
using BrgyMS.backend.models;
using BrgyMS.backend.models.base_model;
using BrgyMS.backend.services;
using BrgyMS.uiDesign.adminDashboard.controls;
using BrgyMS.uiDesign.adminDashboard.modals;
using BrgyMS.uiDesign.uiUtils.uiAdminUtils;
using BrgyMS.uiDesign.usersDashboard.secretary_controls;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrgyMS.uiDesign.usersDashboard.modals {
    public partial class BlotterResidentModalCotntrol : UserControl {
        private readonly UIAdminUtils uiadmin = new UIAdminUtils();
        private readonly Utils utils = new Utils();
        private bool isActivted = false;
        private AdminAccountVerification accverifyControl = new AdminAccountVerification();
        private bool isFirstTimeSeeker = false;
        private ResidentServices _ResidentServices = new ResidentServices();
        private BaseServices _BaseServices = new BaseServices();
        private SecretaryServices _SecretaryServices = new SecretaryServices();
        private AdminServices _AdminServices = new AdminServices();
        private UserInfoValidation validation = new UserInfoValidation();
        private string userId = "";
        private AuthUtils _AuthUtils = new AuthUtils();

        public BlotterResidentModalCotntrol() {
            InitializeComponent();
            string token = _AuthUtils.ReadTokenInFile();
            var user = _AuthUtils.ValidateToken(token);

            userId = user.UserId;
        }

        private void ClearFields() {
            cboComplainantName.SelectedItem = "--Select--";
            cboRespondentName.SelectedItem = "--Select--";
            txtStatements.Text = "";
        }



        private async void btnUpdateBlotter_Click_1(object sender, EventArgs e) {
            try {
                string id = utils.ReadIdInFile();
                string status = cboStatus.SelectedItem.ToString();
                Cursor = Cursors.WaitCursor;

                var option = MessageBox.Show("Are you sure you want to update this?", "Blotter",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (option == DialogResult.Yes) {
                    await _AdminServices.UpdateBlotter(id, status);

                    string logsId = await _BaseServices.GenerateLogsId();

                    Logs logs = new Logs(logsId, userId, "Blotter")
                    {
                        DatePerformed = DateTime.Now,
                        Details = $"Update Blotter Resident with the id of {id}."
                    };

                    await Task.Run(async () =>
                    {
                        await _BaseServices.LogUserActions(logs);
                    });
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            finally {
                Cursor = Cursors.Default;
            }

        }

        private async void BlotterResidentModalCotntrol_Load(object sender, EventArgs e) {
            try {
                cboComplainantName.Items.Clear();
                cboRespondentName.Items.Clear();

                cboComplainantName.Items.Insert(0, "--Select--");
                cboComplainantName.SelectedItem = "--Select--";

                cboRespondentName.Items.Insert(0, "--Select--");
                cboRespondentName.SelectedItem = "--Select--";


                Cursor = Cursors.WaitCursor;
                var dt = await _AdminServices.GetUserInformation();
                List<string> list1 = new List<string>();
                await Task.Run(() =>
                {
                    foreach (DataRow item in dt.Rows) {
                        string fullnameWithID = $"{item["Fullname"]} ({item["ID"]})";
                        list1.Add(fullnameWithID);
                    }
                });

                if (InvokeRequired) {
                    BeginInvoke(new Action(() =>
                    {
                        foreach (var item in list1) {
                            cboComplainantName.Items.Add(item);
                            cboRespondentName.Items.Add(item);
                        }
                    }));
                }
                else {
                    foreach (var item in list1) {
                        cboComplainantName.Items.Add(item);
                        cboRespondentName.Items.Add(item);
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            finally {
                Cursor = Cursors.Default;
            }
        }

        private async void btnSubmitBlotter_Click(object sender, EventArgs e) {
            try {
                AdminBlotterControl bControl = new AdminBlotterControl();
                BlotterInformation blotter = new BlotterInformation()
                {
                    ComplainantId = cboComplainantName.SelectedItem.ToString(),
                    RespondentId = cboRespondentName.SelectedItem.ToString(),
                    DateFiled = DateTime.Now,
                    Statements = txtStatements.Text,
                };

                // to get the id
                string complainantId = Regex.Split(blotter.ComplainantId, @"[()]")[1].ToString();
                string respondenntId = Regex.Split(blotter.RespondentId, @"[()]")[1].ToString();

                // cut the word to get the full name of respondent and complainant name
                string cname = Regex.Split(cboComplainantName.SelectedItem.ToString(), @"[()]")[0].ToString().Trim();
                string rName = Regex.Split(cboRespondentName.SelectedItem.ToString(), @"[()]")[0].ToString().Trim();


                //set the id
                blotter.ComplainantId = complainantId;
                blotter.RespondentId = respondenntId;


                //set the name
                blotter.ComplainantName = cname;
                blotter.RespondentName = rName;

                
                var option = MessageBox.Show("Are you sure you want to blotter this?", "Blotter",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (option == DialogResult.Yes) {

                    await _SecretaryServices.BlotterResident(blotter);

                    string id = await _BaseServices.GenerateLogsId();

                    Logs logs = new Logs(id, userId, "Blotter")
                    {
                        DatePerformed = DateTime.Now,
                        Details = $"Blotter Resident."
                    };

                    await Task.Run(async () =>
                    {
                        await _BaseServices.LogUserActions(logs);
                    });

                    MessageBox.Show("Successfully blotter Resident!");
                    ClearFields();


                }

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
