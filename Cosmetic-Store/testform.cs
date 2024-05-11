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
    public partial class testform : Form
    {
        public testform()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            QuanLyKinhDoanh qlkd = new QuanLyKinhDoanh();
            qlkd.Dock = DockStyle.Fill;
        }
    }
}
