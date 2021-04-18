using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
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

            TextBlock[] details = GetConditionDetailBlocks().ToArray();
            for(int i = 0; i < details.Length; i ++)
            {
                TextBlock detail = details[i];
                detail.Order = i;
                detail.OwnerId = condition.Id;
                seeder.Builder.AddOwnedData((Condition o) => o.Details, detail);
            }

            seeder.Builder.AddData(condition);
        }

        public abstract Condition GetCondition(ConditionSeeder seeder);
        public abstract SourcePage? GetSourcePage(ConditionSeeder seeder);

        public virtual IEnumerable<TextBlock> GetConditionDetailBlocks()
        {
            yield break;
        }
    }
}
