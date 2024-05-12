using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using ValueObject;
namespace BLL
{
    public class ContractBLL
    {
        static ContractDAL contractDAL;
        static List<Contract> contractList;
        public ContractBLL()
        {
            contractDAL = new ContractDAL();
            contractList = contractDAL.GetAllContract();

        }
        public List<Contract> GetAllContract()
        {
            return contractDAL.GetAllContract();
        }
        public bool InsertContract(Contract contract)
        {
            return contractDAL.InsertContract(contract);
        }
        public int AutoID()
        {
            return contractDAL.AutoID();
        }
        public bool CheckContractNoExist(int contractNo)
        {
            return contractDAL.CheckContractNoExist(contractNo);
        }
        public bool UpdateContract(Contract contract)
        {
            return contractDAL.UpdateContract(contract);
        }
        public bool DeleteContract(int contractNo)
        {
            return contractDAL.DeleteContract(contractNo);
        }
    }
}
