using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAL;

namespace BLL
{
    
    public class testBLL
    {
        DatabaseConnection dbConn = new DatabaseConnection();
        public testBLL()
        {

        }

        public bool OpenDB()
        {
            return dbConn.OpenDB();
        }
    }

}
