using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CargoFlow_Client_App
{
    public partial class Home_Page : Form
    {
        public Home_Page()
        {
            InitializeComponent();
        }
        public string uname { get; set; }
        private void Home_Page_Load(object sender, EventArgs e)
        {
            txtemailid.Text = uname;
            showdata();
            Showdata2();
            
             panel2.Hide();
            guna2Panel1.Hide();
            panel3.Hide();
            InitBrowser();
            profile_showdata();
            panel4.Hide();
            profile_showdata2();
            viewbooked.Hide();
            vdashboard.Hide();
            cc();
            dashboard3();
            dashboard4();
            dashboard5();
            dashboard6();
            dashboard7();
            dashboard8();

            dtPickupDate.MinDate= DateTime.Now;
        }

        private void dashboard3()
        {
            //count_Driver_assign()
            con.Open();
            SqlCommand cmd = new SqlCommand($"Select Count(*) from Client_Order_Assign where trans_status = 'Pending' And Client_ID = '{txtcid.Text}'", con);
            var count1 = cmd.ExecuteScalar();
            txt_number.Text = count1.ToString();
            con.Close();
        }
        private void dashboard4()
        {
            //count_Driver_assign()
            con.Open();
            SqlCommand cmd = new SqlCommand($"Select Count(*) from Client_Order_Assign where trans_status = 'Pending' And Client_ID = '{txtcid.Text}'", con);
            var count1 = cmd.ExecuteScalar();
            txtds1.Text = count1.ToString();
            con.Close();
        }

        private void dashboard5()
        {
            //count_Driver_assign()
            con.Open();
            SqlCommand cmd = new SqlCommand($"Select Count(*) from Client_Order_Assign where trans_status = 'Completed' And Client_ID = '{txtcid.Text}'", con);
            var count1 = cmd.ExecuteScalar();
            txtds2.Text = count1.ToString();
            con.Close();
        }

        private void dashboard6()
        {
            //count_Driver_assign()
            con.Open();
            SqlCommand cmd = new SqlCommand($"Select sum(totkm) from Client_Order_Assign where Client_ID = '{txtcid.Text}'", con);
            var count1 = cmd.ExecuteScalar();
            txtds3.Text = count1.ToString();
            con.Close();
        }

        private void dashboard7()
        {
            //count_Driver_assign()
            con.Open();
            SqlCommand cmd = new SqlCommand($"Select sum(totfare) from Client_Order_Assign where trans_status = 'Completed' And Client_ID = '{txtcid.Text}'", con);
            var count1 = cmd.ExecuteScalar();
            txtds4.Text = count1.ToString();
            con.Close();
        }

        private void dashboard8()
        {
            //count_Driver_assign()
            con.Open();
            SqlCommand cmd = new SqlCommand($"Select count(*) from Client_BookData where status = 'In Review' And Client_ID = '{txtcid.Text}'", con);
            var count1 = cmd.ExecuteScalar();
            txtds5.Text = count1.ToString();
            con.Close();
        }

        private void showdata()
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-I99KH2H2\SQLEXPRESS01;Initial Catalog=Credentials;Integrated Security=True;");
            con.Open();

            string query = "Select Client_ID,CFname from Client_Details where Uname = '" + txtemailid.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);

            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                if (dr.Read())
                {
                    txtcid.Text = dr["Client_ID"].ToString();
                    txtname.Text = dr["CFname"].ToString();
                }
            }


        }

        private void guna2GradientButton6_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();

            dialog = MessageBox.Show("Do You Want to Sign Out Your Application\nMake It Relogin and Connect It....", "Visit Again!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialog == DialogResult.Yes)
            {
                Form1 hj = new Form1();
                hj.Show();
                this.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time_show.Text = DateTime.Now.ToLongTimeString();
            show_cal.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            first_panel.Show();
            panel2.Hide();
            guna2Panel1.Hide();
            panel3.Hide();
            panel4.Hide();
            viewbooked.Hide();
            vdashboard.Hide();
        }

        private void Showdata2()
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-I99KH2H2\SQLEXPRESS01;Initial Catalog=Credentials;Integrated Security=True;");
            con.Open();

            string query = "Select CFname,CMname,CLname,Mobno,PMobno,Email,Uname,WAddress,Aadhar,HAddress from Client_Details where Uname = '" + txtemailid.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);

            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                if (dr.Read())
                {
                    vfname.Text = dr["CFname"].ToString();
                    vmname.Text = dr["CMname"].ToString();
                    vlname.Text = dr["CLname"].ToString();
                    vmobno.Text = dr["Mobno"].ToString();
                    vpmono.Text = dr["PMobno"].ToString();
                    vemail.Text = dr["Email"].ToString();
                    vusername.Text = dr["Uname"].ToString();
                    vwaddress.Text = dr["WAddress"].ToString();
                    vHaddress.Text = dr["HAddress"].ToString();
                    vaadhar.Text = dr["Aadhar"].ToString();
                }
            }
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            first_panel.Hide();
            panel2.Show();
            guna2Panel1.Hide();
            panel3.Hide();
            panel4.Hide();
            viewbooked.Hide();
            vdashboard.Hide();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            first_panel.Hide();
            panel2.Show();
            guna2Panel1.Hide();
            panel3.Hide();
            panel4.Hide();
            viewbooked.Hide();
            vdashboard.Hide();
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            //Pricing_Page hj = new Pricing_Page();
            //hj.Show();
           // this.Hide();

            first_panel.Hide();
            panel2.Hide();
            guna2Panel1.Show();
            panel3.Hide();
            panel4.Hide();
            viewbooked.Hide();
            vdashboard.Hide();
        }

        private void guna2GradientButton7_Click(object sender, EventArgs e)
        {
            panel3.Show();
            first_panel.Hide();
            panel2.Hide();
            guna2Panel1.Hide();
            panel4.Hide();
            viewbooked.Hide();
            vdashboard.Hide();

        }

        private void guna2GradientButton8_Click(object sender, EventArgs e)
        {
            showdata();
            Showdata2();

            panel2.Hide();
            guna2Panel1.Hide();
            panel3.Hide();
            InitBrowser();
            profile_showdata();
            panel4.Hide();
            profile_showdata2();
            viewbooked.Hide();
            vdashboard.Hide();
            cc();
            dashboard3();
            dashboard4();
            dashboard5();
            dashboard6();
            dashboard7();
            dashboard8();
        }

        private void first_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }



        private async Task initizated()
        {
            await webView21.EnsureCoreWebView2Async(null);
        }
        public async void InitBrowser()
        {
            await initizated();
            webView21.CoreWebView2.Navigate("https://www.google.com/maps/@41.2950114,-91.9826847,14z");
            //see the description for code and other details
        }

        private void webView21_SourceChanged(object sender, Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventArgs e)
        {
            string[] urls = webView21.Source.ToString().Split('/');
            string[] paramters;
            if (urls[urls.Length - 1].Contains("data"))
            {
                paramters = urls[urls.Length - 2].Split(',');
            }
            else
            {
                paramters = urls[urls.Length - 1].Split(',');
            }
            textBox1.Text = paramters[0];
            textBox2.Text = paramters[1];
            textBox3.Text = paramters[2];
        }



        private void profile_showdata()
        {
            SqlConnection connection = new SqlConnection("Data Source=LAPTOP-I99KH2H2\\SQLEXPRESS01;Initial Catalog=Credentials;Integrated Security=True;");

            SqlCommand cmd;
            try
            {
                string sql = "Select P_image from Client_Details where Uname = '" + txtemailid.Text + "'";
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                    cmd = new SqlCommand(sql, connection);

                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();

                    if (reader.HasRows)
                    {


                        byte[] img = (byte[])(reader[0]);

                        if (img == null)
                        {
                            P_profilebutton.Image = null;
                        }
                        else
                        {
                            var stream = new MemoryStream(img);
                            P_profilebutton.Image = Image.FromStream(stream);
                        }

                    }
                    else
                    {
                        connection.Close();
                        MessageBox.Show("Image Does not Exit!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void profile_showdata2()
        {
            SqlConnection connection = new SqlConnection("Data Source=LAPTOP-I99KH2H2\\SQLEXPRESS01;Initial Catalog=Credentials;Integrated Security=True;");

            SqlCommand cmd;
            try
            {
                string sql = "Select P_image from Client_Details where Uname = '" + txtemailid.Text + "'";
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                    cmd = new SqlCommand(sql, connection);

                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();

                    if (reader.HasRows)
                    {


                        byte[] img = (byte[])(reader[0]);

                        if (img == null)
                        {
                            profilepicture2.Image = null;
                        }
                        else
                        {
                            var stream = new MemoryStream(img);
                            profilepicture2.Image = Image.FromStream(stream);
                        }

                    }
                    else
                    {
                        connection.Close();
                        MessageBox.Show("Image Does not Exit!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void P_profilebutton_DoubleClick(object sender, EventArgs e)
        {
            first_panel.Hide();
            panel2.Show();
            guna2Panel1.Hide(); 
            panel3.Hide();
            viewbooked.Hide();
            vdashboard.Hide();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            first_panel.Hide();
            panel2.Hide();
            guna2Panel1.Hide();
            panel3.Hide();
            panel4.Show();
            viewbooked.Hide();
            vdashboard.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void vwaddress_Click(object sender, EventArgs e)
        {

        }

        private void vHaddress_Click(object sender, EventArgs e)
        {

        }

        private void label50_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if(txtpadd.Text != "" && txtdradd.Text != "" && txtmaterial.Text !="" && txtttype.Text!="" && txtWeight.Text!="" && txtdescrption.Text != "" && txtpadd.Text != txtdradd.Text)
            {

                float km = 0;
                float fr = 0;
                string st = "In Review";

                SqlConnection con;
                string constring = @"Data Source=LAPTOP-I99KH2H2\SQLEXPRESS01;Initial Catalog=Credentials;Integrated Security=True;";
                con = new SqlConnection(constring);

                con.Open();

                String query = $"INSERT INTO Client_BookData (Client_ID , p_add , d_add ,material, truck_type, s_date , weight, descr , tot_km, tot_fare,status) VALUES ('{txtcid.Text}','{txtpadd.Text}','{txtdradd.Text}','{txtmaterial.Text}','{txtttype.Text}','{dtPickupDate.Text}','{txtWeight.Text}','{txtdescrption.Text}','{km}','{fr}','{st}')";

                SqlCommand com;

                com = new SqlCommand(query, con);
                com.ExecuteNonQuery();
                MessageBox.Show("Within next 24 Hours Check In\n View Order Module The Order Will be Booked!", "Note For Booking Information!!", MessageBoxButtons.OK, MessageBoxIcon.Information);


                con.Close();

                txtpadd.Clear();
                txtdradd.Clear();
                txtmaterial.Refresh();
                txtttype.Refresh();
                dtPickupDate.Refresh();
                txtWeight.Clear();
                txtdescrption.Clear();
            }
            else
            {
                MessageBox.Show("Empty Text Filed\nPickup Address and Drop Address does not Same!","Empty",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
                    

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Truck_Info ti = new Truck_Info();
            ti.Show();
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            first_panel.Hide();
            panel2.Hide();
            guna2Panel1.Hide();
            panel3.Hide();
            panel4.Hide();
            viewbooked.Show();
            vdashboard.Hide();
        }

        private void P_profilebutton_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            first_panel.Hide();
            panel2.Hide();
            guna2Panel1.Hide();
            panel3.Hide();
            panel4.Hide();
            viewbooked.Hide();
            vdashboard.Show();
        }


        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-I99KH2H2\SQLEXPRESS01;Initial Catalog=Credentials;Integrated Security=True;");
        private void cc()
        {
            // String mm = "Yes";
            txtclinebktid.Items.Clear();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select Order_Trans_ID from Client_Order_Assign where Client_ID = '{txtcid.Text}' and trans_status = 'Pending'";
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
            cmd.CommandText = "select  p_add , d_add , t_type , weight ,material ,s_date , descr,driver_name,driver_mob,vechile_ID,vechile_no,vechile_name,totkm,tottoll,gsttx,totfare  from Client_Order_Assign where Order_Trans_ID = '" + txtclinebktid.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                
                lapadd.Text = dr["p_add"].ToString();
                ladradd.Text = dr["d_add"].ToString();
                latttype.Text = dr["t_type"].ToString();
                laweight.Text = dr["weight"].ToString();
                lamaterial.Text = dr["material"].ToString();
                laschedate.Text = dr["s_date"].ToString();
                ladesc.Text = dr["descr"].ToString();
                ladrivername.Text = dr["driver_name"].ToString();
                ladriverrmobile.Text = dr["driver_mob"].ToString();
                
                
                lavid.Text = dr["vechile_ID"].ToString();
                lavno.Text = dr["vechile_no"].ToString();
                lavname.Text = dr["vechile_name"].ToString();
                latotkm.Text = dr["totkm"].ToString();
                latottoll.Text = dr["tottoll"].ToString();
                lagstamt.Text = dr["gsttx"].ToString();
                latotamt.Text = dr["totfare"].ToString();
            }
            con.Close();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();

            dialog = MessageBox.Show("Do You Want to Pay and Book Your Ordern\nOrder Will be Confimredt....", "Visit Again!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialog == DialogResult.Yes)
            {
                dr_update();
                cc();
            }
        }

        private void dr_update()
        {
            //Order_Update()

            SqlConnection con;
            string constring = @"Data Source=LAPTOP-I99KH2H2\SQLEXPRESS01;Initial Catalog=Credentials;Integrated Security=True;";
            con = new SqlConnection(constring);
            con.Open();

            String query = $"Update Client_Order_Assign SET trans_status = 'Completed' where Order_Trans_ID = '{txtclinebktid.Text}'";

            SqlCommand com;

            com = new SqlCommand(query, con);
            com.ExecuteNonQuery();
            MessageBox.Show("Data Update Successfully");


            con.Close();
        }

        private void vdashboard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtdradd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtpadd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtdradd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            e.Graphics.DrawString("Jay Shree Krishna", new Font("Monotype Corsiva", 15, FontStyle.Regular), Brushes.Black, new Point(350, 1));
            Bitmap mp = Properties.Resources._2_prev_ui;
            Image image = mp;


            e.Graphics.DrawImage(image, 320, 2, 200, 200);
            e.Graphics.DrawString("CARGOFLOW Invoice", new Font("Palatino Linotype", 30, FontStyle.Bold), Brushes.Black, new Point(200, 180));
            e.Graphics.DrawString("Date : - " + DateTime.Now, new Font("Calibri", 15, FontStyle.Bold), Brushes.Black, new Point(280, 280));

            e.Graphics.DrawString("Pickup Address :- " + lapadd.Text, new Font("Palatino Linotype", 15, FontStyle.Regular), Brushes.Black, new Point(100, 350));
            e.Graphics.DrawString("Drop Address   :- " + ladradd.Text, new Font("Palatino Linotype", 15, FontStyle.Regular), Brushes.Black, new Point(100, 390));
            e.Graphics.DrawString("Truck Type   :- " + latttype.Text, new Font("Palatino Linotype", 15, FontStyle.Regular), Brushes.Black, new Point(100, 430));
            e.Graphics.DrawString("Weight(Metric Ton)   :- " + laweight.Text, new Font("Palatino Linotype", 15, FontStyle.Regular), Brushes.Black, new Point(100, 470));
            e.Graphics.DrawString("Materials   :- " + lamaterial.Text, new Font("Palatino Linotype", 15, FontStyle.Regular), Brushes.Black, new Point(100, 510));
            e.Graphics.DrawString("Scheduled Date   :- " + laschedate.Text, new Font("Palatino Linotype", 15, FontStyle.Regular), Brushes.Black, new Point(100, 550));
            e.Graphics.DrawString("Description   :- " + ladesc.Text, new Font("Palatino Linotype", 15, FontStyle.Regular), Brushes.Black, new Point(100, 590));
            e.Graphics.DrawString("Driver Name   :- " + ladrivername.Text, new Font("Palatino Linotype", 15, FontStyle.Regular), Brushes.Black, new Point(100, 630));
            e.Graphics.DrawString("Driver Mobile   :- " + ladriverrmobile.Text, new Font("Palatino Linotype", 15, FontStyle.Regular), Brushes.Black, new Point(100, 670));
            e.Graphics.DrawString("Vechile ID   :- " + lavid.Text, new Font("Palatino Linotype", 15, FontStyle.Regular), Brushes.Black, new Point(100, 710));
            e.Graphics.DrawString("Vechile No.   :- " + lavno.Text, new Font("Palatino Linotype", 15, FontStyle.Regular), Brushes.Black, new Point(100, 750));
            e.Graphics.DrawString("Vechile Name   :- " + lavname.Text, new Font("Palatino Linotype", 15, FontStyle.Regular), Brushes.Black, new Point(100, 790));

        }
    }
}
