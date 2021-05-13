using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.HazardImmunities
{
    public abstract class Template : EntityTemplate<HazardImmunity>
    {
        protected override HazardImmunity GetEntity(ModelBuilder builder)
        {
            HazardImmunity immunity = GetHazardImmunity();
            return immunity;
        }

        protected abstract HazardImmunity GetHazardImmunity();
    }
}
