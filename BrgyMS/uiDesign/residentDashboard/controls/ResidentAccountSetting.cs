using BrgyMs.backend.utils;
using BrgyMS.uiDesign.adminDashboard.modals;
using BrgyMS.uiDesign.adminDashboard.modals.modals_controls;
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

namespace BrgyMS.uiDesign.residentDashboard.controls {
    public partial class ResidentAccountSetting : UserControl
    {
        private UIAdminUtils uiAdmin = new UIAdminUtils();
        private Utils utils = new Utils();
        private AdminModal modal = new AdminModal();
        public bool isUpdated = false;
        public ResidentAccountSetting()
        {
            InitializeComponent();

        }

        private void ResidentAccountSetting_Load(object sender, EventArgs e)
        {
            PersonalAccountInformationControl info = new();
            pnlAsControlHolder.Controls.Clear();
            pnlAsControlHolder.Controls.Add(info);
            info.Dock = DockStyle.Fill;
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {

        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {

        }
    }
}
