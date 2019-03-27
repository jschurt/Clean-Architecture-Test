using ApplicationCore.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure.EntityConfig
{
    public class ContatoMap : IEntityTypeConfiguration<Contato>
    {
        public void Configure(EntityTypeBuilder<Contato> builder)
        {

            #region Contato table Configuration...

            builder
                .Property(c => c.Nome)
                .HasColumnType("varchar(200)")
                .IsRequired();

            builder
                .Property(c => c.Email)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder
                .Property(c => c.Telefone)
                .HasColumnType("varchar(150)");

            //Apesar de respeitar a convencao de nome para chave, vou deixar explicito a chave
            builder
                .HasKey(c => c.ContatoId);

            //desnecessario explicitar. Este comando e' importante caso nao sejam utilizadsa as convencoes de nome do entity framework
            builder
                .HasOne(cnt => cnt.Cliente)
                    .WithMany(cli => cli.Contatos)
                    .HasForeignKey(cli => cli.ClienteId)
                .HasPrincipalKey(cnt => cnt.ClienteId)
                .OnDelete(DeleteBehavior.Restrict); //O comportamento default eh cascade. Nao quero que ao remover um cliente que os contatos sejam removidos;

            #endregion


        } //Configure

    } //class
} //namespace
