using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponGroups
{
    public abstract class Template : EntityTemplate<WeaponGroup>
    {
        protected override WeaponGroup GetEntity(ISeedBuilder builder)
        {
            WeaponGroup group = GetWeaponGroup();

            builder.AddSourcePage(group, GetSourcePage(), e => e.SourcePageId);

            return group;
        }

        protected abstract WeaponGroup GetWeaponGroup();
        protected abstract SourcePage GetSourcePage();
    }
}
