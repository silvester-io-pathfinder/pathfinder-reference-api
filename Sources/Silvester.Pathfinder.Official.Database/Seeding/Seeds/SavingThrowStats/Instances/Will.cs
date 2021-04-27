using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.SavingThrowStats.Instances
{
    public class Will : AbstractSavingThrowStatTemplate
    {
        public static readonly Guid ID = Guid.Parse("a71929b0-9dff-492a-9bf9-8f9cadda198c");

        public override SavingThrowStat GetSavingThrowStat()
        {
            return new SavingThrowStat 
            {
                Id = ID, 
                Name = "Will" 
            };
        }

        public override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c6213214-61d9-4f42-b3bd-6cad3d69df09"), Type = TextBlockType.Text, Text = "Will saving throws measure how well you can resist attacks to your mind and spirit. They use your Wisdom modifier and are calculated as shown in the formula below." };
            yield return new TextBlock { Id = Guid.Parse("78900027-b7dc-42e8-b5bd-e2da081f7356"), Type = TextBlockType.Example, Text = "Will Saving Throw = d20 + Wisdom Modifier + Proficiency Bonus + Other Bonuses + Other Penalties" };
        }
    }
}
