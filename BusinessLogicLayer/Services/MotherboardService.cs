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
        private IDAO<Int32, MotherboardEntity> dao;

        public MotherboardService()
        {
            this.dao = new MotherboardDAO();
        }

        public IList<Motherboard> GetAll()
        {
            return dao.ReadAll().Select(motherboard => motherboard.ToModel()).ToList();
        }
    }
}
