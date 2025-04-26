using BrgyMs.backend.models.base_model;
using BrgyMs.backend.utils;
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

namespace BrgyMS.uiDesign.adminDashboard.modals {
    public partial class AdminModal : Form {
        private readonly Utils utils = new Utils();
        private bool status = true; // default true, beracuse acc is activated or verified
        
        public AdminModal() {
            InitializeComponent();
        }

        private void AdminModal_FormClosing(object sender, FormClosingEventArgs e) {
            var option = MessageBox.Show("Are you sure you want to close this?",
               "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (option == DialogResult.Yes) {
                utils.DeleteUserIdAfterCloseTheModal();
                return;
            }
            e.Cancel = true;

        }
    }
}
