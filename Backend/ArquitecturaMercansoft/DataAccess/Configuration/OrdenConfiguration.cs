using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Configuration
{
    public class OrdenConfiguration : IEntityTypeConfiguration<Orden>
    {
        public void Configure(EntityTypeBuilder<Orden> builder)
        {
            builder.ToTable("MER_TBL_ORDEN");
            builder.HasKey(o => new { o.FacturaId, o.ProductoId });
            builder.Property(c => c.FacturaId).HasColumnName("ORD_FACTURA_ID");
            builder.Property(c => c.ProductoId).HasColumnName("ORD_PRODUCTO_ID");
            builder.Property(c => c.ValorTotal).HasColumnName("ORD_VALOR_TOTAL").HasComment("VALOR TOTAL DE LA ORDEN");
            builder.Property(c => c.Activo).HasColumnName("ORD_ACTIVO");
            builder.Property(c => c.Eliminado).HasColumnName("ORD_ELIMINADO");

            builder
                .HasOne(f => f.Factura)
                    .WithMany(f => f.Ordenes)
                    .HasForeignKey(f => f.FacturaId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ORD_FAC");

            builder
                .HasOne(f => f.Producto)
                    .WithMany(f => f.Ordenes)
                    .HasForeignKey(f => f.ProductoId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ORD_PRO");
        }
    }
}
