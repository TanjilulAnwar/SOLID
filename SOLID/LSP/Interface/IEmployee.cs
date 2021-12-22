using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP.Interface
{
    interface IEmployee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal GetMinimumSalary();


    }
}
