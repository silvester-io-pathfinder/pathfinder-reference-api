using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.DeityCategories
{
    public abstract class AbstractDeityCategoryTemplate : EntityTemplate<DeityCategory>
    {
        protected override DeityCategory GetEntity(ModelBuilder builder)
        {
            DeityCategory category = GetCategory();
            return category;
        }

        protected abstract DeityCategory GetCategory();
    }
}
