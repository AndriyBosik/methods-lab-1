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
    public class ProcessorService : IService<Processor>
    {
        private IDAO<Int32, ProcessorEntity> dao;

        public ProcessorService()
        {
            this.dao = new ProcessorDAO();
        }

        public IList<Processor> GetAll()
        {
            return dao.ReadAll().Select(processor => processor.ToModel()).ToList();
        }
    }
}
