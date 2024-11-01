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
    public partial class Client_Orders : UserControl
    {
        public Client_Orders()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-I99KH2H2\SQLEXPRESS01;Initial Catalog=Credentials;Integrated Security=True;");

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void txtdradd_TextChanged(object sender, EventArgs e)
        {

        }

        private void Client_Orders_Load(object sender, EventArgs e)
        {
            cc();
            cc2();
            cc3();
        }

        private void cc()
        {
            // String mm = "Yes";
            txtclinebktid.Items.Clear();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Client_Book_ID from Client_BookData where status ='In Review'";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txtclinebktid.Items.Add(dr["Client_Book_ID"].ToString());

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
            cmd.CommandText = "select Client_ID,p_add,d_add,material,truck_type,s_date,weight,descr from Client_BookData where Client_Book_ID = '" + txtclinebktid.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txtclientid.Text = dr["Client_ID"].ToString();
                txtpadd.Text = dr["p_add"].ToString();
                txtdradd.Text = dr["d_add"].ToString();
                txtmaterial.Text = dr["material"].ToString();
                txtttype.Text = dr["truck_type"].ToString();
                dtPickupDate.Text = dr["s_date"].ToString();
                txtWeight.Text = dr["weight"].ToString();
                txtdescrption.Text = dr["descr"].ToString();
            }
            con.Close();
        }


        private void cc2()
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

        private void cc3()
        {
            // String mm = "Yes";
            txtvid.Items.Clear();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select vechile_ID from vechile_Details where vechile_status ='Free'";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txtvid.Items.Add(dr["vechile_ID"].ToString());

            }
            txtvid.Refresh();
            con.Close();


        }

        private void txtvid_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-I99KH2H2\SQLEXPRESS01;Initial Catalog=Credentials;Integrated Security=True;");


            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select vechile_no,vechile_name,vechile_status from Vechile_Details where vechile_ID = '" + txtvid.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txtvno.Text = dr["vechile_no"].ToString();
                txtvname.Text = dr["vechile_name"].ToString();
                txtvstatus.Text = dr["vechile_status"].ToString();

            }
            con.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKilometer.Text))
            {
                MessageBox.Show("Please fill total kilometer", "CargoFlow", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            if (string.IsNullOrWhiteSpace(txtToll.Text))
            {
                MessageBox.Show("Please fill total toll charges", "CargoFlow", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }

            if (!string.IsNullOrEmpty(txtKilometer.Text) && !string.IsNullOrWhiteSpace(txtToll.Text))
            {
                double distance = Convert.ToDouble(txtKilometer.Text);
                double baseFare = 0;

                if (distance >= 0 && distance <= 100)
                {
                    baseFare = 7500 + (distance * (48 + 15));
                }
                else if (distance > 100 && distance <= 200)
                {
                    baseFare = 10000 + (distance * (48 + 15));
                }
                else if (distance > 200 && distance <= 500)
                {
                    baseFare = 15000 + (distance * (48 + 15));
                }
                else if (distance > 500 && distance <= 1000)
                {
                    baseFare = 20000 + (distance * (48 + 15));
                }
                else if (distance > 1000)
                {
                    baseFare = (distance * 50) + (distance * (48 + 15));
                }

                double fuelCharge = baseFare;
                double tollCharge = Convert.ToDouble(txtToll.Text);
                double gst = 0.18;

                //baseFare += fuelCharge + tollCharge;
                double GST_tot = baseFare * gst;
                double totalFare = baseFare + GST_tot;

                txtTotalBase.Text = baseFare.ToString();
                txtTotal.Text = totalFare.ToString();
                txt_gst.Text = GST_tot.ToString();
            }
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            //Insert_Transaction_details() 

            SqlConnection con;
            string constring = @"Data Source=LAPTOP-I99KH2H2\SQLEXPRESS01;Initial Catalog=Credentials;Integrated Security=True;";
            con = new SqlConnection(constring);
            con.Open();

            String query = $"INSERT INTO Client_Order_Assign (Client_BookID , Client_ID , p_add , d_add , t_type , weight ,material ,s_date , descr , driver_ID  , driver_name ,driver_mob ,vechile_ID ,vechile_no, vechile_name ,driver_status , vechile_status,trans_status ,totkm, tottoll, gsttx , totfare) VALUES ('{txtclinebktid.Text}','{txtclientid.Text}','{txtpadd.Text}','{txtdradd.Text}','{txtttype.Text}','{txtWeight.Text}','{txtmaterial.Text}','{dtPickupDate.Text}','{txtdescrption.Text}','{txt_did.Text}','{txt_dname.Text}','{txt_drmob.Text}','{txtvid.Text}','{txtvno.Text}','{txtvname.Text}','{txt_dstatus.Text}','{txtvstatus.Text}','{txt_transstatus.Text}','{txtKilometer.Text}','{txtToll.Text}','{txt_gst.Text}','{txtTotal.Text}')";

            SqlCommand com;

            com = new SqlCommand(query, con);
            com.ExecuteNonQuery();
            MessageBox.Show("Data Inserted Successfully");


            con.Close();
            dr_update();
            dr_update2();
            dr_delete();
        }


        private void dr_update()
        {
            //Order_Update()

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

        private void dr_update2()
        {
            //Order_Update()

            SqlConnection con;
            string constring = @"Data Source=LAPTOP-I99KH2H2\SQLEXPRESS01;Initial Catalog=Credentials;Integrated Security=True;";
            con = new SqlConnection(constring);
            con.Open();

            String query = $"Update Vechile_Details SET vechile_status = '{txtvstatus.Text}' where vechile_ID = '{txtvid.Text}'";

            SqlCommand com;

            com = new SqlCommand(query, con);
            com.ExecuteNonQuery();
            MessageBox.Show("Data Update2 Successfully");


            con.Close();
        }

        private void dr_delete()
        {
            //Order_Delete()

            SqlConnection con;
            string constring = @"Data Source=LAPTOP-I99KH2H2\SQLEXPRESS01;Initial Catalog=Credentials;Integrated Security=True;";
            con = new SqlConnection(constring);
            con.Open();

            String query = $"Update Client_BookData SET tot_Km = '{txtKilometer.Text}', tot_fare = '{txtTotal.Text}', status = 'On Payment' where Client_Book_ID = '{txtclinebktid.Text}'";

            SqlCommand com;

            com = new SqlCommand(query, con);
            com.ExecuteNonQuery();
            MessageBox.Show("Data Delete Successfully");


            con.Close();
        }
    }
}
