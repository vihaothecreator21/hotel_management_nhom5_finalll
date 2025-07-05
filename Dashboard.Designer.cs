using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using System;

namespace hotel_management_nhom5
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnCustomers = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel20 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel19 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnCheckOut = new Guna.UI2.WinForms.Guna2Button();
            this.roomBtn = new Guna.UI2.WinForms.Guna2Button();
            this.btnBookings = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2CircleButton2 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2CircleButton3 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2CircleButton4 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel6 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel17 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2GradientPanel4 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2HtmlLabel18 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel15 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2GradientPanel3 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2HtmlLabel16 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel13 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2HtmlLabel14 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel12 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2HtmlLabel10 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel11 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel7 = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Panel8 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel32 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel31 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel30 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel29 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ProgressBar4 = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.guna2ProgressBar3 = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.guna2ProgressBar2 = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.guna2ProgressBar1 = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.guna2HtmlLabel28 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel27 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel26 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel25 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2CircleButton6 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2HtmlLabel23 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel24 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Button7 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button6 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel22 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel21 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2CircleButton5 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.guna2Panel5.SuspendLayout();
            this.guna2Panel6.SuspendLayout();
            this.guna2Panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.guna2Panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2Panel1.Controls.Add(this.btnCustomers);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel20);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel19);
            this.guna2Panel1.Controls.Add(this.btnCheckOut);
            this.guna2Panel1.Controls.Add(this.roomBtn);
            this.guna2Panel1.Controls.Add(this.btnBookings);
            this.guna2Panel1.Controls.Add(this.guna2Button1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(209, 779);
            this.guna2Panel1.TabIndex = 0;
            // 
            // btnCustomers
            // 
            this.btnCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCustomers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCustomers.FillColor = System.Drawing.Color.Transparent;
            this.btnCustomers.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnCustomers.ForeColor = System.Drawing.Color.Black;
            this.btnCustomers.Image = global::hotel_management_nhom5.Properties.Resources.icons8_settings_30;
            this.btnCustomers.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCustomers.Location = new System.Drawing.Point(0, 333);
            this.btnCustomers.Margin = new System.Windows.Forms.Padding(4);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(209, 57);
            this.btnCustomers.TabIndex = 12;
            this.btnCustomers.Text = "Customer";
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // guna2HtmlLabel20
            // 
            this.guna2HtmlLabel20.AutoSize = false;
            this.guna2HtmlLabel20.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel20.BackgroundImage = global::hotel_management_nhom5.Properties.Resources.icons8_hotel_50;
            this.guna2HtmlLabel20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.guna2HtmlLabel20.Location = new System.Drawing.Point(0, 0);
            this.guna2HtmlLabel20.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel20.Name = "guna2HtmlLabel20";
            this.guna2HtmlLabel20.Size = new System.Drawing.Size(75, 62);
            this.guna2HtmlLabel20.TabIndex = 11;
            this.guna2HtmlLabel20.Text = null;
            // 
            // guna2HtmlLabel19
            // 
            this.guna2HtmlLabel19.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel19.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel19.Location = new System.Drawing.Point(77, 22);
            this.guna2HtmlLabel19.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel19.Name = "guna2HtmlLabel19";
            this.guna2HtmlLabel19.Size = new System.Drawing.Size(90, 30);
            this.guna2HtmlLabel19.TabIndex = 10;
            this.guna2HtmlLabel19.Text = "Bookings";
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCheckOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCheckOut.FillColor = System.Drawing.Color.Transparent;
            this.btnCheckOut.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnCheckOut.ForeColor = System.Drawing.Color.Black;
            this.btnCheckOut.Image = global::hotel_management_nhom5.Properties.Resources.icons8_settings_30;
            this.btnCheckOut.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCheckOut.Location = new System.Drawing.Point(0, 271);
            this.btnCheckOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(209, 54);
            this.btnCheckOut.TabIndex = 5;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // roomBtn
            // 
            this.roomBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roomBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.roomBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.roomBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.roomBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.roomBtn.FillColor = System.Drawing.Color.Transparent;
            this.roomBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.roomBtn.ForeColor = System.Drawing.Color.Black;
            this.roomBtn.Image = global::hotel_management_nhom5.Properties.Resources.icons8_room_30;
            this.roomBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.roomBtn.Location = new System.Drawing.Point(0, 213);
            this.roomBtn.Margin = new System.Windows.Forms.Padding(4);
            this.roomBtn.Name = "roomBtn";
            this.roomBtn.Size = new System.Drawing.Size(209, 50);
            this.roomBtn.TabIndex = 3;
            this.roomBtn.Text = "Rooms";
            this.roomBtn.Click += new System.EventHandler(this.roomBtn_Click);
            // 
            // btnBookings
            // 
            this.btnBookings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBookings.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBookings.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBookings.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBookings.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBookings.FillColor = System.Drawing.Color.Transparent;
            this.btnBookings.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnBookings.ForeColor = System.Drawing.Color.Black;
            this.btnBookings.Image = global::hotel_management_nhom5.Properties.Resources.icons8_reservation_30;
            this.btnBookings.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBookings.Location = new System.Drawing.Point(0, 148);
            this.btnBookings.Margin = new System.Windows.Forms.Padding(4);
            this.btnBookings.Name = "btnBookings";
            this.btnBookings.Size = new System.Drawing.Size(209, 57);
            this.btnBookings.TabIndex = 2;
            this.btnBookings.Text = "Bookings";
            this.btnBookings.Click += new System.EventHandler(this.btnBookings_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.Image = global::hotel_management_nhom5.Properties.Resources.icons8_dashboard_30;
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.Location = new System.Drawing.Point(0, 84);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(209, 65);
            this.guna2Button1.TabIndex = 1;
            this.guna2Button1.Text = "Dashboard";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.BorderRadius = 10;
            this.guna2Panel2.Controls.Add(this.guna2CircleButton1);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel6);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel2);
            this.guna2Panel2.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Panel2.Location = new System.Drawing.Point(244, 84);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(216, 113);
            this.guna2Panel2.TabIndex = 1;
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.Image = global::hotel_management_nhom5.Properties.Resources.icons8_booking_30;
            this.guna2CircleButton1.Location = new System.Drawing.Point(151, 11);
            this.guna2CircleButton1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.Size = new System.Drawing.Size(47, 43);
            this.guna2CircleButton1.TabIndex = 5;
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(13, 37);
            this.guna2HtmlLabel6.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(33, 38);
            this.guna2HtmlLabel6.TabIndex = 4;
            this.guna2HtmlLabel6.Text = "15";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(13, 12);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(93, 21);
            this.guna2HtmlLabel2.TabIndex = 4;
            this.guna2HtmlLabel2.Text = "New Bookings";
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel3.BorderRadius = 10;
            this.guna2Panel3.Controls.Add(this.guna2CircleButton2);
            this.guna2Panel3.Controls.Add(this.guna2HtmlLabel7);
            this.guna2Panel3.Controls.Add(this.guna2HtmlLabel3);
            this.guna2Panel3.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Panel3.Location = new System.Drawing.Point(488, 84);
            this.guna2Panel3.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(216, 113);
            this.guna2Panel3.TabIndex = 2;
            // 
            // guna2CircleButton2
            // 
            this.guna2CircleButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton2.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton2.Image = global::hotel_management_nhom5.Properties.Resources.icons8_check_in_30;
            this.guna2CircleButton2.Location = new System.Drawing.Point(151, 11);
            this.guna2CircleButton2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2CircleButton2.Name = "guna2CircleButton2";
            this.guna2CircleButton2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton2.Size = new System.Drawing.Size(47, 43);
            this.guna2CircleButton2.TabIndex = 6;
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(21, 37);
            this.guna2HtmlLabel7.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(33, 38);
            this.guna2HtmlLabel7.TabIndex = 5;
            this.guna2HtmlLabel7.Text = "20";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(21, 12);
            this.guna2HtmlLabel3.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(59, 21);
            this.guna2HtmlLabel3.TabIndex = 5;
            this.guna2HtmlLabel3.Text = "Check-In";
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel4.BorderRadius = 10;
            this.guna2Panel4.Controls.Add(this.guna2CircleButton3);
            this.guna2Panel4.Controls.Add(this.guna2HtmlLabel8);
            this.guna2Panel4.Controls.Add(this.guna2HtmlLabel4);
            this.guna2Panel4.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Panel4.Location = new System.Drawing.Point(740, 84);
            this.guna2Panel4.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(216, 113);
            this.guna2Panel4.TabIndex = 2;
            // 
            // guna2CircleButton3
            // 
            this.guna2CircleButton3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton3.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton3.Image = global::hotel_management_nhom5.Properties.Resources.icons8_check_out_30;
            this.guna2CircleButton3.Location = new System.Drawing.Point(148, 11);
            this.guna2CircleButton3.Margin = new System.Windows.Forms.Padding(4);
            this.guna2CircleButton3.Name = "guna2CircleButton3";
            this.guna2CircleButton3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton3.Size = new System.Drawing.Size(47, 43);
            this.guna2CircleButton3.TabIndex = 7;
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(19, 37);
            this.guna2HtmlLabel8.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(33, 38);
            this.guna2HtmlLabel8.TabIndex = 6;
            this.guna2HtmlLabel8.Text = "25";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(19, 12);
            this.guna2HtmlLabel4.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(71, 21);
            this.guna2HtmlLabel4.TabIndex = 6;
            this.guna2HtmlLabel4.Text = "Check-Out";
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel5.BorderRadius = 10;
            this.guna2Panel5.Controls.Add(this.guna2CircleButton4);
            this.guna2Panel5.Controls.Add(this.guna2HtmlLabel9);
            this.guna2Panel5.Controls.Add(this.guna2HtmlLabel5);
            this.guna2Panel5.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Panel5.Location = new System.Drawing.Point(989, 84);
            this.guna2Panel5.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Size = new System.Drawing.Size(216, 113);
            this.guna2Panel5.TabIndex = 2;
            // 
            // guna2CircleButton4
            // 
            this.guna2CircleButton4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton4.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton4.Image = global::hotel_management_nhom5.Properties.Resources.icons8_revenue_30;
            this.guna2CircleButton4.Location = new System.Drawing.Point(151, 11);
            this.guna2CircleButton4.Margin = new System.Windows.Forms.Padding(4);
            this.guna2CircleButton4.Name = "guna2CircleButton4";
            this.guna2CircleButton4.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton4.Size = new System.Drawing.Size(47, 43);
            this.guna2CircleButton4.TabIndex = 8;
            // 
            // guna2HtmlLabel9
            // 
            this.guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel9.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel9.Location = new System.Drawing.Point(19, 37);
            this.guna2HtmlLabel9.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            this.guna2HtmlLabel9.Size = new System.Drawing.Size(101, 38);
            this.guna2HtmlLabel9.TabIndex = 7;
            this.guna2HtmlLabel9.Text = "30.000đ";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(19, 12);
            this.guna2HtmlLabel5.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(92, 21);
            this.guna2HtmlLabel5.TabIndex = 5;
            this.guna2HtmlLabel5.Text = "Total Revenue";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(244, 12);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(135, 38);
            this.guna2HtmlLabel1.TabIndex = 3;
            this.guna2HtmlLabel1.Text = "Dashboard";
            // 
            // guna2Panel6
            // 
            this.guna2Panel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel6.BorderRadius = 10;
            this.guna2Panel6.Controls.Add(this.guna2HtmlLabel17);
            this.guna2Panel6.Controls.Add(this.guna2GradientPanel4);
            this.guna2Panel6.Controls.Add(this.guna2HtmlLabel18);
            this.guna2Panel6.Controls.Add(this.guna2HtmlLabel15);
            this.guna2Panel6.Controls.Add(this.guna2GradientPanel3);
            this.guna2Panel6.Controls.Add(this.guna2HtmlLabel16);
            this.guna2Panel6.Controls.Add(this.guna2HtmlLabel13);
            this.guna2Panel6.Controls.Add(this.guna2GradientPanel2);
            this.guna2Panel6.Controls.Add(this.guna2HtmlLabel14);
            this.guna2Panel6.Controls.Add(this.guna2HtmlLabel12);
            this.guna2Panel6.Controls.Add(this.guna2GradientPanel1);
            this.guna2Panel6.Controls.Add(this.guna2HtmlLabel10);
            this.guna2Panel6.Controls.Add(this.guna2HtmlLabel11);
            this.guna2Panel6.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Panel6.Location = new System.Drawing.Point(244, 223);
            this.guna2Panel6.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel6.Name = "guna2Panel6";
            this.guna2Panel6.Size = new System.Drawing.Size(343, 214);
            this.guna2Panel6.TabIndex = 5;
            // 
            // guna2HtmlLabel17
            // 
            this.guna2HtmlLabel17.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel17.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel17.Location = new System.Drawing.Point(151, 138);
            this.guna2HtmlLabel17.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel17.Name = "guna2HtmlLabel17";
            this.guna2HtmlLabel17.Size = new System.Drawing.Size(69, 21);
            this.guna2HtmlLabel17.TabIndex = 15;
            this.guna2HtmlLabel17.Text = "Not Ready";
            // 
            // guna2GradientPanel4
            // 
            this.guna2GradientPanel4.BorderRadius = 5;
            this.guna2GradientPanel4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(33)))), ((int)(((byte)(58)))));
            this.guna2GradientPanel4.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(41)))), ((int)(((byte)(30)))));
            this.guna2GradientPanel4.Location = new System.Drawing.Point(132, 138);
            this.guna2GradientPanel4.Margin = new System.Windows.Forms.Padding(4);
            this.guna2GradientPanel4.Name = "guna2GradientPanel4";
            this.guna2GradientPanel4.Size = new System.Drawing.Size(12, 48);
            this.guna2GradientPanel4.TabIndex = 14;
            // 
            // guna2HtmlLabel18
            // 
            this.guna2HtmlLabel18.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel18.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel18.Location = new System.Drawing.Point(151, 151);
            this.guna2HtmlLabel18.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel18.Name = "guna2HtmlLabel18";
            this.guna2HtmlLabel18.Size = new System.Drawing.Size(33, 38);
            this.guna2HtmlLabel18.TabIndex = 13;
            this.guna2HtmlLabel18.Text = "15";
            // 
            // guna2HtmlLabel15
            // 
            this.guna2HtmlLabel15.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel15.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel15.Location = new System.Drawing.Point(33, 138);
            this.guna2HtmlLabel15.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel15.Name = "guna2HtmlLabel15";
            this.guna2HtmlLabel15.Size = new System.Drawing.Size(63, 21);
            this.guna2HtmlLabel15.TabIndex = 12;
            this.guna2HtmlLabel15.Text = "Occupied";
            // 
            // guna2GradientPanel3
            // 
            this.guna2GradientPanel3.BorderRadius = 5;
            this.guna2GradientPanel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(204)))), ((int)(((byte)(242)))));
            this.guna2GradientPanel3.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(128)))), ((int)(((byte)(237)))));
            this.guna2GradientPanel3.Location = new System.Drawing.Point(13, 138);
            this.guna2GradientPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.guna2GradientPanel3.Name = "guna2GradientPanel3";
            this.guna2GradientPanel3.Size = new System.Drawing.Size(12, 48);
            this.guna2GradientPanel3.TabIndex = 11;
            // 
            // guna2HtmlLabel16
            // 
            this.guna2HtmlLabel16.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel16.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel16.Location = new System.Drawing.Point(33, 151);
            this.guna2HtmlLabel16.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel16.Name = "guna2HtmlLabel16";
            this.guna2HtmlLabel16.Size = new System.Drawing.Size(33, 38);
            this.guna2HtmlLabel16.TabIndex = 10;
            this.guna2HtmlLabel16.Text = "15";
            // 
            // guna2HtmlLabel13
            // 
            this.guna2HtmlLabel13.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel13.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel13.Location = new System.Drawing.Point(151, 62);
            this.guna2HtmlLabel13.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel13.Name = "guna2HtmlLabel13";
            this.guna2HtmlLabel13.Size = new System.Drawing.Size(59, 21);
            this.guna2HtmlLabel13.TabIndex = 9;
            this.guna2HtmlLabel13.Text = "Received";
            // 
            // guna2GradientPanel2
            // 
            this.guna2GradientPanel2.BorderRadius = 5;
            this.guna2GradientPanel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(197)))), ((int)(((byte)(49)))));
            this.guna2GradientPanel2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(167)))));
            this.guna2GradientPanel2.Location = new System.Drawing.Point(132, 62);
            this.guna2GradientPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2GradientPanel2.Name = "guna2GradientPanel2";
            this.guna2GradientPanel2.Size = new System.Drawing.Size(12, 48);
            this.guna2GradientPanel2.TabIndex = 8;
            // 
            // guna2HtmlLabel14
            // 
            this.guna2HtmlLabel14.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel14.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel14.Location = new System.Drawing.Point(151, 75);
            this.guna2HtmlLabel14.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel14.Name = "guna2HtmlLabel14";
            this.guna2HtmlLabel14.Size = new System.Drawing.Size(33, 38);
            this.guna2HtmlLabel14.TabIndex = 7;
            this.guna2HtmlLabel14.Text = "15";
            // 
            // guna2HtmlLabel12
            // 
            this.guna2HtmlLabel12.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel12.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel12.Location = new System.Drawing.Point(33, 62);
            this.guna2HtmlLabel12.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel12.Name = "guna2HtmlLabel12";
            this.guna2HtmlLabel12.Size = new System.Drawing.Size(60, 21);
            this.guna2HtmlLabel12.TabIndex = 6;
            this.guna2HtmlLabel12.Text = "Available";
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BorderRadius = 5;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(153)))), ((int)(((byte)(142)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(239)))), ((int)(((byte)(125)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(13, 62);
            this.guna2GradientPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(12, 48);
            this.guna2GradientPanel1.TabIndex = 5;
            // 
            // guna2HtmlLabel10
            // 
            this.guna2HtmlLabel10.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel10.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel10.Location = new System.Drawing.Point(33, 75);
            this.guna2HtmlLabel10.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel10.Name = "guna2HtmlLabel10";
            this.guna2HtmlLabel10.Size = new System.Drawing.Size(33, 38);
            this.guna2HtmlLabel10.TabIndex = 4;
            this.guna2HtmlLabel10.Text = "15";
            // 
            // guna2HtmlLabel11
            // 
            this.guna2HtmlLabel11.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel11.Location = new System.Drawing.Point(13, 17);
            this.guna2HtmlLabel11.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel11.Name = "guna2HtmlLabel11";
            this.guna2HtmlLabel11.Size = new System.Drawing.Size(140, 23);
            this.guna2HtmlLabel11.TabIndex = 4;
            this.guna2HtmlLabel11.Text = "Room Availability";
            // 
            // guna2Panel7
            // 
            this.guna2Panel7.Controls.Add(this.pictureBox1);
            this.guna2Panel7.Controls.Add(this.guna2Panel8);
            this.guna2Panel7.Controls.Add(this.guna2Button7);
            this.guna2Panel7.Controls.Add(this.guna2Button6);
            this.guna2Panel7.Controls.Add(this.guna2HtmlLabel22);
            this.guna2Panel7.Controls.Add(this.guna2HtmlLabel21);
            this.guna2Panel7.Controls.Add(this.guna2CircleButton5);
            this.guna2Panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2Panel7.Location = new System.Drawing.Point(1210, 0);
            this.guna2Panel7.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel7.Name = "guna2Panel7";
            this.guna2Panel7.Size = new System.Drawing.Size(329, 779);
            this.guna2Panel7.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::hotel_management_nhom5.Properties.Resources.room_image;
            this.pictureBox1.Location = new System.Drawing.Point(7, 84);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(307, 228);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // guna2Panel8
            // 
            this.guna2Panel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel8.BorderRadius = 10;
            this.guna2Panel8.Controls.Add(this.guna2HtmlLabel32);
            this.guna2Panel8.Controls.Add(this.guna2HtmlLabel31);
            this.guna2Panel8.Controls.Add(this.guna2HtmlLabel30);
            this.guna2Panel8.Controls.Add(this.guna2HtmlLabel29);
            this.guna2Panel8.Controls.Add(this.guna2ProgressBar4);
            this.guna2Panel8.Controls.Add(this.guna2ProgressBar3);
            this.guna2Panel8.Controls.Add(this.guna2ProgressBar2);
            this.guna2Panel8.Controls.Add(this.guna2ProgressBar1);
            this.guna2Panel8.Controls.Add(this.guna2HtmlLabel28);
            this.guna2Panel8.Controls.Add(this.guna2HtmlLabel27);
            this.guna2Panel8.Controls.Add(this.guna2HtmlLabel26);
            this.guna2Panel8.Controls.Add(this.guna2HtmlLabel25);
            this.guna2Panel8.Controls.Add(this.guna2CircleButton6);
            this.guna2Panel8.Controls.Add(this.guna2HtmlLabel23);
            this.guna2Panel8.Controls.Add(this.guna2HtmlLabel24);
            this.guna2Panel8.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Panel8.Location = new System.Drawing.Point(7, 319);
            this.guna2Panel8.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel8.Name = "guna2Panel8";
            this.guna2Panel8.Size = new System.Drawing.Size(307, 249);
            this.guna2Panel8.TabIndex = 6;
            // 
            // guna2HtmlLabel32
            // 
            this.guna2HtmlLabel32.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel32.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel32.Location = new System.Drawing.Point(236, 208);
            this.guna2HtmlLabel32.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel32.Name = "guna2HtmlLabel32";
            this.guna2HtmlLabel32.Size = new System.Drawing.Size(24, 22);
            this.guna2HtmlLabel32.TabIndex = 17;
            this.guna2HtmlLabel32.Text = "4.6";
            // 
            // guna2HtmlLabel31
            // 
            this.guna2HtmlLabel31.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel31.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel31.Location = new System.Drawing.Point(236, 172);
            this.guna2HtmlLabel31.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel31.Name = "guna2HtmlLabel31";
            this.guna2HtmlLabel31.Size = new System.Drawing.Size(24, 22);
            this.guna2HtmlLabel31.TabIndex = 16;
            this.guna2HtmlLabel31.Text = "4.6";
            // 
            // guna2HtmlLabel30
            // 
            this.guna2HtmlLabel30.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel30.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel30.Location = new System.Drawing.Point(236, 140);
            this.guna2HtmlLabel30.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel30.Name = "guna2HtmlLabel30";
            this.guna2HtmlLabel30.Size = new System.Drawing.Size(24, 22);
            this.guna2HtmlLabel30.TabIndex = 15;
            this.guna2HtmlLabel30.Text = "4.6";
            // 
            // guna2HtmlLabel29
            // 
            this.guna2HtmlLabel29.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel29.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel29.Location = new System.Drawing.Point(236, 110);
            this.guna2HtmlLabel29.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel29.Name = "guna2HtmlLabel29";
            this.guna2HtmlLabel29.Size = new System.Drawing.Size(24, 22);
            this.guna2HtmlLabel29.TabIndex = 14;
            this.guna2HtmlLabel29.Text = "4.6";
            // 
            // guna2ProgressBar4
            // 
            this.guna2ProgressBar4.Location = new System.Drawing.Point(100, 210);
            this.guna2ProgressBar4.Margin = new System.Windows.Forms.Padding(4);
            this.guna2ProgressBar4.Name = "guna2ProgressBar4";
            this.guna2ProgressBar4.Size = new System.Drawing.Size(124, 12);
            this.guna2ProgressBar4.TabIndex = 13;
            this.guna2ProgressBar4.Text = "guna2ProgressBar4";
            this.guna2ProgressBar4.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // guna2ProgressBar3
            // 
            this.guna2ProgressBar3.Location = new System.Drawing.Point(100, 177);
            this.guna2ProgressBar3.Margin = new System.Windows.Forms.Padding(4);
            this.guna2ProgressBar3.Name = "guna2ProgressBar3";
            this.guna2ProgressBar3.Size = new System.Drawing.Size(124, 11);
            this.guna2ProgressBar3.TabIndex = 12;
            this.guna2ProgressBar3.Text = "guna2ProgressBar3";
            this.guna2ProgressBar3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // guna2ProgressBar2
            // 
            this.guna2ProgressBar2.Location = new System.Drawing.Point(100, 145);
            this.guna2ProgressBar2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2ProgressBar2.Name = "guna2ProgressBar2";
            this.guna2ProgressBar2.Size = new System.Drawing.Size(124, 11);
            this.guna2ProgressBar2.TabIndex = 11;
            this.guna2ProgressBar2.Text = "guna2ProgressBar2";
            this.guna2ProgressBar2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // guna2ProgressBar1
            // 
            this.guna2ProgressBar1.Location = new System.Drawing.Point(100, 112);
            this.guna2ProgressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2ProgressBar1.Name = "guna2ProgressBar1";
            this.guna2ProgressBar1.Size = new System.Drawing.Size(124, 11);
            this.guna2ProgressBar1.TabIndex = 10;
            this.guna2ProgressBar1.Text = "guna2ProgressBar1";
            this.guna2ProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // guna2HtmlLabel28
            // 
            this.guna2HtmlLabel28.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel28.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel28.Location = new System.Drawing.Point(15, 208);
            this.guna2HtmlLabel28.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel28.Name = "guna2HtmlLabel28";
            this.guna2HtmlLabel28.Size = new System.Drawing.Size(55, 21);
            this.guna2HtmlLabel28.TabIndex = 9;
            this.guna2HtmlLabel28.Text = "Comfort";
            // 
            // guna2HtmlLabel27
            // 
            this.guna2HtmlLabel27.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel27.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel27.Location = new System.Drawing.Point(15, 174);
            this.guna2HtmlLabel27.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel27.Name = "guna2HtmlLabel27";
            this.guna2HtmlLabel27.Size = new System.Drawing.Size(54, 21);
            this.guna2HtmlLabel27.TabIndex = 8;
            this.guna2HtmlLabel27.Text = "Services";
            // 
            // guna2HtmlLabel26
            // 
            this.guna2HtmlLabel26.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel26.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel26.Location = new System.Drawing.Point(15, 143);
            this.guna2HtmlLabel26.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel26.Name = "guna2HtmlLabel26";
            this.guna2HtmlLabel26.Size = new System.Drawing.Size(73, 21);
            this.guna2HtmlLabel26.TabIndex = 7;
            this.guna2HtmlLabel26.Text = "Cleanliness";
            // 
            // guna2HtmlLabel25
            // 
            this.guna2HtmlLabel25.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel25.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel25.Location = new System.Drawing.Point(13, 112);
            this.guna2HtmlLabel25.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel25.Name = "guna2HtmlLabel25";
            this.guna2HtmlLabel25.Size = new System.Drawing.Size(58, 21);
            this.guna2HtmlLabel25.TabIndex = 6;
            this.guna2HtmlLabel25.Text = "Facilities";
            // 
            // guna2CircleButton6
            // 
            this.guna2CircleButton6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton6.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton6.Image = global::hotel_management_nhom5.Properties.Resources.icons8_rating_30;
            this.guna2CircleButton6.Location = new System.Drawing.Point(236, 12);
            this.guna2CircleButton6.Margin = new System.Windows.Forms.Padding(4);
            this.guna2CircleButton6.Name = "guna2CircleButton6";
            this.guna2CircleButton6.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton6.Size = new System.Drawing.Size(47, 43);
            this.guna2CircleButton6.TabIndex = 5;
            // 
            // guna2HtmlLabel23
            // 
            this.guna2HtmlLabel23.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.guna2HtmlLabel23.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel23.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.guna2HtmlLabel23.Location = new System.Drawing.Point(25, 42);
            this.guna2HtmlLabel23.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel23.Name = "guna2HtmlLabel23";
            this.guna2HtmlLabel23.Padding = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel23.Size = new System.Drawing.Size(75, 46);
            this.guna2HtmlLabel23.TabIndex = 4;
            this.guna2HtmlLabel23.Text = "4.6/5";
            this.guna2HtmlLabel23.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // guna2HtmlLabel24
            // 
            this.guna2HtmlLabel24.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel24.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel24.Location = new System.Drawing.Point(13, 11);
            this.guna2HtmlLabel24.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel24.Name = "guna2HtmlLabel24";
            this.guna2HtmlLabel24.Size = new System.Drawing.Size(112, 23);
            this.guna2HtmlLabel24.TabIndex = 4;
            this.guna2HtmlLabel24.Text = "Overall Rating";
            // 
            // guna2Button7
            // 
            this.guna2Button7.BorderRadius = 10;
            this.guna2Button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button7.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button7.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button7.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button7.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Button7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button7.ForeColor = System.Drawing.Color.White;
            this.guna2Button7.Image = global::hotel_management_nhom5.Properties.Resources.icons8_exit_30;
            this.guna2Button7.Location = new System.Drawing.Point(260, 22);
            this.guna2Button7.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Button7.Name = "guna2Button7";
            this.guna2Button7.Size = new System.Drawing.Size(51, 44);
            this.guna2Button7.TabIndex = 12;
            this.guna2Button7.Click += new System.EventHandler(this.guna2Button7_Click);
            // 
            // guna2Button6
            // 
            this.guna2Button6.BorderRadius = 10;
            this.guna2Button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button6.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Button6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button6.ForeColor = System.Drawing.Color.White;
            this.guna2Button6.Image = global::hotel_management_nhom5.Properties.Resources.icons8_notification_32;
            this.guna2Button6.Location = new System.Drawing.Point(201, 22);
            this.guna2Button6.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Button6.Name = "guna2Button6";
            this.guna2Button6.Size = new System.Drawing.Size(51, 44);
            this.guna2Button6.TabIndex = 11;
            // 
            // guna2HtmlLabel22
            // 
            this.guna2HtmlLabel22.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel22.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel22.Location = new System.Drawing.Point(75, 43);
            this.guna2HtmlLabel22.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel22.Name = "guna2HtmlLabel22";
            this.guna2HtmlLabel22.Size = new System.Drawing.Size(31, 21);
            this.guna2HtmlLabel22.TabIndex = 7;
            this.guna2HtmlLabel22.Text = "Role";
            // 
            // guna2HtmlLabel21
            // 
            this.guna2HtmlLabel21.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel21.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel21.Location = new System.Drawing.Point(75, 12);
            this.guna2HtmlLabel21.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel21.Name = "guna2HtmlLabel21";
            this.guna2HtmlLabel21.Size = new System.Drawing.Size(100, 27);
            this.guna2HtmlLabel21.TabIndex = 10;
            this.guna2HtmlLabel21.Text = "Dashboard";
            // 
            // guna2CircleButton5
            // 
            this.guna2CircleButton5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton5.FillColor = System.Drawing.Color.Empty;
            this.guna2CircleButton5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton5.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton5.Image = global::hotel_management_nhom5.Properties.Resources.icons8_avatar_45;
            this.guna2CircleButton5.ImageSize = new System.Drawing.Size(50, 50);
            this.guna2CircleButton5.Location = new System.Drawing.Point(4, 12);
            this.guna2CircleButton5.Margin = new System.Windows.Forms.Padding(4);
            this.guna2CircleButton5.Name = "guna2CircleButton5";
            this.guna2CircleButton5.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton5.Size = new System.Drawing.Size(63, 54);
            this.guna2CircleButton5.TabIndex = 9;
            // 
            // chart1
            // 
            chartArea6.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart1.Legends.Add(legend6);
            this.chart1.Location = new System.Drawing.Point(595, 223);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(611, 214);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BorderRadius = 10;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.IconLeft = global::hotel_management_nhom5.Properties.Resources.icons8_search_30;
            this.guna2TextBox1.Location = new System.Drawing.Point(873, 14);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PlaceholderText = "Search for room, guest, book, etc.";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(320, 38);
            this.guna2TextBox1.TabIndex = 8;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1539, 779);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.guna2Panel7);
            this.Controls.Add(this.guna2Panel6);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2Panel5);
            this.Controls.Add(this.guna2Panel4);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            this.guna2Panel5.ResumeLayout(false);
            this.guna2Panel5.PerformLayout();
            this.guna2Panel6.ResumeLayout(false);
            this.guna2Panel6.PerformLayout();
            this.guna2Panel7.ResumeLayout(false);
            this.guna2Panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.guna2Panel8.ResumeLayout(false);
            this.guna2Panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnCheckOut;
        private Guna.UI2.WinForms.Guna2Button roomBtn;
        private Guna.UI2.WinForms.Guna2Button btnBookings;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel10;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel11;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel7;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton2;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton3;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton4;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel12;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel17;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel18;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel15;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel16;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel13;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel14;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel20;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel19;
        private Guna.UI2.WinForms.Guna2Button guna2Button6;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel22;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel21;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton5;
        private Guna.UI2.WinForms.Guna2Button guna2Button7;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel8;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton6;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel23;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel24;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel28;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel27;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel26;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel25;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel32;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel31;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel30;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel29;
        private Guna.UI2.WinForms.Guna2ProgressBar guna2ProgressBar4;
        private Guna.UI2.WinForms.Guna2ProgressBar guna2ProgressBar3;
        private Guna.UI2.WinForms.Guna2ProgressBar guna2ProgressBar2;
        private Guna.UI2.WinForms.Guna2ProgressBar guna2ProgressBar1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnCustomers;
    }
}
