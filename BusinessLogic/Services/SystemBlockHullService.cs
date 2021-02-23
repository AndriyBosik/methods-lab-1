using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Models;
using BusinessLogic.Interfaces;
using DataAccess.DAO;
using Entities;
using Mappers;

namespace BusinessLogic.Services
{
    public class SystemBlockHullService : IService<SystemBlockHull>
    {
        private IDAO<Int32, SystemBlockHullEntity> dao;

        public SystemBlockHullService()
        {
            this.dao = new SystemBlockHullDAO();
        }

        public IList<SystemBlockHull> GetAll()
        {
            return dao.ReadAll().Select(systemBlockHull => systemBlockHull.ToModel()).ToList();
        }

        public void Insert(SystemBlockHull model)
        {
            dao.Create(model.ToEntity());
        }
    }
}
