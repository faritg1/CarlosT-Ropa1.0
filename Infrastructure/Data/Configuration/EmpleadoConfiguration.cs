using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class EmpleadoConfiguration : IEntityTypeConfiguration<Empleado>
    {
        public void Configure(EntityTypeBuilder<Empleado> builder)
        {
            builder.ToTable("empleado");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id);

            builder.HasIndex(x => x.IdEmple).IsUnique();

            builder.Property(e => e.NombreEmple)
            .IsRequired()
            .HasMaxLength(50);

            builder.Property(e => e.FechaIngreso)
            .HasColumnType("datetime");

            builder.HasOne(p => p.Cargos)
            .WithMany(p => p.Empleados)
            .HasForeignKey(p => p.IdCargoFk);

            builder.HasOne(p => p.Municipios)
            .WithMany(p => p.Empleados)
            .HasForeignKey(p => p.IdMunicipio);
        }
    }
}