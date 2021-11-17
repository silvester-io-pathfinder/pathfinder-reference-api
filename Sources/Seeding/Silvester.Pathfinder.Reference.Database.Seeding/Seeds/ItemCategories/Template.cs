using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ItemCategories
{
    public abstract class Template : EntityTemplate<ItemCategory>
    {
        protected override ItemCategory GetEntity(ISeedBuilder builder)
        {
            ItemCategory category = GetItemCategory();
            return category;
        }

        protected abstract ItemCategory GetItemCategory();
    }
}
