using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2GradientButton6_Click(object sender, EventArgs e)
        {
            thirdpanel.Show();
            thirdpanel.BringToFront();

            first_panel.Hide();
            guna2GradientButton6.Hide();
            back_arrow.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            thirdpanel.Hide();
            back_arrow.Hide();
            Features_panel.Hide();
        }

        private void back_arrow_Click(object sender, EventArgs e)
        {
            first_panel.Show();
            first_panel.BringToFront();

            thirdpanel.Hide();
            guna2GradientButton6.Show();
            back_arrow.Hide();
        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            Login_Form h1 = new Login_Form();
            h1.Show();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Login_Form h2 = new Login_Form();
            h2.Show();
            this.Hide();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Login_Form h3 = new Login_Form();
            h3.Show();
            this.Hide();
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            Features_panel.Show();
            first_panel.Hide();
            thirdpanel.Hide();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            first_panel.Show();
            thirdpanel.Hide();
            Features_panel.Hide();
        }
    }
}
