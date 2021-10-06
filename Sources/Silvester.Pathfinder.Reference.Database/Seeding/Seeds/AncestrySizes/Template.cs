using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Models;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.AncestrySizes
{
    public abstract class Template : EntityTemplate<AncestrySize>
    {
        protected override AncestrySize GetEntity(ModelBuilder builder)
        {
            AncestrySize size = GetAncestrySize();
            return size;
        }

        protected abstract AncestrySize GetAncestrySize();
    }
}
