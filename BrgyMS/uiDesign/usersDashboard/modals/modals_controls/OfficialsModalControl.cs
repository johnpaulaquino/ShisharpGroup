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
        private readonly UIAdminUtils uiadmin = new();
        private readonly Utils utils = new();
        private bool isActivted = false;
        private AdminAccountVerification accverifyControl = new();
        private bool isFirstTimeSeeker = false;
        private ResidentServices _ResidentServices = new();
        private SecretaryServices _SecretaryServices = new();
        private BaseServices _BaseServices = new();
        private UserInfoValidation validation = new();
        private List<string> listAccom = new List<string>();

        public OfficialsModalControl() {
            InitializeComponent();
            cboPosition.Items.Insert(0, "--Select--");
            cboPosition.SelectedItem = "--Select--";

            cboStatus.Items.Insert(0, "--Select--");
            cboStatus.SelectedItem = "--Select--";

            cboDateRange.Items.Insert(0, "--Select--");
            cboDateRange.SelectedItem = "--Select--";

            cboStatus.SelectedItem = "Active";
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


                String formattedStartDate = dtpkStartTerm.Value.Date.ToString("yyyy-mm-dd");
                String formattedEndtDate = dtpkEndTerm.Value.Date.ToString("yyyy-mm-dd");
                OfficialsInfo officialsInfo = new()
                {

                    Position = cboPosition.SelectedItem.ToString(),
                    Status = cboStatus.SelectedItem.ToString(),
                    UserId = userId,
                    ElectionHistories = new ElectionHistories()
                    {
                        TermStart = formattedStartDate,
                        TermEnd = formattedEndtDate
                    }
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
        } // 

        private void CLearFields() {
            cboPosition.SelectedItem = "--Select--";
            dtpkStartTerm.Value = DateTime.Now;
            dtpkEndTerm.Format = DateTimePickerFormat.Custom;
        }

        private void btnOfficialsSaveChanges_Click(object sender, EventArgs e) {

        }

        private void btnAddAchievement_Click(object sender, EventArgs e) {
            try {
                string accomplishment = txtAchievements.Text;
                if (string.IsNullOrEmpty(accomplishment)) {
                    listAccom.Add(accomplishment);
                    cboAchievements.Items.Add(accomplishment);
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboAchievements_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right) {
                if (cboAchievements.SelectedIndex == -1) {
                    ctxRemoveAchievements.Visible = false; // or skip opening
                }
                else {
                    ctxRemoveAchievements.Show(cboAchievements, e.Location);
                }
            }
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e) {
            var option = MessageBox.Show("Are you sure you want to remove this item?", "Achievement",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (option == DialogResult.Yes) {
                cboAchievements.SelectedIndex = -1;
            }
        }
    }


}
