using RestaurantOH.Domain.Interface;
using System;
using System.Collections.Generic;

namespace RestaurantOH.Domain.Service
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : class
    {
        public TEntity Add(TEntity obj)
        {
            throw new NotImplementedException();
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public TEntity Edit(TEntity obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public TEntity GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
