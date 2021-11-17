using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.HazardTypes
{
    public abstract class Template : EntityTemplate<HazardType>
    {
        protected override HazardType GetEntity(ISeedBuilder builder)
        {
            HazardType type = GetHazardType();

            builder.AddSourcePage(type, GetSourcePage(), e => e.SourcePageId);

            return type;
        }

        protected abstract HazardType GetHazardType();
        protected abstract SourcePage GetSourcePage();
    }
}
