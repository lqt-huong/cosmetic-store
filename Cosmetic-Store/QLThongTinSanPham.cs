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
	public partial class QLThongTinSanPham : UserControl
	{
		ProductDetailBLL ttspdl = new ProductDetailBLL();
		List<ProductVariety> listtsp = new List<ProductVariety>();
		List<TTCTSanPham> listTTCTsp = new List<TTCTSanPham>();
		static bool isDeleting = false, isUpdating = false, isAdding = false;

		public QLThongTinSanPham()
		{
			InitializeComponent();
			LoadTTSP();
		}
		private void LoadTTSP()
		{
			listTTCTsp = ttspdl.GetAllTTSanPhams();
			//dgvSanPham.DataSource = listTTCTsp;
			for (int i = 0; i < list.Count; i++)
			{
				DataGridViewRow newRow = new DataGridViewRow();
				newRow.CreateCells(dgvSanPham);
				newRow.Cells[0].Value = listTTCTsp[i].VarietyID;
				newRow.Cells[1].Value = listTTCTsp[i].ProductVolume;
				newRow.Cells[2].Value = listTTCTsp[i].Price;
				newRow.Cells[3].Value = listTTCTsp[i].Quantity;
				newRow.Cells[4].Value = listTTCTsp[i].ProductID;
				newRow.Cells[5].Value = listTTCTsp[i].ProductName;
				newRow.Cells[6].Value = listTTCTsp[i].ImportPrice;
				dgvSanPham.Rows.Add(newRow);

			}

			txtMaDSP.Text = ttspdl.AutoID().ToString();
			// Cập nhật hiện ẩn các nút cần thiết
			btnHuy.Enabled = false;
			btnXacNhan.Enabled = false;
			btnThem.Enabled = true;
			btnSua.Enabled = true;
			btnXoa.Enabled = true;

		}

		private void RefreshTxt()
		{
			txtMaDSP.Text = ttspdl.AutoID().ToString();
			txtTenSP.Text = "";
			cbbMaSP.Text = string.Empty;
			txtGiaBan.Text = "";
			txtGiaNhap.Text = "";
			txtDungTich.Text = "";
			txtSoLuong.Text = "";
		}

		private void QLSanPham_Load(object sender, EventArgs e)
		{

		}

		private void txtTenSP_TextChanged(object sender, EventArgs e)
		{

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
				isDeleting = true;
				btnHuy.Enabled = true;
				btnXacNhan.Enabled = true;
				btnThem.Enabled = false;
				btnSua.Enabled = false;
				btnXoa.Enabled = false;
			}
		}

		private void dgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int i;
			i = dgvSanPham.CurrentRow.Index;
			txtMaDSP.Text = dgvSanPham.Rows[i].Cells[0].Value.ToString();
			txtDungTich.Text = dgvSanPham.Rows[i].Cells[1].Value.ToString();
			txtGiaBan.Text = dgvSanPham.Rows[i].Cells[2].Value.ToString();
			txtSoLuong.Text = dgvSanPham.Rows[i].Cells[3].Value.ToString();
			cbbMaSP.Text = dgvSanPham.Rows[i].Cells[4].Value.ToString();
			txtTenSP.Text = ttspdl.GetProductName((int)dgvSanPham.Rows[i].Cells[4].Value);
			txtGiaNhap.Text = dgvSanPham.Rows[i].Cells[5].Value.ToString();

		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			if (String.IsNullOrWhiteSpace(txtDungTich.Text) || String.IsNullOrWhiteSpace(cbbMaSP.SelectedItem.ToString()) || String.IsNullOrWhiteSpace(txtGiaBan.Text) || String.IsNullOrWhiteSpace(txtSoLuong.Text))
			{
				MessageBox.Show("Không được để trống thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else if (!ttspdl.KiemTraTrung(Convert.ToInt32(cbbMaSP.Text), Convert.ToInt32(txtDungTich.Text)))
			{
				MessageBox.Show("Thông tin sản phẩm bị trùng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				isAdding = true;
				btnHuy.Enabled = true;
				btnXacNhan.Enabled = true;
				btnThem.Enabled = false;
				btnSua.Enabled = false;
				btnXoa.Enabled = false;				
			}
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			if (String.IsNullOrWhiteSpace(txtMaDSP.Text))
			{
				MessageBox.Show("Bạn chưa chọn sản phẩm cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else if (String.IsNullOrWhiteSpace(txtDungTich.Text) || String.IsNullOrWhiteSpace(cbbMaSP.SelectedItem.ToString()) || String.IsNullOrWhiteSpace(txtGiaBan.Text) || String.IsNullOrWhiteSpace(txtSoLuong.Text))
			{
				MessageBox.Show("Không được để trống thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else if (ttspdl.KiemTraTrungMa(Convert.ToInt32(txtMaDSP.Text)))
			{
				MessageBox.Show("Sản phẩm không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				isUpdating = true;
				btnHuy.Enabled = true;
				btnXacNhan.Enabled = true;
				btnThem.Enabled = false;
				btnSua.Enabled = false;
				btnXoa.Enabled = false;
			}
		}

		private void btnXacNhan_Click(object sender, EventArgs e)
		{
			if (isAdding)
			{
				txtSoLuong.Text = "0";
				ProductVariety sanPham = new ProductVariety(Convert.ToInt32(ttspdl.AutoID()), Convert.ToInt32(txtDungTich.Text), Convert.ToInt32(txtGiaBan.Text), Convert.ToInt32(txtSoLuong.Text), Convert.ToInt32(cbbMaSP.SelectedItem));
				MessageBox.Show(ttspdl.Them(sanPham), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				LoadTTSP();
				RefreshTxt();
				isAdding = false;
			}

			else if (isUpdating)
			{
				ProductVariety sanPham = new ProductVariety(Convert.ToInt32(txtMaDSP), Convert.ToInt32(txtDungTich.Text), Convert.ToInt32(txtGiaBan.Text), Convert.ToInt32(txtSoLuong.Text), Convert.ToInt32(cbbMaSP.SelectedItem));
				MessageBox.Show(ttspdl.Sua(sanPham), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				LoadTTSP();
				RefreshTxt();
				isUpdating = false;
			}

			else if (isDeleting)
			{
				MessageBox.Show(ttspdl.Xoa(Convert.ToInt32(txtMaDSP.Text)), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				LoadTTSP();
				RefreshTxt();
				isDeleting = false;
			}

		}

		private void btnHuy_Click(object sender, EventArgs e)
		{
			LoadTTSP();
			RefreshTxt();
			isDeleting = false;
			isAdding = false;
			isUpdating = false;
		}


		private void txtGiaBan_TextChanged(object sender, EventArgs e)
		{

		}

		private void label6_Click(object sender, EventArgs e)
		{

		}
	}
}
