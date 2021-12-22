using SOLID.DIP.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DIP.DataAccess
{
    class DataAcessLayer : IRepositoryLayer
    {
        public void Save(object details)
        {
            Console.WriteLine("Saved!");
        }
    }
}
