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
    public class ContatoService : IContatoService
    {

        private readonly IContatoRepository _repository;

        public ContatoService(IContatoRepository repository)
        {
            _repository = repository;
        } //constructor

        public Contato Add(Contato entity)
        {
            //Exemplo de regra de negocio sendo incluida aqui..
            if (entity.Cliente.Endereco.Estado != "RJ")
                return null;

            return _repository.Add(entity);

        } //Add

        public IEnumerable<Contato> GetAll()
        {
            return _repository.GetAll();
        } //GetAll

        public Contato GetById(long id)
        {
            return _repository.GetById(id);
        } //GetById

        public void Remove(Contato entity)
        {
            _repository.Remove(entity);
        } //Remove

        public IEnumerable<Contato> Search(Expression<Func<Contato, bool>> predicate)
        {
            return _repository.Search(predicate);
        } //Search

        public void Update(Contato entity)
        {
            _repository.Update(entity);
        } //Update

    } //class
} //namespace
