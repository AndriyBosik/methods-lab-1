using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Salon;
using DataAccessLayer.DAO;
using BusinessLogicLayer.Services;

namespace ApplicationConfiguration
{
    class Config
    {
        static void Main(string[] args)
        {
            var globalDAO = new GlobalDAO();
            var globalService = new GlobalService(globalDAO);
            var program = new Program(globalService);

            program.Start();
        }
    }
}
