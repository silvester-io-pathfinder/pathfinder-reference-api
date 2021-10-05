using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Models;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.PreciousMaterialItemCategories
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
