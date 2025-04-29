
using BrgyMS.uiDesign;
using BrgyMS.uiDesign.adminDashboard;
using BrgyMS.uiDesign.adminDashboard.controls;
using BrgyMS.uiDesign.residentDashboard;
using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrgyMs.uiDesign.IndexUtils {
    class UILoginUtils {

        public UILoginUtils() {

        }
        public void Homepage(Form form, string Status) {
            ResidentPageForm homepage = new();

            if (string.Equals(Status, "admin")) {
                form.Hide();
                AdminDashboardForm admin = new AdminDashboardForm();
                admin.Owner = form;
                admin.Show();
            }else if (string.Equals(Status, "secretary")) {
                form.Hide();
                homepage.Owner = form;
                homepage.Show();

            }
            else {
                form.Hide();
                homepage.Owner = form;
                homepage.Show();
            }
        }
    }

}





