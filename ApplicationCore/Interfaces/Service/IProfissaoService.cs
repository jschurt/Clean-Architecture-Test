using ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ApplicationCore.Interface.Service
{
    public interface IProfissaoService
    {

        Profissao Add(Profissao entity);

        void Update(Profissao entity);

        IEnumerable<Profissao> GetAll();

        Profissao GetById(long id);

        IEnumerable<Profissao> Search(Expression<Func<Profissao, bool>> predicate);

        void Remove(Profissao entity);


    } //interface
} //namespace
