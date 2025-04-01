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
    public partial class Index: Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
           

        }

        private void kryptonButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Krypton_LogIn back = new Krypton_LogIn();
            back.Show();
        }

        private void kryptonButton1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Krypton_LogIn back = new Krypton_LogIn();
            back.Show();
        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Krypton_LogIn back = new Krypton_LogIn();
            back.Show();
        }
    }
}
