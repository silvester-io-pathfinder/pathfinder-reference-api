using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Ammunitions
{
    public abstract class Template : EntityTemplate<Ammunition>
    {
        protected override Ammunition GetEntity(ModelBuilder builder)
        {
            Ammunition ammunition = GetAmmunition();

            builder.AddSourcePage(ammunition, GetSourcePage(), e => e.SourcePageId);

            return ammunition;
        }

        protected abstract SourcePage GetSourcePage();
        protected abstract Ammunition GetAmmunition();
    }
}
