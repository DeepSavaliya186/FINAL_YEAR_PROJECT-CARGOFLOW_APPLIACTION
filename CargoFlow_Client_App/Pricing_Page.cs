﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CargoFlow_Client_App
{
    public partial class Pricing_Page : Form
    {
        public Pricing_Page()
        {
            InitializeComponent();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Home_Page ui = new Home_Page();
            ui.Show();
            this.Hide();
            
        }
    }
}