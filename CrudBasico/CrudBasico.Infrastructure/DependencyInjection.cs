using CrudBasico.Infrastructure.Data;
using CrudBasico.Infrastructure.Repository;
using CrudBasico.Infrastructure.Repository.Inteface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CrudBasico.Ilustra.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<CrudBasicoContext>(options => options.UseSqlServer(configuration.GetConnectionString("CrudEntities")));


            //Repositories
            services.AddScoped<IContactoRepository, ContactoRepository>();
            services.AddScoped<IBaseRepository, BaseRepository>();


            return services;
        }
    }
}
