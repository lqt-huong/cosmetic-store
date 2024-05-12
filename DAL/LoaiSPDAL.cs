using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject;

namespace DAL
{
	public class LoaiSPDAL
	{
		DatabaseConnection databaseConnection = new DatabaseConnection();
		DataTable dataTable;
		public LoaiSPDAL() 
		{ 
		}

		public List<LoaiSP> getAllLoaiSP()
		{
			List<LoaiSP> listLsp = new List<LoaiSP>();
			string query = "select * from Category where IsDeleted != 1";
			if (!databaseConnection.OpenDB()) return null;
			dataTable = databaseConnection.RunQuery(query);
			LoaiSP lsp;

			for (int i = 0; i < dataTable.Rows.Count; i++)
			{
				lsp = new LoaiSP();
				lsp.CategoryID = (int)dataTable.Rows[i]["CategoryID"];
				lsp.CategoryName = dataTable.Rows[i]["CategoryName"].ToString();
				lsp.NumberOfItems = (int)dataTable.Rows[i]["NumberOfItems"];
				lsp.IsDeleted = (int)dataTable.Rows[i]["IsDeleted"];
				listLsp.Add(lsp);
			}
			return listLsp;
		}

		public bool ThemLSP(LoaiSP lsp)
		{
			try
			{
				string query = $"insert into Category(CategoryID, CategoryName, NumberOfItems, IsDeleted) values({lsp.CategoryID}, '{lsp.CategoryName}', '0'')";
				databaseConnection.ExecuteNonQuery(query);
			}
			catch (Exception e)
			{
				return false;
			}
			return true;
		}

		public bool SuaLSP(LoaiSP lsp)
		{
			try
			{
				string query = $"update Category set CategoryName = '{lsp.CategoryName}' where CategoryID = {lsp.CategoryID}";
				databaseConnection.ExecuteNonQuery(query);
			}
			catch (Exception e)
			{
				return false;
			}
			return true;
		}

		public bool XoaLSP(int categoryID)
		{
			try
			{
				string query = $"update Category set IsDeleted = '1' where CategoryID = {categoryID}";
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
			string query = "select max(CategoryID) as max_ID from Category";
			dataTable = databaseConnection.RunQuery(query);
			int num = -1;
			if (!int.TryParse(dataTable.Rows[0]["max_ID"].ToString(), out num)) return 1;
			id = (int)dataTable.Rows[0]["max_ID"];
			return id + 1;
		}

		public bool KiemTraTrung(int categoryID)
		{
			string queryPr = $"select * from Category where ProviderID = '{categoryID}'";
			dataTable = databaseConnection.RunQuery(queryPr);
			if (dataTable.Rows.Count > 0) return false;
			return true;
		}




	}
}
