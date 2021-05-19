using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Immunities
{
    public abstract class Template : EntityTemplate<Immunity>
    {
        protected override Immunity GetEntity(ModelBuilder builder)
        {
            Immunity immunity = GetHazardImmunity();
            return immunity;
        }

        protected abstract Immunity GetHazardImmunity();
    }
}
