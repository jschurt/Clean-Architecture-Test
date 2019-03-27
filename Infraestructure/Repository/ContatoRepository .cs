using ApplicationCore.Entity;
using ApplicationCore.Interfaces.Repository;
using Infraestructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infraestructure.Repository
{
    public class ContatoRepository : EFRepository<Contato>, IContatoRepository
    {

        public ContatoRepository(ClienteContext context) : base(context)
        {

        } //ContatoRepository

    } //class
} //namespace
