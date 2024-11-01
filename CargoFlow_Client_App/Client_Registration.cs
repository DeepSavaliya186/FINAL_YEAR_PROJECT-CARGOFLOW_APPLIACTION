using CargoFlow_Client_App;
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
using static System.Runtime.CompilerServices.RuntimeHelpers;
using System.IO;

namespace Client
{
    public partial class Client_Registration : Form
    {
        public Client_Registration()
        {
            InitializeComponent();
        }

        private void Client_Registration_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
           if(guna2CheckBox1.Checked)
            {
                txtHno.Text = txtIno.Text;
                txtSname.Text = txtIsname.Text;
                txtDistrict.Text = txtIdistrict.Text;
                txtCity.Text = txtIcity.Text;
                txtState.Text = txtIstate.Text;
                txtCountry.Text = txtIcountry.Text;
                txtPincode.Text = txtIpincode.Text;
            }
           
        }

        private void guna2CheckBox1_CheckStateChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string Work = txtIno.Text + " " + txtIsname.Text+" "+txtIdistrict.Text+" "+txtIcity.Text+" "+txtIstate.Text+" "+txtIcountry.Text+" "+txtIpincode.Text;
            string Home = txtHno.Text + " " + txtSname.Text + " " + txtDistrict.Text + " " + txtCity.Text + " " + txtState.Text + " " + txtCountry.Text + " " + txtPincode.Text;
            SqlConnection con;
            string constring = @"Data Source=LAPTOP-I99KH2H2\SQLEXPRESS01;Initial Catalog=Credentials;Integrated Security=True;";
            con = new SqlConnection(constring);


            byte[] images = null;
            FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(stream);
            images = brs.ReadBytes((int)stream.Length);



            con.Open();

            String query = $"INSERT INTO Client_Details (CFname , CMname , CLname ,Mobno,PMobno, Email , Uname, WAddress ,Aadhar,HAddress,Password,P_image) VALUES ('{txtFname.Text}','{txtMname.Text}','{txtLname.Text}','{txtMno.Text}','{txtPmno.Text}','{txtEmailid.Text}','{txtPemailid.Text}','{Work}','{txtAadharno.Text}','{Home}','{txtPassword.Text}',@images)";

            SqlCommand com;

            com = new SqlCommand(query, con);
            com.Parameters.Add(new SqlParameter("@images", images));
            com.ExecuteNonQuery();
            MessageBox.Show("Please Relogin Your New Credentials","Alert Credentials!!",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);


            con.Close();
            mailSer();

            Login_Form hy = new Login_Form();
            hy.Show();
            this.Hide();

        }

        private void guna2GradientButton10_Click(object sender, EventArgs e)
        {
            Form1 hj = new Form1();
            hj.Show();
            this.Hide();
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

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Login_Form lg = new Login_Form();
            lg.Show();
            this.Hide();
        }

        private void mailSer()
        {
            string to, from, pass;
            to = txtPemailid.Text;
            from = "cargoflow186@gmail.com";
            pass = "bopa fsbo vlfi eqsn";
            MailMessage message = new MailMessage();
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = "Check The Submitted Details\n Full Name: -"+txtFname.Text+" "+txtMname.Text+" "+txtLname.Text+"";
            message.Subject = "CarGoFlow Register Successfully";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);

            try
            {
                smtp.Send(message);
               MessageBox.Show("Check The Mail For Details Of Form Submitted Data...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        string imgLocation = "";
        private void btnBI_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                pfpicture.ImageLocation = imgLocation;
            }
        }
    }
}
