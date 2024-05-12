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
	public partial class QL_DSPhieuNhap : UserControl
	{
		HoaDonNhapBLL hdnBLL = new HoaDonNhapBLL();
		List<HoaDonNhap> list = new List<HoaDonNhap>();
		static QuanLyKho qL;
		public QL_DSPhieuNhap()
		{
			InitializeComponent();
			DSPNLoad();

		}

		private void DSPNLoad()
		{
			list = hdnBLL.GetAllImportBill();
			//dgvPhieuNhap.DataSource = list;
			for (int i = 0; i < list.Count; i++)
			{
				DataGridViewRow newRow = new DataGridViewRow();
				newRow.CreateCells(dgvPhieuNhap);
				newRow.Cells[0].Value = list[i].ImportBillID;
				newRow.Cells[1].Value = list[i].ProviderID;
				newRow.Cells[2].Value = list[i].Date;
				newRow.Cells[3].Value = list[i].TotalValue;
				newRow.Cells[4].Value = list[i].SatffID;
				dgvPhieuNhap.Rows.Add(newRow);

			}
		}



		private void dgvPhieuNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int i;
			i = dgvPhieuNhap.CurrentRow.Index;
			txtMaPN.Text = dgvPhieuNhap.Rows[i].Cells[0].Value.ToString();
			txtMaNCC.Text = dgvPhieuNhap.Rows[i].Cells[1].Value.ToString();
			txtTenNCC.Text = hdnBLL.GetProviderName((int)dgvPhieuNhap.Rows[i].Cells[1].Value);
			DateNgayNhap.Text = dgvPhieuNhap.Rows[i].Cells[2].Value.ToString();
			txtTongTien.Text = dgvPhieuNhap.Rows[i].Cells[3].Value.ToString();
			txtMaNV.Text = dgvPhieuNhap.Rows[i].Cells[4].Value.ToString();
			txtTenNV.Text = hdnBLL.GetStaffName((int)dgvPhieuNhap.Rows[i].Cells[4].Value);

		}

		private void btnTaoPhieuNhap_Click(object sender, EventArgs e)
		{
			QLNhapHang qlnh = new QLNhapHang();
			qlnh.Dock = DockStyle.Fill;
			qL.Controls.Clear();
			qL.Controls.Add(qlnh);
		}
	}
}
