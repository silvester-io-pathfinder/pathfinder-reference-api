using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DeityCategories
{
    public abstract class Template : EntityTemplate<DeityCategory>
    {
        protected override DeityCategory GetEntity(ModelBuilder builder)
        {
            DeityCategory category = GetCategory();
            return category;
        }

        protected abstract DeityCategory GetCategory();
    }
}
