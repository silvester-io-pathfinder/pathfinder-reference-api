using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Models;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.FeatTypes
{
    public abstract class Template : EntityTemplate<FeatType>
    {
        protected override FeatType GetEntity(ModelBuilder builder)
        {
            FeatType type = GetAction();
            return type;
        }

        protected abstract FeatType GetAction();
    }
}
