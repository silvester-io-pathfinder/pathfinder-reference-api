using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ArmorGroups
{
    public abstract class Template : EntityTemplate<ArmorGroup>
    {
        protected override ArmorGroup GetEntity(ModelBuilder builder)
        {
            ArmorGroup group = GetArmorGroup();

            builder.AddSourcePage(group, GetSourcePage(), e => e.SourcePageId);

            return group;
        }

        protected abstract SourcePage GetSourcePage();
        protected abstract ArmorGroup GetArmorGroup();
    }
}
