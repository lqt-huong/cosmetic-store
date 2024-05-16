using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using System.IO;
using System.Data.SqlClient;
using Google.Protobuf.Collections;
using BLL;
using ValueObject;

namespace Cosmetic_Store
{
    public partial class QuanLyKinhDoanh : UserControl
    {
        //string connectstring = @"Data Source=DESKTOP-D29FRPQ\MSSQL2022;Initial Catalog=cosmetic-store;Integrated Security=True";
        string connectstring = @"Data Source=josie\sqlexpress;Initial Catalog=cosmetic-store;Integrated Security=True"; //connection string của TH
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dt;
        private string inputDate;

        ThongKeDoanhThuBLL bllTK = new ThongKeDoanhThuBLL();

        SaleBillBLL bllHD = new SaleBillBLL();
        List<SaleBill> listHD = new List<SaleBill>();

        BillDetailsBLL bllCTHD = new BillDetailsBLL();
        List<BillDetails> listCTHD = new List<BillDetails>();

        ProductDetailBLL bllsp = new ProductDetailBLL();
        List<ProductVariety> listSP = new List<ProductVariety>();

        int selectedBill = -1;

        bool isDeleting = false, isUpdating = false;

        Account loggedIn;


        public QuanLyKinhDoanh()
        {
            InitializeComponent();
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            listHD = bllHD.getAll();
            LoadDataGridHD();
            loggedIn = Form1.LoggedInAccount;
            LoadThongKeDoanhThu();
            LoadCbbMaLoaiSP();

            try
            {
                if (loggedIn.PermissionID != 4 && loggedIn.PermissionID != 1 && loggedIn.PermissionID != 6)
                {
                    tabControl1.TabPages.Remove(tabPage1);
                    tabControl1.TabPages.Remove(tabPage2);
                    btnXoaHD.Enabled = false;
                }
                else if (loggedIn.PermissionID == 1)
                {
                    btnXoaHD.Enabled = false;
                    btnThemHD.Enabled = false;
                    btnThemCT.Enabled = false;
                    btnXoaCT.Enabled = false;
                    btnCNCT.Enabled = false;
                }
            }
            catch (Exception e)
            {

            }
        }

