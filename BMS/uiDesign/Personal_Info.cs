using Krypton.Toolkit;
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
    public partial class Personal_Info: Form
    {
        public Personal_Info()
        {
            InitializeComponent();
        }

        private void kryptonLabel1_Click(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            kryptonTextBox1.UseSystemPasswordChar = !kryptonCheckBox1.Checked;

        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {

        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {

        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            List<KryptonPanel> panelList = new List<KryptonPanel>();
            panelList.Add(pnlPersonalInformation);
            panelList.Add(pnlAddress);

            
        }

        private void kryptonCustomPaletteBase2_PalettePaint(object sender, PaletteLayoutEventArgs e)
        {

        }
    }
}
