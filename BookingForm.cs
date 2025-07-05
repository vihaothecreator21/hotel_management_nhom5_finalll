using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using hotel_management_nhom5.Data;
using hotel_management_nhom5.Models;
using hotel_management_nhom5.Repositories.Implementations;
using hotel_management_nhom5.Properties;

namespace hotel_management_nhom5
{
    public partial class BookingForm : Form
    {
        private readonly CustomerRepository _custRepo = new CustomerRepository();
        private readonly BookingRepository _resRepo = new BookingRepository();
        private readonly RoomRepository _roomRepo = new RoomRepository();

        private Room _selectedRoom;

        public BookingForm()
        {
            InitializeComponent();
            dtpCheckIn.Format = DateTimePickerFormat.Long;
            dtpCheckOut.Format = DateTimePickerFormat.Long;
            this.Load += BookingForm_Load;
        }

        private void BookingForm_Load(object sender, EventArgs e)
        {
            RefreshRoomStatuses();
            LoadRooms();
            // Đảm bảo sự kiện chỉ đăng ký một lần
            btnSubmit.Click -= btnSubmit_Click;
            btnSubmit.Click += btnSubmit_Click;
        }

        private void RefreshRoomStatuses()
        {
            var today = DateTime.Today;
            using (var ctx = new AppDbContext())
            {
                foreach (var room in _roomRepo.GetAll())
                {
                    bool isBooked = ctx.Bookings
                                      .Any(b => b.RoomId == room.RoomId
                                             && b.CheckOut > today);
                    var status = isBooked ? "Booked" : "Available";
                    if (room.Status != status)
                        _roomRepo.ChangeStatus(room.RoomId, status);
                }
            }
        }

        private void LoadRooms()
        {
            flowLayoutPanelRooms.SuspendLayout();
            flowLayoutPanelRooms.Controls.Clear();

            foreach (var room in _roomRepo.GetAll().OrderBy(r => r.RoomNumber))
            {
                var panel = new Guna.UI2.WinForms.Guna2Panel
                {
                    Width = 200,
                    Height = 240,
                    Margin = new Padding(8),
                    Padding = new Padding(0),
                    BorderRadius = 8,
                    BorderThickness = 1,
                    BorderColor = Color.Silver,
                    FillColor = Color.White,
                    Tag = room
                };

                // ảnh
                var pic = new Guna.UI2.WinForms.Guna2PictureBox
                {
                    Dock = DockStyle.Top,
                    Height = 140,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Tag = room
                };
                var img = Resources.room_image;
                if (!string.IsNullOrEmpty(room.ImageKey))
                {
                    var o = Resources.ResourceManager.GetObject(room.ImageKey);
                    if (o is Image i) img = (Bitmap)i;
                }
                pic.Image = img;
                pic.Click += Room_Click;
                panel.Controls.Add(pic);

                // số phòng
                var lblNum = new Label
                {
                    Text = "Room " + room.RoomNumber,
                    Dock = DockStyle.Top,
                    Height = 24,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    Tag = room
                };
                lblNum.Click += Room_Click;
                panel.Controls.Add(lblNum);

                // trạng thái
                var lblStatus = new Label
                {
                    Text = room.Status,
                    Dock = DockStyle.Top,
                    Height = 20,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Segoe UI", 9),
                    ForeColor = room.Status == "Available"
                               ? Color.Green
                               : Color.DarkOrange,
                    Tag = room
                };
                lblStatus.Click += Room_Click;
                panel.Controls.Add(lblStatus);

                flowLayoutPanelRooms.Controls.Add(panel);
            }

            flowLayoutPanelRooms.ResumeLayout();
        }

        private void Room_Click(object sender, EventArgs e)
        {
            // clear highlight
            foreach (Control ctl in flowLayoutPanelRooms.Controls)
                if (ctl is Guna.UI2.WinForms.Guna2Panel p)
                    p.BorderColor = Color.Silver;

            var clicked = (Control)sender;
            while (clicked != null && !(clicked is Guna.UI2.WinForms.Guna2Panel))
                clicked = clicked.Parent;

            if (clicked is Guna.UI2.WinForms.Guna2Panel panel
             && panel.Tag is Room room)
            {
                _selectedRoom = room;
                panel.BorderColor = Color.MediumSeaGreen;
                panel.BorderThickness = 2;

                var pic = panel.Controls
                               .OfType<Guna.UI2.WinForms.Guna2PictureBox>()
                               .FirstOrDefault();
                if (pic != null)
                {
                    pictureRoomIcon.Image = pic.Image;
                    pictureRoomIcon.SizeMode = PictureBoxSizeMode.Zoom;
                }

                lbRoomNumber.Text = room.RoomNumber;
                bRoomType.Text = room.Type;
                lbRoomStatus.Text = room.Status;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (_selectedRoom == null)
            {
                MessageBox.Show("Chọn phòng trước.", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var idCard = txtIdentity.Text.Trim();
            var name = txtName.Text.Trim();
            var phone = txtPhone.Text.Trim();
            if (string.IsNullOrEmpty(idCard)
             || string.IsNullOrEmpty(name)
             || string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Nhập đủ thông tin khách.", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var inDate = dtpCheckIn.Value.Date;
            var outDate = dtpCheckOut.Value.Date;
            if (outDate <= inDate)
            {
                MessageBox.Show("Check-out phải sau check-in.", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // lấy hoặc tạo Customer
            var cust = _custRepo.GetByIdentity(idCard)
                       ?? new Customer
                       {
                           FullName = name,
                           IdentityCard = idCard,
                           Phone = phone,
                           CreatedAt = DateTime.Now
                       };
            if (cust.CustomerId == 0)
                _custRepo.Add(cust);

            // tạo booking (chỉ gán CheckIn/CheckOut, model sẽ tự tính Nights & TotalPrice)
            var booking = new Booking
            {
                CustomerId = cust.CustomerId,
                RoomId = _selectedRoom.RoomId,
                CheckIn = inDate,
                CheckOut = outDate,
                BookingDate = DateTime.Now,
                Status = BookingStatus.Booked
            };
            _resRepo.Add(booking);

            // cập nhật trạng thái phòng
            _roomRepo.ChangeStatus(_selectedRoom.RoomId, "Booked");
            lbRoomStatus.Text = "Booked";

            MessageBox.Show($"Đặt phòng {_selectedRoom.RoomNumber} thành công.",
                            "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
