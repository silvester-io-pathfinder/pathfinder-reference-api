using Microsoft.EntityFrameworkCore;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding
{
    public class EntitySeeder<TEntity>
        where TEntity : BaseEntity
    {
        public void Seed(ModelBuilder builder)
        {
            foreach (EntityTemplate<TEntity> template in CreateInstance<TemplateProvider<TEntity>>().GetTemplates()) 
            {
                template.Seed(builder);
            }
        }

        private static T CreateInstance<T>()
        {
            return (T) Activator.CreateInstance(typeof(T))!;
        }
    }
}
