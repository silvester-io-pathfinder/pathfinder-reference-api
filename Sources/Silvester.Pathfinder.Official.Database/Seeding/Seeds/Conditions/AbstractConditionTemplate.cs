using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Conditions
{
    public abstract class AbstractConditionTemplate
    {
        public void Seed(ConditionSeeder seeder)
        {
            Condition condition = GetCondition(seeder);
            
            SourcePage? sourcePage = GetSourcePage(seeder);
            if(sourcePage != null)
            {
                seeder.Builder.AddData(sourcePage);
                condition.SourcePageId = sourcePage.SourceId;
            }

            foreach (ConditionDetailBlock detailBlock in GetConditionDetailBlocks())
            {
                detailBlock.ConditionId = condition.Id;
                seeder.Builder.AddData(detailBlock);
            }

            seeder.Builder.AddData(condition);
        }

        public abstract Condition GetCondition(ConditionSeeder seeder);
        public abstract SourcePage? GetSourcePage(ConditionSeeder seeder);

        public virtual IEnumerable<ConditionDetailBlock> GetConditionDetailBlocks()
        {
            yield break;
        }
    }
}
