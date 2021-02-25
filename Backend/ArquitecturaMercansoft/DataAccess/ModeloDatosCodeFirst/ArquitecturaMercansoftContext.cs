using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ModeloDatosCodeFirst
{
    public class ArquitecturaMercansoftContext : DbContext, IArquitecturaMercansoftContext
    {
        public ArquitecturaMercansoftContext(DbContextOptions<ArquitecturaMercansoftContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Factura> Facturas { get; set; }
        public virtual DbSet<Producto> Productos { get; set; }
        public virtual DbSet<Orden> Ordenes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ArquitecturaMercansoftContext).Assembly);
        }
    }
}
