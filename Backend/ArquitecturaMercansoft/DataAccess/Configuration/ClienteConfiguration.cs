using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transversal.Entities;

namespace DataAccess.Configuration
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("MER_TBL_CLIENTE");
            builder.HasKey(c => c.IdCliente).HasName("CLI_ID_CLIENTE");
            builder.Property(c => c.IdCliente).HasColumnName("CLI_ID_CLIENTE");
            builder.Property(c => c.TipoIdentificacion).HasColumnName("CLI_TIPO_IDENTIFICACION");
            builder.Property(c => c.Identificacion).HasColumnName("CLI_IDENTIFICACION");
            builder.Property(c => c.Nombre).HasMaxLength(120).HasColumnName("CLI_NOMBRE");
            builder.Property(c => c.Activo).HasColumnName("CLI_ACTIVO");
            builder.Property(c => c.Eliminado).HasColumnName("CLI_ELIMINADO");
        }
    }
}
