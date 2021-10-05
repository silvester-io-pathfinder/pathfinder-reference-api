using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Models;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Bulks
{
    public abstract class Template : EntityTemplate<Bulk>
    {
        protected override Bulk GetEntity(ModelBuilder builder)
        {
            Bulk bulk = GetBulk();
            return bulk;
        }

        protected abstract Bulk GetBulk();
    }
}
