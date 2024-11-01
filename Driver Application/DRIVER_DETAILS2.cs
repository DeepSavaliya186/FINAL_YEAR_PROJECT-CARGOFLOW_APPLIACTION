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
    public partial class DRIVER_DETAILS2 : UserControl
    {
        public DRIVER_DETAILS2()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-I99KH2H2\SQLEXPRESS01;Initial Catalog=Credentials;Integrated Security=True;");
        private void cc()
        {
            // String mm = "Yes";
            tbid.Items.Clear();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Trans_id from D_Assign";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                tbid.Items.Add(dr["Trans_id"].ToString());

            }
            tbid.Refresh();
            con.Close();


        }
        private void showdata()
        {
            //show_Order_details()

            SqlConnection con;
            string constring = @"Data Source=LAPTOP-I99KH2H2\SQLEXPRESS01;Initial Catalog=Credentials;Integrated Security=True;";

            con = new SqlConnection(constring);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM D_Assign", con);
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
        private void DRIVER_DETAILS2_Load(object sender, EventArgs e)
        {
            showdata();
            cc();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            (guna2DataGridView1.DataSource as DataTable).DefaultView.RowFilter =
              String.Format("convert(Trans_id , 'System.String') Like '%{0}%'", tbid.Text);
        }
    }
}
