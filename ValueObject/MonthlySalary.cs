using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObject
{
    public class MonthlySalary
    {
        int staffID;
        int month;
        int year;
        int positionID;
        int totalLeavingDays;
        int actualReceiving;

        public MonthlySalary(int staffID, int month, int year, int positionID, int totalLeavingDays, int actualReceiving)
        {
            this.staffID = staffID;
            this.month = month;
            this.year = year;
            this.positionID = positionID;
            this.totalLeavingDays = totalLeavingDays;
            this.actualReceiving = actualReceiving;
        }

        public MonthlySalary()
        {
        }

        public int StaffID { get { return this.staffID; } set { this.staffID = value; } }
        public int Month { get { return this.month; } set { this.month = value; } }
        public int Year { get { return this.year; } set { this.year = value; } }
        public int PositionID { get { return this.positionID; } set { this.positionID = value; } }
        public int TotalLeavingDays { get { return this.totalLeavingDays; } set { this.totalLeavingDays = value; } }
        public int ActualReceiving { get { return this.actualReceiving; } set { this.actualReceiving = value; } }
    }
}
