﻿using ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Interfaces.Repository
{
    public interface IClienteRepository : IRepository<Cliente>
    {
        //Posso agora incluir contratos especificos para clientes

        Cliente ObterPorProfissao(long ProfissaoId);

    } //interface
} //namespace
