using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NpgsqlTypes;
using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding;
using Silvester.Pathfinder.Official.Database.Utilities.Tables;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Silvester.Pathfinder.Official.Database.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static ModelBuilder HasJoinData(this ModelBuilder modelBuilder, Type firstType, Type secondType, params (Guid First, Guid Second)[] data)
        {
            MethodInfo method = typeof(ModelBuilderExtensions).GetMethod(nameof(HasJoinData), 2, new Type[] { typeof(ModelBuilder), typeof(IEnumerable<(Guid, Guid)>)})!;
            method.MakeGenericMethod(firstType, secondType).Invoke(null, new object[] { modelBuilder, data.AsEnumerable() });

            return modelBuilder;
        }

        public static ModelBuilder HasJoinData<TFirst, TSecond>(this ModelBuilder modelBuilder, TFirst first, IEnumerable<Guid> seconds)
           where TFirst : BaseEntity
           where TSecond : BaseEntity
        {
            return modelBuilder.HasJoinData<TFirst, TSecond>(seconds.Select(id => (first.Id, id)));
        }

        public static ModelBuilder HasJoinData<TFirst, TSecond>(this ModelBuilder modelBuilder, params (Guid First, Guid Second)[] data)
            where TFirst : class where TSecond : class
        {
            return modelBuilder.HasJoinData<TFirst, TSecond>(data.AsEnumerable());
        }

        public static ModelBuilder HasJoinData<TFirst, TSecond>(this ModelBuilder modelBuilder, IEnumerable<(Guid First, Guid Second)> data)
            where TFirst : class where TSecond : class
        {
            IMutableEntityType firstEntityType = modelBuilder.Model.FindEntityType(typeof(TFirst));
            IMutableEntityType secondEntityType = modelBuilder.Model.FindEntityType(typeof(TSecond));

            IMutableSkipNavigation firstToSecond = GetFirstToSecondNavigation<TFirst, TSecond>(firstEntityType, secondEntityType);

            IMutableEntityType joinEntityType = firstToSecond.JoinEntityType;
            IMutableProperty firstProperty = firstToSecond.ForeignKey.Properties.Single();
            IMutableProperty secondProperty = firstToSecond.Inverse.ForeignKey.Properties.Single();

            IEnumerable<object> seedData = data.Select(e =>
            {
                return (object)new Dictionary<string, object>
                {
                    [firstProperty.Name] = e.First,
                    [secondProperty.Name] = e.Second,
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
            IMutableSkipNavigation[] skipNavigations1 = firstEntityType
                .GetSkipNavigations()
                .ToArray();

            IMutableSkipNavigation[] skipNavigations2 = secondEntityType
                .GetSkipNavigations()
                .ToArray();
            try
            {
                return skipNavigations1.Single(n => n.TargetEntityType == secondEntityType);

            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Following navigational properties could not be found. Are you sure they're present and PROPERTIES (as opposed to FIELDS)?");
                Console.WriteLine($"First: {typeof(TFirst).Name}");
                Console.WriteLine($"Second: {typeof(TSecond).Name}");
                Console.WriteLine($"First Count: {skipNavigations1.Length} with entries '{string.Join(", ", skipNavigations1.Select(e => e.Name))}'.");
                Console.WriteLine($"Second Count: {skipNavigations2.Length} with entries '{string.Join(", ", skipNavigations2.Select(e => e.Name))}'.");

                throw;
            }
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


        public static EntityTypeBuilder<TOwner> AddOwnedData<TOwner, TOwned>(this ModelBuilder builder, TOwner owner, TOwned owned, Expression<Func<TOwner, IEnumerable<TOwned>>> collectionSelector)
            where TOwned : BaseEntity, IOwnedEntity, new()
            where TOwner : BaseEntity
        {
            owned.OwnerId = owner.Id;
            return builder.AddOwnedData(collectionSelector, new TOwned[] { owned});
        }

        public static EntityTypeBuilder<TOwner> AddOwnedData<TOwner, TOwned>(this ModelBuilder builder, Expression<Func<TOwner, IEnumerable<TOwned>>> collectionSelector, TOwned ownedEntity)
            where TOwned : BaseEntity, IOwnedEntity, new()
            where TOwner : BaseEntity
        {
            return builder.AddOwnedData(collectionSelector, new TOwned[] { ownedEntity });
        }

        public static EntityTypeBuilder<TOwner> AddOwnedData<TOwner, TOwned>(this ModelBuilder builder, Expression<Func<TOwner, IEnumerable<TOwned>>> collectionSelector, IEnumerable<TOwned> ownedEntities)
           where TOwned : BaseEntity, IOwnedEntity
           where TOwner : BaseEntity
        {
            try
            {
                return builder
                    .Entity<TOwner>()
                    .OwnsMany(collectionSelector, accessor =>
                    {
                        accessor.HasKey(e => e.Id);
                        accessor.Property(e => e.Id).ValueGeneratedOnAdd();
                        accessor.Property<Guid>("OwnerId").ValueGeneratedOnAdd();
                        accessor.WithOwner().HasForeignKey("OwnerId");
                        accessor.HasData(ownedEntities);

                        if(typeof(TOwned).GetInterfaces().Contains(typeof(ISearchableEntity)))
                        {
                            //After checking at run time whether the TEntity is searchable, it will comply with all of the generic type parameter constraints.
                            MethodInfo method = typeof(ModelBuilderExtensions).GetMethod(nameof(ConfigureSearch), BindingFlags.Static | BindingFlags.NonPublic)!;
                            method.MakeGenericMethod(typeof(TOwner), typeof(TOwned)).Invoke(null, new object[] { accessor });
                        }
                    });
            } 
            catch(InvalidOperationException exception)
            {
                Console.WriteLine(exception.Message);
                throw;
            }
        }

        private static void ConfigureSearch<TOwner, TOwned>(OwnedNavigationBuilder<TOwner, TOwned> accessor)
            where TOwner : BaseEntity
            where TOwned : BaseEntity, IOwnedEntity, ISearchableEntity
        {
            SearchableEntityConfigurator<TOwned> configurator = SearchableEntityConfigurator<TOwned>.ForEntity();
            configurator.ConfigureSearch(accessor);
        }

        public static EntityTypeBuilder<TOwner> AddOwnedData<TOwner, TOwned>(this ModelBuilder builder, Expression<Func<TOwner, TOwned?>> selector, TOwned ownedEntity)
           where TOwned : BaseEntity
           where TOwner : BaseEntity
        {
            try
            {
                return builder
                    .Entity<TOwner>()
                    .OwnsOne(selector, a =>
                    {
                        a.HasKey(e => e!.Id);
                        a.Property(e => e!.Id).ValueGeneratedOnAdd();
                        a.Property<Guid>("OwnerId").ValueGeneratedOnAdd();
                        a.WithOwner().HasForeignKey("OwnerId");
                        a.HasData(ownedEntity);
                    });
            }
            catch (InvalidOperationException exception)
            {
                Console.WriteLine(exception.Message);
                throw;
            }
        }

        public static EntityTypeBuilder AddOwnedData(this ModelBuilder builder, Type ownerType, Type ownedType, string propertyName, IEnumerable<object> ownedEntities)
        {
            try
            {
                return builder
                    .Entity(ownerType)
                    .OwnsMany(ownedType, propertyName, a =>
                    {
                        a.HasKey(nameof(BaseEntity.Id));
                        a.Property(nameof(BaseEntity.Id)).ValueGeneratedOnAdd();
                        a.Property<Guid>("OwnerId").ValueGeneratedOnAdd();
                        a.WithOwner().HasForeignKey("OwnerId");
                        a.HasData(ownedEntities);
                    });
            }
            catch (InvalidOperationException exception)
            {
                Console.WriteLine(exception.Message);
                throw;
            }
        }

        public static EntityTypeBuilder AddOwnedData(this ModelBuilder builder, Type ownerType, Type ownedType, string propertyName, object ownedEntity)
        {
            try
            {
                return builder
                    .Entity(ownerType)
                    .OwnsOne(ownedType, propertyName, a =>
                    {
                        a.HasKey(nameof(BaseEntity.Id));
                        a.Property(nameof(BaseEntity.Id)).ValueGeneratedOnAdd();
                        a.Property<Guid>("OwnerId").ValueGeneratedOnAdd();
                        a.WithOwner().HasForeignKey("OwnerId");
                        a.HasData(ownedEntity);
                    });
            }
            catch (InvalidOperationException exception)
            {
                Console.WriteLine(exception.Message);
                throw;
            }
        }
    }
}
