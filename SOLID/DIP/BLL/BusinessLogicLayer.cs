using SOLID.DIP.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DIP.BLL
{
    class BusinessLogicLayer
    {
        private readonly IRepositoryLayer DAL;

        public BusinessLogicLayer(IRepositoryLayer repositoryLayer)
        {
            DAL = repositoryLayer;
        }

        public void Save(Object details)
        {
            DAL.Save(details);
        }

    }
}
