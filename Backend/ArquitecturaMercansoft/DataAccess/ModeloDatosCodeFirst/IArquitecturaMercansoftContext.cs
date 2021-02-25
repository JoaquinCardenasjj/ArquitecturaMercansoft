using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ModeloDatosCodeFirst
{
    public interface IArquitecturaMercansoftContext
    {
        DbSet<Cliente> Clientes { get; set; }
        DbSet<Factura> Facturas { get; set; }        
        DbSet<Producto> Productos { get; set; }
        DbSet<Orden> Ordenes { get; set; }
    }
}
