using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class InsumoProveedorConfiguration : IEntityTypeConfiguration<InsumoProveedor>
    {
        public void Configure(EntityTypeBuilder<InsumoProveedor> builder)
        {
            builder.ToTable("insumoproveedor");

            builder.HasKey(t => new { t.IdProveedorfk, t.IdInsumofk });

            builder.HasOne(p => p.Proveedores)
            .WithMany(p => p.InsumosProveedores)
            .HasForeignKey(p => p.IdProveedorfk);

            builder.HasOne(p => p.Insumos)
            .WithMany(p => p.InsumosProveedores)
            .HasForeignKey(p => p.IdInsumofk);
        }
    }
}