using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValueObject;

namespace Cosmetic_Store
{
    public partial class Form1 : Form
    {
        static Form1 form;
        static Account loggedinAccount;
        private Button previousButton;
        PermissionBLL bllPQ = new PermissionBLL();
        PermissionGrantingBLL bllCTPQ = new PermissionGrantingBLL();

        List<PermissionGranting> accountPermission = new List<PermissionGranting>();
        public Form1(Account account)
        {
            InitializeComponent();
            previousButton = null;

            // Gán sự kiện Click cho tất cả các button trong form
            foreach (Control control in panel1.Controls)
            {
                if (control is Button)
                {
                    ((Button)control).Click += Button_Click;
                }
            }
            loggedinAccount = account;

            lblUserName.Text = loggedinAccount.Username;
            lblQuyen.Text = bllPQ.GetTenQuyen(loggedinAccount.PermissionID);
            accountPermission = bllCTPQ.QuyenTK(loggedinAccount.Username);
            unlockFunction();
        }

        private void unlockFunction()
        {
            foreach (PermissionGranting permission in accountPermission)
            {
                switch (permission.FunctionID)
                {
                    case 1:
                        btnQLTK.Visible = true;
                        break;
                    case 2:
                        btnQLNS.Visible = true;
                        break;
                    case 3:
                        btnQLK.Visible = true;
                        break;
                    case 4:
                        btnQLKD.Visible = true;
                        break;
                    case 5:
                        btnQLNS.Visible = true;
                        break;
                }
            }
        }

        // Xử lý sự kiện Click cho tất cả các button
        private void Button_Click(object sender, EventArgs e)
        {
            Button currentButton = (Button)sender;

            if (previousButton != null)
            {
                // Reset màu của button trước đó
                previousButton.BackColor = Color.FromArgb(146, 146, 214);
                previousButton.ForeColor = Color.White;
            }

            // Thay đổi màu của button hiện tại
            currentButton.BackColor = Color.White;
            currentButton.ForeColor = Color.FromArgb(140, 120, 204);
            // Cập nhật previousButton thành button hiện tại
            previousButton = currentButton;
            form = this;
        }

        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnQLNS_Click(object sender, EventArgs e)
        {
            QuanLyNhanSu qlns = new QuanLyNhanSu();
            qlns.Dock = DockStyle.Fill;
            ChangeControlTo(qlns);

            
        }
        public void ChangeControlTo(UserControl control)
        {
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(control);
        }

        private void btnQLTK_Click(object sender, EventArgs e)
        {
            QuanLyTaiKhoan qltk = new QuanLyTaiKhoan();
            qltk.Dock = DockStyle.Fill;
            ChangeControlTo(qltk);
        }

        private void btnQLK_Click(object sender, EventArgs e)
        {
            QuanLyKho qlk = new QuanLyKho();
            qlk.Dock = DockStyle.Fill;
            ChangeControlTo(qlk);
        }

        private void btnQLKD_Click(object sender, EventArgs e)
        {
            QuanLyKinhDoanh qlkd = new QuanLyKinhDoanh();
            qlkd.Dock = DockStyle.Fill;
            ChangeControlTo(qlkd);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác nhận thoát!", "Thông báo", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác nhận đăng xuất!", "Thông báo", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                this.Hide();
                new LoginForm().Show();
            }
        }

        private void pnlContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
