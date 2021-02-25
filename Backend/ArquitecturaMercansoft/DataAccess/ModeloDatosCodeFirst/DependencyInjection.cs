using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ModeloDatosCodeFirst
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ArquitecturaMercansoftContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("ArquitecturaMercansoftDataBase")));

            services.AddScoped<IArquitecturaMercansoftContext>(provider => provider.GetService<ArquitecturaMercansoftContext>());

            return services;
        }
    }
}
