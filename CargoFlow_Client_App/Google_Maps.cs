using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CargoFlow_Client_App
{
    public partial class Google_Maps : Form
    {
        public Google_Maps()
        {
            InitializeComponent();
        }

        private void Google_Maps_Load(object sender, EventArgs e)
        {
            InitBrowser();
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

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Home_Page h1 = new Home_Page();
            h1.Show();
            this.Hide();
        }
    }
}
