using BrgyMs.backend.database.repositories;
using BrgyMs.backend.models.base_model;
using BrgyMs.backend.services;
using BrgyMs.backend.utils;
using BrgyMS.backend.services;
using BrgyMS.uiDesign.adminDashboard.modals;
using BrgyMS.uiDesign.adminDashboard.modals.modals_controls;
using BrgyMS.uiDesign.uiUtils.uiAdminUtils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BrgyMS.uiDesign.usersDashboard.user_controls {
    public partial class ResidentAccountSetting : UserControl {
        private string userId = "";
        private Utils utils = new Utils();
        private AccountSettingsDataHolderController data;
        public ResidentAccountSetting() {
            InitializeComponent();
            userId = utils.ReadIdInFile();


        }

        private async void ResidentAccountSetting_Load(object sender, EventArgs e) {
            try {
                if (data == null) // check if the object is not null then create
                {
                    data = new();
                }


                // clear first
                pnlAsMainContentHolder.Controls.Clear();
                //then add
                pnlAsMainContentHolder.Controls.Add(data);
                //Dock
                data.Dock = DockStyle.Fill;
                await data.LoadContents();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }// end of the funtion


    }
}
