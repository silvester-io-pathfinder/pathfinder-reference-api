using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Silvester.Pathfinder.Reference.Database.Seeding
{
    public interface ISeedBuilder
    {
        ISeedBuilder AddData(Type type, object entity);
        ISeedBuilder AddData<TEntity>(TEntity entity) 
            where TEntity : class;
        ISeedBuilder AddData<TEntity>(IEnumerable<TEntity> entities)
           where TEntity : class;
        ISeedBuilder AddJoinData<TLeft, TRight>(TLeft left, IEnumerable<TRight> rights)
           where TLeft : BaseEntity
           where TRight : BaseEntity;
        ISeedBuilder AddJoinData<TLeft, TRight>(TLeft left, IEnumerable<Guid> rightIds)
            where TLeft : BaseEntity
            where TRight : BaseEntity;
        ISeedBuilder AddJoinData<TLeft, TRight>(TLeft left, Guid rightId)
            where TLeft : BaseEntity
            where TRight : BaseEntity;
    }

    public class SeedBuilder : ISeedBuilder
    {
        private ReferenceDatabase Database { get; }

        public SeedBuilder(ReferenceDatabase database)
        {
            Database = database;
        }

        public ISeedBuilder AddData<TEntity>(IEnumerable<TEntity> entities)
           where TEntity : class
        {
            foreach(TEntity entity in entities)
            {
                AddData(entity);
            }
            return this;
        }

        public ISeedBuilder AddData<TEntity>(TEntity entity)
            where TEntity : class
        {
            Database.Set<TEntity>().Add(entity);
            return this;
        }

        public ISeedBuilder AddData(Type type, object entity)
        {
            MethodInfo method = Database
                .GetType()
                .GetMethod(nameof(DbContext.Set), Array.Empty<Type>())!
                .MakeGenericMethod(type);

            object dbSet = method.Invoke(Database, null)!;
            MethodInfo add = dbSet
                .GetType()
                .GetMethod("Add")!;

            add.Invoke(dbSet, new object[] { entity });
            return this;
        }

        public ISeedBuilder AddJoinData<TLeft, TRight>(TLeft left, IEnumerable<TRight> rights)
           where TLeft : BaseEntity
           where TRight : BaseEntity
        {
            return AddJoinData<TLeft, TRight>(left, rights.Select(e => e.Id));
        }

        public ISeedBuilder AddJoinData<TLeft, TRight>(TLeft left, Guid rightId)
           where TLeft : BaseEntity
           where TRight : BaseEntity
        { 
            return AddJoinData<TLeft, TRight>(left, new Guid[] { rightId });
        }
    
        public ISeedBuilder AddJoinData<TLeft, TRight>(TLeft left, IEnumerable<Guid> rightIds)
            where TLeft : BaseEntity
            where TRight : BaseEntity
        {
            IEntityType firstEntityType = Database.Model.FindEntityType(typeof(TLeft));
            IEntityType secondEntityType = Database.Model.FindEntityType(typeof(TRight));

            ISkipNavigation firstToSecond = GetFirstToSecondNavigation<TLeft, TRight>(firstEntityType, secondEntityType);

            IEntityType joinEntityType = firstToSecond.JoinEntityType;
            IProperty firstProperty = firstToSecond.ForeignKey.Properties.Single();
            IProperty secondProperty = firstToSecond.Inverse.ForeignKey.Properties.Single();
            IClrPropertyGetter firstValueGetter = firstToSecond.ForeignKey.PrincipalKey.Properties.Single().GetGetter();
            IClrPropertyGetter secondValueGetter = firstToSecond.Inverse.ForeignKey.PrincipalKey.Properties.Single().GetGetter();

            DbSet<Dictionary<string, object>> set = Database.Set<Dictionary<string, object>>(joinEntityType.GetTableName());
            foreach (Guid rightId in rightIds)
            {
                set.Add(new Dictionary<string, object>
                {
                    [firstProperty.Name] = left.Id,
                    [secondProperty.Name] = rightId
                });
            }

            return this;
        }

        private static ISkipNavigation GetFirstToSecondNavigation<TFirst, TSecond>(IEntityType firstEntityType, IEntityType secondEntityType)
        {
            ISkipNavigation[] skipNavigations1 = firstEntityType
                .GetSkipNavigations()
                .ToArray();

            ISkipNavigation[] skipNavigations2 = secondEntityType
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
    }
}
