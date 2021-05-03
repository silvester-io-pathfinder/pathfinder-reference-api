using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System.Collections.Generic;
using System.Linq;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Conditions
{
    public abstract class AbstractConditionTemplate : EntityTemplate<Condition>
    {
        protected override Condition GetEntity(ModelBuilder builder)
        {
            Condition condition = GetCondition();
            
            SourcePage? sourcePage = GetSourcePage();
            if(sourcePage != null)
            {
                builder.AddData(sourcePage);
                condition.SourcePageId = sourcePage.Id;
            }

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
