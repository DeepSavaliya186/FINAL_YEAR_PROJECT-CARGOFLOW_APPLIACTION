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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
           
            dashboard();
            dashboard2();
            dashboard3();
            dashboard4();
            dashboard5();  
            dashboard6();
            dashboard7();
            dashboard8();
            dashboard9();
            dashboard10();
            timer1.Start();
            time_show.Text = DateTime.Now.ToLongTimeString();
            show_cal.Text = DateTime.Now.ToLongDateString();
        }

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-I99KH2H2\SQLEXPRESS01;Initial Catalog=Credentials;Integrated Security=True;");
        private void dashboard()
        {
            //count_totDriver()
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Count(*) from Driver_det", con);
            var count1 = cmd.ExecuteScalar();
            txt_number.Text = count1.ToString();
            con.Close();
        }

        private void dashboard2()
        {
            //Count_Order_book()
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Count(*) from Order_bk", con);
            var count1 = cmd.ExecuteScalar();
            c_order.Text = count1.ToString();
            con.Close();
        }

        private void dashboard3()
        {
            //count_Driver_assign()
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Count(*) from Driver_det where status = 'Assign'", con);
            var count1 = cmd.ExecuteScalar();
            count_driverid.Text = count1.ToString();
            con.Close();
        }

        private void dashboard4()
        {
            //count_driver_fresh()
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Count(*) from Driver_det where status = 'Fresh'", con);
            var count1 = cmd.ExecuteScalar();
            count_dsleep.Text = count1.ToString();
            con.Close();
        }

        private void dashboard5()
        {
            //count_driver_leave()
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Count(*) from Driver_det where status = 'Not Avaliable'", con);
            var count1 = cmd.ExecuteScalar();
            count_leave.Text = count1.ToString();
            con.Close();
        }

        private void dashboard6()
        {
            //count_driver_onroad()
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Count(*) from D_Assign where driver_status = 'Assign'", con);
            var count1 = cmd.ExecuteScalar();
            label7.Text = count1.ToString();
            con.Close();
        }

        private void dashboard7()
        {
            //count_Order_complete()
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Count(*) from Order_report", con);
            var count1 = cmd.ExecuteScalar();
            label9.Text = count1.ToString();
            con.Close();
        }

        private void dashboard8()
        {
            //count_Order_complete()
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Count(*) from Vechile_Details", con);
            var count1 = cmd.ExecuteScalar();
            label12.Text = count1.ToString();
            con.Close();
        }

        private void dashboard9()
        {
            //count_Order_complete()
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Count(*) from Vechile_Details where vechile_status ='Maintainance'", con);
            var count1 = cmd.ExecuteScalar();
            label16.Text = count1.ToString();
            con.Close();
        }

        private void dashboard10()
        {
            //count_Order_complete()
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Count(*) from Vechile_Details where vechile_status ='Busy'", con);
            var count1 = cmd.ExecuteScalar();
            label14.Text = count1.ToString();
            con.Close();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Main_Page f1 = new Main_Page();
            f1.Show();
            this.Hide();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            Show_Details sw = new Show_Details();
            sw.Show();
            this.Hide();
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            //make_ORder()
            order_Form od = new order_Form();
            od.Show();
            this.Hide();
        }

        private void c_order_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            dashboard();
            dashboard2();
            dashboard3();
            dashboard4();
            dashboard5();
            dashboard6();
        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();

            dialog = MessageBox.Show("Thank You!\nDo you want to close?", "Visit Again!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void guna2GradientButton6_Click(object sender, EventArgs e)
        {
            Order_Assigncs fgd = new Order_Assigncs();
            fgd.Show();
            this.Hide();
        }

        private void guna2GradientButton7_Click(object sender, EventArgs e)
        {
            Order_Details_Assign ad = new Order_Details_Assign();   
            ad.Show();
            this.Hide();
        }

        private void guna2GradientButton8_Click(object sender, EventArgs e)
        {
            driver_reassign dr = new driver_reassign();
            dr.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time_show.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void guna2GradientButton10_Click(object sender, EventArgs e)
        {
            Order_completion oc = new Order_completion();
            oc.Show();
            this.Hide();
        }

        private void guna2GradientButton11_Click(object sender, EventArgs e)
        {
            Order_History oh = new Order_History(); 
            oh.Show();
            this.Hide();
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientButton2_Click_1(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();

            dialog = MessageBox.Show("Alert for Credentials", "Are You Sure For Log Out?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialog == DialogResult.Yes)
            {
                Admin_Login ad = new Admin_Login();
                ad.Show();
                this.Hide();
            }
        }

        private void guna2GradientButton7_Click_1(object sender, EventArgs e)
        {
            
        }

        private void guna2GradientButton6_Click_1(object sender, EventArgs e)
        {
            vechile_mangement bh = new vechile_mangement(); 
            bh.Show();
            this.Hide();
        }

        private void guna2GradientButton7_Click_2(object sender, EventArgs e)
        {
            client_manage cm = new client_manage();
            cm.Show();
            this.Hide();
        }
    }
}
