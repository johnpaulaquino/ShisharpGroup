using BrgyMs.backend.data_validation;
using BrgyMs.backend.models.base_model;
using BrgyMs.backend.utils;
using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrgyMs.uiDesign
{
    public partial class SignUpForm : Form
    {
        //This is the global variables
        private int pnlPage = 0;
        private int lblPgNumber = 1;
        private List<KryptonPanel> kryptonpanels = new List<KryptonPanel>();
        private List<KryptonLabel> pageNumberlabel = new List<KryptonLabel>();
        private readonly UserInfoValidation _UserValidation = new UserInfoValidation();
        private User _Users;
        private PersonalInformation _PersonalInfo;
        private AdditionalInfo _AddlInfo;
        private Address _Address;
        private List<object> modelStorage = new List<object>();
        private Utils utils = new Utils();
        private bool voterStatus = false;
        private byte[] bytesProofOfR = null;
        private byte[] bytesProfilePic = null;
        private string filePathProofOfR = "";
        private string filePathProfilePic = "";


        public SignUpForm()
        {
            InitializeComponent();

            //This is the method below in this program
            AfterInitComponent();


        }

        private void Personal_Info_Load(object sender, EventArgs e)
        {

        }

        private void btnSLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }

        private void cbSShowPass_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cbSShowPass.Checked)
            {
                cbSShowPass.Text = "Hide Password";
                txtSConfirmPass.PasswordChar = (char)0;
                txtSPassword.PasswordChar = (char)0;
            }
            else
            {
                cbSShowPass.Text = "Show Password";
                txtSConfirmPass.PasswordChar = '●';
                txtSPassword.PasswordChar = '●';
            }
        }

        private async void btnSNext_Click(object sender, EventArgs e)
        {
            try
            {
                //Data from 1st page
                string email = txtSEmail.Text.ToString();
                string password = txtSPassword.Text.ToString();
                string confirmEmail = txtSConfirmEmail.Text.ToString();
                string confirmPassword = txtSConfirmPass.Text.ToString();
                _Users = new User(email, password);

                //Data from 2nd page
                string firstname = txtSFName.Text.ToString();
                string middlename = txtSMName.Text.ToString();
                string lastname = txtSLastname.Text.ToString();
                string suffix = cboSSuffix.SelectedItem.ToString();
                string gender = cboSGender.SelectedItem.ToString();



                // Data from 3rd and 4th page 
                if (cbAVoterStatus.Checked)
                {
                    voterStatus = true;
                }

                string civilStatus = cboACivilStatus.SelectedItem.ToString();
                string educationalStatus = cboAEducAttain.SelectedItem.ToString();
                string empStatus = cboEmpStatus.SelectedItem.ToString();
                string religion = txtAReligion.Text.ToString();
                DateTime bday = dtpkABirthday.Value.Date;
                int age = utils.calculateAge(bday);
                string contactNo = txtAContactNo.Text.ToString();

                //check if the filepath of the proof of residency
                if (!string.IsNullOrEmpty(filePathProofOfR))
                {
                    //Read the selected image
                    using (var fileStream = new FileStream(filePathProofOfR, FileMode.Open, FileAccess.Read))
                    {
                        //set the bytes on the bytesProofOfR variable
                        bytesProofOfR = new byte[fileStream.Length];
                        await fileStream.ReadExactlyAsync(bytesProofOfR);
                    }
                }


                //check if the filepath of the profile image
                if (!string.IsNullOrEmpty(filePathProofOfR))
                {
                    //Read the selected image
                    using (var fileStream = new FileStream(filePathProfilePic, FileMode.Open, FileAccess.Read))
                    {
                        //set the bytes on the bytesProofOfR variable
                        bytesProfilePic = new byte[fileStream.Length];
                        await fileStream.ReadExactlyAsync(bytesProfilePic);
                    }
                }

                // This is the 5th page for address

                string houseNo = txtSHouseNo.Text;
                string street = txtSStreet.Text;
                string villagename = txtSSubdivision.Text;
                string lotNo = txtSLotNo.Text;
                string blockNo = txtSBlockNo.Text;
                string purok = txtSpurok.Text;


                // personal info
                _PersonalInfo = new PersonalInformation(firstname, middlename, lastname, gender)
                { Suffix = suffix };
               
                // additional info
                _AddlInfo = new AdditionalInfo(
                    voterStatus,
                    bday,
                    empStatus,
                    educationalStatus,
                    civilStatus,
                    contactNo,
                    religion,
                    bytesProofOfR
                    )
                { ProfileImage = bytesProfilePic};

                _Address = new Address(
                    street,
                    houseNo)
                { SubdivisionName = villagename ,
                LotNo = lotNo,
                BlockNumber = blockNo,
                Purok = purok};


                //set empty strings to the not required fields if not set.
                _UserValidation.SetEmptyStringThatCanAcceptNull(_PersonalInfo);


                //validate per page
                switch (pnlPage)
                {
                    case 0:
                        _UserValidation.ValidateUser(_Users, confirmEmail, confirmPassword);
                        // validate first the field before go to another page.
                        break;
                    case 1:
                        _UserValidation.ValidatePersonalInfo(_PersonalInfo);
                       
                        break;

                    case 3:
                        _UserValidation.ValidateAddInfo(_AddlInfo);
                        _UserValidation.ValidateFileType(filePathProofOfR);
                        if (!string.IsNullOrEmpty(filePathProfilePic))
                        {
                            _UserValidation.ValidateFileType(filePathProfilePic);
                        }
                        break;
                  
                }

                //increment the index for accessing the list
                lblPgNumber++;
                pnlPage++;

                //check wether the page is less than or equal to the number of pages
                if (pnlPage <= kryptonpanels.Count - 1)
                {
                    //then set visible the button prev
                    btnSPrevious.Visible = true;

                    //bring front the panel to make it show
                    kryptonpanels[pnlPage].BringToFront();

                    // set the current page of the user filling up
                    pageNumberlabel[pnlPage].Text = $"{lblPgNumber} out of {kryptonpanels.Count}";
                }


                //always chceck if the number of page is exceeding the limit, so we will show the submit button.
                if (pnlPage == kryptonpanels.Count - 1)
                {
                    btnSCreateAccount.BringToFront();

                }
                //then add the object, so that we can access this in the submit button
                modelStorage.Add(_Users);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnSPrevious_Click(object sender, EventArgs e)
        {
            pnlPage--;
            lblPgNumber -= 1;
            Console.WriteLine(pnlPage);
            if (pnlPage >= 0)
            {
                kryptonpanels[pnlPage].BringToFront();
                pageNumberlabel[pnlPage].Text = $"{lblPgNumber} out of {kryptonpanels.Count}";
            }
            if (pnlPage == 0)
            {
                btnSPrevious.Visible = false;
            }

            btnSNext.BringToFront();
        }

        public void AfterInitComponent()
        {
            //set the first option in the combo box suffix and gender
            cboSSuffix.Items.Insert(0, "--Select--");
            cboSSuffix.SelectedItem = "--Select--";

            cboSGender.Items.Insert(0, "--Select--");
            cboSGender.SelectedItem = "--Select--";

            cboACivilStatus.Items.Insert(0, "--Select--");
            cboACivilStatus.SelectedItem = "--Select--";

            cboAEducAttain.Items.Insert(0, "--Select--");
            cboAEducAttain.SelectedItem = "--Select--";

            cboEmpStatus.Items.Insert(0, "--Select--");
            cboEmpStatus.SelectedItem = "--Select--";

            //This is the panel
            kryptonpanels.Add(pnlSLogCredentials);
            kryptonpanels.Add(pnlSPinfo1);
            kryptonpanels.Add(pnlSAddInfo1);
            kryptonpanels.Add(pnlSAddInfo2);
            kryptonpanels.Add(pnlSAddress);
            kryptonpanels.Add(pnlSAddress2);

            //This is the panel page number
            pageNumberlabel.Add(lblpageNumber1);
            pageNumberlabel.Add(lblpageNumber2);
            pageNumberlabel.Add(lblpageNumber3);
            pageNumberlabel.Add(lblpageNumber4);
            pageNumberlabel.Add(lblPageNumber5);
            pageNumberlabel.Add(lblPageNumber6);

            //set enable to false these textfield if not living in village 
            txtSSubdivision.Enabled = false;
            txtSLotNo.Enabled = false;
            txtSBlockNo.Enabled = false;

            pageNumberlabel[pnlPage].Text = $"{lblPgNumber} out of { kryptonpanels.Count}";

        }

        private void btnAProofOfresidency_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                filePathProofOfR = fileDialog.FileName;
                txtAPoRFilePath.Text = filePathProofOfR;
            }
      
        }

        private void cbIsLiveInSubdivision_CheckedChanged(object sender, EventArgs e)
        {
            if (cbIsLiveInSubdivision.Checked)
            {
                txtSSubdivision.Enabled = true;
                txtSLotNo.Enabled = true;
                txtSBlockNo.Enabled = true;
            }
            else{
                txtSSubdivision.Enabled = false;
                txtSLotNo.Enabled = false;
                txtSBlockNo.Enabled = false;
            }
        }
    }

}
