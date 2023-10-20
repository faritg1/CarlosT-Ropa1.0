using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class VentaConfiguration : IEntityTypeConfiguration<Venta>
    {
        public void Configure(EntityTypeBuilder<Venta> builder)
        {
            builder.ToTable("venta");

            builder.HasKey(x => x.Id);
            builder.HasKey(x => x.Id);

            builder.Property(e => e.Fecha)
            .HasColumnType("datetime");

            builder.HasOne(p => p.Empelados)
            .WithMany(p => p.Ventas)
            .HasForeignKey(p => p.IdEmpledoFk);

            builder.HasOne(p => p.Clientes)
            .WithMany(p => p.Ventas)
            .HasForeignKey(p => p.IdClienteFk);

            builder.HasOne(p => p.FormasPagos)
            .WithMany(p => p.Ventas)
            .HasForeignKey(p => p.IdFormaPagoFk);
        }
    }
}