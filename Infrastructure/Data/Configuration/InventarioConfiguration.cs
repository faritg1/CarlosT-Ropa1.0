using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class InventarioConfiguration : IEntityTypeConfiguration<Inventario>
    {
        public void Configure(EntityTypeBuilder<Inventario> builder)
        {
            builder.ToTable("inventario");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id);

            builder.HasIndex(x => x.CodigoInv).IsUnique();

            builder.Property(e => e.ValorVtaCop)
            .HasColumnType("double");

            builder.Property(e => e.ValorUsd)
            .HasColumnType("double");

            builder.HasOne(p => p.Prendas)
            .WithMany(p => p.Inventarios)
            .HasForeignKey(p => p.IdPrendaFk);
        }
    }
}