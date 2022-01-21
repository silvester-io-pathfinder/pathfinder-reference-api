using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Reference.Database.Seeding
{
    public interface IEntitySeeder
    {
        Task SeedAsync(Assembly seedAssembly);
    }

    public class EntitySeeder : IEntitySeeder
    {
        private ReferenceDatabase Database { get; }

        public EntitySeeder(ReferenceDatabase database)
        {
            Database = database;
        }

        public async Task SeedAsync(Assembly seedAssembly)
        {
            ISeedBuilder seedBuilder = new SeedBuilder(Database);
            
            foreach (Type entityType in typeof(Spell).Assembly.GetTypes().Where(e => e.IsSubclassOf(typeof(BaseEntity)) && e.IsGenericType == false))
            {
                Console.WriteLine($"Seeding: '{entityType.Name}'.");

                GetType()
                    .GetMethod(nameof(SeedEntity), BindingFlags.NonPublic | BindingFlags.Instance)!
                    .MakeGenericMethod(entityType)!
                    .Invoke(this, new object[] { seedBuilder, seedAssembly });
            }

            await Database.SaveChangesAsync();
        }

        private void SeedEntity<TEntity>(ISeedBuilder seedBuilder, Assembly seedAssembly)
            where TEntity : BaseEntity
        {
            foreach (EntityTemplate<TEntity> template in new EntityTemplateProvider<TEntity>(seedAssembly).GetTemplates())
            {
                template.Seed(seedBuilder);
            }
        }
    }
}
