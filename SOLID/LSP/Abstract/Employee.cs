using SOLID.LSP.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP.Abstract
{
    public abstract class Employee:IEmployee,IEmployeeBonus
    {

        public int ID { get; set; }
        public string Name { get; set; }

        public Employee(string Name, string ID) : this()
        {

        }
        public Employee()
        {

        }

    
        public override string ToString()
        {
            return string.Format("ID: " + this.ID + " Name: " + this.Name);

        }

        public abstract decimal GetMinimumSalary();
       

        public abstract decimal CalculateBonus(decimal salary);
        
    }

   

  






}
