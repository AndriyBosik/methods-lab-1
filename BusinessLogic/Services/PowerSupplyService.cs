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
    public class PowerSupplyService : IService<PowerSupply>
    {
        private IDAO<Int32, PowerSupplyEntity> dao;

        public PowerSupplyService()
        {
            this.dao = new PowerSupplyDAO();
        }

        public IList<PowerSupply> GetAll()
        {
            return dao.ReadAll().Select(powerSupply => powerSupply.ToModel()).ToList();
        }

        public void Insert(PowerSupply model)
        {
            dao.Create(model.ToEntity());
        }
    }
}
