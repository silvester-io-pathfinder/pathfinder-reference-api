using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.AncestrySizes
{
    public abstract class Template : EntityTemplate<AncestrySize>
    {
        protected override AncestrySize GetEntity(ISeedBuilder builder)
        {
            AncestrySize size = GetAncestrySize();
            return size;
        }

        protected abstract AncestrySize GetAncestrySize();
    }
}
