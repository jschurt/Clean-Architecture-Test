using ApplicationCore.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure.EntityConfig
{
    public class MenuMap : IEntityTypeConfiguration<Menu>
    {
        public void Configure(EntityTypeBuilder<Menu> builder)
        {

            #region Configuracao Menu table...

            builder
                .HasKey(m => m.Id);

            //Para auto associacao nao se coloca nada no withone
            builder
                .HasMany(m => m.SubMenu)
                    .WithOne()
                    .HasForeignKey(sm => sm.MenuId)
                .HasPrincipalKey(m => m.Id);

            #endregion


        } //Configure
    } //class
} //namespace
