using BrgyMs.backend.database.repositories;
using BrgyMs.backend.utils;
using BrgyMs.uiDesign;
using BrgyMS.uiDesign.residentDashboard.controls;
using BrgyMS.uiDesign.uiUtils.uiAdminUtils;
using Google.Protobuf.Reflection;
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


namespace BrgyMS.uiDesign.residentDashboard {
    public partial class ResidentPageForm : Form {
        private UIAdminUtils uiadmin = new UIAdminUtils();
        private AuthUtils _AuthUtils = new AuthUtils();

        public ResidentPageForm() {
            InitializeComponent();


        }

        private void picAccountManagement_Click(object sender, EventArgs e) {
            ResidentAccountSetting accountcontrol = new ResidentAccountSetting();
            pnlMainContentHolder1.Controls.Clear();
            pnlMainContentHolder1.Controls.Add(accountcontrol);
            accountcontrol.Dock = DockStyle.Fill;
        }


    }
}
