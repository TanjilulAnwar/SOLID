using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP
{
    public abstract class Employee
    {

        public int ID { get; set; }
        public string Name { get; set; }

        public Employee(string Name, string ID) : this()
        {

        }
        public Employee()
        {

        }

        public abstract decimal CalculateBonus(decimal salary);
        public override string ToString()
        {
            return string.Format("ID: " + this.ID + " Name: " + this.Name);

        }
    }

    public class PermanentEmployee : Employee
    {

        public PermanentEmployee(string Name, string ID) : base(Name,ID)//because this is a hybrid contstructor
        {

        }
        public PermanentEmployee()
        {

        }
        public override decimal CalculateBonus(decimal salary)
        {
            return salary * .1M;
        }
    }

    public class TemporaryEmployee : Employee
    {

        public TemporaryEmployee(string Name, string ID) : base(Name, ID)//because this is a hybrid contstructor
        {

        }
        public TemporaryEmployee() 
        {

        }
        public override decimal CalculateBonus(decimal salary)
        {
            return salary * .05M;
        }
    }






}
