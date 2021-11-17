using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ArmorCategories
{
    public abstract class Template : EntityTemplate<ArmorCategory>
    {
        protected override ArmorCategory GetEntity(ISeedBuilder builder)
        {
            ArmorCategory category = GetArmorCategory();
            return category;
        }

        protected abstract ArmorCategory GetArmorCategory();
    }
}
