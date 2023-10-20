using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class DetalleVentaConfiguration : IEntityTypeConfiguration<DetalleVenta>
    {
        public void Configure(EntityTypeBuilder<DetalleVenta> builder)
        {
            builder.ToTable("detalleventa");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id);

            builder.Property(e => e.Cantidad)
            .HasColumnType("int");

            builder.Property(e => e.ValorUnit)
            .HasColumnType("double");

            builder.HasOne(p => p.Ventas)
            .WithMany(p => p.DetallesVentas)
            .HasForeignKey(p => p.IdVentaFk);

            builder.HasOne(p => p.Inventarios)
            .WithMany(p => p.DetallesVentas)
            .HasForeignKey(p => p.IdInventartioFk);

            builder.HasOne(p => p.Tallas)
            .WithMany(p => p.DetallesVentas)
            .HasForeignKey(p => p.IdTallaFk);
        }
    }
}