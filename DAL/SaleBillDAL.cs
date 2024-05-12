﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject;
using static System.Net.Mime.MediaTypeNames;

namespace DAL
{
    public class SaleBillDAL
    {
        DataServices dataServices = new DataServices();
        DataTable dataTable;

        public SaleBillDAL()
        {
            dataServices.OpenDB();
        }

        public List<SaleBill> getAll()
        {
            List<SaleBill> list = new List<SaleBill>();
            string sql = "SELECT * FROM SaleBill WHERE IsDeleted = 0";
            if (!dataServices.OpenDB()) return null;
            dataTable = dataServices.RunQuery(sql);
            SaleBill saleBill;

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                saleBill = new SaleBill();
                saleBill.BillID = (int)dataTable.Rows[i]["BillID"];
                saleBill.Date = (DateTime)dataTable.Rows[i]["Date"];
                saleBill.TotalValue = (int)dataTable.Rows[i]["TotalValue"];
                saleBill.StaffID = (int)dataTable.Rows[i]["StaffID"];
                saleBill.IsDeleted = Convert.ToBoolean(dataTable.Rows[i]["IsDeleted"]);                
                list.Add(saleBill);
            }
            return list;
        }

        public bool Insert(SaleBill saleBill)
        {
            string sql = "SELECT * FROM SaleBill";
            dataTable = dataServices.RunQuery(sql);
            DataRow row = dataTable.NewRow();
            row["BillID"] = saleBill.BillID;
            row["Date"] = saleBill.Date;
            row["TotalValue"] = saleBill.TotalValue; 
            row["StaffID"] = saleBill.StaffID;
            row["IsDeleted"] = saleBill.IsDeleted;            
            dataTable.Rows.Add(row);
            dataServices.Update(dataTable);
            return true;
        }

        public bool Delete(int billID )
        {
            try
            {
                string sql = $"UPDATE SaleBill SET IsDeleted = 1 WHERE BillID = '{billID}'";
                dataServices.ExecuteNonQuery(sql);
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public bool Update(SaleBill saleBill)
        {
            string sql = "SELECT * FROM SaleBill";
            dataTable = dataServices.RunQuery(sql);
            dataTable.PrimaryKey = new DataColumn[] { dataTable.Columns["BillID"] };
            DataRow row = dataTable.Rows.Find(saleBill.BillID);
            row["BillID"] = saleBill.BillID;
            row["Date"] = saleBill.Date;
            row["TotalValue"] = saleBill.TotalValue;
            row["IsDeleted"] = saleBill.IsDeleted;
            row["StaffID"] = saleBill.StaffID;
            dataServices.Update(dataTable);
            return true;
        }


        public int GetFee(int VarietyID)
        {
            string sql = $"SELECT Price FROM ProductVariety WHERE VarietyID = {VarietyID}";
            dataTable = dataServices.RunQuery(sql);
            int fee = (int)dataTable.Rows[0]["Price"];
            return fee;
        }

        public bool TrungMa(int BillID)
        {
            string sql = $"SELECT * FROM SaleBill WHERE BillID = {BillID}";
            dataTable = dataServices.RunQuery(sql);
            if (dataTable.Rows.Count == 0) return false;
            return true;
        }

        public int NextID()
        {
            string sql = "SELECT MAX(BillID) as 'max' FROM SaleBill";
            dataTable = dataServices.RunQuery(sql);
            int num = -1;
            if (!int.TryParse(dataTable.Rows[0]["max"].ToString(), out num)) return 1;
            int curId = (int)dataTable.Rows[0]["max"];
            return curId + 1;
        }
    }
}
