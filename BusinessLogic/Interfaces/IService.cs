using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Models;

namespace BusinessLogic.Interfaces
{
    public interface IService<T> where T: SystemComponentBase
    {
        IList<T> GetAll();

        void Insert(T model);
    }
}
