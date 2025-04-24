using BrgyMs.backend.database.repositories;
using BrgyMS.uiDesign.uiUtils.uiAdminUtils;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrgyMS.uiDesign {
    public partial class AdminForm : Form {
        private UIAdminUtils uiadmin = new UIAdminUtils();
        private bool isClicked = true;
        private int limit = 0;
        public AdminForm() {
            InitializeComponent();
            limit = ((int)nudLimit.Value);

        }

        private async void AdminForm_Load(object sender, EventArgs e) {
            uiadmin.setAdminDashboardTableWitdth(dataGridAdminDashboard);
            uiadmin.SetUserInformation(lblRole, lblUsername);

             uiadmin.SetUserAndSecInfo(dataGridAdminDashboard, limit, txtSearch.Text);

        }
        private async void nudLimit_ValueChanged(object sender, EventArgs e) {

            
             uiadmin.SetUserAndSecInfo(dataGridAdminDashboard, limit, txtSearch.Text);
        }

        private void txtSearch_Enter(object sender, EventArgs e) {
            if (string.Equals(txtSearch.Text, "Search")) {
                txtSearch.Text = "";
                txtSearch.ForeColor = System.Drawing.ColorTranslator.FromHtml("#21130d");
            }
        }

        private async void txtSearch_TextChanged(object sender, EventArgs e) {
            try {
                 uiadmin.SearchRecords(dataGridAdminDashboard, limit, txtSearch.Text.ToString());
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);

            }
        }

    }
}
