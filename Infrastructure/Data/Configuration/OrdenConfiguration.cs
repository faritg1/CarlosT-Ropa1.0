using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class OrdenConfiguration : IEntityTypeConfiguration<Orden>
    {
        public void Configure(EntityTypeBuilder<Orden> builder)
        {
            builder.ToTable("orden");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id);

            builder.Property(e => e.Fecha)
            .HasColumnType("datetime");

            builder.HasOne(p => p.Empleados)
            .WithMany(p => p.Ordenes)
            .HasForeignKey(p => p.IdEmpledoFk);

            builder.HasOne(p => p.Clientes)
            .WithMany(p => p.Ordenes)
            .HasForeignKey(p => p.IdClienteFk);

            builder.HasOne(p => p.Estados)
            .WithMany(p => p.Ordenes)
            .HasForeignKey(p => p.IdEstadoFk);
        }
    }
}