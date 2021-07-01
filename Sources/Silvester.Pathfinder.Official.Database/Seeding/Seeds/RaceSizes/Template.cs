using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Models;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.RaceSizes
{
    public abstract class Template : EntityTemplate<RaceSize>
    {
        protected override RaceSize GetEntity(ModelBuilder builder)
        {
            RaceSize size = GetRaceSize();
            return size;
        }

        protected abstract RaceSize GetRaceSize();
    }
}
