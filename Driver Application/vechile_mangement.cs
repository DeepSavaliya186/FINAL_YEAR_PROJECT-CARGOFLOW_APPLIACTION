using Driver_Application.Properties;
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

namespace Driver_Application
{
    public partial class vechile_mangement : Form
    {
        public vechile_mangement()
        {
            InitializeComponent();
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();

            dialog = MessageBox.Show("Thank You!\nDo you want to close?", "Visit Again!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void vechile_mangement_Load(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Hide();
            cc();
        }

        private void guna2GradientButton7_Click(object sender, EventArgs e)
        {
            

            panel1.Show();
            panel1.BringToFront();

            panel2.Hide();
        }

        SqlConnection connection = new SqlConnection("Data Source=LAPTOP-I99KH2H2\\SQLEXPRESS01;Initial Catalog=Credentials;Integrated Security=True;");
        string imgLocation = "";
        SqlCommand cmd;


        private void btnBI_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                pictureBox1.ImageLocation = imgLocation;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] images = null;
                FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(stream);
                images = brs.ReadBytes((int)stream.Length);

                connection.Open();
                string sqlQuery = "Insert into Vechile_Details(vechile_no,vechile_type,vechile_name,vechile_ins,vechile_chass,vechile_Eng_no,v_image,vechile_status) values ('" + vNo.Text + "','" + vType.Text + "','" + vName.Text + "','" + vInsurance.Text + "','" + vChassisNo.Text + "','" + vEngineNo.Text + "',@images,'"+vStatus.Text+"')";
                cmd = new SqlCommand(sqlQuery, connection);
                cmd.Parameters.Add(new SqlParameter("@images", images));
                int n = cmd.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show(n.ToString() + "Data saved.........");
                vNo.Clear();
                vName.Clear();
                vType.Clear();
                vInsurance.Clear();
                vChassisNo.Clear();
                vEngineNo.Clear();
                vNo.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            

            panel2.Show();
            panel2.BringToFront();

            panel1.Hide();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "Select vechile_no,vechile_type,vechile_name,vechile_ins,vechile_chass,vechile_Eng_no,v_image,vechile_status from Vechile_Details where vechile_ID = '" + txtvid.Text + "'";
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                    cmd = new SqlCommand(sql, connection);

                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();

                    if (reader.HasRows)
                    {
                        txtvno.Text = reader[0].ToString();
                        txtvtype.Text = reader[1].ToString();
                        txtvname.Text = reader[2].ToString();
                        txtinsaruance.Text = reader[3].ToString();
                        txtchassis.Text = reader[4].ToString();
                        txtengine.Text = reader[5].ToString();
                        
                        byte[] img = (byte[])(reader[6]);

                        if (img == null)
                        {
                            pictureBox1.Image = null;
                        }
                        else
                        {
                            var stream = new MemoryStream(img);
                            pictureBox2.Image = Image.FromStream(stream);
                        }
                        status.Text = reader[7].ToString();
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

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            Dashboard db = new Dashboard();

            db.Show();
            this.Hide();
        }

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-I99KH2H2\SQLEXPRESS01;Initial Catalog=Credentials;Integrated Security=True;");
        private void cc()
        {
            // String mm = "Yes";
            txtvid.Items.Clear();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select vechile_ID from Vechile_Details";
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

        private void guna2GradientButton8_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con;
                string constring = @"Data Source=LAPTOP-I99KH2H2\SQLEXPRESS01;Initial Catalog=Credentials;Integrated Security=True;";
                con = new SqlConnection(constring);
                con.Open();

                String query = $"Update Vechile_Details SET vechile_type = '{vType.Text}',vechile_name = '{vName.Text}',vechile_ins = '{vInsurance.Text}',vechile_chass = '{vChassisNo.Text}',vechile_Eng_no = '{vEngineNo.Text}',vechile_status = '{vStatus.Text}' where vechile_no = '{vNo.Text}'";

                SqlCommand com;

                com = new SqlCommand(query, con);
                com.ExecuteNonQuery();
                MessageBox.Show("Data Update Successfully");


                con.Close();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            vechile_mangement gh = new vechile_mangement();
            gh.Show();
            this.Hide();
        }

        private void guna2GradientButton9_Click(object sender, EventArgs e)
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


            e.Graphics.DrawString("TRUCK DETAILS", new Font("Palatino Linotype", 30, FontStyle.Bold), Brushes.Black, new Point(250, 180));
            e.Graphics.DrawString("Cargo Flow", new Font("Palatino Linotype", 30, FontStyle.Bold), Brushes.Black, new Point(290, 220));
            e.Graphics.DrawImage(pictureBox2.Image, 220, 300, 400, 350);
            e.Graphics.DrawString("Vechile ID :- " + txtvid.Text, new Font("Palatino Linotype", 15, FontStyle.Regular), Brushes.Black, new Point(100, 650));
            e.Graphics.DrawString("Vechile No   :- " + txtvno.Text, new Font("Palatino Linotype", 15, FontStyle.Regular), Brushes.Black, new Point(100, 690));
            e.Graphics.DrawString("Vechile Name   :- " + txtvname.Text, new Font("Palatino Linotype", 15, FontStyle.Regular), Brushes.Black, new Point(100, 730));
            e.Graphics.DrawString("Vechile Type   :- " + txtvtype.Text, new Font("Palatino Linotype", 15, FontStyle.Regular), Brushes.Black, new Point(100, 770));
            e.Graphics.DrawString("Vechile Insaurance   :- " + txtinsaruance.Text, new Font("Palatino Linotype", 15, FontStyle.Regular), Brushes.Black, new Point(100, 810));
            e.Graphics.DrawString("Vechile Chassis No.   :- " + txtchassis.Text, new Font("Palatino Linotype", 15, FontStyle.Regular), Brushes.Black, new Point(100, 850));
            e.Graphics.DrawString("Vechile Engine No.   :- " + txtengine.Text, new Font("Palatino Linotype", 15, FontStyle.Regular), Brushes.Black, new Point(100, 890));
            e.Graphics.DrawString("Vechile Status   :- " + status.Text, new Font("Palatino Linotype", 15, FontStyle.Regular), Brushes.Black, new Point(100, 930));


            e.Graphics.DrawString("Date : - " + DateTime.Now, new Font("Calibri", 15, FontStyle.Bold), Brushes.Black, new Point(280, 280));
           
            e.Graphics.DrawString("This document for use only authorized person.", new Font("Monotype Corsiva", 15, FontStyle.Regular), Brushes.Black, new Point(100, 970));
            e.Graphics.DrawString("Designed By Application Team", new Font("Calibri", 11, FontStyle.Bold), Brushes.Black, new Point(100, 1000));
        }
    }
}
