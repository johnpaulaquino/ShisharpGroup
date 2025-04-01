using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMS.uiDesign
{
    public partial class SidebarContainer : Form
    {
        bool sidebarExpand;
        public SidebarContainer()
        {
            InitializeComponent();
        }

        private void home_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            //if (sidebarExpand)
            //{
            //    sidebar.Width -= 10;
            //    if (sidebar.Width ==  sidebar.MinimumSize.Width)
            //    {
            //        sidebarExpand = false;
            //        sidebarTimer.stop();
            //    }
            //}
            //else
            //{
            //    sidebar.Width += 10;
            //    if (sidebar.Width == sidebar.MaximumSize.Width)
            //    {
            //        sidebarExpand = true;
            //        sidebarTimer.Stop();

            //    }
            //}
        }

        private void kryptonPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
