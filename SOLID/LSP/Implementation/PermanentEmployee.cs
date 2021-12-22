using SOLID.LSP.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP.Implementation
{
    public class PermanentEmployee : Employee
    {

        public PermanentEmployee(string Name, string ID) : base(Name, ID)//because this is a hybrid contstructor
        {

        }
        public PermanentEmployee()
        {

        }

        public override decimal GetMinimumSalary()
        {
            return 55000;
        }

        public override decimal CalculateBonus(decimal salary)
        {
            return salary * .1M;
        }
    }
}
