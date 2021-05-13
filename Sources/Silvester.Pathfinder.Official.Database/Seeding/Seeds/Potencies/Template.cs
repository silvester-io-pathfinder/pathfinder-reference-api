using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Potencies
{
    public abstract class Template : EntityTemplate<Potency>
    {
        protected override Potency GetEntity(ModelBuilder builder)
        {
            Potency potency = GetPotency();
            return potency;
        }

        protected abstract Potency GetPotency();
    }
}
