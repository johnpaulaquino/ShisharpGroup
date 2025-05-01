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
        public AdminDashboardControl() {
            InitializeComponent();
        }

        private async void AdminDashboardControl_Load(object sender, EventArgs e) {

            await uiadmin.SetTotalsInLabels(lblTotalPopulation, lblTotalHouseholds, lblTotalBlotter);


        }


    }
}
