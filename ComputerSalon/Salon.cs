using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerSalon
{
    class Salon
    {
        private IDataReader dataReader;

        public Salon(IDataReader dataReader)
        {
            this.dataReader = dataReader;
        }
    }
}
