using HotChocolate;
using HotChocolate.Execution.Configuration;
using HotChocolate.Types;
using HotChocolate.Types.Pagination;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Primitives;
using Microsoft.OpenApi.Models;
using Silvester.Pathfinder.Reference.Api.Graphql;
using Silvester.Pathfinder.Reference.Api.Graphql.Extensions;
using Silvester.Pathfinder.Reference.Api.Graphql.Handlers.Queryable.String.CaseInsensitive;
using Silvester.Pathfinder.Reference.Api.Graphql.Interceptors;
using Silvester.Pathfinder.Reference.Api.Middlewares;
using Silvester.Pathfinder.Reference.Api.Probes.Readiness;
using Silvester.Pathfinder.Reference.Api.Services;
using Silvester.Pathfinder.Reference.Database;
using Silvester.Pathfinder.Reference.Probes.Liveness;
using Silvester.Pathfinder.Reference.Probes.Readiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Silvester.Pathfinder.Reference.Api
{
    public class Startup
    {
        private const string LOCALHOST_CORS_POLICY_NAME = "CORS_POLICY_LOCALHOST";

        private IConfiguration Configuration { get; }
        
        private IWebHostEnvironment Environment { get; }

        public Startup(IConfiguration configuration, IWebHostEnvironment environment)
        {
            Configuration = configuration;
            Environment = environment;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services
                .AddOptions<ForwardedPathBaseHeaderMiddleware.Options>()
                .Configure(options =>
                {
                    options.ForwardedPathHeaderName = "x-forwarded-path";
                })
                .ValidateDataAnnotations();

            services
                .AddCors(options =>
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

            if(bool.Parse(Configuration.GetSection("Databases").GetSection("Reference")["Enabled"]))
            {
                services.AddSingleton<IHostedService, MigrationService>();
            }

            services
                .AddSingleton<IReadinessProbe, DatabaseReadinessProbe>();

            services
                .AddPooledDbContextFactory<ReferenceDatabase>((sp, options) =>
                {
                    IConfigurationSection section = Configuration.GetSection("Databases").GetSection("Reference");
                    string connectionString = $"Server={section["Server"]};Database={section["Database"]};User Id={section["UserId"]};Password={section["Password"]};Port={section["Port"]};Timeout={section["Timeout"]};CommandTimeout={section["CommandTimeout"]};Include Error Detail={section["IncludeErrorDetails"]}";

                    options.EnableSensitiveDataLogging(Environment.IsDevelopment());
                    options.UseNpgsql(connectionString);
                });

            IRequestExecutorBuilder graphql = services
                .AddGraphQLServer()
                .AddType(new UuidType('D'))
                .AddQueryType<Query>()
                .AddEntityTypes()
                .AddCaseInsensitiveFilterConvention()
                .AddSorting()
                .AddProjections()
                .AddType<QueryType>()
                .SetPagingOptions(new PagingOptions { MaxPageSize = 100, DefaultPageSize = 25, IncludeTotalCount = true })
                .TryAddTypeInterceptor<NavigationTypeInterceptor>()
                .TryAddTypeInterceptor<TextSearchVectorInterceptor>();

            services
                .Configure<ForwardedHeadersOptions>(options =>
                {
                    options.ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedHost | ForwardedHeaders.XForwardedProto;
                });
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseForwardedHeaders();
            app.UseMiddleware<ForwardedPathBaseHeaderMiddleware>();
            app.UseLivenessProbe();
            app.UseReadinessProbe();

            app.UseSwagger(c => 
            {
                c.PreSerializeFilters.Add((swaggerDoc, httpReq) =>
                {
                    swaggerDoc.Servers = new List<OpenApiServer> { new OpenApiServer { Url = $"https://{httpReq.Host.Value}{httpReq.PathBase}" } };
                });
            });
            app.UseSwaggerUI(c =>
            {
                c.DocumentTitle = "PF2E - REST API";
                c.SwaggerEndpoint("v1/swagger.json", "V1");
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
