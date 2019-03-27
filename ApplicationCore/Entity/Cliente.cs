using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entity
{
    public class Cliente
    {
        public long ClienteId { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }

        public ICollection<Contato> Contatos { get; set; }

        public long EnderecoId { get; set; }
        public Endereco Endereco { get; set; }

        public ICollection<ProfissaoClienteJunc> ProfissaoClientes { get; set; }

    } //class
} //namespace
