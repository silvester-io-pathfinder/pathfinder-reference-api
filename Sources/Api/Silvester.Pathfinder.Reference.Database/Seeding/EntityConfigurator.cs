using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database.Extensions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Silvester.Pathfinder.Reference.Database.Seeding
{
    public class EntityConfigurator<TEntity>
        where TEntity : BaseEntity
    {
        public virtual void Configure(ModelBuilder builder)
        {
            Type[] interfaces = typeof(TEntity).GetInterfaces();
            if (interfaces.Contains(typeof(IOwnedEntity)))
            {
                OwnedEntityTypeBuilder<TEntity> entity = builder.Owned<TEntity>();
            }
            else
            {
                EntityTypeBuilder<TEntity> entity = builder.Entity<TEntity>();
                entity.HasBaseEntityKey();

                if (typeof(TEntity).GetInterfaces().Contains(typeof(ISearchableEntity)))
                {
                    //After checking at run time whether the TEntity is searchable, it will comply with all of the generic type parameter constraints.
                    MethodInfo method = typeof(EntityConfigurator<TEntity>).GetMethod(nameof(ConfigureEntitySearch), BindingFlags.Static | BindingFlags.NonPublic)!;
                    method.MakeGenericMethod(typeof(TEntity)).Invoke(null, new object[] { entity });
                }

                CheckPropertiesForOwnedEntityTypes(entity);
            }
        }

        private void CheckPropertiesForOwnedEntityTypes(EntityTypeBuilder<TEntity> entity)
        {
            foreach (PropertyInfo property in typeof(TEntity).GetProperties())
            {
                if (IsOwnedEntity(property))
                {
                    entity.OwnsOne(property.PropertyType, property.Name, accessor =>
                    {
                        accessor.HasKey(nameof(IOwnedEntity.OwnerId));
                        accessor.Property(nameof(BaseEntity.Id)).ValueGeneratedOnAdd();
                        accessor.Property<Guid>(nameof(IOwnedEntity.OwnerId)).ValueGeneratedOnAdd();
                        accessor.WithOwner().HasForeignKey(nameof(IOwnedEntity.OwnerId));

                        SetupSearchVector(property, accessor, property.PropertyType);
                    });
                }
                else if (IsOwnedEntityCollection(property))
                {
                    Type actualEntityType = property.PropertyType.GetGenericArguments()[0];
                    entity.OwnsMany(actualEntityType, property.Name, accessor =>
                    {
                        accessor.HasKey(nameof(BaseEntity.Id));
                        accessor.Property(nameof(BaseEntity.Id)).ValueGeneratedOnAdd();
                        accessor.Property<Guid>(nameof(IOwnedEntity.OwnerId)).ValueGeneratedOnAdd();
                        accessor.WithOwner().HasForeignKey(nameof(IOwnedEntity.OwnerId));

                        SetupSearchVector(property, accessor, actualEntityType);
                    });
                }
            }
        }

        private static bool IsOwnedEntity(PropertyInfo property)
        {
            return property.PropertyType.GetInterfaces().Contains(typeof(IOwnedEntity));
        }

        private static bool IsOwnedEntityCollection(PropertyInfo property)
        {
            return typeof(IEnumerable).IsAssignableFrom(property.PropertyType) 
                && property.PropertyType.IsGenericType
                && property.PropertyType.GetGenericArguments()[0].GetInterfaces().Contains(typeof(IOwnedEntity));
        }

        private void SetupSearchVector(PropertyInfo property, OwnedNavigationBuilder accessor, Type ownedEntityType)
        {
            if (ownedEntityType.GetInterfaces().Contains(typeof(ISearchableEntity)))
            {
                MethodInfo method = typeof(EntityConfigurator<>).MakeGenericType(typeof(TEntity)).GetMethod(nameof(ConfigureOwnedEntitySearch), BindingFlags.Static | BindingFlags.NonPublic)!;
                method.MakeGenericMethod(typeof(TEntity), ownedEntityType).Invoke(null, new object[] { accessor });
            }
        }

        private static void ConfigureEntitySearch<TSearchableEntity>(EntityTypeBuilder<TSearchableEntity> entity)
            where TSearchableEntity : BaseEntity, ISearchableEntity
        {
            SearchableEntityConfigurator<TSearchableEntity> configurator = SearchableEntityConfigurator<TSearchableEntity>.ForEntity();
            configurator.ConfigureSearch(entity);
        }

        private static void ConfigureOwnedEntitySearch<TOwner, TOwned>(OwnedNavigationBuilder accessor)
           where TOwner : BaseEntity
           where TOwned : BaseEntity, IOwnedEntity, ISearchableEntity
        {
            SearchableEntityConfigurator<TOwned> configurator = SearchableEntityConfigurator<TOwned>.ForEntity();
            configurator.ConfigureSearch<TOwner, TOwned>(accessor);
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

        public void ConfigureSearch<TOwner, TOwned>(OwnedNavigationBuilder accessor)
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
