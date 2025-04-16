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
        private List<object> modelStorage = new List<object>();
        private Utils utils = new Utils();
        private bool voterStatus = false;
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

        private void btnSNext_Click(object sender, EventArgs e)
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

                // Data from 3rd page
                if (cbAVoterStatus.Checked)
                {
                    voterStatus = true;
                }
                string civilStatus = cboACivilStatus.SelectedItem.ToString();
                string educationalStatus = cboAEducAttain.SelectedItem.ToString();
                string religion = txtAReligion.Text.ToString();
                DateTime bday = dtpkABirthday.Value.Date;
                int age = utils.calculateAge(bday);
                string contactNo = txtAContactNo.Text.ToString();

                //Data from 4th page



                _PersonalInfo = new PersonalInformation(firstname, middlename, lastname, gender)
                { Suffix = suffix };


                _UserValidation.SetEmptyStringThatCanAcceptNull(_PersonalInfo);

                switch (pnlPage)
                {
                    case 0:
                        _UserValidation.ValidateUser(_Users, confirmEmail, confirmPassword);
                        // validate first the field before go to another page.
                        break;
                    case 1:
                        _UserValidation.ValidatePersonalInfo(_PersonalInfo);
                        break;

                }

                lblPgNumber++;
                pnlPage++;

                if (pnlPage <= kryptonpanels.Count - 1)
                {
                    btnSPrevious.Visible = true;
                    kryptonpanels[pnlPage].BringToFront();
                    pageNumberlabel[pnlPage].Text = $"{lblPgNumber} out of 7";
                }

                if (pnlPage == kryptonpanels.Count - 1)
                {
                    btnSCreateAccount.BringToFront();

                }
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
                pageNumberlabel[pnlPage].Text = $"{lblPgNumber} out of 7";
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

            //This is the panel
            kryptonpanels.Add(pnlSLogCredentials);
            kryptonpanels.Add(pnlSPinfo1);
            kryptonpanels.Add(pnlSAddInfo1);
            kryptonpanels.Add(pnlSAddInfo2);

            //This is the panel page number
            pageNumberlabel.Add(lblpageNumber1);
            pageNumberlabel.Add(lblpageNumber2);
            pageNumberlabel.Add(lblpageNumber3);
            pageNumberlabel.Add(lblpageNumber4);
        }

        private void btnAProofOfresidency_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                filePathProofOfR = fileDialog.FileName;
                txtAPoRFilePath.Text = filePathProofOfR;
            }
            MessageBox.Show(filePathProofOfR);
        }
    }

}
