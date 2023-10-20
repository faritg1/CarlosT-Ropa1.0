using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class DetalleOrdenConfiguration : IEntityTypeConfiguration<DetalleOrden>
    {
        public void Configure(EntityTypeBuilder<DetalleOrden> builder)
        {
            builder.ToTable("detalleorden");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id);

            builder.Property(e => e.CantidadProducir)
            .HasColumnType("int");

            builder.Property(e => e.CantidadProducida)
            .HasColumnType("int");

            builder.HasOne(p => p.Ordenes)
            .WithMany(p => p.DetallesOrdenes)
            .HasForeignKey(p => p.IdOrdenFk);

            builder.HasOne(p => p.Prendas)
            .WithMany(p => p.DetallesOrdenes)
            .HasForeignKey(p => p.IdPrendaFk);

            builder.HasOne(p => p.Estados)
            .WithMany(p => p.DetallesOrdenes)
            .HasForeignKey(p => p.IdEstadoFk);

            builder.HasOne(p => p.Colores)
            .WithMany(p => p.DetallesOrdenes)
            .HasForeignKey(p => p.IdColorFk);
        }
    }
}