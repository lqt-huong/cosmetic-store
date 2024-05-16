using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ValueObject;
namespace DAL
{
    public class ContractDAL
    {
        DatabaseConnection dbConn = new DatabaseConnection();
        DataTable dataTable;
        public ContractDAL()
        {

        }
        public List<Contract> GetAllContract()
        {
            List<Contract> list = new List<Contract>();
            string query = "SELECT * FROM Contract WHERE IsDeleted=0";
            if (!dbConn.OpenDB())
                return null;
            dataTable = dbConn.RunQuery(query);
            Contract contract;
            foreach (DataRow row in dataTable.Rows)
            {
                contract = new Contract();
                contract.ContractNo = (int)row["ContractNo"];
                contract.StartingDate = (DateTime)row["StartingDate"];
                contract.EndingDate = (DateTime)row["EndingDate"];
                contract.StaffID = (int)row["StaffID"];
                contract.PositionID = (int)row["PositionID"];
                contract.IsDeleted = Convert.ToByte((bool)row["IsDeleted"]);
                list.Add(contract);
            }
            return list;
        }
        public bool InsertContract(Contract contract)
        {
            string query = "SELECT * FROM Contract";
            dataTable = dbConn.RunQuery(query);
            DataRow new_row = dataTable.NewRow();
            new_row["ContractNo"] = contract.ContractNo;
            new_row["StartingDate"] = contract.StartingDate;
            new_row["EndingDate"] = contract.EndingDate;
            new_row["StaffID"] = contract.StaffID;
            new_row["PositionID"] = contract.PositionID;
            new_row["IsDeleted"] = contract.IsDeleted;

            dataTable.Rows.Add(new_row);
            dbConn.Update(dataTable);
            return true;
        }
        public int AutoID()
        {
            int id = 0;
            string query = "SELECT MAX(ContractNo) as max_contractNo FROM Contract";
            dataTable = dbConn.RunQuery(query);
            int num = -1;
            if (!int.TryParse(dataTable.Rows[0]["max_contractNo"].ToString(), out num))
                return 1;
            id = (int)dataTable.Rows[0]["max_contractNo"];
            return id + 1;
        }
        public bool CheckContractNoExist(int contractNo)
        {
            string query = $"SELECT * FROM Contract WHERE ContractNo={contractNo}";
            dataTable = dbConn.RunQuery(query);
            if (dataTable.Rows.Count > 0) return true;
            return false;
        }
        public bool UpdateContract(Contract contract)
        {
            string query = "SELECT * FROM Contract Where IsDeleted = 0";
            dataTable = dbConn.RunQuery(query);
            dataTable.PrimaryKey = new DataColumn[] { dataTable.Columns["ContractNo"] };
            DataRow new_row = dataTable.Rows.Find(contract.ContractNo);
            new_row["StartingDate"] = contract.StartingDate;
            new_row["EndingDate"] = contract.EndingDate;
            new_row["StaffID"] = contract.StaffID;
            new_row["PositionID"] = contract.PositionID;

            dbConn.Update(dataTable);
            return true;
        }
        public bool DeleteContract(int contractNo)
        {
            string query = $"SELECT * FROM Contract Where ContractNo = {contractNo} ";
            dataTable = dbConn.RunQuery(query);
            dataTable.PrimaryKey = new DataColumn[] { dataTable.Columns["ContractNo"] };
            DataRow new_row = dataTable.Rows.Find(contractNo);
            new_row["IsDeleted"] = 1;
            dbConn.Update(dataTable);
            return true;
        }
    }
}
