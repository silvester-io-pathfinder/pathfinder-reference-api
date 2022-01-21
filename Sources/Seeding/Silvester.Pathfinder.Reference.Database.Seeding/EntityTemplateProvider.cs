using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Silvester.Pathfinder.Reference.Database.Seeding
{
    public class EntityTemplateProvider<TEntity>
       where TEntity : BaseEntity
    {
        private Assembly SeedAssembly { get; }

        public EntityTemplateProvider(Assembly seedAssembly)
        {
            SeedAssembly = seedAssembly;
        }

        public IEnumerable<Type> GetTypes()
        {
            if(typeof(TEntity).IsAbstract)
            {
                yield break;
            }

            foreach(Type type in SeedAssembly.GetTypes())
            {
                if(type.IsAbstract)
                {
                    continue;
                }

                if(IsAssignableToEntityTemplate(type) || IsCovariantlyAssignableToEntityTemplate(type))
                {
                    yield return type;
                }
            }
        }

        public bool IsAssignableToEntityTemplate(Type type)
        {
            return type.IsAssignableTo(typeof(EntityTemplate<TEntity>));
        }
        
        public bool IsCovariantlyAssignableToEntityTemplate(Type type)
        {
            return type.IsAssignableTo(typeof(IEntityTemplate<>).MakeGenericType(typeof(TEntity)));
        }

        public IEnumerable<EntityTemplate<TEntity>> GetTemplates()
        {
            return GetTypes()
                .Select(e => (EntityTemplate<TEntity>) Activator.CreateInstance(e)!);
        }
    }
}
