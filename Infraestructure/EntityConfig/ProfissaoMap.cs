using ApplicationCore.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure.EntityConfig
{
    public class ProfissaoMap : IEntityTypeConfiguration<Profissao>
    {
        public void Configure(EntityTypeBuilder<Profissao> builder)
        {
            #region Profissao table Configuration...

            builder
                .Property(p => p.Nome)
                .HasColumnType("varchar(400)")
                .IsRequired();

            builder
                .Property(p => p.CBO)
                .HasColumnType("varchar(10)")
                .IsRequired();

            builder
                .Property(p => p.Descricao)
                .HasColumnType("varchar(1000)")
                .IsRequired();


            //Desnecessario quando a convencao de nomes eh seguida
            builder
                .HasKey(p => p.ProfissaoId);

            //Relacionamento com a tabela juncao
            builder
                .HasMany(p => p.ProfissaoClientes)
                    .WithOne(pc => pc.Profissao)
                    .HasForeignKey(pc => pc.ProfissaoId)
                .HasPrincipalKey(p => p.ProfissaoId);

            #endregion

        } //Configure
    } //class
} //namespace
