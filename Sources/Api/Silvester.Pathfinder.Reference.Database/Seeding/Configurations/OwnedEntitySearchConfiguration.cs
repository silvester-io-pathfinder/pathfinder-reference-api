using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Configurations
{
    public class OwnedEntitySearchConfiguration<TEntity> : IEntityConfiguration<TEntity>
        where TEntity : BaseEntity, ISearchableEntity
    {
        private Expression<Func<TEntity, object>> PropertiesIncludedInSearch { get; }

        public OwnedEntitySearchConfiguration(Expression<Func<TEntity, object>> propertiesIncludedInSearch)
        {
            PropertiesIncludedInSearch = propertiesIncludedInSearch;
        }

        public void Configure(ModelBuilder builder)
        {
            IEnumerable<Type> allEntityTypes = typeof(TEntity)
                .Assembly
                .GetTypes()
                .Where(e => e.IsAssignableTo(typeof(BaseEntity)))
                .Where(e => e.IsAssignableTo(typeof(IOwnedEntity)) == false); 

            foreach (Type owner in allEntityTypes)
            {
                ConfigureOwner(builder, owner);
            }
        }

        private void ConfigureOwner(ModelBuilder builder, Type owner)
        {
            IEnumerable<PropertyInfo> propertiesOfEntityType = owner
                .GetProperties()
                .Where(e => e.PropertyType.IsTypeOrCollectionOfType<TEntity>());

            foreach (PropertyInfo property in propertiesOfEntityType)
            {
                ConfigureProperty(builder, owner, property);
            }
        }

        private void ConfigureProperty(ModelBuilder builder, Type owner, PropertyInfo property)
        {
            EntityTypeBuilder entity = builder.Entity(owner);
            if (property.PropertyType.IsOwnedEntity())
            {
                ConfigureOwnedEntity(owner, property, entity);
            }
            else if (property.PropertyType.IsOwnedEntityCollection())
            {
                ConfigureOwnedEntityCollection(owner, property, entity);
            }
        }

        private void ConfigureOwnedEntityCollection(Type owner, PropertyInfo property, EntityTypeBuilder entity)
        {
            Type actualEntityType = property.PropertyType.GetGenericArguments()[0];
            entity.OwnsMany(actualEntityType, property.Name, accessor =>
            {
                SetupSearchVector(owner, actualEntityType, accessor);
            });
        }

        private void ConfigureOwnedEntity(Type owner, PropertyInfo property, EntityTypeBuilder entity)
        {
            entity.OwnsOne(property.PropertyType, property.Name, accessor =>
            {
                SetupSearchVector(owner, property.PropertyType, accessor);
            });
        }

        public void SetupSearchVector(Type owner, Type owned, OwnedNavigationBuilder accessor)
        {
            GetType()
                .GetMethod(nameof(SetupSearchVector), genericParameterCount: 2, new Type[] { typeof(OwnedNavigationBuilder) })!
                .MakeGenericMethod(owner, owned)
                .Invoke(this, new object[] { accessor });
        }

        public void SetupSearchVector<TOwner, TOwned>(OwnedNavigationBuilder accessor)
            where TOwner : BaseEntity
            where TOwned : BaseEntity, IOwnedEntity, ISearchableEntity
        {
            PropertyBuilder<NpgsqlTsVector> property = accessor
                .Property<NpgsqlTsVector>(nameof(ISearchableEntity.SearchVector))
                .IsGeneratedTsVectorColumn("english", PropertiesIncludedInSearch.GetPropertyAccessList().Select(ReflectionExtensions.GetSimpleMemberName).ToArray());

            accessor
                .HasIndex(nameof(ISearchableEntity.SearchVector))
                .HasMethod("GIN");
        }

    }
}
