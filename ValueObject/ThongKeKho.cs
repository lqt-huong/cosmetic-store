using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObject
{
	public class ThongKeKho
	{
		int varietyID;
		int productID;
		string productName;
		int productVolume;
		DateTime date;
		int price;
		int quantity;
		int providerID;

		public ThongKeKho()
		{

		}

		public ThongKeKho(int varietyID, int productID, string productName, int productVolume, DateTime date, int price, int quantity, int providerID)
		{
			this.varietyID = varietyID;
			this.productID = productID;
			this.productName = productName;
			this.productVolume = productVolume;
			this.date = date;
			this.price = price;
			this.quantity = quantity;
			this.providerID = providerID;
		}

		public int VarietyID { get { return varietyID; } set { varietyID = value; } }
		public int ProductID { get { return productID; } set { productID = value; } }
		public string ProductName { get { return productName; } set { productName = value; } }
		public int ProductVolume { get { return productVolume; } set { productVolume = value; } }
		public int Price { get { return price; } set { price = value; } }
		public DateTime Date { get { return date; } set { date = value; } }
		public int Quantity { get { return quantity; } set { quantity = value; } }
		public int ProviderID { get { return providerID; } set { providerID = value; } }
	}
}
