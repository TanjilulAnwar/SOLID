using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DIP.DataAccess.Repository
{
    interface IRepositoryLayer
    {
        void Save(Object details);
    }
}
