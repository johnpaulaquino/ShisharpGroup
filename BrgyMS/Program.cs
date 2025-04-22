using BrgyMs.backend;
using BrgyMs.backend.utils;
using BrgyMs.uiDesign;

namespace BrgyMS
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            
            ApplicationConfiguration.Initialize();
            System.Diagnostics.Debug.WriteLine(Guid.NewGuid().ToString()+ Guid.NewGuid().ToString());
            Application.Run(new LoginForm());
            
           
        }
    }
}