using BLL;
using ValueObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cosmetic_Store
{
    public partial class LoginForm : Form
    {
        AccountBLL blltk = new AccountBLL();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác nhận thoát!", "Thông báo", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void lblRefresh_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtUsername.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtUsername.Text) || String.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Không được để trống thông tin đăng nhập!", "Thông báo");
            }
            else if (!blltk.TrungTenTK(txtUsername.Text))
            {
                MessageBox.Show("Tên tài khoản không tồn tại!", "Thông báo");
            }
            else if (!blltk.KTMatKhau(txtUsername.Text, txtPassword.Text))
            {
                MessageBox.Show("Sai mật khẩu!", "Thông báo");
            }
            else
            {
                Account account = blltk.TimTK(txtUsername.Text, txtPassword.Text);
                Application.Exit();
                Application.Run(new Form1(account));
            }
        }
    }
}
