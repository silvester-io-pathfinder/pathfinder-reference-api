using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using System.Linq.Expressions;
using System.Reflection;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Configurations
{
    public class BaseEntitySearchConfiguration<TEntity> : IEntityConfiguration<TEntity>
        where TEntity : BaseEntity, ISearchableEntity
    {
        private Expression<Func<TEntity, object>> PropertiesIncludedInSearch { get; }

        public BaseEntitySearchConfiguration(Expression<Func<TEntity, object>> propertiesIncludedInSearch)
        {
            PropertiesIncludedInSearch = propertiesIncludedInSearch;
        }

        public void Configure(ModelBuilder builder)
        {
            builder
              .Entity<TEntity>()
              .HasGeneratedTsVectorColumn(e => e.SearchVector, "english", PropertiesIncludedInSearch)
              .HasIndex(e => e.SearchVector)
              .HasMethod("GIN");
        }
    }
}
