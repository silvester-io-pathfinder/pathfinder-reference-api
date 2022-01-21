using Microsoft.Extensions.DependencyInjection;

namespace Silvester.Pathfinder.Reference.Database.Seeding.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddSeeding(this IServiceCollection services)
        {
            services
                .AddTransient<IEntitySeeder, EntitySeeder>();

            return services;
        }
    }
}
