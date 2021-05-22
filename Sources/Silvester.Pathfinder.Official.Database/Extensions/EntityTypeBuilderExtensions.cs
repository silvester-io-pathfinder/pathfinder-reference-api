using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Silvester.Pathfinder.Official.Database.Extensions
{
    public static class EntityTypeBuilderExtensions
    {
        public static EntityTypeBuilder<T> HasBaseEntityKey<T>(this EntityTypeBuilder<T> builder)
            where T : BaseEntity
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            return builder;
        }

        public static EntityTypeBuilder HasBaseEntityKey(this EntityTypeBuilder builder, Type entityType)
        {
            builder.HasKey(nameof(BaseEntity.Id));
            builder.Property(nameof(BaseEntity.Id)).ValueGeneratedOnAdd();
            return builder;
        }

        public static T AddData<T>(this EntityTypeBuilder<T> builder, T entity)
            where T : class
        {
            builder.HasData(entity);
            return entity;
        }

        public static object AddData(this EntityTypeBuilder builder, object entity)
        {
            builder.HasData(entity);
            return entity;
        }

        public static T[] AddData<T>(this EntityTypeBuilder<T> builder, IEnumerable<T> entities)
            where T : class
        {
            T[] array = entities.ToArray();
            builder.HasData(array);
            return array;
        }
    }
}
