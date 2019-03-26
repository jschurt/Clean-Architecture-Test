using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entity
{
    public class Contato
    {
        public long ContatoId { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }

        public long ClienteId { get; set; }
        public Cliente Cliente { get; set; }

    } //class
} //namespace
