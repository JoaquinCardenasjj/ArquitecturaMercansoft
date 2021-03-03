using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.ModeloDatosCodeFirst;
using Microsoft.EntityFrameworkCore;
using Transversal.Entities;

namespace ArquitecturaMercansoftUnitTest.ModeloDatosPrueba
{
    public class ArquitecturaMercansoftTestContextFactory
    {
        public static ArquitecturaMercansoftContext Create()
        {
            var options = new DbContextOptionsBuilder<ArquitecturaMercansoftContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            var context = new ArquitecturaMercansoftContext(options);

            context.Database.EnsureCreated();

            context.Clientes.AddRange(new[] {
                new Cliente { IdCliente = 1, Nombre= "Adam", Identificacion="123456",TipoIdentificacion=2,Activo=true ,Eliminado=true},
                new Cliente { IdCliente = 2, Nombre = "Jason", Identificacion="654123",TipoIdentificacion=1,Activo=true ,Eliminado=false},
                new Cliente { IdCliente = 3, Nombre = "Brendan", Identificacion="789456",TipoIdentificacion=3,Activo=false,Eliminado=true },
            });

            context.SaveChanges();

            return context;
        }

        public static void Destroy(ArquitecturaMercansoftContext context)
        {
            context.Database.EnsureDeleted();

            context.Dispose();
        }
    }
}
