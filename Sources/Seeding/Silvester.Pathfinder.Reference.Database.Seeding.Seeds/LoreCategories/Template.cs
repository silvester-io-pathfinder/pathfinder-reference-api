using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.LoreCategories
{
    public abstract class Template : EntityTemplate<LoreCategory>
    {
        protected override LoreCategory GetEntity(ISeedBuilder builder)
        {
            LoreCategory category = GetLoreCategory();
            return category;
        }

        protected abstract LoreCategory GetLoreCategory();
    }
}
