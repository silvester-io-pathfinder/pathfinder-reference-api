using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Immunities
{
    public abstract class Template : EntityTemplate<Immunity>
    {
        protected override Immunity GetEntity(ISeedBuilder builder)
        {
            Immunity immunity = GetHazardImmunity();
            return immunity;
        }

        protected abstract Immunity GetHazardImmunity();
    }
}
