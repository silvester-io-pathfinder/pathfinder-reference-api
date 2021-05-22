using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Stats
{
    public abstract class Template : EntityTemplate<Stat>
    {
        protected override Stat GetEntity(ModelBuilder builder)
        {
            Stat stat = GetStat();
            return stat;
        }

        protected abstract Stat GetStat();
    }
}
