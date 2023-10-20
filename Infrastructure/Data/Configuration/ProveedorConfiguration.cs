using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class ProveedorConfiguration : IEntityTypeConfiguration<Proveedor>
    {
        public void Configure(EntityTypeBuilder<Proveedor> builder)
        {
            builder.ToTable("proveedor");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id);

            builder.HasIndex(x => x.NitProv).IsUnique();

            builder.Property(e => e.NombreProv)
            .IsRequired()
            .HasMaxLength(50);

            builder.HasOne(p => p.TiposPersonas)
            .WithMany(p => p.Proveedores)
            .HasForeignKey(p => p.IdTipoPersonaFk);

            builder.HasOne(p => p.Municipios)
            .WithMany(p => p.Proveedores)
            .HasForeignKey(p => p.IdMunicipioFk);
        }
    }
}