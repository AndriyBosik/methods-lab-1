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
    public class MemoryCardService : IService<MemoryCard>
    {
        private IDAO<Int32, MemoryCardEntity> dao;

        public MemoryCardService(IDAO<Int32, MemoryCardEntity> dao)
        {
            this.dao = dao;
        }

        public IList<MemoryCard> GetAll()
        {
            return dao.ReadAll().Select(memoryCard => memoryCard.ToModel()).ToList();
        }
    }
}
