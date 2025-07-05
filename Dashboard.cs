using System;
using System.Linq;
using System.Windows.Forms;
using hotel_management_nhom5.Repositories.Implementations;
using hotel_management_nhom5.Models;
using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data.Entity; // Để dùng DbFunctions


namespace hotel_management_nhom5
{
    public partial class Dashboard : Form
    {
        private readonly BookingRepository _bookingRepo = new BookingRepository();
        private readonly RoomRepository _roomRepo = new RoomRepository();
        private readonly ReviewRepository _reviewRepo = new ReviewRepository();
        private Timer refreshTimer;

        public Dashboard()
        {
            InitializeComponent();
            this.FormClosed += (s, e) => Application.Exit();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            LoadDashboardMetrics();

            // Tự động làm mới mỗi 30 giây
            refreshTimer = new Timer();
            refreshTimer.Interval = 30 * 1000;
            refreshTimer.Tick += (s2, e2) => LoadDashboardMetrics();
            refreshTimer.Start();
        }

        private void LoadDashboardMetrics()
        {
            var today = DateTime.Today;

            // Booking chưa lọc
            var allBookings = _bookingRepo.GetAllIncludingCheckOutNull();
            var checkedOutBookings = allBookings.Where(b => b.CheckOut.HasValue).ToList();

            var allRooms = _roomRepo.GetAll().ToList();
            var allReviews = _reviewRepo.GetAll().ToList();

            // 1) Tổng số booking (bao gồm cả chưa CheckOut)
            guna2HtmlLabel6.Text = allBookings.Count.ToString();

            // 2) Check-in hôm nay
            guna2HtmlLabel7.Text = allBookings
                .Count(b => b.CheckIn.Date == today)
                .ToString();

            // 3) Check-out hôm nay
            guna2HtmlLabel8.Text = allBookings
                .Count(b => b.CheckOut?.Date == today)
                .ToString();

            // 4) Tổng doanh thu
            var totalRevenue = checkedOutBookings.Sum(b => b.TotalPrice);
            guna2HtmlLabel9.Text = totalRevenue.ToString("N0") + "đ";

            // 5) Trạng thái phòng
            guna2HtmlLabel10.Text = allRooms.Count(r => r.Status == "Available").ToString();
            guna2HtmlLabel14.Text = allRooms.Count(r => r.Status == "Received").ToString();
            guna2HtmlLabel16.Text = allRooms.Count(r => r.Status == "Occupied").ToString();
            guna2HtmlLabel18.Text = allRooms.Count(r => r.Status == "Not Ready").ToString();

            // 6) Biểu đồ doanh thu 7 ngày gần nhất
            var last7 = Enumerable.Range(0, 7)
                .Select(i => today.AddDays(-6 + i))
                .ToArray();

            var series = chart1.Series["Series1"];
            series.Points.Clear();
            series.ChartType = SeriesChartType.Column;
            series.IsValueShownAsLabel = true;

            var revenueByDay = last7.Select(day => new
            {
                Date = day,
                Revenue = checkedOutBookings
         .Where(b => b.CheckIn.Date == day)
         .Sum(b => b.TotalPrice)
            }).ToList();


            foreach (var item in revenueByDay)
            {
                series.Points.AddXY(item.Date.ToString("dd/MM"), item.Revenue);
            }

            chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
            series.ToolTip = "Ngày #VALX: #VALY đ";

            // 7) Trung bình đánh giá
            double avg = allReviews.Any()
                       ? allReviews.Average(r => r.Rating)
                       : 0.0;

            guna2HtmlLabel23.Text = $"{avg:F1}/5";

            int pct = (int)(avg / 5 * 100);
            guna2ProgressBar1.Value = pct;
            guna2ProgressBar2.Value = pct;
            guna2ProgressBar3.Value = pct;
            guna2ProgressBar4.Value = pct;

            string avgText = avg.ToString("F1");
            guna2HtmlLabel29.Text = avgText;
            guna2HtmlLabel30.Text = avgText;
            guna2HtmlLabel31.Text = avgText;
            guna2HtmlLabel32.Text = avgText;
        }

        private void btnBookings_Click(object sender, EventArgs e)
        {
            var bookingForm = new BookingForm();
            bookingForm.Show();
        }

        private void roomBtn_Click(object sender, EventArgs e)
        {
            var roomForm = new RoomForm();
            roomForm.Show();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            var checkOutForm = new CheckOutForm();
            checkOutForm.Show();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            var customerForm = new CustomerForm();
            customerForm.Show();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
