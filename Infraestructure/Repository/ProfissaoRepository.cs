using ApplicationCore.Entity;
using ApplicationCore.Interfaces.Repository;
using Infraestructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infraestructure.Repository
{
    public class ProfissaoRepository : EFRepository<Profissao>, IProfissaoRepository
    {

        public ProfissaoRepository(ClienteContext context) : base(context)
        {

        } //ProfissaoRepository

    } //class
} //namespace
