using DrPolina.Core.Repositories;
using DrPolina.Domain.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace DrPolina.API.Configurations
{
    public static class ServicesConfiguration
    {
        public static IServiceCollection AddRepositories(
            this IServiceCollection services)
        {
            services
                .AddTransient<IAlbumRepository, AlbumRepository>()
                .AddTransient<IArtistRepository, ArtistRepository>();

            return services;
        }
    }
}
