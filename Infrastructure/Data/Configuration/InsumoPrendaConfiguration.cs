using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class InsumoPrendaConfiguration : IEntityTypeConfiguration<InsumoPrenda>
    {
        public void Configure(EntityTypeBuilder<InsumoPrenda> builder)
        {
            builder.ToTable("insumoprenda");

            builder.HasKey(t => new { t.IdPrendaFk, t.IdInsumoFk });

            builder.HasOne(p => p.Prendas)
            .WithMany(p => p.InsumosPrendas)
            .HasForeignKey(p => p.IdPrendaFk);

            builder.HasOne(p => p.Insumos)
            .WithMany(p => p.InsumosPrendas)
            .HasForeignKey(p => p.IdInsumoFk);
        }
    }
}