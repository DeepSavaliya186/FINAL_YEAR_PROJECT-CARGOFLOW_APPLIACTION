using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Driver_Application
{
    public partial class order_Form : Form
    {
        public order_Form()
        {
            InitializeComponent();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
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
                order_Form mp = new order_Form();
                mp.Refresh();
            }
        }

        private void order_Form_Load(object sender, EventArgs e)
        {
            makE_ORDER1.Hide();
            driveR_ASSIGN1.Hide();
            ORDER_DETAILS.Hide();
            
        }

        private void guna2GradientButton7_Click(object sender, EventArgs e)
        {
            driveR_ASSIGN1.Hide();
            ORDER_DETAILS.Hide();
            ordeR_REFRESH1.Hide();


            makE_ORDER1.Show();
            makE_ORDER1.BringToFront();
        }

        private void guna2GradientButton6_Click(object sender, EventArgs e)
        {
            makE_ORDER1.Hide();
            ORDER_DETAILS.Hide();
            ordeR_REFRESH1.Hide();

            driveR_ASSIGN1.Show();
            driveR_ASSIGN1.BringToFront();
        }

        private void driveR_DETAILS21_Load(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            makE_ORDER1.Hide();
            driveR_ASSIGN1.Hide();
            ordeR_REFRESH1.Hide();

            ORDER_DETAILS.Show();
            ORDER_DETAILS.BringToFront();
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            Dashboard db = new Dashboard();
            
                db.Show();
                this.Hide();
            
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientButton1_Click_1(object sender, EventArgs e)
        {
            makE_ORDER1.Hide();
            driveR_ASSIGN1.Hide();
            ORDER_DETAILS.Hide();

            ordeR_REFRESH1.Show();
            ordeR_REFRESH1.BringToFront();

            order_Form f1 = new order_Form();   
            f1.Show();
            this.Hide();
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();

            dialog = MessageBox.Show("Thank You!\nDo you want to close?", "Visit Again!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void driveR_ASSIGN1_Load(object sender, EventArgs e)
        {

        }
    }
}
