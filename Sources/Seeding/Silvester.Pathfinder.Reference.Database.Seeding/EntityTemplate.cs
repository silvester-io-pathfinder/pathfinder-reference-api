using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Silvester.Pathfinder.Reference.Database.Seeding
{
    public interface IEntityTemplate<out TEntity> 
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

        protected string ToMarkdownLink<TReference>(string displayText, Guid entityId)
        {
            return $"[{displayText}]({GetCollectionName<TReference>()}/{entityId.ToString("d")})";
        }

        private string GetCollectionName<TReference>()
        {
            return typeof(ReferenceDatabase)
                .GetProperties()
                .First(e => e.PropertyType == typeof(DbSet<>).MakeGenericType(typeof(Models.Entities.Spell)))
                .Name;
        }
    }
}
