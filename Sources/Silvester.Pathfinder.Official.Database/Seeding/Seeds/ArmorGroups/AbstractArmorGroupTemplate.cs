using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.ArmorGroups
{
    public abstract class AbstractArmorGroupTemplate : EntityTemplate<ArmorGroup>
    {
        protected override ArmorGroup GetEntity(ModelBuilder builder)
        {
            ArmorGroup armorGroup = GetArmorGroup();
            return armorGroup;
        }

        protected abstract ArmorGroup GetArmorGroup();
    }
}
