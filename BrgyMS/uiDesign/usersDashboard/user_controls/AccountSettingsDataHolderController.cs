using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BrgyMS.backend.services;
using BrgyMs.backend.utils;
using BrgyMS.uiDesign.uiUtils.uiAdminUtils;
using BrgyMs.backend.models.base_model;
using System.Runtime.InteropServices;
using BrgyMS.uiDesign.uiUtils.ui_residents_utils;
using BrgyMs.backend.data_validation;
using MySqlX.XDevAPI.Common;
using BrgyMS.backend.models;

namespace BrgyMS.uiDesign.usersDashboard.user_controls {
    public partial class AccountSettingsDataHolderController : UserControl {


        private BaseServices _BaseServices;
        private AuthUtils _AuthUtils = new();
        private Utils _Utils = new();
        private string userId;
        private PersonalInformation personalInfo;
        private AdditionalInfo additionalInfo;
        private Address addressInfo;
        private UIResidentUtils uiResident = new();
        string filePathProofOfR = "";
        private UserInfoValidation validation = new();
        public AccountSettingsDataHolderController() {

            InitializeComponent();


            cboAsCivilStatus.SelectedItem = "--Select--";
            cboAsEducAttain.SelectedItem = "--Select--";
            cboAsEmploymentStatus.SelectedItem = "--Select--";
            cboAsGender.SelectedItem = "--Select--";
            cboAsResidentType.SelectedItem = "--Select--";
            cboAsSuffix.SelectedItem = "--Select--";


        }



        public async Task LoadContents() {
            try {
                userId = _Utils.ReadUserIdInFile();
                _BaseServices = new BaseServices();

                Cursor = Cursors.WaitCursor;
                List<object> userInfo = await Task.Run(() =>
                {
                    return _BaseServices.GetAllUserInformations(userId);
                });

                Cursor = Cursors.Default;

                // Make a thread
                Invoke(new Action(() =>
                {
                    if (userInfo != null) {

                        // cast the object into specific type
                        PersonalInformation pInfo = (PersonalInformation)userInfo[1];
                        AdditionalInfo addInfo = (AdditionalInfo)userInfo[2];
                        Address address = (Address)userInfo[3];

                        //personal info
                        txtAsFname.Text = pInfo.Firstname;
                        txtAsMname.Text = pInfo.Middlename;
                        txtAsLname.Text = pInfo.Lastname;
                        cboAsSuffix.SelectedItem = pInfo.Suffix;
                        cboAsGender.SelectedItem = pInfo.Gender;

                        //Additional Info
                        dtpkAsBday.SetDate(addInfo.BirthDate);
                        txtAsAge.Text = addInfo.Age.ToString();
                        txtAsContactNo.Text = addInfo.ContactNo;
                        txtAsReligion.Text = addInfo.Religion;
                        cboAsCivilStatus.SelectedItem = addInfo.CivilStatus;
                        cboAsEducAttain.SelectedItem = addInfo.EducAttain;
                        cboAsEmploymentStatus.SelectedItem = addInfo.EmpStatus;
                        cboAsResidentType.SelectedItem = addInfo.ResidentType;

                        if (addInfo.IsVoter) {
                            cbVoterStatus.Checked = true;
                        }

                        Task.Run(() =>
                        {
                            if (addInfo.ProfileImage != null) {
                                using MemoryStream mStream = new MemoryStream(addInfo.ProfileImage);
                                picAsProfilePicture.Image = new Bitmap(mStream);
                                // set the profile picture

                            }
                        });

                        //Address
                        txtAsHouseNo.Text = address.HouseNumber;
                        txtAsStreet.Text = address.Street;
                        txtAsSubdivision.Text = address.SubdivisionName;
                        txtAsLotNo.Text = address.LotNo;
                        txtAsBlockNo.Text = address.BlockNumber;
                    }

                }));

            }
            catch (Exception) {
                throw;
            }
        }

        private async void kryptonButton1_Click(object sender, EventArgs e) {
            // for personal information
            _BaseServices = new();
            userId = _Utils.ReadUserIdInFile();
            try {
                Cursor = Cursors.WaitCursor;
                //    Invoke(new Action(() =>
                //{

                personalInfo = new PersonalInformation(
                  txtAsFname.Text,
                  txtAsMname.Text,
                  txtAsLname.Text,
                  cboAsGender.SelectedItem.ToString()
                   )
                { Suffix = cboAsSuffix.SelectedItem.ToString(), };


                //for additional information
                bool isVoter = false;

                if (cbVoterStatus.Checked) {
                    isVoter = true;
                }


                byte[] profileImage = uiResident.GetBytesFromPictureBox(picAsProfilePicture);

                MessageBox.Show("S profile image is null?" + (profileImage == null));
                additionalInfo = new AdditionalInfo(isVoter,
                    dtpkAsBday.Value.Date,
                    cboAsEmploymentStatus.SelectedItem.ToString(),
                    cboAsEducAttain.SelectedItem.ToString(),
                    cboAsCivilStatus.SelectedItem.ToString(),
                    cboAsResidentType.SelectedItem.ToString(),
                    txtAsContactNo.Text,
                    txtAsReligion.Text)
                { ProfileImage = profileImage };

                //for address

                addressInfo = new(
                    txtAsStreet.Text,
                    txtAsHouseNo.Text
                    )
                {
                    SubdivisionName = txtAsSubdivision.Text,
                    BlockNumber = txtAsBlockNo.Text,
                    LotNo = txtAsLotNo.Text
                };


                //validate fields first
                validation.ValidatePersonalInfo(personalInfo);
                validation.ValidateAddInfoForUpdate(additionalInfo);
                validation.ValidateAddress(addressInfo);



                //}));


                //set empty that can have a null values
                validation.SetEmptyStringThatCanAcceptNullForPInfo(personalInfo);
                validation.SetEmptyStringThatCanAcceptNullForAddress(addressInfo);

                var option = MessageBox.Show("Are you sure you want to update?",
                    "Personal Information", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (option == DialogResult.Yes) {


                    await Task.Run(async () =>
                    {

                        await _BaseServices.UpdateUserInformations(userId,
                            personalInfo, additionalInfo, addressInfo);// update if no error
                        string id = await _BaseServices.GenerateLogsId();

                        Logs logs = new Logs(id, userId, "Update",
                            DateTime.Now, "Update Own Information."
                            );
                        await _BaseServices.LogUserActions(logs);
                    });
                }


                MessageBox.Show("Successfully updated information!");


            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
            finally {
                Cursor = Cursors.Default;
            }
        }// end of function



        private void btnAsUpload_Click(object sender, EventArgs e) {
            try {
                OpenFileDialog fileDialog = new OpenFileDialog();
                if (fileDialog.ShowDialog() == DialogResult.OK) {

                    validation.ValidateFileType(fileDialog.FileName); // the image file extension, if it is valid
                                                                      // 
                    filePathProofOfR = fileDialog.FileName;

                    picAsProfilePicture.Image = new Bitmap(filePathProofOfR);
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
