using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.HazardTypes
{
    public abstract class Template : EntityTemplate<HazardType>
    {
        protected override HazardType GetEntity(ModelBuilder builder)
        {
            HazardType type = GetHazardType();

            builder.AddSourcePage(type, GetSourcePage(), e => e.SourcePageId);

            return type;
        }

        protected abstract HazardType GetHazardType();
        protected abstract SourcePage GetSourcePage();
    }
}
