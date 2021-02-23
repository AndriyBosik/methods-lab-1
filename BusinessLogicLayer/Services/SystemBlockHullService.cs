﻿using System;
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
        private IDAO<Int32, SystemBlockHullEntity> dao;

        public SystemBlockHullService()
        {
            this.dao = new SystemBlockHullDAO();
        }

        public IList<SystemBlockHull> GetAll()
        {
            return dao.ReadAll().Select(systemBlockHull => systemBlockHull.ToModel()).ToList();
        }
    }
}
