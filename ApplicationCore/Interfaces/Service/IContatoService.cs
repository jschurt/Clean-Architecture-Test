using ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ApplicationCore.Interface.Service
{
    public interface IContatoService
    {

        Contato Add(Contato entity);

        void Update(Contato entity);

        IEnumerable<Contato> GetAll();

        Contato GetById(long id);

        IEnumerable<Contato> Search(Expression<Func<Contato, bool>> predicate);

        void Remove(Contato entity);


    } //interface
} //namespace
