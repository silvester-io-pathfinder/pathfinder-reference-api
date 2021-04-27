using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.SavingThrowStats.Instances
{
    public class Fortitude : AbstractSavingThrowStatTemplate
    {
        public static readonly Guid ID = Guid.Parse("83f532a1-dad3-4dc8-b13d-77e69959444a");

        public override SavingThrowStat GetSavingThrowStat()
        {
            return new SavingThrowStat 
            {
                Id = ID, 
                Name = "Fortitude" 
            };
        }

        public override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3b6fc2fa-73ab-4b02-b435-a6a9ae683458"), Type = TextBlockType.Text, Text = "Fortitude saving throws allow you to reduce the effects of abilities and afflictions that can debilitate the body. They use your Constitution modifier and are calculated as shown in the formula below." };
            yield return new TextBlock { Id = Guid.Parse("44536dd5-2014-4d02-8216-094b8d14bc9f"), Type = TextBlockType.Example, Text = "Fortitude Saving Throw = d20 + Constitution Modifier + Proficiency Bonus + Other Bonuses + Other Penalties" };
        }
    }
}
