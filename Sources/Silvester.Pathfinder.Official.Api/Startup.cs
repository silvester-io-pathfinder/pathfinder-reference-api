using HotChocolate;
using HotChocolate.Data;
using HotChocolate.Execution.Configuration;
using HotChocolate.Types;
using HotChocolate.Types.Descriptors;
using HotChocolate.Types.Descriptors.Definitions;
using HotChocolate.Types.Pagination;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Silvester.Pathfinder.Official.Api.Graphql;
using Silvester.Pathfinder.Official.Api.Graphql.Extensions;
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
        private const string LOCALHOST_CORS_POLICY_NAME = "CORS_POLICY_LOCALHOST";

        private IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(name: LOCALHOST_CORS_POLICY_NAME, builder =>
                {
                    builder.SetIsOriginAllowed(origin => new Uri(origin).Host == "localhost");
                    builder.AllowAnyHeader();
                    builder.AllowAnyMethod();
                    builder.AllowCredentials();
                });
            });

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
                services.AddSingleton<IHostedService, MigrationService>();
            }

            services
                .AddSingleton<IReadinessProbe, DatabaseReadinessProbe>();

            services
                .AddPooledDbContextFactory<OfficialDatabase>((sp, options) =>
                {
                    IConfigurationSection section = Configuration.GetSection("Databases").GetSection("Official");
                    string connectionString = $"Server={section["Server"]};Database={section["Database"]};User Id={section["UserId"]};Password={section["Password"]};Port={section["Port"]};Timeout={section["Timeout"]};CommandTimeout={section["CommandTimeout"]};";

                    options.UseNpgsql(connectionString);
                });


            IRequestExecutorBuilder graphql = services
                .AddGraphQLServer()
                .AddType(new UuidType('D'))
                .AddQueryType<Query>()
                .AddEntityTypes()
                .AddFiltering()
                .AddSorting()
                .AddProjections()
                .AddType<QueryType>()
                .SetPagingOptions(new PagingOptions { MaxPageSize = 100, DefaultPageSize = 25, IncludeTotalCount = true })
                .TryAddTypeInterceptor<NavigationTypeInterceptor>();

            services
                .Configure<ForwardedHeadersOptions>(options =>
                {
                    options.ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedHost | ForwardedHeaders.XForwardedProto;
                });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseForwardedHeaders();

            if (env.IsDevelopment())
            {
                //app.UseDeveloperExceptionPage();
            }

            app.UseLivenessProbe();
            app.UseReadinessProbe();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "V1");
            });

            app.UseRouting();
            app.UseCors(LOCALHOST_CORS_POLICY_NAME);

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapGraphQL();
            });
        }
    }
}
