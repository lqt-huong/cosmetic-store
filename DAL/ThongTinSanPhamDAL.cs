using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using ValueObject;

namespace DAL
{
	public class ThongTinSanPhamDAL
	{
		DatabaseConnection databaseConnection = new DatabaseConnection();
		DataTable dataTable;
		public ThongTinSanPhamDAL()
		{
		}

		public List<TTCTSanPham> GetAllTTSanPhams()
		{
			List<TTCTSanPham> listSP = new List<TTCTSanPham>();
			string querySP = "select * from Product p and ProductVariety pv and ImportDetails ipd where p.IsDeleted != 1 and p.ProductID = pv.ProductID and pv.VarietyID = ipd.VarietyID";
			//Ket noi false thi tra ve null
			if (!databaseConnection.OpenDB())
				return null;
			dataTable = databaseConnection.RunQuery(querySP);
			TTCTSanPham TTSanPham;

			for (int i = 0; i < dataTable.Rows.Count; i++)
			{
				TTSanPham = new TTCTSanPham();
				TTSanPham.VarietyID = (int)dataTable.Rows[i]["VarietyID"];
				TTSanPham.ProductID = (int)dataTable.Rows[i]["ProductID"];
				TTSanPham.ProductName = dataTable.Rows[i]["ProductName"].ToString();
				TTSanPham.ProductVolume = (int)dataTable.Rows[i]["Volume"];
				TTSanPham.ImportPrice = (int)dataTable.Rows[i]["ipd.Price"];
				TTSanPham.Price = (int)dataTable.Rows[i]["pv.Price"];
			}
			return listSP;
		}

		public List<ProductVariety> GetSanPhamNCC(int providerID)
		{
			List<ProductVariety> listSP = new List<ProductVariety>();
			string querySP = $"select * from ProductVariety pv and Product p where IsDelete != 1 and pv.ProductID = p.ProductID and p.ProviderID = '{providerID}' ";
			if (!databaseConnection.OpenDB())
				return null;
			dataTable = databaseConnection.RunQuery(querySP);
			ProductVariety TTSanPham;

			for (int i = 0; i < dataTable.Rows.Count; i++)
			{
				TTSanPham = new ProductVariety();
				TTSanPham.VarietyID = (int)dataTable.Rows[i]["VarietyID"];
				TTSanPham.ProductID = (int)dataTable.Rows[i]["ProductID"];
				TTSanPham.ProductVolume = (int)dataTable.Rows[i]["Volume"];
				TTSanPham.Price = (int)dataTable.Rows[i]["Price"];
				TTSanPham.Quantity = (int)dataTable.Rows[i]["Quantity"];
			}
			return listSP;
		}

		public List<ProductVariety> GetAllProductVariety()
		{
			List<ProductVariety> listSP = new List<ProductVariety>();
			string querySP = $"select * from ProductVariety where IsDeleted != 1";
			if (!databaseConnection.OpenDB())
				return null;
			dataTable = databaseConnection.RunQuery(querySP);
			ProductVariety TTSanPham;

			for (int i = 0; i < dataTable.Rows.Count; i++)
			{
				TTSanPham = new ProductVariety();
				TTSanPham.VarietyID = (int)dataTable.Rows[i]["VarietyID"];
				TTSanPham.ProductID = (int)dataTable.Rows[i]["ProductID"];
				TTSanPham.ProductVolume = (int)dataTable.Rows[i]["Volume"];
				TTSanPham.Price = (int)dataTable.Rows[i]["Price"];
				TTSanPham.Quantity = (int)dataTable.Rows[i]["Quantity"];
			}
			return listSP;
		}

		public bool ThemTTSP(ProductVariety TTSanPham)
		{
			string querySP = "select * from ProductVariety";
			dataTable = databaseConnection.RunQuery(querySP);
			DataRow row = dataTable.NewRow();
			TTSanPham.Quantity = 0;
			row["VarietyID"] = TTSanPham.VarietyID;
			row["ProductID"] = TTSanPham.ProductID;
			row["Volume"] = TTSanPham.ProductVolume;
			row["Price"] = TTSanPham.Price;
			row["Quantity"] = TTSanPham.Quantity;
			dataTable.Rows.Add(row);
			databaseConnection.Update(dataTable);
			return true;
		}

		public bool SuaTTSP(ProductVariety TTSanPham)
		{
			string querySP = "select* from ProductVariety";
			dataTable = databaseConnection.RunQuery(querySP);
			//Tao cot khoa chinh
			dataTable.PrimaryKey = new DataColumn[] { dataTable.Columns["VarietyID"] };
			DataRow row = dataTable.Rows.Find(TTSanPham.VarietyID);
			row["ProductID"] = TTSanPham.ProductID;
			row["Volume"] = TTSanPham.ProductVolume;
			row["Price"] = TTSanPham.Price;
			row["Quantity"] = TTSanPham.Quantity;
			databaseConnection.Update(dataTable);
			return true;
		}

		public bool XoaTTSP(int varietyID)
		{
			try
			{
				string queryPrVariety = $"update ProductVariety set IsDeleted = 1 where VarietyID = '{varietyID}";
				databaseConnection.ExecuteNonQuery(queryPrVariety);
			}
			catch (Exception ex)
			{
				return false;
			}
			return true;
		}

		public bool KiemTraTrung(int productID, int productVolume)
		{
			string queryPr = $"select * from ProductVariety where ProductID = '{productID}' && Volume = '{productVolume}'";
			dataTable = databaseConnection.RunQuery(queryPr);
			if (dataTable.Rows.Count > 0) return false;
			return true;
		}

		public bool KiemTraTrungMa(int varietyID)
		{
			string queryPr = $"select * from ProductVariety where VarietyID = '{varietyID}'";
			dataTable = databaseConnection.RunQuery(queryPr);
			if (dataTable.Rows.Count > 0) return false;
			return true;
		}


		public int AutoID()
		{
			int id;
			string query = "select max(VarietyID) as max_ID from ProductVariety";
			dataTable = databaseConnection.RunQuery(query);
			int num = -1;
			if (!int.TryParse(dataTable.Rows[0]["max_ID"].ToString(), out num)) return 1;
			id = (int)dataTable.Rows[0]["max_ID"];
			return id + 1;
		}

		//Lấy tên sản phẩm
		public string getProductName(int productID)
		{
			string query = $"select ProductName from Product where ProductID = {productID}";
			dataTable = databaseConnection.RunQuery(query);
			return dataTable.Rows[0]["ProductName"].ToString();
		}

		//Lấy tên nhà cung cấp sản phẩm
		public string getProviderName(int providerID)
		{
			string query = $"select ProviderName from Provider where ProviderID = {providerID}";
			dataTable = databaseConnection.RunQuery(query);
			return dataTable.Rows[0]["ProviderName"].ToString();
		}

		//Lấy tên loại sản phẩm
		public string getCategoryName(int categoryID)
		{
			string query = $"select CategoryName from Category where CategoryID = {categoryID}";
			dataTable = databaseConnection.RunQuery(query);
			return dataTable.Rows[0]["CategoryName"].ToString();
		}

	}
}
