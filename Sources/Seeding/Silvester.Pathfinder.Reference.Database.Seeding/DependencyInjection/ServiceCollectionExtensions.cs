using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
