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
    public class MemoryCardService : IService<MemoryCard>
    {
        private IDAO<Int32, MemoryCardEntity> dao;

        public MemoryCardService()
        {
            this.dao = new MemoryCardDAO();
        }

        public IList<MemoryCard> GetAll()
        {
            return dao.ReadAll().Select(memoryCard => memoryCard.ToModel()).ToList();
        }
    }
}
