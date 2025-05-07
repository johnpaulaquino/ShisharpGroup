using BrgyMs.backend.database.repositories;
using BrgyMs.backend.services;
using BrgyMs.backend.utils;
using BrgyMS.uiDesign.usersDashboard.modals;
using BrgyMS.uiDesign.uiUtils.ui_residents_utils;
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
using BrgyMS.backend.utils;
using BrgyMS.backend.services;
using BrgyMs.backend.models.base_model;
using System.IO;
using BrgyMS.backend.models;
using Microsoft.VisualBasic;

namespace BrgyMS.uiDesign.usersDashboard.secretary_controls {
    public partial class SecretaryApprovalDocumentsControls : UserControl {
        private UIResidentUtils uioResident = new UIResidentUtils();
        private SecretaryServices _SecServices = new SecretaryServices();
        private EmailServices _EmailServices = new EmailServices();
        private DocumentsGenerator _DocsGenerator = new DocumentsGenerator();
        private BaseServices _BaseServices = new BaseServices();
        private Utils utils = new Utils();
        private AuthUtils _AuthUtils = new AuthUtils();
        private string cachedUserid = "";
        public SecretaryApprovalDocumentsControls() {
            InitializeComponent();
            string token = _AuthUtils.ReadTokenInFile(); // r ead token for user id
            var cachedId = _AuthUtils.ValidateToken(token); // get the user credentials
            cachedUserid = cachedId.UserId;
        }

