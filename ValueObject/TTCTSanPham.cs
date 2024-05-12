using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObject
{
	public class TTCTSanPham
	{
		int varietyID;
		int productVolume;
		int price;
		int quantity;
		int productID;
		string productName;
		int importPrice;

		public TTCTSanPham() 
		{

		}

		public TTCTSanPham(int varietyID, int productVolume, int price, int quantity, int productID, string productName, int importPrice)
		{
			this.varietyID = varietyID;
			this.productID = productID;
			this.productName = productName;
			this.productVolume = productVolume;
			this.importPrice = importPrice; 
			this.price = price;
			this.quantity = quantity;
		}

		public int VarietyID { get { return varietyID; } set { varietyID = value; } }
		public int ProductID { get { return productID; } set { productID = value; } }
		public string ProductName { get { return productName; } set {productName = value; } }
		public int ProductVolume { get { return productVolume; } set { productVolume = value; } }
		public int Price { get { return price; } set { price = value; } }
		public int ImportPrice { get { return importPrice; } set { importPrice = value; } }
		public int Quantity { get { return quantity; } set { quantity = value; } }

	}
}
