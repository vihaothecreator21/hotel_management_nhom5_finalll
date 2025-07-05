using System;
using System.Linq;
using System.Windows.Forms;
using hotel_management_nhom5.Data;
using hotel_management_nhom5.Models;
using hotel_management_nhom5.Repositories.Implementations;

namespace hotel_management_nhom5
{
    public partial class CheckOutForm : Form
    {
        private readonly CustomerRepository _custRepo = new CustomerRepository();
        private readonly BookingRepository _bookRepo = new BookingRepository();
        private readonly RoomRepository _roomRepo = new RoomRepository();
        private readonly ReviewRepository _reviewRepo = new ReviewRepository();

        // Giữ booking đang xử lý
        private Booking _currentBooking;

        public CheckOutForm()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            var idNum = txtIdentity.Text.Trim();
            if (string.IsNullOrEmpty(idNum))
            {
                MessageBox.Show("Vui lòng nhập CCCD để tìm.", "Chú ý",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 1) Tìm khách
            var cust = _custRepo.GetByIdentity(idNum);
            if (cust == null)
            {
                MessageBox.Show("Không tìm thấy khách.", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInfo();
                return;
            }

            // 2) Lấy booking chưa check-out
            _currentBooking = _bookRepo
                .GetByCustomer(cust.CustomerId)
                .FirstOrDefault(b => b.Status != BookingStatus.CheckedOut);

            if (_currentBooking == null)
            {
                MessageBox.Show("Khách không có booking đang hoạt động.", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInfo();
                return;
            }

            // 3) Hiển thị lên form
            lbRoomNumber.Text = "Room " + _currentBooking.Room.RoomNumber;
            lbTime.Text = $"{_currentBooking.CheckIn:dd/MM/yyyy} → {_currentBooking.CheckOut:dd/MM/yyyy}";
            lbTotalPrice.Text = _currentBooking.TotalPrice.ToString("N0") + " VND";

            // Bật nút check-out
            btnCheckOut.Enabled = true;
        }

      
        private void ClearInfo()
        {
            txtIdentity.Text = "";
            lbRoomNumber.Text = "";
            lbTime.Text = "";
            lbTotalPrice.Text = "";
            ratingStars.Value = 0;
            _currentBooking = null;
            btnCheckOut.Enabled = false;
        }

        private void CheckOutForm_Load(object sender, EventArgs e)
        {
            ClearInfo();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        
        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
              
            if (_currentBooking == null)
            {
                MessageBox.Show("Bạn chưa tìm booking để check out.", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 4) Cập nhật booking status
            _currentBooking.Status = BookingStatus.CheckedOut;
            _bookRepo.Update(_currentBooking);

            // 5) Cập nhật room status → Available
            _roomRepo.ChangeStatus(_currentBooking.RoomId, "Available");

            // 6) Lưu review sao
            var stars = (int)ratingStars.Value; // Guna2RatingStar trả về float
            var review = new Review
            {
                BookingId = _currentBooking.BookingId,
                RoomId = _currentBooking.RoomId,
                Rating = stars,
                Comment = "",  // thêm textbox nếu cần
                CreatedAt = DateTime.Now
            };
            _reviewRepo.Add(review);

            MessageBox.Show("Check-out thành công!\nCảm ơn bạn đã đánh giá.",
                            "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearInfo();
        }

    }
}

