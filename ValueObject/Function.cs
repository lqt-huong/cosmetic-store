using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObject
{
    public class Function
    {
        int functionID;
        string functionName;

        public Function(int functionID, string functionName)
        {
            this.functionID = functionID;
            this.functionName = functionName;
        }

        public Function()
        {
        }

        public int FunctionID { get { return this.functionID; } set { this.functionID = value; } }
        public string FunctionName { get { return this.functionName; } set { this.functionName = value; } }
    }
}
