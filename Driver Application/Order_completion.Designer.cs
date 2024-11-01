namespace Driver_Application
{
    partial class Order_completion
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
            this.txt_dstatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_did = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_transid = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_drmob = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_dname = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_orderid = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_delidate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txt_ppdate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_gtype = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_dstate = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_sstate = new Guna.UI2.WinForms.Guna2TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_ordername = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton3 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_ostatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SuspendLayout();
            // 
            // txt_dstatus
            // 
            this.txt_dstatus.BackColor = System.Drawing.Color.Transparent;
            this.txt_dstatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txt_dstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_dstatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_dstatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_dstatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_dstatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txt_dstatus.ItemHeight = 30;
            this.txt_dstatus.Items.AddRange(new object[] {
            "Fresh",
            "Assign",
            "Reassign",
            "Not Avaliable"});
            this.txt_dstatus.Location = new System.Drawing.Point(611, 509);
            this.txt_dstatus.Name = "txt_dstatus";
            this.txt_dstatus.Size = new System.Drawing.Size(211, 36);
            this.txt_dstatus.TabIndex = 89;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(337, 509);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(257, 31);
            this.label8.TabIndex = 88;
            this.label8.Text = "Driver Current Status: -";
            // 
            // txt_did
            // 
            this.txt_did.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_did.DefaultText = "";
            this.txt_did.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_did.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_did.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_did.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_did.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_did.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_did.ForeColor = System.Drawing.Color.Black;
            this.txt_did.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_did.Location = new System.Drawing.Point(611, 268);
            this.txt_did.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_did.Name = "txt_did";
            this.txt_did.PasswordChar = '\0';
            this.txt_did.PlaceholderText = "";
            this.txt_did.ReadOnly = true;
            this.txt_did.SelectedText = "";
            this.txt_did.Size = new System.Drawing.Size(229, 31);
            this.txt_did.TabIndex = 87;
            // 
            // txt_transid
            // 
            this.txt_transid.BackColor = System.Drawing.Color.Transparent;
            this.txt_transid.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txt_transid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_transid.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_transid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_transid.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_transid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txt_transid.ItemHeight = 30;
            this.txt_transid.Location = new System.Drawing.Point(935, 147);
            this.txt_transid.Name = "txt_transid";
            this.txt_transid.Size = new System.Drawing.Size(211, 36);
            this.txt_transid.TabIndex = 86;
            this.txt_transid.SelectedIndexChanged += new System.EventHandler(this.txt_transid_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(693, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 31);
            this.label1.TabIndex = 85;
            this.label1.Text = "Transaction ID: -";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(337, 429);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 31);
            this.label3.TabIndex = 84;
            this.label3.Text = "Driver Mobile: -";
            // 
            // txt_drmob
            // 
            this.txt_drmob.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_drmob.DefaultText = "";
            this.txt_drmob.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_drmob.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_drmob.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_drmob.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_drmob.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_drmob.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_drmob.ForeColor = System.Drawing.Color.Black;
            this.txt_drmob.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_drmob.Location = new System.Drawing.Point(611, 429);
            this.txt_drmob.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_drmob.Name = "txt_drmob";
            this.txt_drmob.PasswordChar = '\0';
            this.txt_drmob.PlaceholderText = "";
            this.txt_drmob.ReadOnly = true;
            this.txt_drmob.SelectedText = "";
            this.txt_drmob.Size = new System.Drawing.Size(194, 31);
            this.txt_drmob.TabIndex = 83;
            // 
            // txt_dname
            // 
            this.txt_dname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_dname.DefaultText = "";
            this.txt_dname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_dname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_dname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_dname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_dname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_dname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_dname.ForeColor = System.Drawing.Color.Black;
            this.txt_dname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_dname.Location = new System.Drawing.Point(611, 347);
            this.txt_dname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_dname.Name = "txt_dname";
            this.txt_dname.PasswordChar = '\0';
            this.txt_dname.PlaceholderText = "";
            this.txt_dname.ReadOnly = true;
            this.txt_dname.SelectedText = "";
            this.txt_dname.Size = new System.Drawing.Size(294, 31);
            this.txt_dname.TabIndex = 82;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(337, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 31);
            this.label6.TabIndex = 81;
            this.label6.Text = "Driver Name: -";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(337, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 31);
            this.label2.TabIndex = 80;
            this.label2.Text = "Driver ID: -";
            // 
            // txt_orderid
            // 
            this.txt_orderid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_orderid.DefaultText = "";
            this.txt_orderid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_orderid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_orderid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_orderid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_orderid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_orderid.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_orderid.ForeColor = System.Drawing.Color.Black;
            this.txt_orderid.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_orderid.Location = new System.Drawing.Point(1229, 268);
            this.txt_orderid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_orderid.Name = "txt_orderid";
            this.txt_orderid.PasswordChar = '\0';
            this.txt_orderid.PlaceholderText = "";
            this.txt_orderid.ReadOnly = true;
            this.txt_orderid.SelectedText = "";
            this.txt_orderid.Size = new System.Drawing.Size(235, 30);
            this.txt_orderid.TabIndex = 103;
            // 
            // txt_delidate
            // 
            this.txt_delidate.Checked = true;
            this.txt_delidate.FillColor = System.Drawing.Color.White;
            this.txt_delidate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_delidate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txt_delidate.Location = new System.Drawing.Point(611, 666);
            this.txt_delidate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txt_delidate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txt_delidate.Name = "txt_delidate";
            this.txt_delidate.Size = new System.Drawing.Size(200, 36);
            this.txt_delidate.TabIndex = 102;
            this.txt_delidate.Value = new System.DateTime(2024, 2, 9, 18, 51, 2, 995);
            // 
            // txt_ppdate
            // 
            this.txt_ppdate.Checked = true;
            this.txt_ppdate.FillColor = System.Drawing.Color.White;
            this.txt_ppdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_ppdate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txt_ppdate.Location = new System.Drawing.Point(611, 590);
            this.txt_ppdate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txt_ppdate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txt_ppdate.Name = "txt_ppdate";
            this.txt_ppdate.Size = new System.Drawing.Size(200, 36);
            this.txt_ppdate.TabIndex = 101;
            this.txt_ppdate.Value = new System.DateTime(2024, 2, 9, 18, 51, 2, 995);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(337, 666);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 31);
            this.label9.TabIndex = 100;
            this.label9.Text = "Delivery Date: -";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(337, 595);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(160, 31);
            this.label11.TabIndex = 99;
            this.label11.Text = "Pickup Date: -";
            // 
            // txt_gtype
            // 
            this.txt_gtype.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_gtype.DefaultText = "";
            this.txt_gtype.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_gtype.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_gtype.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_gtype.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_gtype.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_gtype.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_gtype.ForeColor = System.Drawing.Color.Black;
            this.txt_gtype.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_gtype.Location = new System.Drawing.Point(1229, 590);
            this.txt_gtype.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_gtype.Name = "txt_gtype";
            this.txt_gtype.PasswordChar = '\0';
            this.txt_gtype.PlaceholderText = "";
            this.txt_gtype.ReadOnly = true;
            this.txt_gtype.SelectedText = "";
            this.txt_gtype.Size = new System.Drawing.Size(235, 31);
            this.txt_gtype.TabIndex = 98;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1047, 590);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 31);
            this.label7.TabIndex = 97;
            this.label7.Text = "Goods Type : -";
            // 
            // txt_dstate
            // 
            this.txt_dstate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_dstate.DefaultText = "";
            this.txt_dstate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_dstate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_dstate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_dstate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_dstate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_dstate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_dstate.ForeColor = System.Drawing.Color.Black;
            this.txt_dstate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_dstate.Location = new System.Drawing.Point(1229, 509);
            this.txt_dstate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_dstate.Name = "txt_dstate";
            this.txt_dstate.PasswordChar = '\0';
            this.txt_dstate.PlaceholderText = "";
            this.txt_dstate.ReadOnly = true;
            this.txt_dstate.SelectedText = "";
            this.txt_dstate.Size = new System.Drawing.Size(194, 31);
            this.txt_dstate.TabIndex = 96;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1000, 509);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(212, 31);
            this.label10.TabIndex = 95;
            this.label10.Text = "Destination State: -";
            // 
            // txt_sstate
            // 
            this.txt_sstate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_sstate.DefaultText = "";
            this.txt_sstate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_sstate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_sstate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_sstate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_sstate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_sstate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_sstate.ForeColor = System.Drawing.Color.Black;
            this.txt_sstate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_sstate.Location = new System.Drawing.Point(1229, 429);
            this.txt_sstate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_sstate.Name = "txt_sstate";
            this.txt_sstate.PasswordChar = '\0';
            this.txt_sstate.PlaceholderText = "";
            this.txt_sstate.ReadOnly = true;
            this.txt_sstate.SelectedText = "";
            this.txt_sstate.Size = new System.Drawing.Size(194, 31);
            this.txt_sstate.TabIndex = 94;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1049, 429);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(163, 31);
            this.label12.TabIndex = 93;
            this.label12.Text = "Source State: -";
            // 
            // txt_ordername
            // 
            this.txt_ordername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ordername.DefaultText = "";
            this.txt_ordername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_ordername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_ordername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_ordername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_ordername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ordername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_ordername.ForeColor = System.Drawing.Color.Black;
            this.txt_ordername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ordername.Location = new System.Drawing.Point(1229, 347);
            this.txt_ordername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_ordername.Name = "txt_ordername";
            this.txt_ordername.PasswordChar = '\0';
            this.txt_ordername.PlaceholderText = "";
            this.txt_ordername.ReadOnly = true;
            this.txt_ordername.SelectedText = "";
            this.txt_ordername.Size = new System.Drawing.Size(294, 31);
            this.txt_ordername.TabIndex = 92;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(953, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(259, 31);
            this.label4.TabIndex = 91;
            this.label4.Text = "Order Booking Name : -";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1079, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 31);
            this.label5.TabIndex = 90;
            this.label5.Text = "Order ID : -";
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.BorderRadius = 25;
            this.guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.Location = new System.Drawing.Point(841, 764);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.Size = new System.Drawing.Size(264, 70);
            this.guna2GradientButton1.TabIndex = 104;
            this.guna2GradientButton1.Text = "Completed";
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // guna2GradientButton3
            // 
            this.guna2GradientButton3.BorderRadius = 20;
            this.guna2GradientButton3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton3.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.guna2GradientButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton3.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton3.Location = new System.Drawing.Point(37, 45);
            this.guna2GradientButton3.Name = "guna2GradientButton3";
            this.guna2GradientButton3.Size = new System.Drawing.Size(180, 45);
            this.guna2GradientButton3.TabIndex = 105;
            this.guna2GradientButton3.Text = "Back To Dashboard";
            this.guna2GradientButton3.Click += new System.EventHandler(this.guna2GradientButton3_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Palatino Linotype", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(729, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(376, 58);
            this.label13.TabIndex = 106;
            this.label13.Text = "Order Completion";
            // 
            // txt_ostatus
            // 
            this.txt_ostatus.BackColor = System.Drawing.Color.Transparent;
            this.txt_ostatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txt_ostatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_ostatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ostatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ostatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_ostatus.ForeColor = System.Drawing.Color.Black;
            this.txt_ostatus.ItemHeight = 30;
            this.txt_ostatus.Items.AddRange(new object[] {
            "Active",
            "Inactive",
            "Completed"});
            this.txt_ostatus.Location = new System.Drawing.Point(1229, 661);
            this.txt_ostatus.Name = "txt_ostatus";
            this.txt_ostatus.Size = new System.Drawing.Size(194, 36);
            this.txt_ostatus.TabIndex = 108;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1071, 666);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 31);
            this.label14.TabIndex = 107;
            this.label14.Text = "Status : -";
            // 
            // guna2GradientButton2
            // 
            this.guna2GradientButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton2.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton2.Location = new System.Drawing.Point(328, 822);
            this.guna2GradientButton2.Name = "guna2GradientButton2";
            this.guna2GradientButton2.Size = new System.Drawing.Size(180, 45);
            this.guna2GradientButton2.TabIndex = 109;
            this.guna2GradientButton2.Text = "guna2GradientButton2";
            this.guna2GradientButton2.Click += new System.EventHandler(this.guna2GradientButton2_Click);
            // 
            // Order_completion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.guna2GradientButton2);
            this.Controls.Add(this.txt_ostatus);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.guna2GradientButton3);
            this.Controls.Add(this.guna2GradientButton1);
            this.Controls.Add(this.txt_orderid);
            this.Controls.Add(this.txt_delidate);
            this.Controls.Add(this.txt_ppdate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_gtype);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_dstate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_sstate);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_ordername);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_dstatus);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_did);
            this.Controls.Add(this.txt_transid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_drmob);
            this.Controls.Add(this.txt_dname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Name = "Order_completion";
            this.Text = "Order_completion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Order_completion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox txt_dstatus;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txt_did;
        private Guna.UI2.WinForms.Guna2ComboBox txt_transid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txt_drmob;
        private Guna.UI2.WinForms.Guna2TextBox txt_dname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txt_orderid;
        private Guna.UI2.WinForms.Guna2DateTimePicker txt_delidate;
        private Guna.UI2.WinForms.Guna2DateTimePicker txt_ppdate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2TextBox txt_gtype;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txt_dstate;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox txt_sstate;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2TextBox txt_ordername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton3;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2ComboBox txt_ostatus;
        private System.Windows.Forms.Label label14;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton2;
    }
}