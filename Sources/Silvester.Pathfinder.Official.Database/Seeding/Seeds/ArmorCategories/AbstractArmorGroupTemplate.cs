using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.ArmorCategories
{
    public abstract class AbstractArmorGroupTemplate : EntityTemplate<ArmorCategory>
    {
        protected override ArmorCategory GetEntity(ModelBuilder builder)
        {
            ArmorCategory category = GetArmorCategory();
            return category;
        }

        protected abstract ArmorCategory GetArmorCategory();
    }
}
