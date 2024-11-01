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
    public partial class Order_completion : Form
    {
        public Order_completion()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-I99KH2H2\SQLEXPRESS01;Initial Catalog=Credentials;Integrated Security=True;");
        private void cc()
        {
            // String mm = "Yes";
            txt_transid.Items.Clear();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Trans_ID from D_Assign";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txt_transid.Items.Add(dr["Trans_ID"].ToString());

            }
            txt_transid.Refresh();
            con.Close();
        }
        private void Order_completion_Load(object sender, EventArgs e)
        {
            cc();
        }

        private void txt_transid_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-I99KH2H2\SQLEXPRESS01;Initial Catalog=Credentials;Integrated Security=True;");


            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Order_ID ,Driver_ID ,order_name,driver_name,source_st,dest_st,goods_type,driver_mob,driver_status,p_date,d_date,trans_status,ostatus from D_Assign where Trans_ID = '" + txt_transid.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txt_orderid.Text = dr["Order_ID"].ToString();
                txt_did.Text = dr["Driver_ID"].ToString();
                txt_ordername.Text = dr["order_name"].ToString();
                txt_dname.Text = dr["driver_name"].ToString();
                txt_sstate.Text = dr["source_st"].ToString();
                txt_dstate.Text = dr["dest_st"].ToString();
                txt_gtype.Text = dr["goods_type"].ToString();
                txt_drmob.Text = dr["driver_mob"].ToString();
                txt_ppdate.Text = dr["p_date"].ToString();
                txt_delidate.Text = dr["d_date"].ToString();
                txt_dstatus.Text = dr["driver_status"].ToString();
                txt_ostatus.Text = dr["ostatus"].ToString();
            }
            con.Close();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            SqlConnection con;
            string constring = @"Data Source=LAPTOP-I99KH2H2\SQLEXPRESS01;Initial Catalog=Credentials;Integrated Security=True;";
            con = new SqlConnection(constring);
            con.Open();

            String query = $"INSERT INTO Order_report (Trans_id , Order_id , order_name , s_state , d_state,g_type,p_date,d_date,driver_id,driver_name,driver_mob,ostatus) VALUES ('{txt_transid.Text}','{txt_orderid.Text}','{txt_ordername.Text}','{txt_sstate.Text}','{txt_dstate.Text}','{txt_gtype.Text}','{txt_ppdate.Text}','{txt_delidate.Text}','{txt_did.Text}','{txt_dname.Text}','{txt_drmob.Text}','{txt_ostatus.Text}')";

            SqlCommand com;

            com = new SqlCommand(query, con);
            com.ExecuteNonQuery();
            MessageBox.Show("Data Inserted Successfully");


            con.Close();
            dr_update();
            dr_delete();
        }

        private void dr_delete()
        {
            SqlConnection con;
            string constring = @"Data Source=LAPTOP-I99KH2H2\SQLEXPRESS01;Initial Catalog=Credentials;Integrated Security=True;";
            con = new SqlConnection(constring);
            con.Open();

            String query = $"Delete from D_Assign where Trans_ID = '{txt_transid.Text}'";

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

        private void guna2GradientButton3_Click(object sender, EventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            if(txt_ostatus.Text.Equals("Active") && txt_dstatus.Text.Equals("Assign"))
            {
                MessageBox.Show("Order Status is Active\nDriver Status Are Assign");
            }
            if(txt_ostatus.Text.Equals("Inactive") && txt_dstatus.Text.Equals("Assign"))
            {
                MessageBox.Show("Order Status is InActive");
            }
            if(txt_ostatus.Text.Equals("Completed") && txt_dstatus.Text.Equals("Fresh"))
            {
                SqlConnection con;
                string constring = @"Data Source=LAPTOP-I99KH2H2\SQLEXPRESS01;Initial Catalog=Credentials;Integrated Security=True;";
                con = new SqlConnection(constring);
                con.Open();

                String query = $"INSERT INTO Order_report (Trans_id , Order_id , order_name , s_state , d_state,g_type,p_date,d_date,driver_id,driver_name,driver_mob,ostatus) VALUES ('{txt_transid.Text}','{txt_orderid.Text}','{txt_ordername.Text}','{txt_sstate.Text}','{txt_dstate.Text}','{txt_gtype.Text}','{txt_ppdate.Text}','{txt_delidate.Text}','{txt_did.Text}','{txt_dname.Text}','{txt_drmob.Text}','{txt_ostatus.Text}')";

                SqlCommand com;

                com = new SqlCommand(query, con);
                com.ExecuteNonQuery();
                MessageBox.Show("Data Inserted Successfully");


                con.Close();
                dr_update();
                dr_delete();
            }
        }
    }
}
