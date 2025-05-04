using BrgyMs.backend.database.repositories;
using BrgyMs.backend.models.base_model;
using BrgyMs.backend.models.bo_model;
using BrgyMs.backend.services;
using BrgyMs.backend.utils;
using BrgyMS.backend.models;
using BrgyMS.backend.services;
using BrgyMS.uiDesign.adminDashboard.modals;
using BrgyMS.uiDesign.adminDashboard.modals.modals_controls;
using Google.Protobuf.Compiler;
using Krypton.Toolkit;

using Mysqlx.Resultset;
using MySqlX.XDevAPI.Relational;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Org.BouncyCastle.Asn1.Cmp;
using Org.BouncyCastle.Bcpg.Sig;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Text;

using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BrgyMS.uiDesign.uiUtils.uiAdminUtils {
    class UIAdminUtils {
        private readonly AuthUtils _AuthUtils = new AuthUtils();
        private AdminServices _AdminServices = new AdminServices();
        private BaseServices _BaseServices = new BaseServices();
        private EmailServices _EmailServices = new EmailServices();
        private readonly AdminRepository _admin = new AdminRepository();
        private readonly Utils utils = new Utils();
        private SecretaryServices _SecreataryServices = new SecretaryServices();

        public UIAdminUtils() {


        }

        //for account management table
        public void SetWidthToAccountManagementTable(DataGridView dataGridView) {
            dataGridView.Columns[0].Width = 85;
            dataGridView.Columns[1].Width = 150;
            dataGridView.Columns[2].Width = 85;
            dataGridView.Columns[3].Width = 150;
            dataGridView.Columns[4].Width = 150;
            dataGridView.Columns[5].Width = 85;
            dataGridView.Columns[6].Width = 150;
            dataGridView.Columns[7].Width = 50;
            dataGridView.Columns[8].Width = 150;
        }



        //for main form
        public void SetUserLabel(KryptonLabel lblRole,
            KryptonLabel lblusername) {
            string token = _AuthUtils.ReadTokenInFile();
            var principal = _AuthUtils.ValidateToken(token);
            User user = _AuthUtils.ValidateToken(token);


            string role = utils.FormatRoles(user.Role);

            lblRole.Text = role;
            lblusername.Text = "Hi, " + user.Username;
        }
        public async Task SetInfoInAdminAccountTable(DataGridView table, int limit) {


            try {

                table.Update();
                table.Refresh();

                var userInfo = await Task.Run(async () =>
                {
                    return await _AdminServices.GetUserInformation(limit);
                });

                table.Columns.Clear();
                table.DataSource = userInfo;
                SetWidthToAccountManagementTable(table);


            }
            catch (Exception e) {
                MessageBox.Show(e.Message);
            }
            finally {

            }

        }

        //search records in User management
        public async Task SearchRecords(DataGridView table, int limit, string keyword) {

            try {

                table.Update();
                table.Refresh();

                var dt = new DataTable();
                using (var userIno = await Task.Run(() =>
                {
                    return _AdminServices.GetUserInformation(limit, keyword);
                })) {
                    userIno.Fill(dt);

                    table.Columns.Clear();

                    table.DataSource = dt;

                    SetWidthToAccountManagementTable(table);
                }




            }
            catch (System.Exception e) {
                MessageBox.Show(e.Message);
            }
            finally {

            }

        }// End 

        //for users logs table
        public void SetWidthToUsersLogsTable(DataGridView dataGridView) {
            dataGridView.Columns[0].Width = 50;
            dataGridView.Columns[1].Width = 50;
            dataGridView.Columns[2].Width = 150;
            dataGridView.Columns[3].Width = 90;
            dataGridView.Columns[4].Width = 100;
            dataGridView.Columns[5].Width = 100;
            dataGridView.Columns[6].Width = 250;
        }

        //users logs
        public async Task SetUserLogsToTable(DataGridView table, int limit) {
            try {

                table.Update();
                table.Refresh();
                var dt = new DataTable();
                using (var adapter = await Task.Run(() =>
                {
                    return _AdminServices.GetAllLogs(limit);
                })) {
                    adapter.Fill(dt);


                    table.Columns.Clear();

                    table.DataSource = dt;


                    SetWidthToUsersLogsTable(table);
                }




            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                System.Diagnostics.Debug.WriteLine(ex.StackTrace);
            }
            finally {

            }
        }
        //for users Account verification table
        public void SetWidthToAccVerificationtable(DataGridView dataGridView) {
            dataGridView.Columns[0].Width = 85;
            dataGridView.Columns[1].Width = 100;
            dataGridView.Columns[2].Width = 100;
            dataGridView.Columns[3].Width = 100;
            dataGridView.Columns[4].Width = 250;

        }
        public async Task SetInActiveUsersInTable(DataGridView table) {
            try {

                table.Update();
                table.Refresh();

                var dt = new DataTable();

                using (var adapter = await Task.Run(_AdminServices.GetInActiveResidentUser)) {
                    adapter.Fill(dt);


                    table.Columns.Clear();

                    table.DataSource = dt;


                    SetWidthToAccVerificationtable(table);
                }


            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                System.Diagnostics.Debug.WriteLine(ex.StackTrace);
            }
            finally {
            }
        } // end of function 


        //User information 
        public async Task SetUserInfoInuserInfromationModal(
            UserInformationModalControl userinfoControl,
            KryptonTextBox txtUserId,
            KryptonTextBox txtEmail,
            KryptonTextBox txtpassword,
            KryptonTextBox txtUsername
            ) {

            string UserIdInFile = utils.ReadIdInFile(); // Read  the user id that write in file after click the 
            // show information in Account management.


            // Get the user 
            try {
                List<User> user = await Task.Run(() =>
                {
                    return _AdminServices.GetUserBasicInfo(UserIdInFile);
                });


                userinfoControl.userModals = user;
                foreach (var item in user) {
                    txtUserId.Text = UserIdInFile;
                    txtEmail.Text = item.Email;
                    txtUsername.Text = item.Username;
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                System.Diagnostics.Debug.WriteLine(ex.StackTrace);
            }

        }// end of function


        //User Information Modal Control. It will use in the button which save changes
        public async Task UpdateAccountInfo(KryptonTextBox txtMUsername,
            KryptonTextBox txtEmail,
            KryptonTextBox txtPassword,
            KryptonCheckBox cbMStatus,
            KryptonCheckBox cbUSecretary,
            string userId,
            List<User> userModals) {


            string username = txtMUsername.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            string role = "users"; // in default role is users

            bool isActivated = true; // user is activated in default

            //if not checked then deactivate user
            if (!cbMStatus.Checked) {
                isActivated = false;
            }

            //check if the user modal is not null
            if (userModals != null) {
                // then check if the password in this control is empty
                if (string.IsNullOrEmpty(password)) {
                    //then no changes for password
                    foreach (var item in userModals) {
                        password = item.Password;
                    }
                }
            }

            //if secretary is checked then set role as secretary
            if (cbUSecretary.Checked) {
                role = "secretary";
            }

            // create the user
            var userModel = new User(
                email, username)
            { Password = password, Role = role, Status = isActivated };

            try {
                await _AdminServices.UpdateAccountInfo(userModel, userId); // Update info

                string Logsid = await _AdminServices.GenerateLogsId(); // id for logs

                string token = _AuthUtils.ReadTokenInFile(); // token, which credentials of the user who logged in

                var user = _AuthUtils.ValidateToken(token); // Decrypt generated token and get the data.

                await _admin.LogUserActions(new Logs( // log user Action
                    Logsid, user.UserId, "Update")
                { DatePerformed = DateTime.Now, Details = $"Update account info with the user id of {userId}." });

                MessageBox.Show("Successfully updated account info!");
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        } // End of the function


        //To activate the account 
        public async Task ActivateUserAccount(string userId,
            bool isValidated,
            string Emailrecipient,
            string Fullname,
            string Reason = "") {
            try {
                await _AdminServices.ActivateUserAccount(userId, isValidated, Emailrecipient);
                string message = "";
                string subject = "";
                if (!isValidated) {
                    subject = "Update on Your Account";
                    message = $"Dear {Fullname},\r\n\r\nThank you for your " +
                        $" interest in creating an account.\r\n\r\nAfter" +
                        $" careful review, we regret to inform you that your account " +
                        $"application has been declined at this time.\r\n\r\nDue to the {Reason}." +
                        $"\r\n\r\nWe appreciate your understanding and once again thank you so much. " +
                        $"Best regards,\nnBarangayShisharp";
                }
                else {
                    subject = "Update on Your Account";
                    message = $"Dear {Fullname},\r\n\r\nCongratulations! " +
                        $"Your account has been successfully created." +
                        $"You can now log in.\n" +
                        $"Best regards,\nBarangayShisharp";
                }
                await _EmailServices.SendPlainEmail(
                    Emailrecipient, subject, message);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        } // end of the function


        //set the data to the Account Verification control
        public async Task SetUserLabelToVerificationControl(
            KryptonPictureBox picprofilePic,
            KryptonTextBox txtFullname,
            KryptonTextBox txtEmail,
            KryptonTextBox txtFulAddress,
            KryptonTextBox txtBirthday,
            KryptonTextBox txtGender,
            KryptonTextBox txtAge,
            KryptonPictureBox picproofOfResidency
            ) {

            try {
                string userId = utils.ReadIdInFile(); // read the user id from file

                List<object> userInfo = await _AdminServices.GetAllUserInformations(userId); //retrieve the account informations

                //check if the list is not null, 
                if (userInfo != null) {
                    //then cast the objects
                    User user = (User)userInfo[0];
                    PersonalInformation pInfo = (PersonalInformation)userInfo[1];
                    AdditionalInfo addInfo = (AdditionalInfo)userInfo[2];
                    Address address = (Address)userInfo[3];

                    //format the fullname
                    string fullname = utils.FormatFullname(pInfo.Firstname, pInfo.Middlename,
                        pInfo.Lastname, pInfo.Suffix);

                    //format the bday
                    string bday = utils.FormatDate(addInfo.BirthDate);
                    int age = addInfo.Age; // get the age

                    // get the image in the additional info that can hold null 
                    byte[] profileImg = addInfo.ProfileImage;
                    byte[] proof = addInfo.ProofOfResidency;
                    string blk = address.BlockNumber; // blk number
                    string lotno = address.LotNo; // lot number
                    string subdivision = address.SubdivisionName; // subdivision name 

                    //format the address
                    String fulladdress = $"{address.HouseNumber}, {address.Street}," +
                        $" {(string.IsNullOrEmpty(blk) ? "" : blk + ", ")} " +
                        $"{(string.IsNullOrEmpty(lotno) ? "" : lotno + ", ")}" +
                        $"{(string.IsNullOrEmpty(subdivision) ? "" : subdivision)}";


                    //check if the images is not null, then set to the picture box
                    if (profileImg != null) {
                        using (MemoryStream memoryStream = new MemoryStream(profileImg)) {
                            picprofilePic.Image = new Bitmap(memoryStream);
                            memoryStream.Close();
                        }

                    }

                    if (proof != null) {
                        using (MemoryStream memoryStream = new MemoryStream(proof)) {
                            picproofOfResidency.Image = new Bitmap(memoryStream);
                        }

                    }

                    //set the data from the specified fields
                    txtFullname.Text = fullname;
                    txtFulAddress.Text = fulladdress;
                    txtBirthday.Text = bday;
                    txtAge.Text = age.ToString();
                    txtGender.Text = pInfo.Gender;
                    txtEmail.Text = user.Email;

                }

            }
            catch (Exception) {
                throw;
            }
        }// end of function

        public byte[] GetBytesFromPictureBox(KryptonPictureBox picture) {
            byte[] bytes = null;
            if (picture != null) {

                using (MemoryStream ms = new MemoryStream()) {
                    picture.Image.Save(ms, ImageFormat.Png);
                    bytes = ms.ToArray();
                }



            }
            return bytes;
        }// end


        // to get the offivials data in table
        public async Task SetOfficialsInTable(DataGridView table) {
            try {
                var dt = await Task.Run(async () =>
                {
                    return await _SecreataryServices.GetOFficialsInfo();
                });
                table.Columns.Clear();
                table.DataSource = dt;
            }
            catch (Exception) {
                throw;
            }

        } // end


        //set the officials info when the update context menu is clicked inbrangay officials tbale
        public async Task SetOfficialsDataInModal(KryptonTextBox txtAccom,
            KryptonTextBox txtAchievements, KryptonComboBox cboStatus,
            KryptonComboBox cboPosition,
            KryptonComboBox cboDateRange, KryptonComboBox cboAccom,
            KryptonComboBox cboAchievements) {
            try {
                ElectionHistories elect = null;
                List<string> achievemnt = new List<string>();
                List<string> accom = new List<string>();
                List<ElectionHistories> histories = new List<ElectionHistories>();
                string id = utils.ReadIdInFile();

                string json = "";
                cboAccom.Items.Clear();
                cboAchievements.Items.Clear();
                cboDateRange.Items.Clear();


                DataTable dt = await _SecreataryServices.GetOFficialsInfo(id);

                foreach (DataRow item in dt.Rows) {
                    elect = JsonConvert.DeserializeObject<ElectionHistories>((string)item["Histories"]); // dezerialize the object
                    json = (string)item["Histories"]; // get the json, so that can get all the achievements and acomm on that year
                    histories.Add(elect); // add the election history to the list
                    cboStatus.SelectedItem = (string)item["Status"];
                    cboPosition.SelectedItem = (string)item["Position"];
                    string startDate = elect.TermStart;
                    string endDate = elect.TermEnd;

                    string dateRange = $"{startDate} To {endDate}";

                    cboDateRange.Items.Add(dateRange);
                }// end of loop


                // get the date range  based on the cboDaterange selectedIndex
                string startDate1 = "";
                string enDate = "";
                if (cboDateRange.Items.Count != 0) {
                    cboDateRange.SelectedIndex = 0;
                    startDate1 = cboDateRange.SelectedItem.ToString().Split(' ')[0].ToString(); // get the start date
                    enDate = cboDateRange.SelectedItem.ToString().Split(' ')[1].ToString(); // get the start date


                }                // parse the json string
                var jsonArray = JArray.Parse(json);

                await Task.Run(() =>
                {
                    foreach (var item in jsonArray.Children<JObject>()) {
                        if (string.Equals((string)item["TermStart"], startDate1) &&
                            string.Equals((string)item["TermEnd"], enDate)) {

                            var achievemntlist = item["Achievements"] as JArray;
                            var acomlist = item["Accomplished"] as JArray;

                            if (achievemntlist != null) {
                                foreach (var accom1 in achievemntlist) {
                                    cboAchievements.Items.Add(accom1);
                                }
                            }

                        }
                    }
                });


            }
            catch (Exception) {
                throw;
            }
        }

    }
}
