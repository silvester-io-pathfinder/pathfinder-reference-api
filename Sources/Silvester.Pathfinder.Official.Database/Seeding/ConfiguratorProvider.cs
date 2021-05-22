using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Silvester.Pathfinder.Official.Database.Seeding
{
    public class ConfiguratorProvider<TEntity>
       where TEntity : BaseEntity
    {
        public EntityConfigurator<TEntity> GetConfigurator()
        {
            Type configuratorType = GetType().Assembly.GetTypes().FirstOrDefault(e => e.BaseType != null && e.BaseType == typeof(EntityConfigurator<TEntity>)) 
                ?? typeof(EntityConfigurator<TEntity>);

            return (EntityConfigurator<TEntity>) Activator.CreateInstance(configuratorType)!;
        }
    }
}
