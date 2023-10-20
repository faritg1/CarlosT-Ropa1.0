using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class InsumoConfiguration : IEntityTypeConfiguration<Insumo>
    {
        public void Configure(EntityTypeBuilder<Insumo> builder)
        {
            builder.ToTable("insumo");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id);

            builder.HasIndex(e => e.NombreInsumo)
            .IsUnique();

            builder.Property(e => e.ValorUnit)
            .HasColumnType("double");

            builder.Property(e => e.StockMin)
            .HasColumnType("int");

            builder.Property(e => e.StockMax)
            .HasColumnType("int");
        }
    }
}