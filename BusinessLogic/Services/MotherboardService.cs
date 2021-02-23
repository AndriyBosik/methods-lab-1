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
