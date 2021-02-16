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
    public class MotherboardService : IService<Motherboard>
    {
        private IDAO<MotherboardEntity> dao;

        public MotherboardService(IDAO<MotherboardEntity> dao)
        {
            this.dao = dao;
        }

        public IList<Motherboard> GetAll()
        {
            return dao.ReadAll().Select(motherboard => motherboard.ToModel()).ToList();
        }
    }
}
