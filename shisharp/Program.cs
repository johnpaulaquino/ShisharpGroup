using BrgyMs.backend.utils;
using BrgyMs.uiDesign;
using BrgyMS.docs_templates;
using BrgyMS.uiDesign.adminDashboard;
using BrgyMS.uiDesign.usersDashboard;
using DotNetEnv;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shisharp {
    internal static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            Application.Run(new AdminDashboardForm());
        }
    }
}
