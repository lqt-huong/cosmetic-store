using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject;
using static System.Net.Mime.MediaTypeNames;

namespace DAL
{
	public class CTHoaDonNhapDAL
	{
		DatabaseConnection databaseConnection = new DatabaseConnection();
		DataTable dataTable;

		public CTHoaDonNhapDAL()
		{
		}

		public List<CTHoaDonNhap> GetAllCTHoaDonNhap()
		{
			List<CTHoaDonNhap> cthdNhap = new List<CTHoaDonNhap>();
			string query = $"select * from ImportDetails";
			if (!databaseConnection.OpenDB()) return null;

			dataTable = databaseConnection.RunQuery(query);
			CTHoaDonNhap cthdn;

			for (int i = 0; i < dataTable.Rows.Count; i++)
			{
				cthdn = new CTHoaDonNhap();
				cthdn.ImportBillID = (int)dataTable.Rows[i]["ImportBillID"];
				cthdn.VarietyID = (int)dataTable.Rows[i]["VarietyID"];
				cthdn.Quantity = (int)dataTable.Rows[i]["Quantity"];
				cthdn.ImportPrice = (int)dataTable.Rows[i]["Price"];
				cthdNhap.Add(cthdn);
			}
			return cthdNhap;
		}

		public List<CTHoaDonNhap> GetCTHoaDonNhap(int maHDN)
		{
			List<CTHoaDonNhap> cthdNhap = new List<CTHoaDonNhap>();
			string query = $"select * from ImportDetails where ImportBillID = '{maHDN}'";
			dataTable = databaseConnection.RunQuery(query);
			CTHoaDonNhap cthdn;

			for (int i = 0; i < dataTable.Rows.Count; i++)
			{
				cthdn = new CTHoaDonNhap();
				cthdn.ImportBillID = (int)dataTable.Rows[i]["ImportBillID"];
				cthdn.VarietyID = (int)dataTable.Rows[i]["VarietyID"];
				cthdn.Quantity = (int)dataTable.Rows[i]["Quantity"];
				cthdn.ImportPrice = (int)dataTable.Rows[i]["Price"];
				cthdNhap.Add(cthdn);
			}
			return cthdNhap;
		}

		public void TangSL(int mhdn)
		{
			int sum = 0;
			string query = $"select * from ImportDetails ip and ProductVariety pv where ImportBillID = '{mhdn}' and ip.VarietyID = pv.VarietyID";
			dataTable = databaseConnection.RunQuery(query);
			for (int i = 0; i < dataTable.Rows.Count; i++)
			{
				int SLNhap, SLTK;
				SLNhap = (int)dataTable.Rows[i]["ip.Quantity"];
				SLTK = (int)dataTable.Rows[i]["pv.Quantity"];
				sum = SLNhap + SLTK;
				string queryP = $"update ProductVariety set Quantity = '{sum}' where VarietyID = '{(int)dataTable.Rows[i]["VarietyID"]}'";
				databaseConnection.ExecuteNonQuery(queryP);
			}
		}

		public bool ThemCTHoaDonNhap(CTHoaDonNhap cthdn)
		{
			try
			{
				string query = $"insert into ImportDetails(ImportBillID, VarietyID, Quantity, Price) values({cthdn.ImportBillID}, {cthdn.VarietyID}, {cthdn.Quantity}, {cthdn.ImportPrice})";
				databaseConnection.ExecuteNonQuery(query);
				
			}
			catch (Exception e)
			{
				return false;
			}
			return true;
		}

		public bool SuaCTHoaDonNhap(CTHoaDonNhap cthdn)
		{
			try
			{
				string query = $"update ImportDetails set Quantity = {cthdn.Quantity} , Price = {cthdn.ImportPrice} where ImportBillID = {cthdn.ImportBillID} and VarietyID = {cthdn.VarietyID}";
				databaseConnection.ExecuteNonQuery(query);
			}
			catch (Exception e)
			{
				return false;
			}
			return true;
		}

		public bool XoaCTHoaDonNhap(int importBillID, int varietyID)
		{
			try
			{
				string query = $"delete from ImportDetails where ImportBillID = {importBillID} and VarietyID = {varietyID}";
				databaseConnection.ExecuteNonQuery(query);
			}
			catch (Exception e)
			{
				return false;
			}
			return true;
		}

		public bool HuyHDN(int importBillID)
		{
			try
			{
				string query = $"delete from ImportDetails where ImportBillID = {importBillID}";
				databaseConnection.ExecuteNonQuery(query);
			}
			catch (Exception e)
			{
				return false;
			}
			return true;
		}



		public int AutoID()
		{
			int id;
			string query = "select max(ImportBillID) as max_ID from ImportBill";
			dataTable = databaseConnection.RunQuery(query);
			int num = -1;
			if (!int.TryParse(dataTable.Rows[0]["max_ID"].ToString(), out num)) return 1;
			id = (int)dataTable.Rows[0]["max_ID"];
			return id + 1;
		}

		public bool KiemTraTrung(int maHDN, int maDSP )
		{
			string queryPr = $"select * from ImportDetails where ImportBillID = '{maHDN}' and VarietyID = '{maDSP}'";
			dataTable = databaseConnection.RunQuery(queryPr);
			if (dataTable.Rows.Count > 0) return false;
			return true;
		}

		public string getProviderName(int providerID)
		{
			string query = $"select ProviderName from Provider where ProviderID = {providerID}";
			dataTable = databaseConnection.RunQuery(query);
			return dataTable.Rows[0]["ProviderName"].ToString();
		}

		public string getStaffName(int staffID)
		{
			string query = $"select StaffName from Provider where StaffID = {staffID}";
			dataTable = databaseConnection.RunQuery(query);
			return dataTable.Rows[0]["ProviderName"].ToString();
		}

		public int TongTien(int maHDN)
		{
			int sum = 0;
			//SELECT SUM(cot)FROM bang[WHERE dieukien];
			string query = $"select * from ImportDetails where ImportBillID = '{maHDN}'";
			dataTable = databaseConnection.RunQuery(query);
			for (int i = 0; i < dataTable.Rows.Count; i++)
			{
				int quantity, price;
				quantity = (int)dataTable.Rows[i]["Quantity"];
				price = (int)dataTable.Rows[i]["Price"];
				sum += quantity * price;
			}
			return sum;
		}



	}
}
