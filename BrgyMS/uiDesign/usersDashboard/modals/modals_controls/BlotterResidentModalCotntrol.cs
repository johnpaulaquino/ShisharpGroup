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
        private readonly UIAdminUtils uiadmin = new();
        private readonly Utils utils = new();
        private bool isActivted = false;
        private AdminAccountVerification accverifyControl = new();
        private bool isFirstTimeSeeker = false;
        private ResidentServices _ResidentServices = new();
        private BaseServices _BaseServices = new();
        private SecretaryServices _SecretaryServices = new();
        private AdminServices _AdminServices = new();
        private UserInfoValidation validation = new();


        public BlotterResidentModalCotntrol() {
            InitializeComponent();

        }

        private async void btnSubmitBlotter_Click(object sender, EventArgs e) {
            try {



                SecretaryBlotterControl bControl = new();
                BlotterInformation blotter = new()
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
                string cname = Regex.Split(blotter.ComplainantId, @"[()]")[0].ToString().Trim();
                string rName = Regex.Split(blotter.RespondentId, @"[()]")[0].ToString().Trim();

                //set the id
                blotter.ComplainantId = complainantId;
                blotter.RespondentId = respondenntId;

                //set the name
                blotter.ComplainantName = cname;
                blotter.RespondentName = rName;

                var option = MessageBox.Show("Are you sure you want to blotter this?", "Blotter",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (option == DialogResult.Yes) {
                    Invoke(new Action(async () =>
                    {
                        await _SecretaryServices.BlotterResident(blotter);
                        MessageBox.Show("Successfully blotter Resident!");
                        ClearFields();
                    }));

                }

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }// end 

        private void ClearFields() {
            cboComplainantName.SelectedItem = "--Select--";
            cboRespondentName.SelectedItem = "--Select--";
            txtStatements.Text = "";
        }


        private async void btnUpdateBlotter_MouseClick(object sender, MouseEventArgs e) {
            try {
                string id = utils.ReadIdInFile();


                //await _AdminServices.UpdateBlotter(id, blotter);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            // end

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

        private async void btnUpdateBlotter_Click(object sender, EventArgs e) {
            try {
                string id = utils.ReadIdInFile();
                string status = cboStatus.SelectedItem.ToString();
                Cursor = Cursors.WaitCursor;
                await Task.Run(async () =>
                  {
                      await _AdminServices.UpdateBlotter(id, status);
                  });

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
