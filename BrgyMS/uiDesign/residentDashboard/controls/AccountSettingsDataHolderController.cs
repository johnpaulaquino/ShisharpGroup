using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BrgyMS.backend.services;
using BrgyMs.backend.utils;
using BrgyMS.uiDesign.uiUtils.uiAdminUtils;
using BrgyMs.backend.models.base_model;

namespace BrgyMS.uiDesign.residentDashboard.controls
{
    public partial class AccountSettingsDataHolderController : UserControl
    {
  
      
        private BaseServices _BaseServices = new();
        private AuthUtils _AuthUtils = new();
        private Utils _Utils = new();
        private string userId;
        public AccountSettingsDataHolderController()
        {

            InitializeComponent();
            userId = _Utils.ReadUserIdInFile();
        }

        private async Task AccountSettingsDataHolderController_Load(object sender, EventArgs e)
        {
         
            List<object> userInfo = await _BaseServices.GetAllUserInformations(userId);
            if (userInfo != null)
            {
                // cast the object into specific type
                PersonalInformation pInfo = (PersonalInformation)userInfo[1]; 
                AdditionalInfo addInfo = (AdditionalInfo)userInfo[2];
                Address address = (Address)userInfo[2];
            }
            //It will cehck if you are in the UI thread and always check first to avoid InvalidOperationException.
            if (InvokeRequired)
            {
                Invoke(new Action(() =>
                {
                   
                }));
            }
        }
    }
}
