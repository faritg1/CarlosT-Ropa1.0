using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class EstadoConfiguration : IEntityTypeConfiguration<Estado>
    {
        public void Configure(EntityTypeBuilder<Estado> builder)
        {
            builder.ToTable("estado");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id);

            builder.Property(e => e.Descripcion)
            .IsRequired()
            .HasMaxLength(100);

            builder.HasOne(p => p.TiposEstados)
            .WithMany(p => p.Estados)
            .HasForeignKey(p => p.IdTipoEstadoFk);
        }
    }
}