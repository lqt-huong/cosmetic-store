using System.Data.SqlClient;
using System.Data;
using System;

namespace DAL
{
    public class DataServices
    {
        //const string CONNECTION_STRING = @"Data Source=DESKTOP-PT451IS\MSSQLSERVER01;Initial Catalog=English_Centre1;Integrated Security=True"; //connection string của Nhi
        //const string CONNECTION_STRING = @"Data Source=DESKTOP-2138EM5\SQLEXPRESS;Initial Catalog=English_Centre;Integrated Security=True"; //connection string của Phát
        const string CONNECTION_STRING = @"Data Source=JOSIE;Initial Catalog=English_Centre;Integrated Security=True"; //connection string của TH
        //const string CONNECTION_STRING = @"Data Source=DESKTOP-D29FRPQ\MSSQL2022;Initial Catalog=cosmetic-store;Integrated Security=True"; ////connection string của Yang
        SqlConnection conn;
        SqlDataAdapter adapter;

        public DataServices()
        {
        }

        //Hàm kết nối đến database, nếu thành công sẽ trả về true, nếu thất bại sẽ trả về false
        public bool OpenDB()
        {
            try
            {
                conn = new SqlConnection(CONNECTION_STRING);
                conn.Open();
            }
            catch (SqlException ex)
            {
                conn = null;
                Console.WriteLine($"Error: {ex.Number}");
                return false;
            }
            return true;
        }

        //Hàm thực thi câu lệnh sql truyền vào, kết quả trả về nếu thành công là một DataTable, nếu thất bại thì trả về null
        public DataTable RunQuery(string sql)
        {
            DataTable returnedDataTable = new DataTable();

            try
            {
                adapter = new SqlDataAdapter(sql, conn);
                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adapter);
                adapter.Fill(returnedDataTable);
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error: {ex.Number}");
                return null;
            }

            return returnedDataTable;
        }

        //Hàm cập nhật lại dữ liệu từ datatable lên database
        public void Update(DataTable dataTable)
        {
            try
            {
                adapter.Update(dataTable);
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error: {ex.Number}");
            }
        }

        public void ExecuteNonQuery(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error: {ex.Number}");
            }
        }
    }
}