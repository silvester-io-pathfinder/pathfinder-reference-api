using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database;
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

        public static T[] HasDataSeed<T>(this EntityTypeBuilder<T> builder, IEntitySeeder<T> seeder)
            where T : class
        {
            T[] array = seeder.GetSeedEntities().ToArray();
            builder.HasData(array);
            return array;
        }

        public static T AddData<T>(this EntityTypeBuilder<T> builder, T entity)
            where T : class
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
