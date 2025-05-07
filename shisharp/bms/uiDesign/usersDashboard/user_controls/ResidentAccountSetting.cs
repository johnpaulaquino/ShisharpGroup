using BrgyMs.backend.database.repositories;
using BrgyMs.backend.models.base_model;
using BrgyMs.backend.services;
using BrgyMs.backend.utils;
using BrgyMS.backend.models;
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
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BrgyMS.uiDesign.usersDashboard.user_controls {
    public partial class ResidentAccountSetting : UserControl {
        private string userId = "";
        private Utils utils = new Utils();
        private AccountSettingsDataHolderController data;
        private ResidentServices _Services = new ResidentServices();
        public ResidentAccountSetting() {
            InitializeComponent();
            userId = utils.ReadIdInFile();


        }

        private void ResidentAccountSetting_Load_1(object sender, EventArgs e) {

            try {

                data = new AccountSettingsDataHolderController();

                // clear first
                pnlAsMainContentHolder.Controls.Clear();
                //then add
                pnlAsMainContentHolder.Controls.Add(data);
                //Dock
                data.Dock = DockStyle.Fill;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }

}

