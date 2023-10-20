using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("cliente");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id);

            builder.HasIndex(x => x.IdCliente).IsUnique();

            builder.Property(e => e.NombreCliente)
            .IsRequired()
            .HasMaxLength(50);

            builder.Property(e => e.FechaRegistro)
            .HasColumnType("datetime");

            builder.HasOne(p => p.TiposPersonas)
            .WithMany(p => p.Clientes)
            .HasForeignKey(p => p.IdTipoPersonaFk);

            builder.HasOne(p => p.Municipios)
            .WithMany(p => p.Clientes)
            .HasForeignKey(p => p.IdMunicipioFk);
        }
    }
}