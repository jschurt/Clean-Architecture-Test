using ApplicationCore.Entity;
using Infraestructure.EntityConfig;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure.Data
{
    public class ClienteContext : DbContext
    {

        public ClienteContext(DbContextOptions<ClienteContext> options) : base(options)
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Contato> Contatos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Contato>()
                       .ToTable("Contato");

            modelBuilder.ApplyConfiguration(new ClienteMap());
            modelBuilder.ApplyConfiguration(new ContatoMap());
            modelBuilder.ApplyConfiguration(new EnderecoMap());
            modelBuilder.ApplyConfiguration(new MenuMap());
            modelBuilder.ApplyConfiguration(new ProfissaoMap());
            modelBuilder.ApplyConfiguration(new ProfissaoClienteJuncMap());
            
        } //OnModelCreating


    } //class
} //namespace
