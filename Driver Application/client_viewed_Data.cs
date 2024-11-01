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
    public partial class client_viewed_Data : UserControl
    {
        public client_viewed_Data()
        {
            InitializeComponent();
        }

        private void client_viewed_Data_Load(object sender, EventArgs e)
        {
            cc();
            Showdata();
            Showdata2();
            Showdata3();
        }
        private void Showdata()
        {
  
                //Show Method for Driver_details
                SqlConnection con;
                string constring = @"Data Source=LAPTOP-I99KH2H2\SQLEXPRESS01;Initial Catalog=Credentials;Integrated Security=True;";

                con = new SqlConnection(constring);
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT Order_Trans_ID,Client_BookID,Client_Id ,p_add , d_add , t_type , weight ,material ,s_date , descr FROM Client_Order_Assign", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);

                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    guna2DataGridView1.DataSource = dt;
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            
        }
        private void Showdata2()
        {

            //Show Method for Driver_details
            SqlConnection con;
            string constring = @"Data Source=LAPTOP-I99KH2H2\SQLEXPRESS01;Initial Catalog=Credentials;Integrated Security=True;";

            con = new SqlConnection(constring);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT Order_Trans_ID,driver_ID,driver_name,driver_mob,driver_status FROM Client_Order_Assign", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                sda.Fill(dt);
                guna2DataGridView2.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Showdata3()
        {

            //Show Method for Driver_details
            SqlConnection con;
            string constring = @"Data Source=LAPTOP-I99KH2H2\SQLEXPRESS01;Initial Catalog=Credentials;Integrated Security=True;";

            con = new SqlConnection(constring);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT Order_Trans_ID,vechile_ID,vechile_no,vechile_name,vechile_status FROM Client_Order_Assign", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                sda.Fill(dt);
                guna2DataGridView3.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-I99KH2H2\SQLEXPRESS01;Initial Catalog=Credentials;Integrated Security=True;");

        private void cc()
        {
            // String mm = "Yes";
            txtclinebktid.Items.Clear();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Order_Trans_ID from Client_Order_Assign";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txtclinebktid.Items.Add(dr["Order_Trans_ID"].ToString());

            }
            txtclinebktid.Refresh();
            con.Close();


        }

        private void txtclinebktid_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-I99KH2H2\SQLEXPRESS01;Initial Catalog=Credentials;Integrated Security=True;");


            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select  Client_ID , p_add , d_add , t_type , weight ,material ,s_date , descr,driver_ID,driver_name,driver_mob,driver_status,trans_status,vechile_ID,vechile_no,vechile_name,vechile_status  from Client_Order_Assign where Order_Trans_ID = '" + txtclinebktid.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                laclientid.Text = dr["Client_ID"].ToString();
                lapadd.Text = dr["p_add"].ToString();
                ladradd.Text = dr["d_add"].ToString();
                latttype.Text = dr["t_type"].ToString();
                laweight.Text = dr["weight"].ToString();
                lamaterial.Text = dr["material"].ToString();
                laschedate.Text = dr["s_date"].ToString();
                ladesc.Text = dr["descr"].ToString();
                ladriverid.Text = dr["driver_ID"].ToString();
                ladrivername.Text = dr["driver_name"].ToString();
                ladriverrmobile.Text = dr["driver_mob"].ToString();
                ladriverstatus.Text = dr["driver_status"].ToString();
                latransactionst.Text = dr["trans_status"].ToString();
                lavid.Text = dr["vechile_ID"].ToString();
                lavno.Text = dr["vechile_no"].ToString();
                lavname.Text = dr["vechile_name"].ToString();
                lavstatus.Text = dr["vechile_status"].ToString();
            }
            con.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
