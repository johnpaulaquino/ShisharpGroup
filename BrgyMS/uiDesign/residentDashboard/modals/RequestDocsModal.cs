using BrgyMS.uiDesign.adminDashboard.modals.modals_controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrgyMS.uiDesign.residentDashboard.modals {
    public partial class RequestDocsModal : Form {
        public RequestDocsModal() {
            InitializeComponent();
        }

        private void RequestDocsModal_Load(object sender, EventArgs e) {
            RequestDocumentsModalCotntrol control = new();

            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(control);
            control.Dock = DockStyle.Fill;
        }
    }
}
