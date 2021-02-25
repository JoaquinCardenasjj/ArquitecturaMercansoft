using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Configuration
{
    public class FacturaConfiguration : IEntityTypeConfiguration<Factura>
    {
        public void Configure(EntityTypeBuilder<Factura> builder)
        {
            builder.ToTable("MER_TBL_FACTURA");
            builder.HasKey(c => c.IdFactura).HasName("FAC_ID_FACTURA");
            builder.Property(c => c.ClienteId).HasColumnName("FAC_CLIENTE_ID");
            builder.Property(c => c.FechaFactura).HasColumnName("FAC_FECHA_FACTURA").HasComment("FECHA INICIAL DE LA FACTURA");
            builder.Property(c => c.Activo).HasColumnName("FAC_ACTIVO");
            builder.Property(c => c.Eliminado).HasColumnName("FAC_ELIMINADO");

            builder
                .HasOne(f => f.Cliente)
                .WithMany(f => f.Facturas)
                .HasForeignKey(f => f.ClienteId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_CLI_FAC");
        }
    }
}
