using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP
{
    interface IEmployeeBonus
    {
        decimal CalculateBonus(decimal salary);
    }
}
