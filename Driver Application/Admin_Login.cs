using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Driver_Application
{
    public partial class Admin_Login : Form
    {
        public Admin_Login()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Forget Method Show
            panel1.Hide();
            panel2.Show();
        }

        private void Admin_Login_Load(object sender, EventArgs e)
        {
            panel2.Hide();
            guna2Panel1.Hide();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            //Select Query Method
            //- driver_module()

            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-I99KH2H2\SQLEXPRESS01;Initial Catalog=Credentials;Integrated Security=True;");
                SqlCommand cmd = new SqlCommand("select * from Login_tb where username = @username and password = @password", conn);
                cmd.Parameters.AddWithValue("@username", tbusername.Text);
                cmd.Parameters.AddWithValue("@password", tbpassword.Text);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    //MessageBox.Show("Login Succesfully");
                    Dashboard hm = new Dashboard();
                    //Home_Page hm = new Home_Page();
                    
                    hm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Crenditals");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void showbtn_Click(object sender, EventArgs e)
        {
            //password visible
            tbpassword.PasswordChar = (char)0;
        }
        int Vcode = 1000;
        private void timVcode_Tick(object sender, EventArgs e)
        {
            Vcode += 10;
            if (Vcode == 9999)
            {
                Vcode = 2000;
            }
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            //mail Generation Method
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-I99KH2H2\SQLEXPRESS01;Initial Catalog=Credentials;Integrated Security=True;");
                SqlCommand cmd = new SqlCommand("select username from Login_tb where username = @username", conn);
                cmd.Parameters.AddWithValue("@username", tb_gmail.Text);
                //cmd.Parameters.AddWithValue("@password", tbpassword.Text);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    timVcode.Stop();
                    string to, from, pass, mail;
                    to = tb_gmail.Text;
                    from = "cargoflow186@gmail.com";
                    mail = Vcode.ToString();
                    pass = "bopa fsbo vlfi eqsn";
                    MailMessage message = new MailMessage();
                    message.To.Add(to);
                    message.From = new MailAddress(from);
                    message.Body = Vcode.ToString();
                    message.Subject = "Your app Verification Code";
                    SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                    smtp.EnableSsl = true;
                    smtp.Port = 587;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Credentials = new NetworkCredential(from, pass);

                    try
                    {
                        smtp.Send(message);
                        MessageBox.Show("Verification Code Sent into Gmail..", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tb_code.Enabled = true;
                        //btn_cnf.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Wrong Gmail ID....\nPlease Enter Registered E-Mail ID....", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            //code_generation()
            if (tb_code.Text == Vcode.ToString())
            {
                panel1.Hide();
                panel2.Hide();
                guna2Panel1.Show();
            }
            else
            {
                MessageBox.Show("OTP Verifiaction Code are Wrong. Please Check Again Mail...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            string uanme = tb_gmail.Text;
            show_label.Text = uanme;
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            //update_password()
            if (txtpass.Text == txtpass2.Text)
            {
                SqlConnection con;
                String constring = @"Data Source=LAPTOP-I99KH2H2\SQLEXPRESS01;Initial Catalog=Credentials;Integrated Security=True;";
                con = new SqlConnection(constring);
                con.Open();
                String query = $"UPDATE Login_tb SET password = '{txtpass.Text}' WHERE username = '{show_label.Text}'";
                SqlCommand com;
                com = new SqlCommand(query, con);
                com.ExecuteNonQuery();
                //Greatting();
                MessageBox.Show("PassWord Updated Successfully. Please Re - Login Your Credentials .....");

                con.Close();



                panel1.Show();
                panel1.Refresh();
                panel2.Hide();
                guna2Panel1.Hide();
                
            }
            else
            {
                MessageBox.Show("New Password and Confirm Password are Not Same.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
