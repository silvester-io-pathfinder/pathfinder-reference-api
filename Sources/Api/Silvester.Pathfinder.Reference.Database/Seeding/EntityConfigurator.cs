using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Configurations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding
{
    public interface IEntityConfiguration<out TEntity>
        where TEntity : BaseEntity
    {
        void Configure(ModelBuilder builder);
    }

    public class EntityConfigurator<TEntity>
        where TEntity : BaseEntity
    {
        private IList<IEntityConfiguration<TEntity>> Decorators { get; }

        public EntityConfigurator()
        {
            Decorators = new List<IEntityConfiguration<TEntity>>();

            if(typeof(TEntity).IsOwnedEntity())
            {
                Decorators.Add(new OwnedEntityConfiguration<TEntity>());
            }
            else
            {
                Decorators.Add(new BaseEntityConfiguration<TEntity>());
                Decorators.Add(new OwnedPropertyConfiguration<TEntity>());
            }
        }

        public virtual void Configure(ModelBuilder builder)
        {
            foreach(IEntityConfiguration<TEntity> decorator in Decorators)
            {
                decorator.Configure(builder);
            }
        }

        protected void ConfigureEntitySearch<TSearchableEntity>(Expression<Func<TSearchableEntity, object>> propertiesIncludedInSearch)
            where TSearchableEntity : TEntity, ISearchableEntity
        {
            Decorators.Add(new BaseEntitySearchConfiguration<TSearchableEntity>(propertiesIncludedInSearch));
        }

        protected void ConfigureOwnedSearch<TSearchableEntity>(Expression<Func<TSearchableEntity, object>> propertiesIncludedInSearch)
            where TSearchableEntity : TEntity, ISearchableEntity, IOwnedEntity
        {
            Decorators.Add(new OwnedEntitySearchConfiguration<TSearchableEntity>(propertiesIncludedInSearch));
        }
    }

    /*
    public class EntityConfiguratorr<TEntity>
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
                    MethodInfo method = typeof(EntityConfiguratorr<TEntity>).GetMethod(nameof(ConfigureEntitySearch), BindingFlags.Static | BindingFlags.NonPublic)!;
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
                MethodInfo method = typeof(EntityConfiguratorr<>).MakeGenericType(typeof(TEntity)).GetMethod(nameof(ConfigureOwnedEntitySearch), BindingFlags.Static | BindingFlags.NonPublic)!;
                method.MakeGenericMethod(typeof(TEntity), ownedEntityType).Invoke(null, new object[] { accessor });
            }
        }

        private static void ConfigureEntitySearch<TSearchableEntity>(EntityTypeBuilder<TSearchableEntity> entity)
            where TSearchableEntity : BaseEntity, ISearchableEntity
        {
            SearchableEntityConfiguratorr<TSearchableEntity> configurator = SearchableEntityConfiguratorr<TSearchableEntity>.ForEntity();
            configurator.ConfigureSearch(entity);
        }

        private static void ConfigureOwnedEntitySearch<TOwner, TOwned>(OwnedNavigationBuilder accessor)
           where TOwner : BaseEntity
           where TOwned : BaseEntity, IOwnedEntity, ISearchableEntity
        {
            SearchableEntityConfiguratorr<TOwned> configurator = SearchableEntityConfiguratorr<TOwned>.ForEntity();
            configurator.ConfigureSearch<TOwner, TOwned>(accessor);
        }
    }

    public abstract class SearchableEntityConfiguratorr<TEntity> 
        where TEntity : BaseEntity, ISearchableEntity
    {
        public static SearchableEntityConfiguratorr<TEntity> ForEntity()
        {
            Type? type = typeof(SearchableEntityConfiguratorr<>).Assembly.GetTypes().FirstOrDefault(e => e.BaseType != null && e.BaseType == typeof(SearchableEntityConfiguratorr<TEntity>));

            if (type == null)
            {
                throw new InvalidOperationException($"No searchable entity configurator could be found for entity '{typeof(TEntity).Name}'.");
            }

            return (SearchableEntityConfiguratorr<TEntity>) Activator.CreateInstance(type)!;
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
    }*/
}
