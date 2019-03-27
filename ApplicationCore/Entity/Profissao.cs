using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entity
{
    public class Profissao
    {
        public long ProfissaoId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string CBO { get; set; }

        public IEnumerable<ProfissaoClienteJunc> ProfissaoClientes { get; set; }

    } //class
} //namespace
