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
    public class PowerSupplyService : IService<PowerSupply>
    {
        private IDAO<Int32, PowerSupplyEntity> dao;

        public PowerSupplyService(IDAO<Int32, PowerSupplyEntity> dao)
        {
            this.dao = dao;
        }

        public IList<PowerSupply> GetAll()
        {
            return dao.ReadAll().Select(powerSupply => powerSupply.ToModel()).ToList();
        }
    }
}
