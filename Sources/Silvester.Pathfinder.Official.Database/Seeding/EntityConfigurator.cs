using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using System;
using System.Linq;

namespace Silvester.Pathfinder.Official.Database.Seeding
{
    public class EntityConfigurator<TEntity>
        where TEntity : BaseEntity
    {
        public virtual void Configure(ModelBuilder builder)
        {
            if (typeof(TEntity).GetInterfaces().Contains(typeof(IOwnedEntity)))
            {
                builder.Owned<TEntity>();
            }
            else
            {
                builder.Entity<TEntity>().HasBaseEntityKey();
            }
        }
    }
}
