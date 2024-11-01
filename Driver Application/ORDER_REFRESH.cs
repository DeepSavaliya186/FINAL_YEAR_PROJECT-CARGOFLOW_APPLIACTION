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
    public partial class ORDER_REFRESH : UserControl
    {
        public ORDER_REFRESH()
        {
            InitializeComponent();
        }

        private void ORDER_REFRESH_Load(object sender, EventArgs e)
        {
            dashboard2();
            dashboard3();
            dashboard4();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-I99KH2H2\SQLEXPRESS01;Initial Catalog=Credentials;Integrated Security=True;");
        private void dashboard2()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Count(*) from Order_bk", con);
            var count1 = cmd.ExecuteScalar();
            c_order.Text = count1.ToString();
            con.Close();
        }

        private void dashboard3()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Count(*) from D_Assign where driver_status = 'Assign'", con);
            var count1 = cmd.ExecuteScalar();
            count_driverid.Text = count1.ToString();
            con.Close();
        }
        private void dashboard4()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Count(*) from Driver_det where status = 'Fresh'", con);
            var count1 = cmd.ExecuteScalar();
            count_dsleep.Text = count1.ToString();
            con.Close();
        }
    }
}
