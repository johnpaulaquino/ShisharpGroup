using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BMS.backend.database.repositories;
using BMS.backend.models;


namespace BMS
{
    public partial class Form1: Form
    {
        AdminUser admin;
        ITRepository itRepo = new ITRepository();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

  
    }
}
