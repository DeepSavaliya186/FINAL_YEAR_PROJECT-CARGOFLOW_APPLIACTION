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
    public partial class driver_reassign : Form
    {
        public driver_reassign()
        {
            InitializeComponent();
        }

        private void driver_reassign_Load(object sender, EventArgs e)
        {
            cc();
            cc2();
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

        private void cc2()
        {
            //Fetch_Driver_ID()

            // String mm = "Yes";
            nw_did.Items.Clear();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select driver_id from Driver_det where status = 'Fresh'";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                nw_did.Items.Add(dr["driver_id"].ToString());

            }
            nw_did.Refresh();
            con.Close();
        }
        private void txt_transid_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Fetch_Order_Details()

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

        private void nw_did_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Show_Driver_Details()

            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-I99KH2H2\SQLEXPRESS01;Initial Catalog=Credentials;Integrated Security=True;");


            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select driver_name,mobile_no,status from Driver_det where driver_id = '" + nw_did.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                nw_dname.Text = dr["driver_name"].ToString();
                nw_dmob.Text = dr["mobile_no"].ToString();
                nw_dstatus.Text = dr["status"].ToString();
            }
            con.Close();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            //- Update_driver_status()

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
            dr_update();
            dr_update2();
        }

        private void dr_update()
        {
            SqlConnection con;
            string constring = @"Data Source=LAPTOP-I99KH2H2\SQLEXPRESS01;Initial Catalog=Credentials;Integrated Security=True;";
            con = new SqlConnection(constring);
            con.Open();

            String query = $"Update D_Assign SET Driver_ID = '{nw_did.Text}',Driver_name = '{nw_dname.Text}',driver_mob = '{nw_dmob.Text}',driver_status = '{nw_dstatus.Text}' where Trans_ID = '{txt_transid.Text}'";

            SqlCommand com;

            com = new SqlCommand(query, con);
            com.ExecuteNonQuery();
            MessageBox.Show("Data Update Successfully");


            con.Close();
        }

        private void dr_update2()
        {
           // Update_order_status()

            SqlConnection con;
            string constring = @"Data Source=LAPTOP-I99KH2H2\SQLEXPRESS01;Initial Catalog=Credentials;Integrated Security=True;";
            con = new SqlConnection(constring);
            con.Open();

            String query = $"Update Driver_det SET driver_name = '{nw_dname.Text}',mobile_no = '{nw_dmob.Text}',status = '{nw_dstatus.Text}' where driver_id = '{nw_did.Text}'";

            SqlCommand com;

            com = new SqlCommand(query, con);
            com.ExecuteNonQuery();
            MessageBox.Show("Data Update3 Successfully");


            con.Close();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            dr_update2();
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

        private void guna2GradientButton9_Click(object sender, EventArgs e)
        {


            Dashboard db = new Dashboard();
            db.Show();
            this.Hide();
            
        }

        private void guna2GradientButton8_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();

            dialog = MessageBox.Show("Thank You!\nDo you want to close?", "Visit Again!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
