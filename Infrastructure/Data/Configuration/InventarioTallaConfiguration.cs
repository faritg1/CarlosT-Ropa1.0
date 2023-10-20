using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class InventarioTallaConfiguration : IEntityTypeConfiguration<InventarioTalla>
    {
        public void Configure(EntityTypeBuilder<InventarioTalla> builder)
        {
            builder.ToTable("inventariotalla");

            builder.HasKey(t => new { t.IdTallaFk, t.IdInvFk });

            builder.HasOne(p => p.Inventarios)
            .WithMany(p => p.InventariosTallas)
            .HasForeignKey(p => p.IdInvFk);

            builder.HasOne(p => p.Tallas)
            .WithMany(p => p.InventariosTallas)
            .HasForeignKey(p => p.IdTallaFk);
        }
    }
}