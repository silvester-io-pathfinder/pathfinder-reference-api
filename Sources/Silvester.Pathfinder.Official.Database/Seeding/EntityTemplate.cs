using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Reflection;

namespace Silvester.Pathfinder.Official.Database.Seeding
{
    public interface IEntityTemplate<TEntity> 
        where TEntity : BaseEntity
    {
        TEntity Seed(ModelBuilder builder);
    }

    public abstract class EntityTemplate<TEntity> : IEntityTemplate<TEntity>
        where TEntity : BaseEntity
    {
        public TEntity Seed(ModelBuilder builder)
        {
            TEntity entity = GetEntity(builder);

            VerifySourcePageId(entity);

            builder.AddData(entity);
            return entity;
        }

        private static void VerifySourcePageId(TEntity entity)
        {
            PropertyInfo? sourcePageIdProperty = typeof(TEntity).GetProperty("SourcePageId");

            if (sourcePageIdProperty != null)
            {
                Guid? sourcePageId = (Guid?) sourcePageIdProperty.GetValue(entity);
                if (sourcePageId == new Guid())
                {
                    //Console.WriteLine("Should not happen.");
                }
            }
        }

        protected abstract TEntity GetEntity(ModelBuilder builder);
    }
}
