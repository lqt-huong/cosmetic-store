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
	public partial class QLNhapHang : UserControl
	{
		ProductDetailBLL ttspdl = new ProductDetailBLL();
		List<ProductVariety> listtsp = new List<ProductVariety>();
		CTHoaDonNhapBLL cthdn = new CTHoaDonNhapBLL();
		List<CTHoaDonNhap> listhdn = new List<CTHoaDonNhap>();
		HoaDonNhapBLL hdnbll = new HoaDonNhapBLL();


		public QLNhapHang()
		{
			InitializeComponent();
			LoadCbbNCC();
			RefreshPN();

		}


		private void RefreshPN()
		{
			txtMaPN.Text = cthdn.AutoID().ToString();
			txtMaNV.Text = "";
			cbbNCC.Text = string.Empty;
			txtTenNCC.Text = "";
			dateTimePicker1.Value = DateTime.Now;
			txtTongTien.Text = "";

			txtMaSP.Text = string.Empty;
			txtMaDSP.Text = string.Empty;
			txtTenSP.Text = string.Empty;
			txtGiaNhap.Text = string.Empty;
			txtSoLuong.Text = string.Empty;
		}

		private void LoadHDN()
		{
			listhdn = cthdn.GetCTHoaDonNhap(Convert.ToInt32(txtMaPN.Text));
			//dgvCTHDN.DataSource = listhdn;
			// neu cthdn khong co san pham nao thi hien lai cbb nhacc
			if (listhdn.Count < 1)
			{
				cbbNCC.Enabled = true;
			}
			else
			{
				cbbNCC.Enabled = false;
			}
			//cap nhat tong tien hoa don nhap
			LoadTongTienPN();

			for (int i = 0; i < listhdn.Count; i++)
			{
				DataGridViewRow newRow = new DataGridViewRow();
				newRow.CreateCells(dgvCTHDN);
				newRow.Cells[0].Value = listhdn[i].ImportBillID;
				newRow.Cells[1].Value = listhdn[i].VarietyID;
				newRow.Cells[2].Value = listhdn[i].Quantity;
				newRow.Cells[3].Value = listhdn[i].ImportPrice;
				dgvCTHDN.Rows.Add(newRow);

			}
		}

		private void LoadSP()
		{
			listtsp = ttspdl.GetSanPhamNCC(Convert.ToInt32(cbbNCC.SelectedItem));
			//dgvSanPham.DataSource = listtsp;
			for (int i = 0; i < listtsp.Count; i++)
			{
				DataGridViewRow newRow = new DataGridViewRow();
				newRow.CreateCells(dgvSanPham);
				newRow.Cells[0].Value = listtsp[i].VarietyID;
				newRow.Cells[1].Value = listtsp[i].ProductID;
				newRow.Cells[2].Value = listtsp[i].Quantity;
				newRow.Cells[3].Value = listtsp[i].ProductVolume;
				newRow.Cells[4].Value = listtsp[i].Price;
				dgvSanPham.Rows.Add(newRow);

			}
		}

		List<NhaCungCap> listNCC;
		NhaCungCapBLL nccb = new NhaCungCapBLL();

		private void LoadCbbNCC()
		{
			listNCC = nccb.GetAllNCC();
			cbbNCC.Items.Clear();
			listNCC.ForEach(ncc =>
			{
				cbbNCC.Items.Add(ncc.ProviderID.ToString().Trim());
			});
		}

		private void LoadTongTienPN()
		{
			int maPN;
			maPN = Convert.ToInt32(txtMaPN.Text);
			txtTongTien.Text = cthdn.TongTienPN(maPN).ToString();
		}

		private void dgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int i;
			i = dgvSanPham.CurrentRow.Index;
			txtMaDSP.Text = dgvSanPham.Rows[i].Cells[0].Value.ToString();
			txtMaSP.Text = dgvSanPham.Rows[i].Cells[1].Value.ToString();
			txtTenSP.Text = ttspdl.GetProductName((int)dgvSanPham.Rows[i].Cells[1].Value);
		}


		private void btnThem_Click(object sender, EventArgs e)
		{
			if (String.IsNullOrWhiteSpace(txtMaDSP.Text))
			{
				MessageBox.Show("Bạn chưa chọn sản phẩm cần thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else if (String.IsNullOrWhiteSpace(txtGiaNhap.Text) || String.IsNullOrWhiteSpace(txtSoLuong.Text))
			{
				MessageBox.Show("Không được để trống thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else if (!cthdn.KiemTraTrung(Convert.ToInt32(txtMaPN.Text), Convert.ToInt32(txtMaDSP.Text)))
			{
				MessageBox.Show("Sản phẩm này đã được thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				cbbNCC.Enabled = false;
				CTHoaDonNhap cthoadonnhap = new CTHoaDonNhap(Convert.ToInt32(txtMaPN.Text), Convert.ToInt32(txtMaDSP.Text), Convert.ToInt32(txtSoLuong.Text), Convert.ToInt32(txtGiaNhap.Text));
				MessageBox.Show(cthdn.Them(cthoadonnhap), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				LoadHDN();
			}
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			if (String.IsNullOrWhiteSpace(txtMaDSP.Text))
			{
				MessageBox.Show("Bạn chưa chọn sản phẩm cần sua!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else if (String.IsNullOrWhiteSpace(txtGiaNhap.Text) || String.IsNullOrWhiteSpace(txtSoLuong.Text))
			{
				MessageBox.Show("Không được để trống thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else if (!cthdn.KiemTraTrung(Convert.ToInt32(txtMaPN.Text), Convert.ToInt32(txtMaDSP.Text)))
			{
				MessageBox.Show("Sản phẩm này đã được thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				cbbNCC.Enabled = false;
				CTHoaDonNhap cthoadonnhap = new CTHoaDonNhap(Convert.ToInt32(txtMaPN.Text), Convert.ToInt32(txtMaDSP.Text), Convert.ToInt32(txtSoLuong.Text), Convert.ToInt32(txtGiaNhap.Text));
				MessageBox.Show(cthdn.Sua(cthoadonnhap), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				LoadHDN();
			}
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			if (String.IsNullOrWhiteSpace(txtMaDSP.Text))
			{
				MessageBox.Show("Bạn chưa chọn sản phẩm cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else if (ttspdl.KiemTraTrungMa(Convert.ToInt32(txtMaDSP.Text)))
			{
				MessageBox.Show("Không tìm thấy sản phẩm phải xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show(cthdn.Xoa(Convert.ToInt32(txtMaPN), Convert.ToInt32(txtMaDSP.Text)), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				LoadHDN();
			}

		}


		private void cbbNCC_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		private void cbbNCC_SelectionChangeCommitted(object sender, EventArgs e)
		{
			LoadSP();
			txtTenNCC.Text = cthdn.GetProviderName(Convert.ToInt32(cbbNCC.SelectedItem));
		}


		private void btnSave_Click(object sender, EventArgs e)
		{
			listhdn = cthdn.GetCTHoaDonNhap(Convert.ToInt32(txtMaPN.Text));
			if (listhdn.Count > 0)
			{
				HoaDonNhap hdn = new HoaDonNhap(Convert.ToInt32(txtMaPN.Text), Convert.ToDateTime(dateTimePicker1.Text), Convert.ToInt32(txtTongTien.Text), Convert.ToInt32(cbbNCC.Text), Convert.ToInt32(txtMaNV.Text), 0);
				MessageBox.Show(hdnbll.Them(hdn), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				cthdn.TangSL(Convert.ToInt32(txtMaPN.Text));
				cbbNCC.Enabled = true;
				RefreshPN();
			}
			else
			{
				cbbNCC.Enabled = true;
				MessageBox.Show("Bạn chưa chọn sản phẩm nào vào phiếu nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			
		}

		private void btnHuy_Click(object sender, EventArgs e)
		{
			MessageBox.Show(cthdn.HuyHDN(Convert.ToInt32(txtMaPN.Text)), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			cbbNCC.Enabled = true;
			RefreshPN();

		}

	}
}
