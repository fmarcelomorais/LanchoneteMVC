using Lanchonete.Application.Interfaces;
using Lanchonete.Application.Mapping;
using Lanchonete.Application.Services;
using Lanchonete.Domain.Interafces;
using Lanchonete.Infraestrutura.Context;
using Lanchonete.Infraestrutura.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace Lanchonete.CrossCutting
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDependencyInjection(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("SqlServer"));
            });
            
            services.AddTransient<ICategoriaRepository, CategoriaRepository>();
            services.AddTransient<ICategoriaService, CategoriaService>();
            services.AddTransient<ILanchesRepository, LancheRepository>();
            services.AddTransient<ILancheService, LancheService>();

            services.AddAutoMapper(typeof(ModelToModelDTOConfigureProfile));

            return services;
        }
    }
}
