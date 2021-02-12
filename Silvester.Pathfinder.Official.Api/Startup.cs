using HotChocolate;
using HotChocolate.Data;
using HotChocolate.Execution.Configuration;
using HotChocolate.Types;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Silvester.Pathfinder.Official.Api.Graphql;
using Silvester.Pathfinder.Official.Api.Graphql.Interceptors;
using Silvester.Pathfinder.Official.Database;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Silvester.Pathfinder.Api
{
    public class Startup
    {
        private IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services
                .AddControllers()
                .AddJsonOptions(options =>
                {
                    options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
                    options.JsonSerializerOptions.DictionaryKeyPolicy = JsonNamingPolicy.CamelCase;
                    options.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
                });

            services
                .AddSwaggerGen();

            services
                .AddPooledDbContextFactory<OfficialDatabase>(options =>
                {
                    options.UseNpgsql(Configuration.GetSection("Databases").GetSection("Official")["ConnectionString"]);
                    options.EnableSensitiveDataLogging(true);
                });

            IRequestExecutorBuilder graphql = services
                .AddGraphQLServer()
                .AddQueryType<Query>();

            foreach(PropertyInfo property in typeof(OfficialDatabase).GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.GetProperty))
            {
                if (property.PropertyType.IsAssignableTo(typeof(DbSet<>)) || property.PropertyType.IsGenericType == false)
                {
                    continue;
                }

                Type genericType = property.PropertyType.GetGenericArguments().First();
                if (genericType.IsAssignableTo(typeof(BaseEntity)) == false)
                {
                    continue;
                }

                graphql.AddType(genericType);
            }

            graphql
                .AddFiltering()
                .AddSorting()
                .AddProjections()
                .AddType<QueryType>()
                .TryAddTypeInterceptor<NavigationTypeInterceptor>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "V1");
            });

            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapGraphQL();
            });
        }
    }
}
