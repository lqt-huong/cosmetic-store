using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject;

namespace DAL
{
    public class BillDetailsDAL
    {
        DataServices dataServices = new DataServices();
        DataTable dataTable;

        public BillDetailsDAL()
        {

        }

        public List<BillDetails> getAll()
        {
            List<BillDetails> list = new List<BillDetails>();
            string sql = "SELECT * FROM BillDetails WHERE BillID!=0";
            if (!dataServices.OpenDB()) return null;
            dataTable = dataServices.RunQuery(sql);
            BillDetails bd;

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                bd = new BillDetails();
                bd.BillID = (int)dataTable.Rows[i]["BillID"];
                bd.VarietyID = (int)dataTable.Rows[i]["VarietyID"];
                bd.Price = (int)dataTable.Rows[i]["Price"];
                bd.Quantity = (int)dataTable.Rows[i]["Quantity"];
                list.Add(bd);
            }
            return list;
        }

        public bool Insert(BillDetails bd)
        {
            string sql = "SELECT * FROM BillDetails";
            dataTable = dataServices.RunQuery(sql);
            DataRow row = dataTable.NewRow();
            row["BillID"] = bd.BillID;
            row["VarietyID"] = bd.VarietyID;
            row["Price"] = bd.Price;
            row["Quantity"] = bd.Quantity;
            dataTable.Rows.Add(row);
            dataServices.Update(dataTable);
            return true;
        }

        public bool Delete(int BillID)
        {
            try
            {
                string sql = $"DELETE FROM BillDetails WHERE BillID = {BillID}";
                dataServices.ExecuteNonQuery(sql);
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public bool Update(BillDetails bd)
        {
            string sql = "SELECT * FROM BillDetails";
            dataTable = dataServices.RunQuery(sql);
            dataTable.PrimaryKey = new DataColumn[] { dataTable.Columns["BillID"] };
            DataRow row = dataTable.Rows.Find(bd.BillID);
            row["BillID"] = bd.BillID;
            row["VarietyID"] = bd.VarietyID;
            row["Price"] = bd.Price;
            row["Quantity"] = bd.Quantity;
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
