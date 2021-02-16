using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BusinessLogicLayerData;
using BusinessLogicLayer.Interfaces;
using DataAccessLayer.DAO;
using DataAccessLayerEntities;
using Mappers;

namespace BusinessLogicLayer.Services
{
    public class SystemBlockHullService : IService<SystemBlockHull>
    {
        private IDAO<SystemBlockHullEntity> dao;

        public SystemBlockHullService(IDAO<SystemBlockHullEntity> dao)
        {
            this.dao = dao;
        }

        public IList<SystemBlockHull> GetAll()
        {
            return dao.ReadAll().Select(systemBlockHull => systemBlockHull.ToModel()).ToList();
        }
    }
}
