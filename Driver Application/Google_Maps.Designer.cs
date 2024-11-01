namespace Driver_Application
{
    partial class Google_Maps
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.guna2GradientButton7 = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.SuspendLayout();
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(1, 52);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(1911, 833);
            this.webView21.TabIndex = 0;
            this.webView21.ZoomFactor = 1D;
            // 
            // guna2GradientButton7
            // 
            this.guna2GradientButton7.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton7.BorderRadius = 20;
            this.guna2GradientButton7.BorderThickness = 1;
            this.guna2GradientButton7.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton7.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton7.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton7.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton7.FillColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton7.FillColor2 = System.Drawing.Color.Transparent;
            this.guna2GradientButton7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton7.ForeColor = System.Drawing.Color.Black;
            this.guna2GradientButton7.ImageOffset = new System.Drawing.Point(2, 0);
            this.guna2GradientButton7.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2GradientButton7.Location = new System.Drawing.Point(12, 6);
            this.guna2GradientButton7.Name = "guna2GradientButton7";
            this.guna2GradientButton7.Size = new System.Drawing.Size(317, 40);
            this.guna2GradientButton7.TabIndex = 23;
            this.guna2GradientButton7.Text = "Close Google Maps";
            this.guna2GradientButton7.TextOffset = new System.Drawing.Point(5, 0);
            this.guna2GradientButton7.Click += new System.EventHandler(this.guna2GradientButton7_Click);
            // 
            // Google_Maps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1924, 897);
            this.Controls.Add(this.guna2GradientButton7);
            this.Controls.Add(this.webView21);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Google_Maps";
            this.Text = "Google_Maps";
            this.Load += new System.EventHandler(this.Google_Maps_Load);
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton7;
    }
}