using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NpgsqlTypes;
using Silvester.Pathfinder.Official.Database.Extensions;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Silvester.Pathfinder.Official.Database.Seeding
{
    public class EntityConfigurator<TEntity>
        where TEntity : BaseEntity
    {
        public virtual void Configure(ModelBuilder builder)
        {
            Type[] interfaces = typeof(TEntity).GetInterfaces();
            if (interfaces.Contains(typeof(IOwnedEntity)))
            {
                builder.Owned<TEntity>();
            }
            else
            {
                EntityTypeBuilder<TEntity> entity = builder.Entity<TEntity>();
                entity.HasBaseEntityKey();

                if(typeof(TEntity).GetInterfaces().Contains(typeof(ISearchableEntity)))
                {
                    //After checking at run time whether the TEntity is searchable, it will comply with all of the generic type parameter constraints.
                    MethodInfo method = typeof(EntityConfigurator<TEntity>).GetMethod(nameof(ConfigureSearch), BindingFlags.Static | BindingFlags.NonPublic)!;
                    method.MakeGenericMethod(typeof(TEntity)).Invoke(null, new object[] { entity} );
                }
            }
        }

        private static void ConfigureSearch<TSearchableEntity>(EntityTypeBuilder<TSearchableEntity> entity)
            where TSearchableEntity : BaseEntity, ISearchableEntity
        {
            SearchableEntityConfigurator<TSearchableEntity> configurator = SearchableEntityConfigurator<TSearchableEntity>.ForEntity();
            configurator.ConfigureSearch(entity);
        }
    }

    public abstract class SearchableEntityConfigurator<TEntity> 
        where TEntity : BaseEntity, ISearchableEntity
    {
        public static SearchableEntityConfigurator<TEntity> ForEntity()
        {
            Type? type = typeof(SearchableEntityConfigurator<>).Assembly.GetTypes().FirstOrDefault(e => e.BaseType != null && e.BaseType == typeof(SearchableEntityConfigurator<TEntity>));

            if (type == null)
            {
                throw new InvalidOperationException($"No searchable entity configurator could be found for entity '{typeof(TEntity).Name}'.");
            }

            return (SearchableEntityConfigurator<TEntity>) Activator.CreateInstance(type)!;
        }

        public void ConfigureSearch(EntityTypeBuilder<TEntity> entity)
        {
            entity
                .HasGeneratedTsVectorColumn(e => e.SearchVector, "english", GetSearchProperties())
                .HasIndex(e => e.SearchVector)
                .HasMethod("GIN");
        }

        public void ConfigureSearch<TOwner, TOwned>(OwnedNavigationBuilder<TOwner, TOwned> accessor)
            where TOwner : BaseEntity
            where TOwned : BaseEntity, IOwnedEntity, ISearchableEntity
        {
            PropertyBuilder<NpgsqlTsVector> property = accessor
                .Property<NpgsqlTsVector>(nameof(ISearchableEntity.SearchVector))
                .IsGeneratedTsVectorColumn("english", GetSearchProperties().GetPropertyAccessList().Select(ReflectionExtensions.GetSimpleMemberName).ToArray());

            accessor
                .HasIndex(nameof(ISearchableEntity.SearchVector))
                .HasMethod("GIN");
        }

        public abstract Expression<Func<TEntity, object?>> GetSearchProperties();
    }
}
