using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entity
{
    public class Endereco
    {

        public long EnderecoId { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }
        public string Referencia { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        public Cliente Cliente { get; set; }

    } //class
} //namespace
