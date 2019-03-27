using ApplicationCore.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure.EntityConfig
{
    public class EnderecoMap : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {

            #region Endereco table Configuration...

            builder.
                HasKey(e => e.EnderecoId);

            builder
                .Property(e => e.Bairro)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder
                .Property(e => e.CEP)
                .HasColumnType("varchar(10)")
                .IsRequired();

            builder
                .Property(e => e.Logradouro)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder
                .Property(e => e.Referencia)
                .HasColumnType("varchar(400)");

            #endregion


        } //Configure
    } //class
} //namespace
