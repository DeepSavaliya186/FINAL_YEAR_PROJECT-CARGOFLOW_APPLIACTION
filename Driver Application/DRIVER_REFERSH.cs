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
    public partial class DRIVER_REFERSH : UserControl
    {
        public DRIVER_REFERSH()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-I99KH2H2\SQLEXPRESS01;Initial Catalog=Credentials;Integrated Security=True;");
        private void dashboard()
        {
            //count Methods
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Count(*) from Driver_det", con);
            var count1 = cmd.ExecuteScalar();
            txt_number.Text = count1.ToString();
            con.Close();
        }
        private void DRIVER_REFERSH_Load(object sender, EventArgs e)
        {
            dashboard();
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
