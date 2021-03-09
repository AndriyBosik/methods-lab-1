using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstraction
{
    public interface ISpecification<T>
    {
        Boolean IsSatisfiedBy(T entity);
    }
}
