using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.FeatTypes
{
    public abstract class AbstractFeatTypeTemplate : EntityTemplate<FeatType>
    {
        protected override FeatType GetEntity(ModelBuilder builder)
        {
            FeatType type = GetAction();
            return type;
        }

        protected abstract FeatType GetAction();
    }
}
