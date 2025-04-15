using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrgyMs.uiDesign
{
    public partial class PersonalInfo : Form
    {
        private int pnlPage = 0;
        private List<KryptonPanel> kryptonpanels = new List<KryptonPanel>();
        public PersonalInfo()
        {
            InitializeComponent();
            kryptonpanels.Add(pnlSLogCredentials);
            kryptonpanels.Add(pnlPersonalInformation);
            

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
            pnlPage++;

            if (pnlPage <= kryptonpanels.Count - 1)
            {
                btnSPrevious.Visible = true;
                kryptonpanels[pnlPage].BringToFront();
            }
           
            if (pnlPage == kryptonpanels.Count - 1)
            {
                btnSCreateAccount.BringToFront();
            }
        }

        private void btnSPrevious_Click(object sender, EventArgs e)
        {
            pnlPage--;
            Console.WriteLine(pnlPage);
            if (pnlPage >= 0)
            {
                kryptonpanels[pnlPage].BringToFront();
            }
            else
            {
                btnSPrevious.Visible = false;
            }
            btnSNext.BringToFront();
        }
    }
}
