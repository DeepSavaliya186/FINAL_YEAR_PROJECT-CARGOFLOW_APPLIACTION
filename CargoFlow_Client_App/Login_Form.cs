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
using Client;

namespace CargoFlow_Client_App
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            panel2.Hide();
            guna2Panel1.Hide();
        }

        private void guna2GradientButton10_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

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

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Hide();
            panel2.Show();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-I99KH2H2\SQLEXPRESS01;Initial Catalog=Credentials;Integrated Security=True;");
                SqlCommand cmd = new SqlCommand("select * from Client_Details where Uname = @Uname and Password = @Password", conn);
                cmd.Parameters.AddWithValue("@Uname", tbusername.Text);
                cmd.Parameters.AddWithValue("@Password", tbpassword.Text);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    //MessageBox.Show("Login Succesfully");
                    Home_Page hm = new Home_Page();
                    //Home_Page hm = new Home_Page();
                    hm.uname = tbusername.Text;
                    hm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Crenditals","Alert Credentials",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void showbtn_Click(object sender, EventArgs e)
        {
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
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-I99KH2H2\SQLEXPRESS01;Initial Catalog=Credentials;Integrated Security=True;");
                SqlCommand cmd = new SqlCommand("select Uname from Client_Details where Uname = @Uname", conn);
                cmd.Parameters.AddWithValue("@Uname", tb_gmail.Text);
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
                String query = $"UPDATE Client_Details SET Password = '{txtpass.Text}' WHERE Uname = '{show_label.Text}'";
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

        private void guna2GradientButton7_Click(object sender, EventArgs e)
        {
            Client_Registration cf = new Client_Registration();
            cf.Show();
            this.Close();
        }
    }
}
