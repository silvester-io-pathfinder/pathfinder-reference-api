using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.PreciousMaterialObjectCategories
{
    public abstract class Template : EntityTemplate<PreciousMaterialObjectCategory>
    {
        protected override PreciousMaterialObjectCategory GetEntity(ISeedBuilder builder)
        {
            PreciousMaterialObjectCategory category = GetCategory();

            return category;
        }

        public abstract PreciousMaterialObjectCategory GetCategory();
    }
}
