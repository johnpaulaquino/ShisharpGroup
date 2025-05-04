using BrgyMs.backend;
using BrgyMs.backend.utils;
using BrgyMs.uiDesign;
using BrgyMS.docs_templates;

namespace BrgyMS {
    internal static class Program {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.


            Application.Run(new ReportViewer());


        }
    }
}