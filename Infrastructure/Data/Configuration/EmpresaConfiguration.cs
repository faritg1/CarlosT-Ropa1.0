using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class EmpresaConfiguration : IEntityTypeConfiguration<Empresa>
    {
        public void Configure(EntityTypeBuilder<Empresa> builder)
        {
            builder.ToTable("empresa");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id);

            builder.HasIndex(x => x.Nit).IsUnique();

            builder.Property(e => e.RazonSocial)
            .IsRequired()
            .HasMaxLength(100);

            builder.Property(e => e.RepresentanteLegal)
            .IsRequired()
            .HasMaxLength(100);

            builder.Property(e => e.FechaCreacion)
            .HasColumnType("datetime");

            builder.HasOne(p => p.Municipios)
            .WithMany(p => p.Empresas)
            .HasForeignKey(p => p.IdMunicipioFk);
        }
    }
}