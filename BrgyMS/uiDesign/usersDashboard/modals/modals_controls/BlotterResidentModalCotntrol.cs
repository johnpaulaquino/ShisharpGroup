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
        private void BlotterResidentModalCotntrol_Load(object sender, EventArgs e) {
            try {
                cboComplainantName.Items.Insert(0, "--Select--");
                cboComplainantName.SelectedItem = "--Select--";

                cboRespondentName.Items.Insert(0, "--Select--");
                cboRespondentName.SelectedItem = "--Select--";


                Task.Run(async () =>
                {
                    Cursor = Cursors.WaitCursor;
                    var dt = await _AdminServices.GetUserInformation();
                    foreach (DataRow item in dt.Rows) {
                        string fullnameWithID = $"{item["Fullname"]} ({item["ID"]})";
                        Invoke(new Action(() =>
                        {
                            cboComplainantName.Items.Add(fullnameWithID);

                        }));

                        Invoke(new Action(() =>
                        {
                            cboRespondentName.Items.Add(fullnameWithID);
                            cboRespondentName.SelectedIndex = 0;
                        }));

                    }
                    Cursor = Cursors.Default;

                });

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private async void btnSubmitBlotter_Click(object sender, EventArgs e) {
            try {


                BlotterInformation blotter = new()
                {
                    ComplainantId = cboComplainantName.SelectedItem.ToString(),
                    RespondentId = cboRespondentName.SelectedItem.ToString(),
                    DateFiled = DateTime.Now,
                    Statements = txtStatements.Text
                };


                string complainantId = Regex.Split(blotter.ComplainantId, @"[()]")[1].ToString();
                string respondenntId = Regex.Split(blotter.ComplainantId, @"[()]")[1].ToString();

                blotter.ComplainantId = complainantId;
                blotter.RespondentId = respondenntId;


                await _SecretaryServices.BlotterResident(blotter);

                MessageBox.Show("Successfully blotter Resident!");

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
    }
}
