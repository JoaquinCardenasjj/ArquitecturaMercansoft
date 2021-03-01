using Transversal.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Configuration
{
    public class ProductoConfiguration : IEntityTypeConfiguration<Producto>
    {
        public void Configure(EntityTypeBuilder<Producto> builder)
        {
            builder.ToTable("MER_TBL_PRODUCTO");
            builder.HasKey(c => c.IdProducto).HasName("PRO_ID_PRODUCTO");
            builder.Property(c => c.IdProducto).HasColumnName("PRO_ID_PRODUCTO");
            builder.Property(c => c.Nombre).HasMaxLength(120).HasColumnName("PRO_NOMBRE");
            builder.Property(c => c.Precio).HasColumnName("PRO_PRECIO");
            builder.Property(c => c.Activo).HasColumnName("PRO_ACTIVO");
            builder.Property(c => c.Eliminado).HasColumnName("PRO_ELIMINADO");
        }
    }
}
