using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Driver_Application
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
            webView21.CoreWebView2.Navigate("https://www.google.com/maps");


        }

        private void guna2GradientButton7_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
