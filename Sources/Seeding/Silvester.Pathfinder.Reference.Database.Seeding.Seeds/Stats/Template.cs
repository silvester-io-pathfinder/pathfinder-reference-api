using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Stats
{
    public abstract class Template : EntityTemplate<Stat>
    {
        protected override Stat GetEntity(ISeedBuilder builder)
        {
            Stat stat = GetStat();
            return stat;
        }

        protected abstract Stat GetStat();
    }
}