        private void LoadCbbMaLoaiSP()
        {
            listSP = bllsp.GetAllProductVariety();
            txtVarietyID_CT.Items.Clear();
            foreach (ProductVariety sp in listSP)
            {
                txtVarietyID_CT.Items.Add(sp.VarietyID);
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT p.ProductID AS 'Mã sản phẩm', p.ProductName AS 'Tên sản phẩm', c.CategoryName AS 'Loại', pv.Volume AS 'Dung tích (g)', pv.Price AS 'Giá', bd.Quantity AS 'Số lượng', sb.Date AS 'Ngày' " +
                                                "FROM Product p " +
                                                "JOIN Category c ON p.CategoryID = c.CategoryID " +
                                                "JOIN ProductVariety pv ON pv.ProductID = p.ProductID " +
                                                "JOIN BillDetails bd ON bd.VarietyID = pv.VarietyID " +
                                                "JOIN SaleBill sb ON sb.BillID = bd.BillID " +
                                                "WHERE sb.IsDeleted = 0 " +
                                                "GROUP BY p.ProductID, p.ProductName, c.CategoryName, pv.Volume, pv.Price, bd.Quantity, sb.Date " +
                                                "ORDER BY sb.Date", con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Thêm cột Quý và Năm vào DataTable và tính toán giá trị cho các cột mới
                dt.Columns.Add("Quý", typeof(int));
                dt.Columns.Add("Năm", typeof(int));

                foreach (DataRow row in dt.Rows)
                {
                    DateTime date = Convert.ToDateTime(row["Ngày"]);
                    int quarter = (date.Day - 1) / 3 + 1;
                    int year = date.Year;

                    row["Quý"] = quarter;
                    row["Năm"] = year;
                }
                dgvTKSP.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveFileDialog1.Title = "Save Excel File";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (ExcelPackage excelPackage = new ExcelPackage())
                    {
                        ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet1");
                        DataTable dataTable = (DataTable)dgvTKSP.DataSource;

                        // Đưa dữ liệu từ DataTable vào tập tin Excel
                        for (int i = 0; i < dataTable.Columns.Count; i++)
                        {
                            worksheet.Cells[1, i + 1].Value = dataTable.Columns[i].ColumnName;
                        }
                        for (int i = 0; i < dataTable.Rows.Count; i++)
                        {
                            for (int j = 0; j < dataTable.Columns.Count; j++)
                            {
                                worksheet.Cells[i + 2, j + 1].Value = dataTable.Rows[i][j];
                            }
                        }

                        // Lưu tập tin Excel
                        FileInfo excelFile = new FileInfo(saveFileDialog1.FileName);
                        excelPackage.SaveAs(excelFile);
                    }
                    MessageBox.Show("Excel file đã được lưu thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void LoadThongKeDoanhThu()
        {
            DataTable dt = bllTK.GetThongKeDoanhThu();

            // Thêm cột Quý và Năm vào DataTable và tính toán giá trị cho các cột mới
            dt.Columns.Add("Quý", typeof(int));
            dt.Columns.Add("Năm", typeof(int));

            foreach (DataRow row in dt.Rows)
            {
                DateTime date = Convert.ToDateTime(row["Ngày"]);
                int quarter = (date.Day - 1) / 3 + 1;
                int year = date.Year;

                row["Quý"] = quarter;
                row["Năm"] = year;
            }
            dgvTKSP.DataSource = dt;
        }

        private void QuanLyKinhDoanh_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(connectstring);
            try
            {


                SqlCommand cmdDT = new SqlCommand("SELECT sb.Date AS 'Ngày', SUM(sb.TotalValue) AS 'Tổng tiền' " +
                                                "FROM SaleBill sb " +
                                                "WHERE sb.IsDeleted = 0 " +
                                                "GROUP BY sb.Date " +
                                                "ORDER BY sb.Date", con);
                SqlDataAdapter adapterDT = new SqlDataAdapter(cmdDT);
                DataTable dtDT = new DataTable();
                adapterDT.Fill(dtDT);

                // Thêm cột Quý và Năm vào DataTable và tính toán giá trị cho các cột mới
                dtDT.Columns.Add("Quý", typeof(int));
                dtDT.Columns.Add("Năm", typeof(int));

                foreach (DataRow rowDT in dtDT.Rows)
                {
                    DateTime dateDT = Convert.ToDateTime(rowDT["Ngày"]);
                    int quarterDT = (dateDT.Day - 1) / 3 + 1;
                    int yearDT = dateDT.Year;

                    rowDT["Quý"] = quarterDT;
                    rowDT["Năm"] = yearDT;
                }
                dgvTKDT.DataSource = dtDT;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string inputDate = textBox1.Text;
            DateTime date = DateTime.Parse(inputDate);
            int quarter = (date.Day - 1) / 3 + 1; // Xác định quý từ tháng
            int year = date.Year;

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT p.ProductID AS 'Mã sản phẩm', p.ProductName AS 'Tên sản phẩm', c.CategoryName AS 'Loại', pv.Volume AS 'Dung tích (g)', pv.Price AS 'Giá', SUM(bd.Quantity) AS 'Số lượng', @inputDate AS 'Ngày', " + quarter + " AS Quý, " + year + " AS Năm " +
                                                    "FROM Product p " +
                                                    "JOIN Category c ON p.CategoryID = c.CategoryID " +
                                                    "JOIN ProductVariety pv ON pv.ProductID = p.ProductID " +
                                                    "JOIN BillDetails bd ON bd.VarietyID = pv.VarietyID " +
                                                    "JOIN SaleBill sb ON sb.BillID = bd.BillID " +
                                                    //"WHERE sb.Date LIKE @inputDate", con);
                                                    "WHERE CONVERT(date, sb.Date) = @inputDate AND sb.IsDeleted = 0 " +
                                                    "GROUP BY p.ProductID, p.ProductName, c.CategoryName, pv.Volume, pv.Price, bd.Quantity, sb.Date " +
                                                    "ORDER BY sb.Date", con);
                cmd.Parameters.AddWithValue("@inputDate", date);
                //cmd.Parameters.AddWithValue("@Ngày", date);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvTKSP.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveFileDialog1.Title = "Save Excel File";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (ExcelPackage excelPackage = new ExcelPackage())
                    {
                        ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet1");
                        DataTable dataTable = (DataTable)dgvTKDT.DataSource;

                        // Đưa dữ liệu từ DataTable vào tập tin Excel
                        for (int i = 0; i < dataTable.Columns.Count; i++)
                        {
                            worksheet.Cells[1, i + 1].Value = dataTable.Columns[i].ColumnName;
                        }
                        for (int i = 0; i < dataTable.Rows.Count; i++)
                        {
                            for (int j = 0; j < dataTable.Columns.Count; j++)
                            {
                                worksheet.Cells[i + 2, j + 1].Value = dataTable.Rows[i][j];
                            }
                        }

                        // Lưu tập tin Excel
                        FileInfo excelFile = new FileInfo(saveFileDialog1.FileName);
                        excelPackage.SaveAs(excelFile);
                    }
                    MessageBox.Show("Excel file đã được lưu thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT sb.Date AS 'Ngày', SUM(sb.TotalValue) AS 'Tổng tiền' " +
                                                "FROM SaleBill sb " +
                                                "WHERE sb.IsDeleted = 0 " +
                                                "GROUP BY sb.Date " +
                                                "ORDER BY sb.Date", con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Thêm cột Quý và Năm vào DataTable và tính toán giá trị cho các cột mới
                dt.Columns.Add("Quý", typeof(int));
                dt.Columns.Add("Năm", typeof(int));

                foreach (DataRow row in dt.Rows)
                {
                    DateTime date = Convert.ToDateTime(row["Ngày"]);
                    int quarter = (date.Day - 1) / 3 + 1;
                    int year = date.Year;

                    row["Quý"] = quarter;
                    row["Năm"] = year;
                }
                dgvTKDT.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string inputDate = textBox2.Text;
            DateTime date = DateTime.Parse(inputDate);
            int quarter = (date.Day - 1) / 3 + 1; // Xác định quý từ tháng
            int year = date.Year;

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT @inputDate AS 'Ngày', SUM(sb.TotalValue) AS 'Tổng tiền', " + quarter + " AS Quý, " + year + " AS Năm " +
                                                "FROM SaleBill sb " +
                                                "WHERE CONVERT(date, sb.Date) = @inputDate AND sb.IsDeleted = 0 " +
                                                "GROUP BY sb.Date " +
                                                "ORDER BY sb.Date", con);
                cmd.Parameters.AddWithValue("@inputDate", date);
                //cmd.Parameters.AddWithValue("@Ngày", date);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvTKDT.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT sb.Date AS 'Ngày', p.ProductName AS 'Tên sản phẩm', pv.Price AS 'Giá', SUM(bd.Quantity) AS 'Số lượng' " +
                                               "FROM Product p " +
                                               "JOIN Category c ON p.CategoryID = c.CategoryID " +
                                               "JOIN ProductVariety pv ON pv.ProductID = p.ProductID " +
                                               "JOIN BillDetails bd ON bd.VarietyID = pv.VarietyID " +
                                               "JOIN SaleBill sb ON bd.BillID = sb.BillID " +
                                               "GROUP BY sb.Date, p.ProductName, pv.Price " +
                                               "ORDER BY sb.Date", con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Tạo một form mới để hiển thị dữ liệu
                ShowDataForm newDataForm = new ShowDataForm(dt);
                newDataForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void LoadDataGridHD()
        {
            listHD = bllHD.getAll();
            dgvHoaDon.Rows.Clear();
            for (int i = 0; i < listHD.Count; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();

                newRow.CreateCells(dgvHoaDon);
                newRow.Cells[0].Value = listHD[i].BillID;
                newRow.Cells[1].Value = listHD[i].Date;
                newRow.Cells[2].Value = listHD[i].StaffID;
                newRow.Cells[3].Value = listHD[i].TotalValue;

                dgvHoaDon.Rows.Add(newRow);
            }
        }

        private void LoadCTHD(int maHD)
        {
            listCTHD = bllCTHD.getAll(maHD);
            dgvCTHD.Rows.Clear();
            for (int i = 0; i < listCTHD.Count; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();

                newRow.CreateCells(dgvCTHD);
                newRow.Cells[0].Value = listCTHD[i].BillID;
                newRow.Cells[1].Value = listCTHD[i].VarietyID;
                newRow.Cells[2].Value = listCTHD[i].Quantity;
                newRow.Cells[3].Value = listCTHD[i].Price;

                dgvCTHD.Rows.Add(newRow);
            }
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Check if a valid row is clicked
            {
                //Get the DataGridViewRow corresponding to the clicked row
                DataGridViewRow row = dgvHoaDon.Rows[e.RowIndex];
                int maHD = Convert.ToInt32(row.Cells["colMaHD"].Value);

                txtMaHD.Text = row.Cells["colMaHD"].Value.ToString();
                txtNgayXuat.Value = (DateTime)row.Cells["colNgayXH"].Value;
                txtMaNV.Text = row.Cells["colNVXH"].Value.ToString();

                LoadCTHD(maHD);
                selectedBill = maHD;
            }
        }

        private void dgvCTHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Check if a valid row is clicked
            {
                //Get the DataGridViewRow corresponding to the clicked row
                DataGridViewRow row = dgvCTHD.Rows[e.RowIndex];

                txtVarietyID_CT.Text = row.Cells["colVarietyID_CT"].Value.ToString();
                txtQuantity_CT.Text = row.Cells["colQuantity_CT"].Value.ToString();
                txtPrice_CT.Text = row.Cells["colPrice_CT"].Value.ToString();
            }
        }

        private void btnHuyHD_Click(object sender, EventArgs e)
        {
            if (isDeleting)
            {
                isDeleting = false;

                btnXoaHD.Enabled = true;
                btnThemHD.Enabled = true;
                btnXNHD.Enabled = false;
                btnHuyHD.Enabled = false;
            }
        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            SaleBill hd = new SaleBill(bllHD.NextID(), DateTime.Now, 0, loggedIn.StaffID, false);
            MessageBox.Show(bllHD.Insert(hd), "Thông báo");
            LoadDataGridHD();
        }

        private void btnXNHD_Click(object sender, EventArgs e)
        {
            if (isDeleting)
            {
                if (String.IsNullOrWhiteSpace(txtMaHD.Text))
                {
                    MessageBox.Show("Vui lòng chọn hóa đơn cần xóa", "Thông báo");
                }
                else if (!bllHD.TrungMa(Convert.ToInt32(txtMaHD.Text)))
                {
                    MessageBox.Show("Hóa đơn cần xóa không tồn tại!", "Thông báo");
                }
                else
                {
                    MessageBox.Show(bllHD.Delete(Convert.ToInt32(txtMaHD.Text)), "Thông báo");
                    isDeleting = false;

                    btnXoaHD.Enabled = true;
                    btnThemHD.Enabled = true;
                    btnXNHD.Enabled = false;
                    btnHuyHD.Enabled = false;
                    LoadDataGridHD();
                }
            }
        }

        private void btnThemCT_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtVarietyID_CT.Text) || String.IsNullOrWhiteSpace(txtQuantity_CT.Text) || String.IsNullOrWhiteSpace(txtPrice_CT.Text))
            {
                MessageBox.Show("Vui lòng nhập thông tin cần thêm!", "Thông báo");
            }
            else if (bllCTHD.TrungMa(selectedBill, Convert.ToInt32(txtVarietyID_CT.Text)))
            {
                MessageBox.Show("Sản phẩm này đã được thêm!", "Thông báo");
            }
            else
            {
                BillDetails ct = new BillDetails(selectedBill, Convert.ToInt32(txtVarietyID_CT.Text), Convert.ToInt32(txtPrice_CT.Text), Convert.ToInt32(txtQuantity_CT.Text));
                MessageBox.Show(bllCTHD.Insert(ct), "Thông báo");
                LoadCTHD(selectedBill);
            }
        }

