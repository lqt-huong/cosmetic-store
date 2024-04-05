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
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Cosmetic_Store
{
    public partial class QuanLyKinhDoanh : UserControl
    {
        string connectstring = @"Data Source=YANG\SQLEXPRESS;Initial Catalog=cosmetic-store;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dt;
        private string inputDate;

        public QuanLyKinhDoanh()
        {
            InitializeComponent();
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
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
                                                "JOIN SaleBill sb ON sb.BillID = bd.BillID ", con);
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
                dataGridView1.DataSource = dt;
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
                        DataTable dataTable = (DataTable)dataGridView1.DataSource;

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

        private void QuanLyKinhDoanh_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(connectstring);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT p.ProductID AS 'Mã sản phẩm', p.ProductName AS 'Tên sản phẩm', c.CategoryName AS 'Loại', pv.Volume AS 'Dung tích (g)', pv.Price AS 'Giá', bd.Quantity AS 'Số lượng', sb.Date AS 'Ngày' " +
                                                "FROM Product p " +
                                                "JOIN Category c ON p.CategoryID = c.CategoryID " +
                                                "JOIN ProductVariety pv ON pv.ProductID = p.ProductID " +
                                                "JOIN BillDetails bd ON bd.VarietyID = pv.VarietyID " +
                                                "JOIN SaleBill sb ON sb.BillID = bd.BillID ", con);
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
                dataGridView1.DataSource = dt;

                SqlCommand cmdDT = new SqlCommand("SELECT sb.Date AS 'Ngày', sb.TotalValue AS 'Tổng tiền' " +
                                                "FROM SaleBill sb", con);
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
                dataGridView2.DataSource = dtDT;
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
                SqlCommand cmd = new SqlCommand("SELECT p.ProductID AS 'Mã sản phẩm', p.ProductName AS 'Tên sản phẩm', c.CategoryName AS 'Loại', pv.Volume AS 'Dung tích (g)', pv.Price AS 'Giá', bd.Quantity AS 'Số lượng', @inputDate AS 'Ngày', " + quarter + " AS Quý, " + year + " AS Năm " +
                                                    "FROM Product p " +
                                                    "JOIN Category c ON p.CategoryID = c.CategoryID " +
                                                    "JOIN ProductVariety pv ON pv.ProductID = p.ProductID " +
                                                    "JOIN BillDetails bd ON bd.VarietyID = pv.VarietyID " +
                                                    "JOIN SaleBill sb ON sb.BillID = bd.BillID " +
                                                    //"WHERE sb.Date LIKE @inputDate", con);
                                                    "WHERE CONVERT(date, sb.Date) = @inputDate", con);
                cmd.Parameters.AddWithValue("@inputDate", date);
                //cmd.Parameters.AddWithValue("@Ngày", date);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
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
                        DataTable dataTable = (DataTable)dataGridView2.DataSource;

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
                SqlCommand cmd = new SqlCommand("SELECT sb.Date AS 'Ngày', sb.TotalValue AS 'Tổng tiền' " +
                                                "FROM SaleBill sb", con);
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
                dataGridView2.DataSource = dt;
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
            //SqlCommand cmd = new SqlCommand("SELECT bd.Quantity AS 'Số lượng', @inputDate AS 'Ngày', " + quarter + " AS Quý, " + year + " AS Năm " +
            string inputDate = textBox2.Text;
            DateTime date = DateTime.Parse(inputDate);
            int quarter = (date.Day - 1) / 3 + 1; // Xác định quý từ tháng
            int year = date.Year;

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT @inputDate AS 'Ngày', sb.TotalValue AS 'Tổng tiền', " + quarter + " AS Quý, " + year + " AS Năm " +
                                                "FROM SaleBill sb " +
                                                    //"WHERE sb.Date LIKE @inputDate", con);
                                                "WHERE CONVERT(date, sb.Date) = @inputDate", con);
                cmd.Parameters.AddWithValue("@inputDate", date);
                //cmd.Parameters.AddWithValue("@Ngày", date);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView2.DataSource = dt;
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
    }
}
    

