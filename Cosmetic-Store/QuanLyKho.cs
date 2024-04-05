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
    public partial class QuanLyKho : UserControl
    {
        public QuanLyKho()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

		private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}

		private void pnlQLKho_Paint(object sender, PaintEventArgs e)
		{

		}
		public void ChangePanel(UserControl userControl)
		{
			pnlQLKho.Controls.Clear();
			pnlQLKho.Controls.Add(userControl);
		}

		
		private void TSMenu_QLNhaCungCap_Click(object sender, EventArgs e)
		{

		}

		private void TSMenu_QLSanPham_Click(object sender, EventArgs e)
		{
			QLSanPham qlsp = new QLSanPham();
			qlsp.Dock = DockStyle.Fill;
			ChangePanel(qlsp);
		}
	}
}
