using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Silvester.Pathfinder.Console.Core.Executors;
using Silvester.Pathfinder.Reference.Database.Seeding.Cli.Commands;
using Silvester.Pathfinder.Reference.Database.Seeding.DependencyInjection;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Reflection;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Cli
{
    public class Program
    {
        public static async Task<int> Main(string[] args)
        {
            return await Host.CreateDefaultBuilder()
                .ConfigureAppConfiguration(ConfigureApplication)
                .ConfigureServices(ConfigureServices)
                .RunCommandLineApplicationAsync<RootCommand>(args);
        }

        private static void ConfigureApplication(HostBuilderContext context, IConfigurationBuilder builder)
        {
            if(Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "ci")
            {
                builder.AddJsonFile(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)!, "appsettings.ci.json"), optional: false);
            }
            else
            {
                builder.AddJsonFile(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)!, "appsettings.json"), optional: false);
            }
        }

        private static void ConfigureServices(HostBuilderContext context, IServiceCollection services)
        {
            IConfiguration configuration = context.Configuration;

            services.AddTransient<ICommandExecutor<SeedCommand>, SeedCommandExecutor>();
            services.AddSeeding();
            services.AddDbContext<ReferenceDatabase>(options => 
            {
                IConfigurationSection section = configuration.GetSection("Databases").GetSection("Reference");
                string connectionString = $"Server={section["Server"]};Database={section["Database"]};User Id={section["UserId"]};Password={section["Password"]};Port={section["Port"]};Timeout={section["Timeout"]};CommandTimeout={section["CommandTimeout"]};Include Error Detail={section["IncludeErrorDetails"]}";

                System.Console.WriteLine("Using connection string: " + connectionString);

                options.UseNpgsql(connectionString);
                options.EnableSensitiveDataLogging(true);
            });
        }
    }
}
