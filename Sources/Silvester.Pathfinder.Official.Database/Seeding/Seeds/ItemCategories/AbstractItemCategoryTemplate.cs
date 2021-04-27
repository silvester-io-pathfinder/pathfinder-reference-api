using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.ItemCategories
{
    public abstract class AbstractItemCategoryTemplate : EntityTemplate<ItemCategory>
    {
        protected override ItemCategory GetEntity(ModelBuilder builder)
        {
            ItemCategory category = GetItemCategory();
            return category;
        }

        protected abstract ItemCategory GetItemCategory();
    }
}
