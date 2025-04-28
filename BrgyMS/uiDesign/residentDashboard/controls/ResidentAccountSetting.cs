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

namespace BrgyMS.uiDesign.residentDashboard.controls {
    public partial class ResidentAccountSetting : UserControl
    {
        string userId = "";
        private Utils utils = new Utils();
        public ResidentAccountSetting()
        {
            InitializeComponent();
            userId = utils.ReadUserIdInFile();


        }

        private void ResidentAccountSetting_Load(object sender, EventArgs e)
        {
          
            //to avoid invalid operation exception
            if (InvokeRequired)
            {
                //to not block the UI
                Invoke(new Action(() => {
                    //update the UI
                    AccountSettingsDataHolderController data = new();
                    pnlAsMainContentHolder.Controls.Clear();
                    pnlAsMainContentHolder.Controls.Add(data);
                }));
            }
        }
    }
}
