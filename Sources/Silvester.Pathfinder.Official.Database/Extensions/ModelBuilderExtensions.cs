using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Official.Database.Extensions
{
    public static class ModelBuilderExtensions
    {
        /*public static ModelBuilder HasJoinedData<TLeft, TRight>(this ModelBuilder builder, Expression<Func<TLeft, IEnumerable<TRight>>> leftSelector, Expression<Func<TRight, IEnumerable<TLeft>>> rightSelector, params (TLeft left, TRight right)[] data)
          where TLeft : BaseEntity
          where TRight : BaseEntity
        {
            IMutableEntityType firstEntityType = builder.Model.FindEntityType(typeof(TLeft));
            IMutableEntityType secondEntityType = builder.Model.FindEntityType(typeof(TRight));

            IMutableSkipNavigation firstToSecond = firstEntityType
                .GetSkipNavigations()
                .Single(n => n.TargetEntityType == secondEntityType);

            IMutableEntityType joinEntityType = firstToSecond.JoinEntityType;
            IMutableProperty firstProperty = firstToSecond.ForeignKey.Properties.Single();
            IMutableProperty secondProperty = firstToSecond.Inverse.ForeignKey.Properties.Single();
            IClrPropertyGetter firstValueGetter = firstToSecond.ForeignKey.PrincipalKey.Properties.Single().GetGetter();
            IClrPropertyGetter secondValueGetter = firstToSecond.Inverse.ForeignKey.PrincipalKey.Properties.Single().GetGetter();

            builder
                .Entity<TLeft>()
                .HasMany(leftSelector)
                .WithMany(rightSelector)
                .Using
                .UsingEntity<Dictionary<string, object>>(joinEntityType.Name,
                    r => r.HasOne(typeof(TLeft)).WithMany().HasForeignKey(secondProperty.Name),
                    l => l.HasOne(typeof(TRight)).WithMany().HasForeignKey(firstProperty.Name),
                    je =>
                    {
                        je.HasKey(firstProperty.Name, secondProperty.Name);
                        je.HasData(data.Select(e => new Dictionary<string, object>
                        {
                            [firstProperty.Name] = firstValueGetter.GetClrValue(e.left),
                            [secondProperty.Name] = secondValueGetter.GetClrValue(e.right),
                        }));
                    });
         
            return builder;
        }*/

        public static ModelBuilder HasJoinData<TFirst, TSecond>(this ModelBuilder modelBuilder, params (TFirst First, TSecond Second)[] data)
            where TFirst : class where TSecond : class
        {
            return modelBuilder.HasJoinData(data.AsEnumerable());
        }

        public static ModelBuilder HasJoinData<TFirst, TSecond>(this ModelBuilder modelBuilder, IEnumerable<(TFirst First, TSecond Second)> data)
            where TFirst : class where TSecond : class
        {
            IMutableEntityType firstEntityType = modelBuilder.Model.FindEntityType(typeof(TFirst));
            IMutableEntityType secondEntityType = modelBuilder.Model.FindEntityType(typeof(TSecond));
            
            IMutableSkipNavigation firstToSecond = GetFirstToSecondNavigation<TFirst, TSecond>(firstEntityType, secondEntityType);

            IMutableEntityType joinEntityType = firstToSecond.JoinEntityType;
            IMutableProperty firstProperty = firstToSecond.ForeignKey.Properties.Single();
            IMutableProperty secondProperty = firstToSecond.Inverse.ForeignKey.Properties.Single();
            IClrPropertyGetter firstValueGetter = firstToSecond.ForeignKey.PrincipalKey.Properties.Single().GetGetter();
            IClrPropertyGetter secondValueGetter = firstToSecond.Inverse.ForeignKey.PrincipalKey.Properties.Single().GetGetter();

            IEnumerable<object> seedData = data.Select(e =>
            {
                return (object)new Dictionary<string, object>
                {
                    [firstProperty.Name] = firstValueGetter.GetClrValue(e.First),
                    [secondProperty.Name] = secondValueGetter.GetClrValue(e.Second),
                };
            });

            modelBuilder
                .Entity(typeof(TFirst))
                .HasOne(typeof(TSecond))
                .WithMany()
                .HasForeignKey(secondProperty.Name);

            modelBuilder
                .Entity(typeof(TSecond))
                .HasOne(typeof(TFirst))
                .WithMany()
                .HasForeignKey(firstProperty.Name);

            EntityTypeBuilder joinEntity = modelBuilder
                .Entity(joinEntityType.Name);

            joinEntity
                .HasKey(firstProperty.Name, secondProperty.Name);

            joinEntity
                .HasData(seedData);

            return modelBuilder;
        }

        private static IMutableSkipNavigation GetFirstToSecondNavigation<TFirst, TSecond>(IMutableEntityType firstEntityType, IMutableEntityType secondEntityType)
        {
            try
            {
                return firstEntityType
                    .GetSkipNavigations()
                    .Single(n => n.TargetEntityType == secondEntityType);

            }
            catch (InvalidOperationException _)
            {
                Console.WriteLine("Following navigational properties could not be found. Are you sure they're present and PROPERTIES (as opposed to FIELDS)?");
                Console.WriteLine($"First: {typeof(TFirst).Name}");
                Console.WriteLine($"Second: {typeof(TSecond).Name}");

                throw;
            }
        }

        public static ModelBuilder Join<TSource, TTarget>(this ModelBuilder builder, TSource[] sources, TTarget[] targets, IEntityJoiner<TSource, TTarget> joiner)
            where TSource : class
            where TTarget : class
        {

            foreach (TSource source in sources)
            {
                foreach (TTarget target in joiner.Join(source, targets))
                {
                    builder.HasJoinData((source, target));
                }
            }

            return builder;
        }

        public static ModelBuilder Join<TSource, TTarget>(this ModelBuilder builder, TSource[] sources, IEntityJoiner<TSource, TTarget> joiner)
            where TSource : class
            where TTarget : class
        {

            foreach (TSource source in sources)
            {
                TTarget[] newTargetEntities = joiner.Join(source, Array.Empty<TTarget>());
                foreach (TTarget target in newTargetEntities)
                {
                    builder.Entity(target.GetType()).HasData(newTargetEntities);
                    builder.HasJoinData((source, target));
                }
            }

            return builder;
        }

        public static ModelBuilder Join<TSource, TTarget, TJoin>(this ModelBuilder builder, TSource[] sources, TTarget[] targets, IEntityJoiner<TSource, TTarget, TJoin> joiner)
            where TSource : class
            where TTarget : class
            where TJoin : class
        {
            EntityTypeBuilder<TJoin> typeBuilder = builder.Entity<TJoin>();
            foreach (TSource source in sources)
            {
                foreach (TJoin join in joiner.Join(source, targets))
                {
                    typeBuilder.HasData(join);
                }
            }

            return builder;
        }

        public static object AddData(this ModelBuilder builder, Type type, object entity)
        {
            return builder.Entity(type).AddData(entity);
        }

        public static T AddData<T>(this ModelBuilder builder, T entity)
            where T : class
        {
            return builder.Entity<T>().AddData(entity);
        }

        public static T[] AddData<T>(this ModelBuilder builder, IEnumerable<T> entities)
            where T : class
        {
            return builder.Entity<T>().AddData(entities);
        }

        public static EntityTypeBuilder<TOwner> AddOwnedData<TOwner, TOwned>(this ModelBuilder builder, Expression<Func<TOwner, IEnumerable<TOwned>>> collectionSelector, TOwned ownedEntity)
            where TOwned : BaseEntity
            where TOwner : BaseEntity
        {
            return builder.AddOwnedData(collectionSelector, new TOwned[] { ownedEntity });
        }

        public static EntityTypeBuilder<TOwner> AddOwnedData<TOwner, TOwned>(this ModelBuilder builder, Expression<Func<TOwner, IEnumerable<TOwned>>> collectionSelector, IEnumerable<TOwned> ownedEntities)
           where TOwned : BaseEntity
           where TOwner : BaseEntity
        {
            return builder
                .Entity<TOwner>()
                .OwnsMany(collectionSelector, a =>
                {
                    a.HasKey(e => e.Id);
                    a.Property(e => e.Id).ValueGeneratedOnAdd();
                    a.Property<Guid>("OwnerId").ValueGeneratedOnAdd();
                    a.WithOwner().HasForeignKey("OwnerId");
                    a.HasData(ownedEntities);
                });
        }
    }
}
