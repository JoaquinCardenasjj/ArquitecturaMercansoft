using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ModeloDatosCodeFirst
{
    public class ArquitecturaMercansoftContextFactory : DesignTimeDbContextFactoryBase<ArquitecturaMercansoftContext>
    {
        protected override ArquitecturaMercansoftContext CreateNewInstance(DbContextOptions<ArquitecturaMercansoftContext> options)
        {
            return new ArquitecturaMercansoftContext(options);
        }
    }
}
