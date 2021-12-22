using SOLID.LSP.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP.Implementation
{
    public class ContractEmployee : IEmployee
    {
        public int ID { get ; set ; }
        public string Name { get ; set ; }

        public ContractEmployee(string Name, string ID) 
        {

        }
        public ContractEmployee()
        {

        }


        public override string ToString()
        {
            return string.Format("ID: " + this.ID + " Name: " + this.Name);

        }
        public decimal GetMinimumSalary()
        {
            return 45000;
        }
    }
}
