using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Models;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.LoreCategories
{
    public abstract class Template : EntityTemplate<LoreCategory>
    {
        protected override LoreCategory GetEntity(ModelBuilder builder)
        {
            LoreCategory category = GetLoreCategory();
            return category;
        }

        protected abstract LoreCategory GetLoreCategory();
    }
}
