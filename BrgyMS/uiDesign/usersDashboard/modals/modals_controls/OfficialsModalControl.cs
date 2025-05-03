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

namespace BrgyMS.uiDesign.usersDashboard.modals {
    public partial class OfficialsModalControl : UserControl {
        private readonly UIAdminUtils uiadmin = new();
        private readonly Utils utils = new();
        private bool isActivted = false;
        private AdminAccountVerification accverifyControl = new();
        private bool isFirstTimeSeeker = false;
        private ResidentServices _ResidentServices = new();
        private SecretaryServices _SecretaryServices = new();
        private BaseServices _BaseServices = new();



        private UserInfoValidation validation = new();


        public OfficialsModalControl() {
            InitializeComponent();
            cboPosition.Items.Insert(0, "--Select--");
            cboPosition.SelectedItem = "--Select--";

            cboStatus.Items.Insert(0, "--Select--");
            cboStatus.SelectedItem = "--Select--";

        }

        private void btnSubmitOfficials_Click(object sender, EventArgs e) {
            try {

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private async void btnSubmitOfficials_Click_1(object sender, EventArgs e) {
            try {
                List<string> accomp = new List<string>();
                List<string> achievements = new List<string>();

                string userId = utils.ReadIdInFile();


                await Task.Run(async () =>
                 {
                     // Add tje items of cbo accomplished to the list
                     foreach (var item in cboAcom.Items) {
                         if (!string.Equals(item.ToString(), "--Select--")) {
                             accomp.Add(item.ToString());
                         }
                     }

                     // Add tje items of cbo ashievement to the list
                     foreach (var item in cboAchievements.Items) {
                         if (!string.Equals(item.ToString(), "--Select--")) {
                             achievements.Add(item.ToString());
                         }
                     }

                 });
                ElectionHistories elect = new()
                {
                    TermStart = dtpkEndTerm.Value,
                    TermEnd = dtpkEndTerm.Value,
                    Accomplished = accomp,
                    Achievements = achievements

                };

                OfficialsInfo officialsInfo = new()
                {

                    Position = cboPosition.SelectedItem.ToString(),
                    Status = cboStatus.SelectedItem.ToString(),
                    TermStart = dtpkEndTerm.Value,
                    TermEnd = dtpkEndTerm.Value,
                    UserId = userId,
                    ElectionHistories = elect
                };
                Cursor = Cursors.WaitCursor;

                await Task.Run(async () =>
                {
                    await _SecretaryServices.AddBarangayOfficials(officialsInfo);

                });
                MessageBox.Show("Successfull Created Officials!");

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
    }


}
