using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Bulks
{
    public abstract class AbstractBulkTemplate :EntityTemplate<Bulk>
    {
        protected override Bulk GetEntity(ModelBuilder builder)
        {
            Bulk bulk = GetBulk();
            return bulk;
        }

        protected abstract Bulk GetBulk();
    }
}
