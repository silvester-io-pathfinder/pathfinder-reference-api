using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;

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
            builder.AddData(entity);
            return entity;
        }

        protected abstract TEntity GetEntity(ModelBuilder builder);
    }
}
