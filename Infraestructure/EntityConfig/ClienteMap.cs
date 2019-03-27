
using ApplicationCore.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure.EntityConfig
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> modelBuilder)
        {

            modelBuilder
                .ToTable("Cliente");

            #region Fields - Cliente table Configuration...

            modelBuilder
                .Property(c => c.CPF)
                .HasColumnType("varchar(11)")
                .IsRequired();

            modelBuilder
                .Property(c => c.Nome)
                .HasColumnType("varchar(200)")
                .IsRequired();

            //Apesar de respeitar a convencao de nome para chave, vou deixar explicito a chave
            modelBuilder
                .HasKey(c => c.ClienteId);

            //Apesar de respeitar a convencao de nomes para relacionamento, vamos deixar explicito os relacionamentos
            //Nao e' necessario fazer explicitar mas e' uma boa pratica.
            modelBuilder
                .HasMany(cli => cli.Contatos)
                    .WithOne(cnt => cnt.Cliente)
                    .HasForeignKey(cnt => cnt.ClienteId)
                .HasPrincipalKey(cli => cli.ClienteId)
                .OnDelete(DeleteBehavior.Restrict);  //O comportamento default eh cascade. Nao quero que ao remover um cliente que os contatos sejam removidos

            //Relacionamento com a tabela juncao
            modelBuilder
                .HasMany(cli => cli.ProfissaoClientes)
                    .WithOne(pc => pc.Cliente)
                    .HasForeignKey(pc => pc.ClienteId)
                .HasPrincipalKey(cli => cli.ClienteId);

            //Relacionamento 1-1 com a classe Endereco
            modelBuilder
                .HasOne(cli => cli.Endereco)
                    .WithOne(end => end.Cliente);

            #endregion


        } //Configure
    } //class
} //namespace
