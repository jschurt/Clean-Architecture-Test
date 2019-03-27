using ApplicationCore.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure.EntityConfig
{
    class ProfissaoClienteJuncMap : IEntityTypeConfiguration<ProfissaoClienteJunc>
    {
        public void Configure(EntityTypeBuilder<ProfissaoClienteJunc> builder)
        {

            #region Profissao Cliente Junction table Configuration...

            builder
                .HasKey(pc => pc.Id);

            builder
                .HasOne(pc => pc.Cliente)
                    .WithMany(c => c.ProfissaoClientes)
                    .HasForeignKey(pc => pc.ClienteId)
                .HasPrincipalKey(c => c.ClienteId);

            builder
                .HasOne(pc => pc.Profissao)
                    .WithMany(p => p.ProfissaoClientes)
                    .HasForeignKey(p => p.ProfissaoId)
                .HasPrincipalKey(p => p.ProfissaoId);

            #endregion

        } //Configure
    } //class
} //namespace
