using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.SavingThrowStats.Instances
{
    public class Reflex : Template
    {
        public static readonly Guid ID = Guid.Parse("5048e38a-a47c-4832-b37f-fd3818eced35");

        public override SavingThrowStat GetSavingThrowStat()
        {
            return new SavingThrowStat 
            {
                Id = ID, 
                Name = "Reflex" 
            };
        }

        public override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0247a36f-161f-4faf-8486-cc48fd55b554"), Type = TextBlockType.Text, Text = "Reflex saving throws measure how well you can respond quickly to a situation and how gracefully you can avoid effects that have been thrown at you. They use your Dexterity modifier and are calculated as shown in the formula below." };
            yield return new TextBlock { Id = Guid.Parse("e26a1fa8-a6b7-4703-9618-ce10204b5e1e"), Type = TextBlockType.Example, Text = "Reflex Saving Throw = d20 + Dexterity Modifier + Proficiency Bonus + Other Bonuses + Other Penalties" };
        }
    }
}
