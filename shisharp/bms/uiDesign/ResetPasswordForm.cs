using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shisharp.bms.uiDesign {
    public partial class ResetPasswordForm : Form {
        public ResetPasswordForm() {
            InitializeComponent();
        }

        private void btnSPrevious_Click(object sender, EventArgs e) {

        }

        private void ResetPasswordForm_Load(object sender, EventArgs e) {
            EmailVerification control = new EmailVerification();

            pnlMainContent.Controls.Clear();
            pnlMainContent.Controls.Add(control);

            control.Dock = DockStyle.Fill;

        }
    }
}
