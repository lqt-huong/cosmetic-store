using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject;

namespace DAL
{
    public class MonthlySalaryDAL
    {
        DatabaseConnection dataServices = new DatabaseConnection();
        DataTable dataTable;

        public MonthlySalaryDAL()
        {   
        }

        public List<MonthlySalary> GetAll(int month, int year)
        {
            List<MonthlySalary> list = new List<MonthlySalary>();
            string sql = $"SELECT * FROM MonthlySalary WHERE Month = {month} AND Year = {year}";
            if (!dataServices.OpenDB()) return null;
            dataTable = dataServices.RunQuery(sql);
            MonthlySalary luong;

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                luong = new MonthlySalary();
                luong.StaffID = (int)dataTable.Rows[i]["StaffID"];
                luong.Month = (int)dataTable.Rows[i]["Month"];
                luong.Year = (int)dataTable.Rows[i]["Year"];
                luong.PositionID = (int)dataTable.Rows[i]["PositionID"];
                luong.TotalLeavingDays = (int)dataTable.Rows[i]["TotalLeavingDays"];
                luong.ActualReceiving = (int)dataTable.Rows[i]["ActualReceiving"];
                list.Add(luong);
            }
            return list;
        }

        public bool Insert(MonthlySalary luong)
        {
            string sql = "SELECT * FROM MonthlySalary";
            dataTable = dataServices.RunQuery(sql);
            DataRow row = dataTable.NewRow();
            row["StaffID"] = luong.StaffID;
            row["Month"] = luong.Month;
            row["Year"] = luong.Year;
            row["PositionID"] = luong.PositionID;
            row["TotalLeavingDays"] = luong.TotalLeavingDays;
            row["ActualReceiving"] = luong.ActualReceiving;
            dataTable.Rows.Add(row);
            dataServices.Update(dataTable);
            return true;
        }

        public bool DaTinhLuong(int month, int year)
        {
            string sql = $"SELECT * FROM Account WHERE Month = {month} AND Year = {year}";
            dataTable = dataServices.RunQuery(sql);
            if (dataTable.Rows.Count == 0) return false;
            return true;
        }
    }
}
