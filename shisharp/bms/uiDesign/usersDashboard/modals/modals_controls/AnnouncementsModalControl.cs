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
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrgyMS.uiDesign.usersDashboard.modals {
    public partial class AnnouncementsModalControl : UserControl {
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
        AnnouncementsModel announcementMOdel = null;

        private byte[] attachmentsByte = null;
        private String attachmentFilePath = "";


        public AnnouncementsModalControl() {
            InitializeComponent();

        }


        public void ClearFieldsAfterAdd() {
            txtTitle.Text = "";
            txtStatements.Text = "";
            picAttachment.Image = null;

        }


        private void btnUplaodAnnouncement_Click_1(object sender, EventArgs e) {
            try {
                OpenFileDialog fileDialog = new OpenFileDialog();
                if (fileDialog.ShowDialog() == DialogResult.OK) {
                    attachmentFilePath = fileDialog.FileName;
                    picAttachment.Image = new Bitmap(attachmentFilePath);
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private async void btnUpdateAnnouncements_Click_1(object sender, EventArgs e) {
            try {

                string announceId = utils.ReadIdInFile();
                byte[] attachmentImg = uiadmin.GetBytesFromPictureBox(picAttachment);

                bool stat = false;

                AnnouncementsModel announce = new AnnouncementsModel()
                {
                    Attachments = attachmentImg,
                    Details = txtStatements.Text,
                    Status = stat,
                    Title = txtTitle.Text
                };

                if (cbHidePost.Checked) {
                    stat = true;
                }
                announce.Status = stat;


                await Task.Run(async () =>
                {
                    await _AdminServices.UpdateAnnouncements(announce, announceId);
                });

                MessageBox.Show("Susccessfully Updated Anouncement!");

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private async void btnSubmitAnnouncements_Click(object sender, EventArgs e) {
            try {
                string announcementId = utils.ReadIdInFile();

                if (!string.IsNullOrEmpty(attachmentFilePath)) {
                    using (var fs = new FileStream(attachmentFilePath, FileMode.Open, FileAccess.Read)) {
                        attachmentsByte = new byte[fs.Length];

                    }

                    AnnouncementsModel announce = new AnnouncementsModel()
                    {
                        Attachments = attachmentsByte,
                        DatePost = DateTime.Now,
                        Details = txtStatements.Text,
                        Title = txtTitle.Text

                    };

                    Cursor = Cursors.WaitCursor;
                    await Task.Run(async () =>
                    {
                        await _SecretaryServices.CreateAnnouncemrnts(announce);
                    });

                    MessageBox.Show("Successfully Created Annoucemnets!");
                    ClearFieldsAfterAdd();
                }
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
