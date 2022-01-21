using System;
using System.Linq;

namespace Silvester.Pathfinder.Reference.Database.Seeding
{
    public class EntityConfiguratorProvider<TEntity>
       where TEntity : BaseEntity
    {
        public EntityConfigurator<TEntity> GetDefaultConfigurator()
        {
            return (EntityConfigurator<TEntity>)Activator.CreateInstance(typeof(EntityConfigurator<TEntity>))!;
        }

        public EntityConfigurator<TEntity>? GetCustomConfigurator()
        {
            Type? configuratorType = GetType().Assembly.GetTypes().SingleOrDefault(e => e.BaseType != null && e.IsAssignableTo(typeof(EntityConfigurator<TEntity>)));
            return configuratorType == null 
                ? null 
                : (EntityConfigurator<TEntity>) Activator.CreateInstance(configuratorType)!;
        }
    }
}
