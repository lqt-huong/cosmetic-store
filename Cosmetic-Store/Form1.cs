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
    public partial class Form1 : Form
    {
        static Form1 form;
        public Form1()
        {
            InitializeComponent();
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
            Application.Exit();
        }
    }
}
