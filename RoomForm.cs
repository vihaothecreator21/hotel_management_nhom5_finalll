using Guna.UI2.WinForms;
using hotel_management_nhom5.Controllers;
using hotel_management_nhom5.Data;
using hotel_management_nhom5.Models;
using hotel_management_nhom5.Repositories.Implementations;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel_management_nhom5
{
    public partial class RoomForm : Form
    {
        private readonly RoomController roomController = new RoomController();
        private string imageKey = "";

        public RoomForm()
        {
            InitializeComponent();
            editBtn.Visible = false;
            saveBtn.Visible = false;
            deleteBtn.Visible = false;
            addNewRoomBtn.Visible = false;
            txtStatus.Visible = false;
        }

        private void RoomForm_Load(object sender, EventArgs e)
        {
            LoadTypeComboBox();
            LoadStatusComboBox();
            LoadRooms();
        }

        private void LoadTypeComboBox()
        {
            using (var db = new AppDbContext())
            {
                var types = db.Rooms
                    .Where(r => !string.IsNullOrEmpty(r.Type))    // loại bỏ null/empty
                    .Select(r => r.Type)
                    .Distinct()
                    .OrderBy(t => t)
                    .ToList();

                cbRoomType.Items.Clear();
                cbRoomType.Items.Add("All");                   // thêm tùy chọn All
                foreach (var type in types)
                    cbRoomType.Items.Add(type);

                cbRoomType.SelectedIndex = 0;                  // mặc định chọn All
            }
        }

        private void LoadStatusComboBox()
        {
            using (var db = new AppDbContext())
            {
                var statuses = db.Rooms
                    .Where(r => !string.IsNullOrEmpty(r.Status))  // loại bỏ null/empty
                    .Select(r => r.Status)
                    .Distinct()
                    .OrderBy(s => s)
                    .ToList();

                cbRoomStatus.Items.Clear();
                cbRoomStatus.Items.Add("All");                // thêm tùy chọn All
                foreach (var s in statuses)
                    cbRoomStatus.Items.Add(s);

                cbRoomStatus.SelectedIndex = 0;               // mặc định chọn All
            }
        }


        public void LoadRooms()
        {
            string selectedType = cbRoomType.SelectedItem?.ToString();
            string selectedStatus = cbRoomStatus.SelectedItem?.ToString();
            string capacityText = txtCapacity.Text.Trim();

            int.TryParse(capacityText, out int capacityFilter); // Nếu sai định dạng thì = 0

            var rooms = roomController.GetRoomList();

            if (!string.IsNullOrEmpty(selectedType) && selectedType != "All")
                rooms = rooms.Where(r => r.Type == selectedType).ToList();

            if (!string.IsNullOrEmpty(selectedStatus) && selectedStatus != "All")
                rooms = rooms.Where(r => r.Status == selectedStatus).ToList();

            if (capacityFilter > 0)
                rooms = rooms.Where(r => r.Capacity == capacityFilter).ToList();

            flowLayoutPanelRooms.Controls.Clear();

            foreach (var room in rooms)
            {
                bool isAvailable = room.Status == "Available";

                Guna2Panel roomPanel = new Guna2Panel
                {
                    Width = 190,
                    Height = 205,
                    //BackColor = isAvailable ? Color.LightGreen : Color.LightCoral,
                    BorderRadius = 10,
                    BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid,
                    Cursor = Cursors.Hand,
                    FillColor = Color.White,
                };

                var resource = Properties.Resources.ResourceManager.GetObject(room.ImageKey);

                Guna2PictureBox picture = new Guna2PictureBox
                {
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    //Dock = DockStyle.Top,
                    Size = new Size(190, 113),
                    Location = new Point(0, 0),
                    BorderRadius = 5,
                };

                if (resource is Image img)
                {
                    picture.Image = img;
                }
                else
                {
                    picture.Image = Properties.Resources.room_image; // fallback if not found
                }


                Label lblNumber = new Label
                {
                    Text = $"Room {room.RoomNumber}",
                    Font = new Font("Segoe UI", 12, FontStyle.Bold),
                    BackColor = Color.White,
                    //Dock = DockStyle.Top,
                    Size = new Size(86, 19),
                    Location = new Point(15, 119),
                    TextAlign = ContentAlignment.MiddleCenter
                };

                Label lblType = new Label
                {
                    Text = room.Type,
                    BackColor = Color.White,
                    //Dock = DockStyle.Top,
                    Size = new Size(65, 19),
                    Location = new Point(15, 144),
                    TextAlign = ContentAlignment.MiddleCenter
                };

                Label lblStatus = new Label
                {
                    Text = room.Status,
                    ForeColor = Color.White,
                    BackColor = isAvailable ? Color.ForestGreen : Color.Firebrick,
                    //Dock = DockStyle.Bottom,
                    Size = new Size(74, 19),
                    Location = new Point(15, 169),
                    TextAlign = ContentAlignment.MiddleCenter
                };

                // Add in proper order: bottom → top (since Dock stacks them accordingly)
                roomPanel.Controls.Add(lblStatus);
                roomPanel.Controls.Add(lblType);
                roomPanel.Controls.Add(lblNumber);
                roomPanel.Controls.Add(picture);

                flowLayoutPanelRooms.Controls.Add(roomPanel);

                var roomTag = (
                    room.RoomNumber,
                    room.Type,
                    room.ImageKey,
                    room.Status,
                    room.Price,
                    room.Capacity,
                    room.Description
                );

                roomPanel.Tag = roomTag;
                picture.Tag = roomTag;
                lblNumber.Tag = roomTag;
                lblType.Tag = roomTag;
                lblStatus.Tag = roomTag;

                roomPanel.Click += RoomPanel_Click;
                picture.Click += RoomPanel_Click;
                lblNumber.Click += RoomPanel_Click;
                lblType.Click += RoomPanel_Click;
                lblStatus.Click += RoomPanel_Click;
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            var room = new Room
            {
                RoomNumber = txtRoomNumber.Text,
                Type = txtRoomType.Text,
                Price = int.Parse(txtRoomPrice.Text),
                Capacity = int.Parse(txtRoomCapacity.Text),
                ImageKey = imageKey,
                Status = "Available",
                Description = txtDescription.Text,
            };

            var controller = new RoomController(new RoomRepository(new AppDbContext()));
            controller.Add(room);

            LoadRooms();
        }

        private void upLoadFileBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Title = "Select Room Image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string sourceFilePath = openFileDialog.FileName;
                    string fileExtension = Path.GetExtension(sourceFilePath); // e.g. .jpg

                    // ✅ Ask user to manually enter file name (e.g., room408)
                    string customName = Microsoft.VisualBasic.Interaction.InputBox(
                        "Enter custom image name (e.g., room408):",
                        "Rename Image",
                        "room");

                    if (string.IsNullOrWhiteSpace(customName))
                    {
                        MessageBox.Show("Image name cannot be empty.");
                        return;
                    }

                    // Construct final file name
                    string finalFileName = customName + fileExtension;           // room408.jpg
                    string finalFileNameWithoutExt = customName;                // room408

                    // Copy to Resources folder
                    string resourcesFolder = Path.Combine(Application.StartupPath, "Resources");
                    Directory.CreateDirectory(resourcesFolder);
                    string destFilePath = Path.Combine(resourcesFolder, finalFileName);

                    // Copy (overwrite if exists)
                    File.Copy(sourceFilePath, destFilePath, true);

                    // Show image
                    roomPictureBox.Image = Image.FromFile(destFilePath);
                    roomPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

                    // Save for DB
                    imageKey = finalFileNameWithoutExt;     // room408
                    lblFilePath.Text = finalFileName;       // room408.jpg
                }
            }
        }

        private void Clear()
        {
            txtRoomNumber.Text = string.Empty;
            txtRoomType.Text = string.Empty;
            txtRoomPrice.Text = string.Empty;
            txtRoomCapacity.Text = string.Empty;
            txtDescription.Text = string.Empty;
            lblFilePath.Text = string.Empty;
            roomPictureBox.Image = null;
        }

        private void cancelBtn_Click(object sender, EventArgs e) => Clear();

        private void RoomPanel_Click(object sender, EventArgs e)
        {
            Control clicked = sender as Control;

            // Truy ngược lên control có Tag
            while (clicked != null && clicked.Tag == null)
                clicked = clicked.Parent;

            if (clicked?.Tag == null)
            {
                MessageBox.Show("Không tìm thấy thông tin phòng.");
                return;
            }

            var room = ((string RoomNumber, string Type, string ImageKey, string Status, decimal Price, int Capacity, string Description))clicked.Tag;

            txtRoomNumber.Text = room.RoomNumber;
            txtRoomNumber.Tag = room.RoomNumber; // ✅ Lưu RoomNumber gốc để update

            roomType.Text = room.Type;
            roomPrice.Text = room.Price.ToString("N0") + " VND";
            roomCapacity.Text = room.Capacity.ToString();
            roomDescription.Text = room.Description;

            Control parent = sender as Control;
            while (parent != null && !(parent is Guna2Panel))
                parent = parent.Parent;

            if (parent is Guna2Panel roomPanel)
            {
                foreach (Control control in roomPanel.Controls)
                {
                    if (control is Guna2PictureBox picture && picture.Image != null)
                    {
                        // Copy ảnh vào roomPicturePreview
                        roomPicturePreview.Image = new Bitmap(picture.Image);
                        roomPicturePreview.SizeMode = PictureBoxSizeMode.StretchImage;
                        editBtn.Visible = true;

                        if (addNewRoomBtn.Visible == true)
                        {
                            editBtn_Click(sender, EventArgs.Empty);
                        }

                        return;
                    }
                }
            }
            roomPicturePreview.Image = null;
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            addBtn.Visible = false;
            addNewRoomBtn.Visible = true;
            cancelBtn.Visible = false;
            saveBtn.Visible = true;
            deleteBtn.Visible = true;
            guna2HtmlLabel5.Text = "Cập nhật";
            txtStatus.Visible = true;

            txtRoomNumber.Text = roomNumber.Text;
            txtRoomType.Text = roomType.Text;
            txtRoomPrice.Text = roomPrice.Text;
            txtRoomCapacity.Text = roomCapacity.Text;
            txtDescription.Text = roomDescription.Text;
            roomPictureBox.Image = new Bitmap(roomPicturePreview.Image);
            roomPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void addNewRoomBtn_Click(object sender, EventArgs e)
        {
            addBtn.Visible = true;
            cancelBtn.Visible = true;
            saveBtn.Visible = false;
            deleteBtn.Visible = false;
            guna2HtmlLabel5.Text = "Thêm phòng mới";
            addNewRoomBtn.Visible = false;
            txtStatus.Visible = false;
            editBtn.Visible = false;
            roomNumber.Text = string.Empty;
            roomType.Text = string.Empty;
            roomPrice.Text = string.Empty;
            roomCapacity.Text = string.Empty;
            roomDescription.Text = string.Empty;
            roomPicturePreview.Image = null;
            cbRoomType.SelectedIndex = -1;
            cbRoomStatus.SelectedIndex = -1;
            txtCapacity.Text = string.Empty;
            Clear();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string priceText = txtRoomPrice.Text.Replace("VND", "").Trim().Replace(",", "");
            decimal priceValue = decimal.Parse(priceText);

            string originalRoomNumber = txtRoomNumber.Tag?.ToString();

            if (string.IsNullOrEmpty(originalRoomNumber))
            {
                MessageBox.Show("Không tìm thấy phòng gốc để cập nhật.", "Lỗi");
                return;
            }

            using (var context = new AppDbContext())
            {
                var existingRoom = context.Rooms.FirstOrDefault(r => r.RoomNumber == originalRoomNumber);

                if (existingRoom == null)
                {
                    MessageBox.Show("Phòng không tồn tại!", "Lỗi");
                    return;
                }

                // Cập nhật cả RoomNumber mới
                existingRoom.RoomNumber = txtRoomNumber.Text;
                existingRoom.Type = txtRoomType.Text;
                existingRoom.Price = priceValue;
                existingRoom.Capacity = int.Parse(txtRoomCapacity.Text);
                existingRoom.ImageKey = imageKey;
                existingRoom.Status = txtStatus.Text;
                existingRoom.Description = txtDescription.Text;

                context.SaveChanges();
            }

            MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK);
            LoadRooms();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            // Kiểm tra đã chọn panel phòng nào chưa (bạn có thể đánh dấu panel được click)
            var selectedPanel = flowLayoutPanelRooms.Controls
                                   .OfType<Panel>()
                                   .FirstOrDefault(p => p.BackColor == Color.LightBlue); // giả sử đổi màu khi chọn
            if (selectedPanel == null)
            {
                MessageBox.Show("Bạn chưa chọn phòng nào.", "Lỗi");
                return;
            }

            int roomId = (int)selectedPanel.Tag;

            var result = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa phòng ID = {roomId} không?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes) return;

            using (var context = new AppDbContext())
            {
                var room = context.Rooms.Find(roomId);
                if (room != null)
                {
                    context.Rooms.Remove(room);
                    context.SaveChanges();
                    MessageBox.Show("Xóa phòng thành công!", "Thông báo");
                    LoadRooms();  // reload lại panels
                }
                else
                {
                    MessageBox.Show("Không tìm thấy phòng.", "Lỗi");
                }
            }
        }


        private void cbRoomType_SelectedIndexChanged(object sender, EventArgs e) => LoadRooms();
        private void cbRoomStatus_SelectedIndexChanged(object sender, EventArgs e) => LoadRooms();
        private void txtCapacity_TextChanged(object sender, EventArgs e) => LoadRooms();

        private void clearCbRoomType_Click(object sender, EventArgs e)
        {
            cbRoomType.SelectedIndex = -1;
            LoadRooms();
        }

        private void clearCbStatus_Click(object sender, EventArgs e)
        {
            cbRoomStatus.SelectedIndex = -1;
            LoadRooms();
        }

        private void clearRoomCapacity_Click(object sender, EventArgs e)
        {
            txtCapacity.Text = string.Empty;
            LoadRooms();
        }
    }
}