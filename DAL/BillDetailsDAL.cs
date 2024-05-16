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
        DatabaseConnection dataServices = new DatabaseConnection();
        DataTable dataTable;

        public BillDetailsDAL()
        {
            dataServices.OpenDB();
        }

        public List<BillDetails> getAll(int maHD)
        {
            List<BillDetails> list = new List<BillDetails>();
            string sql = $"SELECT * FROM BillDetails WHERE BillID = {maHD}";
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
            string sql = $"INSERT INTO BillDetails VALUES({bd.BillID},{bd.VarietyID},{bd.Quantity},{bd.Price})";
            dataServices.ExecuteNonQuery(sql);

            sql = $"UPDATE ProductVariety WHERE VarietyID = {bd.VarietyID} SET Quantity = Quantity - {bd.Quantity}";
            dataServices.ExecuteNonQuery(sql);

            sql = $"UPDATE SaleBill WHERE BillID = {bd.BillID} SET TotalValue = TotalValue + {bd.Quantity*bd.Price}";
            dataServices.ExecuteNonQuery(sql);
            return true;
        }

        public bool Delete(int BillID, int VarietyID)
        {
            try
            {
                string sql = $"DELETE FROM BillDetails WHERE BillID = {BillID} AND VarietyID = {VarietyID}";
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
            try
            {
                string sql = $"UPDATE BillDetails SET Quantity = {bd.Quantity} WHERE BillID = {bd.BillID} AND VarietyID = {bd.VarietyID}";
                dataServices.ExecuteNonQuery(sql);
            }
            catch (Exception e)
            {
                return false;
            }
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

        public bool TrungMa(int BillID, int VarietyID)
        {
            string sql = $"SELECT * FROM BillDetails WHERE BillID = {BillID} AND VarietyID = {VarietyID}";
            dataTable = dataServices.RunQuery(sql);
            if (dataTable.Rows.Count == 0) return false;
            return true;
        }
    }
}
