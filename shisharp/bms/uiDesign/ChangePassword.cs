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
    public partial class ChangePassword : UserControl {
        public ChangePassword() {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e) {
            try {
                var option = MessageBox.Show("Are you you sure to your new password?", "Chage password",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (option == DialogResult.Yes) {

                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
