using ApplicationCore.Entity;
using ApplicationCore.Interfaces.Repository;
using Infraestructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infraestructure.Repository
{
    public class ClienteRepository : EFRepository<Cliente>, IClienteRepository
    {

        public ClienteRepository(ClienteContext context) : base(context)
        {

        } //ClienteRepository

        public Cliente ObterPorProfissao(long ProfissaoId)
        {
            return this.Search(c => c.ProfissaoClientes.Any(pc => pc.ProfissaoId == ProfissaoId)).FirstOrDefault();
        } //ObterPorProfissao

    } //class
} //namespace
