using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ApplicationCore.Interfaces.Repository
{
    public interface IRepository<T> where T : class
    {

        T Add(T entity);

        void Update(T entity);

        IEnumerable<T> GetAll();

        T GetById(long id);

        IEnumerable<T> Search(Expression<Func<T, bool>> predicate);

        void Remove(T entity);

    } //interface
} //namespace
