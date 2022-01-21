using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.HazardComplexities
{
    public abstract class Template : EntityTemplate<HazardComplexity>
    {
        protected override HazardComplexity GetEntity(ISeedBuilder builder)
        {
            HazardComplexity complexity = GetHazardComplexity();
            return complexity;
        }

        protected abstract HazardComplexity GetHazardComplexity();
    }
}
