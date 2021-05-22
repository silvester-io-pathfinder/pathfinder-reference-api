using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.HazardComplexities
{
    public abstract class Template : EntityTemplate<HazardComplexity>
    {
        protected override HazardComplexity GetEntity(ModelBuilder builder)
        {
            HazardComplexity complexity = GetHazardComplexity();
            return complexity;
        }

        protected abstract HazardComplexity GetHazardComplexity();
    }
}
