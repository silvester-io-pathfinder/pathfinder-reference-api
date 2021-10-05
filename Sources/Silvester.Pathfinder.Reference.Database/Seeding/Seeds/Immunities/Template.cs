using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Models;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Immunities
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
