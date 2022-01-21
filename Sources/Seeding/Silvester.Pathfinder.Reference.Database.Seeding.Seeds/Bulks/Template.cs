using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Bulks
{
    public abstract class Template : EntityTemplate<Bulk>
    {
        protected override Bulk GetEntity(ISeedBuilder builder)
        {
            Bulk bulk = GetBulk();
            return bulk;
        }

        protected abstract Bulk GetBulk();
    }
}
