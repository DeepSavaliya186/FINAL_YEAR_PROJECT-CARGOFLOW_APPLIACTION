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
    public partial class ADD_DRIVER : UserControl
    {
        public ADD_DRIVER()
        {
            InitializeComponent();
        }
        String st;
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //insert driver details method
            if (txt_yes.Checked == true)
            {
                st = "Yes";
            }
            else
            {
                st = "No";
            }
            SqlConnection con;
            string constring = @"Data Source=LAPTOP-I99KH2H2\SQLEXPRESS01;Initial Catalog=Credentials;Integrated Security=True;";
            con = new SqlConnection(constring);
            con.Open();

            String query = $"INSERT INTO Driver_det (driver_name , mobile_no , email_id , aadhar_no , insaruance,licence,status,password) VALUES ('{txt_name.Text}','{txt_mob.Text}','{txt_email.Text}','{txt_aadhar.Text}','{st}','{txt_license.Text}','{txt_dstatus.Text}','{txt_password.Text}')";

            SqlCommand com;

            com = new SqlCommand(query, con);
            com.ExecuteNonQuery();
            //MessageBox.Show("Data Inserted Successfully");
            notifyIcon1.ShowBalloonTip(20, "CargoFlow", "Driver Add Successfully.\nPlease Refersh It.", ToolTipIcon.Info);

            con.Close();
        }
    }
}
