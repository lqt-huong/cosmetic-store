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
			QLNhaCungCap qlncc = new QLNhaCungCap();
			qlncc.Dock = DockStyle.Fill;
			ChangePanel(qlncc);
		}

		private void TSMenu_QLSanPham_Click(object sender, EventArgs e)
		{
		}

		private void QLThongTinSPToolStripMenuItem_Click(object sender, EventArgs e)
		{
			QLThongTinSanPham qlttsp = new QLThongTinSanPham();
			qlttsp.Dock = DockStyle.Fill;
			ChangePanel(qlttsp);
		}

		private void SanPhamToolStripMenuItem_Click(object sender, EventArgs e)
		{
			QLSanPham qlsp = new QLSanPham();
			qlsp.Dock = DockStyle.Fill;
			ChangePanel(qlsp);
		}

		private void DSNhapToolStripMenuItem_Click(object sender, EventArgs e)
		{
			QL_DSPhieuNhap qldsn = new QL_DSPhieuNhap();
			qldsn.Dock = DockStyle.Fill;
			ChangePanel(qldsn);
		}

		private void TaoPhieuNhapToolStripMenuItem_Click(object sender, EventArgs e)
		{
			QLNhapHang qlnh = new QLNhapHang();
			qlnh.Dock = DockStyle.Fill;
			ChangePanel(qlnh);
		}

		private void TSMenu_ThongKeKho_Click(object sender, EventArgs e)
		{
			ThongKeSP tksp = new ThongKeSP();
			tksp.Dock = DockStyle.Fill;
			ChangePanel(tksp);
		}

		private void QLLoaiSP_Click(object sender, EventArgs e)
		{
			QLLoaiSP lsp = new QLLoaiSP();
			lsp.Dock = DockStyle.Fill;
			ChangePanel(lsp);
		}
	}
}
