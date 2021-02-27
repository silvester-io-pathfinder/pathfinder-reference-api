using HotChocolate;
using HotChocolate.Data;
using HotChocolate.Execution.Configuration;
using HotChocolate.Types;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Silvester.Pathfinder.Official.Api.Graphql;
using Silvester.Pathfinder.Official.Api.Graphql.Interceptors;
using Silvester.Pathfinder.Official.Api.Probes.Liveness;
using Silvester.Pathfinder.Official.Api.Probes.Readiness;
using Silvester.Pathfinder.Official.Api.Services;
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

            if(bool.Parse(Configuration.GetSection("Databases").GetSection("Official")["Enabled"]))
            {
                services.AddTransient<IHostedService, MigrationService>();
            }

            services
                .AddPooledDbContextFactory<OfficialDatabase>(options =>
                {
                    IConfigurationSection section = Configuration.GetSection("Databases").GetSection("Official");
                    string connectionString = $"Server={section["Server"]};Database={section["Database"]};User Id={section["UserId"]};Password={section["Password"]};Port={section["Port"]};Timeout={section["Timeout"]};CommandTimeout={section["CommandTimeout"]};";

                    options.UseNpgsql(connectionString);
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

            services
                .Configure<ForwardedHeadersOptions>(options =>
                {
                    options.ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedHost | ForwardedHeaders.XForwardedProto;
                });

            graphql
                .AddFiltering()
                .AddSorting()
                .AddProjections()
                .AddType<QueryType>()
                .TryAddTypeInterceptor<NavigationTypeInterceptor>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseForwardedHeaders();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseLivenessProbe();
            app.UseReadinessProbe();

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
