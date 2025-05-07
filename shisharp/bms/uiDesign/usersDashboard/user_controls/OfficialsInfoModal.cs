using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shisharp.bms.uiDesign.usersDashboard.user_controls {
    public partial class OfficialsInfoModal : Form {
        public OfficialsInfoModal() {
            InitializeComponent();
        }

        private void OfficialsInfoModal_Load(object sender, EventArgs e) {
            OffcialsInformationControl control = new OffcialsInformationControl();
            pnlMainContainer.Controls.Clear();
            pnlMainContainer.Controls.Add(control);

            control.Dock = DockStyle.Fill; 

        }
    }
}
