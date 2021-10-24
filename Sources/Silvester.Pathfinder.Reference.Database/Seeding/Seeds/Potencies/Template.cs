using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Potencies
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
