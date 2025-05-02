using BrgyMs.backend.database.repositories;
using BrgyMs.backend.services;
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

namespace BrgyMS.uiDesign.adminDashboard.controls {
    public partial class AdminDashboardControl : UserControl {
        private UIAdminUtils uiadmin = new UIAdminUtils();
        private AdminServices _AdminServices = new();
        public AdminDashboardControl() {
            InitializeComponent();
        }

        private async void AdminDashboardControl_Load(object sender, EventArgs e) {

            var totalPopulation = await _AdminServices.GetTotalBlotterPopHouseholds();

            if (totalPopulation != null) {
                lblTotalPopulation.Text = totalPopulation[0];
                lblTotalBlotters.Text = totalPopulation[1];
                lblTotalUserRequest.Text = totalPopulation[2];
            }
            else {
                lblTotalPopulation.Text = "0";
                lblTotalBlotters.Text = "0";
                lblTotalUserRequest.Text = "0";
            }
        }

        private void kryptonPanel5_Paint(object sender, PaintEventArgs e) {

        }
    }
}
