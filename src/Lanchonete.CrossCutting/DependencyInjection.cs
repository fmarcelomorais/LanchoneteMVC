using Lanchonete.Application.Mapping;
using Lanchonete.Infraestrutura.Context;
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

            services.AddAutoMapper(typeof(ModelToModelDTOConfigureProfile));

            return services;
        }
    }
}
