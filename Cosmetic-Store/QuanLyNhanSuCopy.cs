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
using BLL;

namespace Cosmetic_Store
{
    public partial class QuanLyNhanSuCopy : UserControl
    {
        List<MonthlySalary> listLuong = new List<MonthlySalary>();
        MonthlySalaryBLL bllLuong = new MonthlySalaryBLL();
        public QuanLyNhanSuCopy()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void LoadBangLuong(int month, int year)
        {
            listLuong = bllLuong.GetAll(month, year);
            dgvLuong.Rows.Clear();
            for (int i = 0; i < listLuong.Count; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();

                newRow.CreateCells(dgvLuong);
                newRow.Cells[0].Value = listLuong[i].StaffID;
                newRow.Cells[0].Value = listLuong[i].Month;
                newRow.Cells[0].Value = listLuong[i].Year;
                newRow.Cells[0].Value = listLuong[i].PositionID;
                newRow.Cells[0].Value = listLuong[i].TotalLeavingDays;
                newRow.Cells[0].Value = listLuong[i].ActualReceiving;

                dgvLuong.Rows.Add(newRow);
            }
        }

        private void btnTinhLuong_Click(object sender, EventArgs e)
        {
            int parsing = -1;
            if (String.IsNullOrWhiteSpace(cbxThang_Luong.SelectedItem.ToString()) || String.IsNullOrWhiteSpace(txtNamTinhLuong.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ tháng và năm cần tính lương!", "Thông báo");
            }
            else if (int.TryParse(txtNamTinhLuong.Text, out parsing) && parsing <=0) {
                MessageBox.Show("Năm đã nhập không hợp lệ!", "Thông báo");
            }
            else if (bllLuong.DaTinhLuong(Convert.ToInt32(cbxThang_Luong.SelectedItem.ToString()), Convert.ToInt32(txtNamTinhLuong.Text)))
            {
                LoadBangLuong(Convert.ToInt32(cbxThang_Luong.SelectedItem.ToString()), Convert.ToInt32(txtNamTinhLuong.Text));
            }
            else
            {
                //tinh luong
            }
        }

        private void dgvLuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNV_Luong.Text = dgvLuong.SelectedRows[0].Cells[0].Value.ToString();
            txtThang_Luong.Text = dgvLuong.SelectedRows[0].Cells[1].Value.ToString();
            txtNam_Luong.Text = dgvLuong.SelectedRows[0].Cells[2].Value.ToString();
            txtMaCV_Luong.Text = dgvLuong.SelectedRows[0].Cells[3].Value.ToString();
            txtNgayNghi_Luong.Text = dgvLuong.SelectedRows[0].Cells[4].Value.ToString();
            txtThucNhan_Luong.Text = dgvLuong.SelectedRows[0].Cells[5].Value.ToString();
        }
    }
}
