using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Conditions
{
    public abstract class Template : EntityTemplate<Condition>
    {
        protected override Condition GetEntity(ModelBuilder builder)
        {
            Condition condition = GetCondition();

            builder.AddSourcePage(condition, GetSourcePage(), e => e.SourcePageId);
            builder.AddTextBlocks(condition, GetConditionDetailBlocks(), e => e.Details);

            return condition;
        }

        public abstract Condition GetCondition();
        public abstract SourcePage? GetSourcePage();

        public virtual IEnumerable<TextBlock> GetConditionDetailBlocks()
        {
            yield break;
        }
    }
}
