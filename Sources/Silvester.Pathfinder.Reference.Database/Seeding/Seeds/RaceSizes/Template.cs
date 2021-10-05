using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Models;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.RaceSizes
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
