using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObject
{
    public class SaleBill
    {
        int billID;
        DateTime date;
        int totalValue;
        int staffID;
        bool isDeleted;

        public SaleBill() 
        { }

        public SaleBill(int billID, DateTime date, int totalValue, int staffID, bool isDeleted)
        {
            this.billID = billID;
            this.date = date;
            this.totalValue = totalValue;
            this.staffID = staffID;
            this.isDeleted = isDeleted;
        }

        public int BillID { get { return billID; } set { billID = value; } }
        public DateTime Date { get { return date; } set { date = value; } }
        public int TotalValue { get { return totalValue; } set { totalValue = value; } }
        public int StaffID { get { return staffID; } set { staffID = value; } }
        public bool IsDeleted { get { return isDeleted; } set { isDeleted = value; } }
    }
}
