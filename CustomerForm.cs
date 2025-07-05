using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using hotel_management_nhom5.Models;
using hotel_management_nhom5.Repositories.Implementations;
using hotel_management_nhom5.Repositories.Interfaces;

namespace hotel_management_nhom5
{
    public partial class CustomerForm : Form
    {
        private readonly ICustomerRepository _custRepo = new CustomerRepository();
        private readonly IBookingRepository _resRepo = new BookingRepository();

        public CustomerForm()
        {
            InitializeComponent();

            dgvCustomers.AutoGenerateColumns = false;
            InitializeGrid();
        }

        private void InitializeGrid()
        {
            dgvCustomers.Columns.Clear();

            dgvCustomers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Booking.RoomNumber),
                HeaderText = "Phòng",
                Width = 60
            });
            dgvCustomers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Booking.GuestName),
                HeaderText = "Khách",
                Width = 120
            });
            dgvCustomers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Booking.CheckInOut),
                HeaderText = "Từ → Đến",
                Width = 180
            });
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var idNum = txtSearchId.Text.Trim();
            if (string.IsNullOrEmpty(idNum))
            {
                MessageBox.Show("Vui lòng nhập CCCD để tìm.", "Chú ý",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var cust = _custRepo.GetByIdentity(idNum);
            if (cust == null)
            {
                MessageBox.Show("Không tìm thấy khách.", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvCustomers.DataSource = null;
                return;
            }

            var bookings = _resRepo.GetByCustomer(cust.CustomerId).ToList();
            if (!bookings.Any())
            {
                MessageBox.Show("Khách chưa có đặt phòng nào.", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvCustomers.DataSource = null;
                return;
            }

            dgvCustomers.DataSource = new BindingList<Booking>(bookings);
        }
    }
}
