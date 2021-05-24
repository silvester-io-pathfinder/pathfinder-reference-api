using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.WeaponGroups
{
    public abstract class Template : EntityTemplate<WeaponGroup>
    {
        protected override WeaponGroup GetEntity(ModelBuilder builder)
        {
            WeaponGroup group = GetWeaponGroup();

            builder.AddSourcePage(group, GetSourcePage(), e => e.SourcePageId);

            return group;
        }

        protected abstract WeaponGroup GetWeaponGroup();
        protected abstract SourcePage GetSourcePage();
    }
}
