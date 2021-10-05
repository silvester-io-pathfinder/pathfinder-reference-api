using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Models;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Stats
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
