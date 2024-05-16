using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObject
{
    public class BillDetails
    {
        int billID; 
        int varietyID; 
        int price; 
        int quantity;

        public BillDetails()
        {
        }

        public BillDetails(int billID, int varietyID, int price, int quantity) 
        {
            this.billID = billID;
            this.varietyID = varietyID;
            this.price = price;
            this.quantity = quantity;
        }

        public int BillID { get { return billID; } set { billID = value; } }
        public int VarietyID { get { return varietyID; } set { varietyID = value; } }
        public int Price { get { return price; } set { price = value; } }
        public int Quantity { get { return quantity; } set { quantity = value; } }
    }
}
