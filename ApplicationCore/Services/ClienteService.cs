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
    public class ClienteService : IClienteService
    {

        private readonly IClienteRepository _repository;

        public ClienteService(IClienteRepository repository)
        {
            _repository = repository;
        } //constructor

        public Cliente Add(Cliente entity)
        {
            //Exemplo de regra de negocio sendo incluida aqui..
            if (entity.Endereco.Estado != "RJ")
                return null;

            return _repository.Add(entity);

        } //Add

        public IEnumerable<Cliente> GetAll()
        {
            return _repository.GetAll();
        } //GetAll

        public Cliente GetById(long id)
        {
            return _repository.GetById(id);
        } //GetById

        public void Remove(Cliente entity)
        {
            _repository.Remove(entity);
        } //Remove

        public IEnumerable<Cliente> Search(Expression<Func<Cliente, bool>> predicate)
        {
            return _repository.Search(predicate);
        } //Search

        public void Update(Cliente entity)
        {
            _repository.Update(entity);
        } //Update

    } //class
} //namespace