        private void btnCNCT_Click(object sender, EventArgs e)
        {
            isUpdating = true;

            btnThemCT.Enabled = false;
            btnCNCT.Enabled = false;
            btnXoaCT.Enabled = false;
            btnXNCT.Enabled = true;
            btnHuyCT.Enabled = true;
        }

        private void btnXoaCT_Click(object sender, EventArgs e)
        {
            isDeleting = true;

            btnThemCT.Enabled = false;
            btnCNCT.Enabled = false;
            btnXoaCT.Enabled = false;
            btnXNCT.Enabled = true;
            btnHuyCT.Enabled = true;
        }

        private void btnHuyCT_Click(object sender, EventArgs e)
        {
            if (isDeleting)
            {
                isDeleting = false;
                btnThemCT.Enabled = true;
                btnCNCT.Enabled = true;
                btnXoaCT.Enabled = true;
                btnXNCT.Enabled = false;
                btnHuyCT.Enabled = false;
            }
            else if (isUpdating)
            {
                isUpdating = false;
                btnThemCT.Enabled = true;
                btnCNCT.Enabled = true;
                btnXoaCT.Enabled = true;
                btnXNCT.Enabled = false;
                btnHuyCT.Enabled = false;
            }
        }

        private void txtVarietyID_CT_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int varietyID = Convert.ToInt32(txtVarietyID_CT.SelectedItem);
            int giaXuat = bllCTHD.GetFee(varietyID);
            txtPrice_CT.Text = giaXuat.ToString();
        }

        private void btnXNCT_Click(object sender, EventArgs e)
        {
            if (isDeleting)
            {
                if (String.IsNullOrWhiteSpace(txtVarietyID_CT.Text))
                {
                    MessageBox.Show("Vui lòng chọn chi tiết cần xóa!");
                }
                else if (!bllCTHD.TrungMa(selectedBill, Convert.ToInt32(txtVarietyID_CT.Text)))
                {
                    MessageBox.Show("Chi tiết cần xóa không tồn tại!");
                }
                else
                {
                    MessageBox.Show(bllCTHD.Delete(selectedBill, Convert.ToInt32(txtVarietyID_CT.Text)), "Thông báo");
                    LoadCTHD(selectedBill);
                    isDeleting = false;
                    btnThemCT.Enabled = true;
                    btnCNCT.Enabled = true;
                    btnXoaCT.Enabled = true;
                    btnXNCT.Enabled = false;
                    btnHuyCT.Enabled = false;
                }
            }
            else if (isUpdating)
            {
                if (String.IsNullOrWhiteSpace(txtVarietyID_CT.Text))
                {
                    MessageBox.Show("Vui lòng chọn chi tiết cần chỉnh sửa!");
                }
                else if (!bllCTHD.TrungMa(selectedBill, Convert.ToInt32(txtVarietyID_CT.Text)))
                {
                    MessageBox.Show("Chi tiết cần chỉnh sửa không tồn tại!");
                }
                else
                {
                    BillDetails ct = new BillDetails(selectedBill, Convert.ToInt32(txtVarietyID_CT.Text), Convert.ToInt32(txtPrice_CT.Text), Convert.ToInt32(txtQuantity_CT.Text));
                    MessageBox.Show(bllCTHD.Update(ct), "Thông báo");
                    LoadCTHD(selectedBill);
                    isUpdating = false;
                    btnThemCT.Enabled = true;
                    btnCNCT.Enabled = true;
                    btnXoaCT.Enabled = true;
                    btnXNCT.Enabled = false;
                    btnHuyCT.Enabled = false;
                }
            }
        }

        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            isDeleting = true;

            btnXoaHD.Enabled = false;
            btnThemHD.Enabled = false;
            btnXNHD.Enabled = true;
            btnHuyHD.Enabled = true;
        }
    }
}



