
using Stimulsoft.Report;
using Stimulsoft.Report.Components;
using Stimulsoft.Report.Dictionary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Stimulsoft.Report.StiOptions.Export;


namespace BrgyMS.docs_templates {
    public partial class Viewer : Form {
        private PrintPreviewControl previewControl;
        private Button btnGenerateReport;
        public Viewer() {
            InitializeComponent();
            this.Load += Viewer_Load;
            previewControl = new PrintPreviewControl();
            previewControl.Dock = DockStyle.Fill;

            // Create a button to generate the report
            btnGenerateReport = new Button();
            btnGenerateReport.Text = "Generate Report";
            btnGenerateReport.Dock = DockStyle.Top;

            // Add controls to the form
            this.Controls.Add(previewControl);
            this.Controls.Add(btnGenerateReport);

            // Set up the form
            this.Size = new System.Drawing.Size(800, 600);
        }

        private void kryptonButton1_Click(object sender, EventArgs e) {


            try {

            }
            catch (Exception ex) {
                Console.WriteLine("Error generating report: " + ex.Message);
            }
            finally {
                // Clean up
                //report.Dispose();
            }


        }

        private void Viewer_Load(object sender, EventArgs e) {

        }

        private void kryptonButton1_Click_1(object sender, EventArgs e) {
            StiReport report = new StiReport();
            report.Load(@"C:\\Users\\ADMIN\\Desktop\\shisharp\\shisharp\\bms\\docs_templates\\Report.mrt");

            foreach (StiVariable item in report.Dictionary.Variables) {

                // Display the variable name and value
                MessageBox.Show($"Variable Name: {item.Value}");
            }

            report.Compile();
            report.Render();
            report.Show();

        }

    }

}
