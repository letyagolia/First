using DrPolina.Core.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DrPolina.API.Configurations
{
    public static class ConfigureConnections
    {
        public static IServiceCollection AddCollectionProvider(
            this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<MusicContext>(opt =>
            opt.UseSqlServer(
                configuration.GetConnectionString("Default"),
                b => b.MigrationsAssembly("DrPolina.API"))

            );
            return services;
        }
    }
}
