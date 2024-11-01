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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Driver_Application
{
    public partial class Show_Details : Form
    {
        public Show_Details()
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
            cmd.CommandText = "select driver_name from Driver_det";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                tbid.Items.Add(dr["driver_name"].ToString());

            }
            tbid.Refresh();
            con.Close();


        }

        private void Show_Details_Load(object sender, EventArgs e)
        {
            cc();
            showdata();
        }

        private void showdata()
        {
            SqlConnection con;
            string constring = @"Data Source=LAPTOP-I99KH2H2\SQLEXPRESS01;Initial Catalog=Credentials;Integrated Security=True;";

            con = new SqlConnection(constring);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Driver_det", con);
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

        private void button2_Click(object sender, EventArgs e)
        {
            (guna2DataGridView1.DataSource as DataTable).DefaultView.RowFilter =
            String.Format("driver_name like '%" + tbid.Text + "%'");

           
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
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
                Show_Details df = new Show_Details();
                df.Refresh();
            }
            

        }
    }
}
