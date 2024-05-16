using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObject
{
    public class ThongKeDoanhThuDTO
    {
        int productID;
        string productName;
        string categoryName;
        int volume;
        int price;
        int quantity;
        DateTime date;

        public ThongKeDoanhThuDTO()
        { }

        public ThongKeDoanhThuDTO(int productID, string productName, string categoryName, int volume, int price, int quantity, DateTime date)
        {
            this.productID = productID;
            this.productName = productName;
            this.categoryName = categoryName;
            this.volume = volume;
            this.price = price;
            this.quantity = quantity;
            this.date = date;
        }

        public int ProductID { get { return productID; } set { productID = value; } }
        public string ProductName { get {  return productName; } set { productName = value; } }
        public string CategoryName { get { return categoryName; } set {  categoryName = value; } }
        public int Volume { get { return volume; } set { volume = value; } }
        public int Price { get { return price; } set { price = value; } }
        public int Quantity { get { return quantity; } set { quantity = value; } }
        public DateTime Date { get { return date; } set { date = value; } }
    }
}
