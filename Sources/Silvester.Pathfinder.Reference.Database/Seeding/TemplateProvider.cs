using System;
using System.Collections.Generic;
using System.Linq;

namespace Silvester.Pathfinder.Reference.Database.Seeding
{
    public class TemplateProvider<TEntity>
       where TEntity : BaseEntity
    {
        public IEnumerable<Type> GetTypes()
        {
            return GetType()
                .Assembly
                .GetTypes()
                .Where(e => e.IsSubclassOf(typeof(EntityTemplate<TEntity>)) && e.IsAbstract == false);
        }

        public IEnumerable<EntityTemplate<TEntity>> GetTemplates()
        {
            return GetTypes()
                .Select(e => (EntityTemplate<TEntity>) Activator.CreateInstance(e)!);
        }
    }
}
