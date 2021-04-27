using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.SavingThrowStats
{
    public abstract class AbstractSavingThrowStatTemplate : EntityTemplate<SavingThrowStat>
    {
        protected override SavingThrowStat GetEntity(ModelBuilder builder)
        {
            SavingThrowStat stat = GetSavingThrowStat();

            builder.AddTextBlocks(stat, GetDetailBlocks(), e => e.Details);

            return stat;
        }

        public abstract SavingThrowStat GetSavingThrowStat();
        public abstract IEnumerable<TextBlock> GetDetailBlocks();
    }
}
