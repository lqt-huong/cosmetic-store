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
            ChangeControlTo(new QuanLyNhanSu());
        }
        public static void ChangeControlTo(UserControl control)
        {
            form.Controls.Clear();
            form.Controls.Add(control);
           
        }


        private void btnQLTK_Click(object sender, EventArgs e)
        {
            ChangeControlTo(new QuanLyTaiKhoan());
        }

        private void btnQLK_Click(object sender, EventArgs e)
        {
            ChangeControlTo(new QuanLyKho());
        }

        private void btnQLKD_Click(object sender, EventArgs e)
        {
            ChangeControlTo(new QuanLyKinhDoanh());
        }
    }
}