        private async void approveDocumentsToolStripMenuItem_Click(object sender, EventArgs e) {
            try {

                string doctype = utils.ReadDocumentTypeInFile();

                var option = MessageBox.Show("Are you sure you want to approve this? ",
                    "Approval", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (option == DialogResult.Yes) {
                    Cursor = Cursors.WaitCursor;
                    MessageBox.Show(doctype);
                    //for barangay idigency
                    if (string.Equals("Barangay Certificate of Indigency", doctype)) {
                        await Task.Run(async () =>
                        {
                            string userid = utils.ReadIdInFile(); // get the id from file
                            var list = await _BaseServices.GetAllUserInformations(userid); //  get all user information
                                                                                           //  
                            _DocsGenerator.GenerateIndigencyDocument(userid); // generate indigency document


                            string fileLoc = _DocsGenerator.GetIndigencyLocation(); // get all users


                            if (list != null) {
                                var user = (User)list[0]; // get the account credentials
                                var personalInfo = (PersonalInformation)list[1]; //

                                if (File.Exists(fileLoc)) { // check if the file is exist

                                    await _EmailServices.SendEmailWithAttachment( // send email
                               user.Email, doctype, "Here is your requested document.\nThank you.",
                               fileLoc, $"{personalInfo.Firstname[0].ToString()}. {personalInfo.Lastname} {doctype}");


                                    string id = await _BaseServices.GenerateLogsId(); // generate Id for logs
                                    string token = _AuthUtils.ReadTokenInFile(); // r ead token for user id
                                    var cachedId = _AuthUtils.ValidateToken(token); // get the user credentials


                                    Logs logs = new Logs(id, cachedId.UserId, // logs
                                        "Update")
                                    {
                                        DatePerformed = DateTime.Now,
                                        ActionsMade = "Approve resident document."
                                    };
                                    await _BaseServices.LogUserActions(logs);// insert into logs
                                    await _SecServices.UpdateResidentDocument(userid);
                                }
                                else {
                                    throw new Exception("File not found!");
                                }

                            }
                        });
                    }
                    //for barangay clearance
                    else {
                        await Task.Run(async () =>
                        {
                            string userid = utils.ReadIdInFile(); // get the id from file
                            var list = await _BaseServices.GetAllUserInformations(userid); //  get all user information
                                                                                           //  
                            _DocsGenerator.GenerateFirstTimeJobSeekerDocument(userid); // generate barangay cloerance document


                            string fileLoc = _DocsGenerator.GetFirstTimeJobSeekerocation(); // get all users


                            if (list != null) {
                                var user = (User)list[0]; // get the account credentials
                                var personalInfo = (PersonalInformation)list[1]; //

                                if (File.Exists(fileLoc)) { // check if the file is exist

                                    await _EmailServices.SendEmailWithAttachment( // send email
                               user.Email, doctype, "Here is your requested document.\nThank you.",
                               fileLoc, $"{personalInfo.Firstname[0].ToString()}. {personalInfo.Lastname} {doctype}");


                                    string id = await _BaseServices.GenerateLogsId(); // generate Id for logs
                                    string token = _AuthUtils.ReadTokenInFile(); // r ead token for user id
                                    var cachedId = _AuthUtils.ValidateToken(token); // get the user credentials


                                    Logs logs = new Logs(id, cachedId.UserId, // logs
                                        "Update")
                                    {
                                        DatePerformed = DateTime.Now,
                                        ActionsMade = "Approve resident document."
                                    };
                                    await _BaseServices.LogUserActions(logs);// insert into logs
                                    await _SecServices.UpdateResidentDocument(userid);
                                }
                                else {
                                    throw new Exception("File not found!");
                                }

                            }

                        });
                    }

                    MessageBox.Show("Successfully approve docuemnt!");

                    await _SecServices.SetDataForApproveDocumentsTable(dataGridApproveDocument);
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

            finally {
                Cursor = Cursors.Default;
            }

        }

        private void SecretaryApprovalDocumentsControls_Load_1(object sender, EventArgs e) {
            try {
                if (_SecServices == null) {
                    _SecServices = new SecretaryServices();
                }

                Invoke(new Action(async () =>
                {

                    await _SecServices.SetDataForApproveDocumentsTable(dataGridApproveDocument);
                }));

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridApproveDocument_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right) {
                var hit = dataGridApproveDocument.HitTest(e.X, e.Y); // get the location where clicked
                if (hit.RowIndex >= 0) {


                    dataGridApproveDocument.ClearSelection();
                    dataGridApproveDocument.Rows[hit.RowIndex].Selected = true; // set selection where the mouse clicked

                    string userId = dataGridApproveDocument.Rows[hit.RowIndex].Cells[0].Value?.ToString();
                    string docType = dataGridApproveDocument.Rows[hit.RowIndex].Cells[2].Value?.ToString();
                    try {
                        utils.PutIdOnFile(userId);
                        utils.PutDocumetntTypeInFile(docType);


                        //show the context
                        ctxApproveDocuments.Show(dataGridApproveDocument, e.Location);
                    }
                    catch (Exception ex) {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private async void delineRequestToolStripMenuItem_Click(object sender, EventArgs e) {
            try {
                var option = MessageBox.Show("Are you sure you want to decline this?");
                if (option == DialogResult.Yes) {
                    Cursor = Cursors.WaitCursor;
                    await Task.Run(async () =>
                    {
                        MessageBox.Show("HEy");
                        string userid = utils.ReadIdInFile(); // read the user id of the resident
                        var list = await _BaseServices.GetAllUserInformations(userid); // get the user information of the resident who requested docs

                        if (list != null) {
                            var user = (User)list[0]; // get the account credentials
                            var personalInfo = (PersonalInformation)list[1]; //
                            string doctype = utils.ReadDocumentTypeInFile();
                            await _EmailServices.SendPlainEmail(user.Email, $"{doctype}", $"Your {doctype} has been delcined.\n" +
                                $"Thank you for your understanding.");
                        }

                        await _SecServices.DeleteRequestDocument(userid); // delete the request docs

                        string id = await _BaseServices.GenerateLogsId(); // generate Id for logs


                        Logs logs = new Logs(id, cachedUserid, // logs
                            "Update")
                        {
                            DatePerformed = DateTime.Now,
                            ActionsMade = "Approve resident document."
                        };
                        await _BaseServices.LogUserActions(logs);// insert into logs
                        await _SecServices.UpdateResidentDocument(userid);


                    });

                    MessageBox.Show("Successfully declined request!");

                    await _SecServices.SetDataForApproveDocumentsTable(dataGridApproveDocument); // refresh table

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
