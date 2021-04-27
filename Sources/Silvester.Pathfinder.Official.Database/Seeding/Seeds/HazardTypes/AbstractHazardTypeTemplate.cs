using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.HazardTypes
{
    public abstract class AbstractHazardTypeTemplate : EntityTemplate<HazardType>
    {
        protected override HazardType GetEntity(ModelBuilder builder)
        {
            HazardType type = GetHazardType();

            SourcePage sourcePage = GetSourcePage();
            type.SourcePageId = sourcePage.Id;
            builder.AddData(sourcePage);

            return type;
        }

        protected abstract HazardType GetHazardType();
        protected abstract SourcePage GetSourcePage();
    }
}
