using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel_management_nhom5
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            // Bỏ dấu chấm phẩy và thêm code xử lý
            if (txtUsername.Text == "admin" && txtPassword.Text == "123456")
            {
                // Đăng nhập thành công
                MessageBox.Show("Đăng nhập thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Mở Form chính
              Dashboard mainForm = new Dashboard();
                mainForm.Show();

                // Ẩn form login
                this.Hide();
            }
            else
            {
                // Đăng nhập thất bại
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Clear password và focus lại username
                txtPassword.Clear();
                txtUsername.Focus();
            }
        }
    }
}