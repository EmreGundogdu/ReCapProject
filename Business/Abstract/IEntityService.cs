using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;


namespace Business.Abstract
{
    public interface IEntityService<T> where T : class, IEntity, new()
    {
        List<T> GetAll();
        T Get(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
