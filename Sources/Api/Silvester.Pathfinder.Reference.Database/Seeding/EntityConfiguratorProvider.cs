using System;
using System.Linq;

namespace Silvester.Pathfinder.Reference.Database.Seeding
{
    public class EntityConfiguratorProvider<TEntity>
       where TEntity : BaseEntity
    {
        public EntityConfigurator<TEntity> GetConfigurator()
        {
            Type configuratorType = GetType().Assembly.GetTypes().FirstOrDefault(e => e.BaseType != null && e.IsAssignableTo(typeof(EntityConfigurator<TEntity>))) 
                ?? typeof(EntityConfigurator<TEntity>);

            return (EntityConfigurator<TEntity>) Activator.CreateInstance(configuratorType)!;
        }
    }
}
