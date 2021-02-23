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
    public class ProcessorService : IService<Processor>
    {
        private IDAO<Int32, ProcessorEntity> dao;

        public ProcessorService(IDAO<Int32, ProcessorEntity> dao)
        {
            this.dao = dao;
        }

        public IList<Processor> GetAll()
        {
            return dao.ReadAll().Select(processor => processor.ToModel()).ToList();
        }
    }
}
