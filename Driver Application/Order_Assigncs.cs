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
    public partial class Order_Assigncs : Form
    {
        public Order_Assigncs()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-I99KH2H2\SQLEXPRESS01;Initial Catalog=Credentials;Integrated Security=True;");
        private void cc()
        {
            // String mm = "Yes";
            txt_did.Items.Clear();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select driver_id from Driver_det where status ='Fresh'";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txt_did.Items.Add(dr["driver_id"].ToString());

            }
            txt_did.Refresh();
            con.Close();
        }

        private void cc2()
        {
            // String mm = "Yes";
            txt_orderid.Items.Clear();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Order_ID from Order_bk";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txt_orderid.Items.Add(dr["Order_ID"].ToString());

            }
            txt_orderid.Refresh();
            con.Close();


        }
        private void Order_Assigncs_Load(object sender, EventArgs e)
        {
            cc();
            cc2();
        }

        private void txt_did_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-I99KH2H2\SQLEXPRESS01;Initial Catalog=Credentials;Integrated Security=True;");


            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select driver_name,mobile_no,status from Driver_det where driver_id = '" + txt_did.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txt_dname.Text = dr["driver_name"].ToString();
                txt_drmob.Text = dr["mobile_no"].ToString();
                txt_dstatus.Text = dr["status"].ToString();
                
            }
            con.Close();
        }

        private void txt_orderid_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-I99KH2H2\SQLEXPRESS01;Initial Catalog=Credentials;Integrated Security=True;");


            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Order_name,s_state,d_state,G_type,p_date,d_date from Order_bk where Order_id = '" + txt_orderid.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txt_ordername.Text = dr["Order_name"].ToString();
                txt_sstate.Text = dr["s_state"].ToString();
                txt_dstate.Text = dr["d_state"].ToString();
                txt_gtype.Text = dr["G_type"].ToString();
                txt_ppdate.Text = dr["p_date"].ToString();
                txt_delidate.Text = dr["d_date"].ToString();
            }
            con.Close();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            SqlConnection con;
            string constring = @"Data Source=LAPTOP-I99KH2H2\SQLEXPRESS01;Initial Catalog=Credentials;Integrated Security=True;";
            con = new SqlConnection(constring);
            con.Open();

            String query = $"INSERT INTO D_Assign (Order_ID , Driver_ID , order_name , driver_name , source_st,dest_st,goods_type,driver_mob,driver_status,p_date,d_date,trans_status) VALUES ('{txt_orderid.Text}','{txt_did.Text}','{txt_ordername.Text}','{txt_dname.Text}','{txt_sstate.Text}','{txt_dstate.Text}','{txt_gtype.Text}','{txt_drmob.Text}','{txt_dstatus.Text}','{txt_ppdate.Text}','{txt_delidate.Text}','{txt_transstatus.Text}')";

            SqlCommand com;

            com = new SqlCommand(query, con);
            com.ExecuteNonQuery();
            MessageBox.Show("Data Inserted Successfully");


            con.Close();
            dr_delete();
            dr_update();
        }

        private void dr_delete()
        {
            SqlConnection con;
            string constring = @"Data Source=LAPTOP-I99KH2H2\SQLEXPRESS01;Initial Catalog=Credentials;Integrated Security=True;";
            con = new SqlConnection(constring);
            con.Open();

            String query = $"Delete from Order_bk where Order_ID = '{txt_orderid.Text}'";

            SqlCommand com;

            com = new SqlCommand(query, con);
            com.ExecuteNonQuery();
            MessageBox.Show("Data Delete Successfully");


            con.Close();
        }

        private void dr_update()
        {
            SqlConnection con;
            string constring = @"Data Source=LAPTOP-I99KH2H2\SQLEXPRESS01;Initial Catalog=Credentials;Integrated Security=True;";
            con = new SqlConnection(constring);
            con.Open();

            String query = $"Update Driver_det SET status = '{txt_dstatus.Text}' where driver_id = '{txt_did.Text}'";

            SqlCommand com;

            com = new SqlCommand(query, con);
            com.ExecuteNonQuery();
            MessageBox.Show("Data Update Successfully");


            con.Close();
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
                Main_Page mp = new Main_Page();
                mp.Refresh();
            }
        }
    }
}
