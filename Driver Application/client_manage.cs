using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Driver_Application
{
    public partial class client_manage : Form
    {
        public client_manage()
        {
            InitializeComponent();
        }

        private void guna2GradientButton7_Click(object sender, EventArgs e)
        {
            client_viewed_Data1.Hide();
            client_Orders1.BringToFront();
            client_Orders1.Show();
        }

        private void client_manage_Load(object sender, EventArgs e)
        {
            client_Orders1.Hide();
            client_viewed_Data1.Hide();
        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            Google_Maps gm = new Google_Maps();
            gm.Show();
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            Dashboard db = new Dashboard();

            db.Show();
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

        private void guna2GradientButton6_Click(object sender, EventArgs e)
        {
            client_Orders1.Hide();
            client_viewed_Data1.BringToFront();
            client_viewed_Data1.Show();
        }
    }
}
