using Microsoft.EntityFrameworkCore;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Configurations
{
    public class OwnedEntityConfiguration<TEntity> : IEntityConfiguration<TEntity>
        where TEntity : BaseEntity
    {
        public void Configure(ModelBuilder builder)
        {
            builder
                .Owned<TEntity>();
        }
    }
}
