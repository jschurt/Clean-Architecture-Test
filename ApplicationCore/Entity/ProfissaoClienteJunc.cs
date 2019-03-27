using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entity
{
    public class ProfissaoClienteJunc
    {
        public long Id { get; set; }
        public long ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public long ProfissaoId { get; set; }
        public Profissao Profissao { get; set; }

    } //class
} //namespace
