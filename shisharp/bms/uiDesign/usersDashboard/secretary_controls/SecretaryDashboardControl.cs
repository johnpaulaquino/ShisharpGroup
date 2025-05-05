using BrgyMs.backend.database.repositories;
using BrgyMs.backend.services;
using BrgyMS.uiDesign.uiUtils.uiAdminUtils;
using shisharp.bms.backend.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BrgyMS.uiDesign.usersDashboard.secretary_controls {
    public partial class SecretaryDashboardControl : UserControl {
        private UIAdminUtils uiadmin = new UIAdminUtils();
        private AdminServices _AdminServices = new AdminServices();
        private ChartGenerator chartGend = new ChartGenerator();
        public SecretaryDashboardControl() {
            InitializeComponent();
        }

        private void AdminDashboardControl_Load(object sender, EventArgs e) {
            try {
                Invoke(new Action(async () =>
                {
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
                    await chartGend.GeneratePieChartForGenderDistribution(piechart);

                    await chartGend.GenerateCartesianPlainChartForTotalHouseHold(cartesianChart);

                    await chartGend.GenerateGaugeChartForTotalVoters(gaugeChart);
                }));

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

        }


    }
}
