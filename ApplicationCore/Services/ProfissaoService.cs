using ApplicationCore.Entity;
using ApplicationCore.Interface.Service;
using ApplicationCore.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

//As regras de negocio ficam aqui em servicos

namespace ApplicationCore.Services
{
    public class ProfissaoService : IProfissaoService
    {

        private readonly IProfissaoRepository _repository;

        public ProfissaoService(IProfissaoRepository repository)
        {
            _repository = repository;
        } //constructor

        public Profissao Add(Profissao entity)
        {
            //Exemplo de regra de negocio sendo incluida aqui..
            if (entity.CBO != "XPTO")
                return null;

            return _repository.Add(entity);

        } //Add

        public IEnumerable<Profissao> GetAll()
        {
            return _repository.GetAll();
        } //GetAll

        public Profissao GetById(long id)
        {
            return _repository.GetById(id);
        } //GetById

        public void Remove(Profissao entity)
        {
            _repository.Remove(entity);
        } //Remove

        public IEnumerable<Profissao> Search(Expression<Func<Profissao, bool>> predicate)
        {
            return _repository.Search(predicate);
        } //Search

        public void Update(Profissao entity)
        {
            _repository.Update(entity);
        } //Update

    } //class
} //namespace
