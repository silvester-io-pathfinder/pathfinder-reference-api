using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Models;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.PreciousMaterialItemCategories
{
    public abstract class Template : EntityTemplate<PreciousMaterialItemCategory>
    {
        protected override PreciousMaterialItemCategory GetEntity(ModelBuilder builder)
        {
            PreciousMaterialItemCategory category = GetCategory();

            return category;
        }

        public abstract PreciousMaterialItemCategory GetCategory();
    }
}
