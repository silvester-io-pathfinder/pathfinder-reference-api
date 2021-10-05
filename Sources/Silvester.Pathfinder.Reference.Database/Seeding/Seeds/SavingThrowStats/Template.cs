using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SavingThrowStats
{
    public abstract class Template : EntityTemplate<SavingThrowStat>
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
