using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Extensions;
using System;
using System.Reflection;

namespace Silvester.Pathfinder.Reference.Database.Seeding
{
    public interface IEntityTemplate<TEntity> 
        where TEntity : BaseEntity
    {
        TEntity Seed(ISeedBuilder builder);
    }

    public abstract class EntityTemplate<TEntity> : IEntityTemplate<TEntity>
        where TEntity : BaseEntity
    {
        public TEntity Seed(ISeedBuilder builder)
        {
            TEntity entity = GetEntity(builder);
            builder.AddData(entity);
            return entity;
        }

        protected abstract TEntity GetEntity(ISeedBuilder builder);
    }
}