using SOLID.LSP.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP.Implementation
{
    public class TemporaryEmployee : Employee
    {

        public TemporaryEmployee(string Name, string ID) : base(Name, ID)//because this is a hybrid contstructor
        {

        }
        public TemporaryEmployee()
        {

        }

        public override decimal GetMinimumSalary()
        {
            return 50000;
        }

        public override decimal CalculateBonus(decimal salary)
        {
            return salary * .05M;
        }
    }
}
