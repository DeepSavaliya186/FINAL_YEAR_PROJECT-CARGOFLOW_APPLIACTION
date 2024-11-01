using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Driver_Application
{
    public partial class Main_Page : Form
    {
        public Main_Page()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Dashboard db = new Dashboard();
            DialogResult dg = new DialogResult();

            dg = MessageBox.Show("Do you want to close?", "Saved Successfully!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dg == DialogResult.Yes)
            {
                db.Show();
                this.Hide();
            }
            else
            {
                Main_Page mp = new Main_Page();
                mp.Refresh();
            }

        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            Dashboard db = new Dashboard();
            
                db.Show();
                this.Hide();
            
        }

        private void guna2GradientButton1_Click_1(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();

            dialog = MessageBox.Show("Thank You!\nDo you want to close?", "Visit Again!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Main_Page_Load(object sender, EventArgs e)
        {
            adD_DRIVER1.Hide();
            driveR_DETAILS1.Hide();
            driveR_REFERSH1.Show();
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            driveR_DETAILS1.Hide();
            driveR_REFERSH1.Hide();

            adD_DRIVER1.Show();
            adD_DRIVER1.BringToFront();
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            adD_DRIVER1.Hide();
            driveR_REFERSH1.Hide();

            driveR_DETAILS1.Show();
            driveR_DETAILS1.BringToFront();
        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            adD_DRIVER1.Hide();
            driveR_DETAILS1.Hide();

            driveR_REFERSH1.Show();
            driveR_REFERSH1.BringToFront();

            driveR_DETAILS1.Refresh();
            adD_DRIVER1.Refresh();

            Main_Page f1 = new Main_Page();
            f1.Show();
            this.Hide();
        }
    }
}
