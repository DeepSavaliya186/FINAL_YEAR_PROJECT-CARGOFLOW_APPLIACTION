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
    public partial class MAKE_ORDER : UserControl
    {
        public MAKE_ORDER()
        {
            InitializeComponent();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            //Insert_Order_details()
            SqlConnection con;
            string constring = @"Data Source=LAPTOP-I99KH2H2\SQLEXPRESS01;Initial Catalog=Credentials;Integrated Security=True;";
            con = new SqlConnection(constring);
            con.Open();

            String query = $"INSERT INTO Order_bk (Order_name , s_dist , s_state , d_dist , d_state,p_date,d_date,G_type,status) VALUES ('{txt_od.Text}','{txt_sdist.Text}','{txt_sstate.Text}','{txt_ddist.Text}','{txt_dstate.Text}','{txt_ppdate.Text}','{txt_delidate.Text}','{txt_gtype.Text}','{txt_ostatus.Text}')";

            SqlCommand com;

            com = new SqlCommand(query, con);
            com.ExecuteNonQuery();
            MessageBox.Show("Data Inserted Successfully");


            con.Close();
        }
    }
}
