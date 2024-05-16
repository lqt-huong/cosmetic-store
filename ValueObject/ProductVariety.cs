using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObject
{
	public class ProductVariety
	{
		int varietyID;
		int productID;
		int productVolume;
		int price;
		int quantity;
		int isDeleted;

		public ProductVariety()
		{

		}

		public ProductVariety(int varietyID, int productID, int productVolume, int price, int quantity, int isDeleted)
		{
			this.varietyID = varietyID;
			this.productID = productID;
			this.productVolume = productVolume;
			this.price = price;
			this.quantity = quantity;
			this.isDeleted = isDeleted;
		}

		public int VarietyID { get { return varietyID; } set { varietyID = value; } }
		public int ProductID { get { return productID; } set { productID = value; } }
		public int ProductVolume { get { return productVolume; } set { productVolume = value; } }
		public int Price { get { return price; } set { price = value; } }
		public int Quantity { get { return quantity; } set { quantity = value; } }
		public int IsDeleted { get { return isDeleted; } set { isDeleted = value; } }

	}
}
