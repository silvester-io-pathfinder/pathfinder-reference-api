using Microsoft.EntityFrameworkCore.ChangeTracking;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Reference.Database.Seeding
{
    public interface IEntitySeeder
    {
        Task SeedAsync();
    }

    public class EntitySeeder : IEntitySeeder
    {
        private ReferenceDatabase Database { get; }

        public EntitySeeder(ReferenceDatabase database)
        {
            Database = database;
        }

        public async Task SeedAsync()
        {
            ISeedBuilder seedBuilder = new SeedBuilder(Database);
            
            foreach (Type entityType in typeof(Spell).Assembly.GetTypes().Where(e => e.IsSubclassOf(typeof(BaseEntity))))
            {
                Console.WriteLine($"Seeding: '{entityType.Name}'.");

                GetType()
                    .GetMethod(nameof(SeedEntity), BindingFlags.NonPublic | BindingFlags.Instance)!
                    .MakeGenericMethod(entityType)!
                    .Invoke(this, new object[] { seedBuilder});
            }
            await Database.SaveChangesAsync();
        }

        private void SeedEntity<TEntity>(ISeedBuilder seedBuilder)
            where TEntity : BaseEntity
        {
            foreach (EntityTemplate<TEntity> template in Activator.CreateInstance<EntityTemplateProvider<TEntity>>().GetTemplates())
            {
                template.Seed(seedBuilder);
            }
        }
    }
}
