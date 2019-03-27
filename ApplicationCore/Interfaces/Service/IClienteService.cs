using ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ApplicationCore.Interface.Service
{
    public interface IClienteService
    {

        Cliente Add(Cliente entity);

        void Update(Cliente entity);

        IEnumerable<Cliente> GetAll();

        Cliente GetById(long id);

        IEnumerable<Cliente> Search(Expression<Func<Cliente, bool>> predicate);

        void Remove(Cliente entity);


    } //interface
} //namespace
