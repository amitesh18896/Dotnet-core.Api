using Customer.DAL.IRepository;
using Customer.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Customer.DAL.UnitOfWork
{
   public interface IUnitOfWork
    {
        IGenericRepository<T> GenericRepository<T>() where T : class;
        void Save();

    }
}
