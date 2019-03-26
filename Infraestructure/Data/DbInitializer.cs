using ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infraestructure.Data
{
    public static class DbInitializer
    {

        public static void Initialize(ClienteContext context)
        {
            if(context.Clientes.Any())
            {
                return; //DB has data
            }

            var clientes = new Cliente[]
            {
                new Cliente {Nome = "Sergio Miranda", CPF = "93283289-02"},
                new Cliente {Nome = "Pedro Antonio", CPF = "23024824-28"},
                new Cliente {Nome = "Maria Aparecida", CPF = "44830024-83"},
            };

            context.AddRange(clientes);

            var contatos = new Contato[]
            {
                new Contato {Nome = "Marina Albuquerque", Email = "marina@gmail.com", Cliente = clientes[0] },
                new Contato {Nome = "Pedro Henrique", Email = "pedro@gmail.com", Cliente = clientes[1] },
                new Contato {Nome = "Maria Christina", Email = "maria@gmail.com", Cliente = clientes[2] },
                new Contato {Nome = "Joao Paulo", Email = "joao@gmail.com", Cliente = clientes[0] },
                new Contato {Nome = "Zilda Silva", Email = "zilda@gmail.com", Cliente = clientes[1] },
                new Contato {Nome = "Robert Zilderman", Email = "robert@gmail.com", Cliente = clientes[2] },
                new Contato {Nome = "Eduarda Schwager", Email = "eduarda@gmail.com", Cliente = clientes[0] },
                new Contato {Nome = "Bob Marley", Email = "bob@gmail.com", Cliente = clientes[1] }
            };

            context.AddRange(contatos);

            context.SaveChanges();

        } //Initialize

    } //class
} //namespace
