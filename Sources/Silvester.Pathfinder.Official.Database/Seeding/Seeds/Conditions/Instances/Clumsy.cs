using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Conditions.Instances
{
    public class Clumsy : Template
    {
        public static readonly Guid ID = Guid.Parse("740be8e2-cab8-4cbe-8065-fd71a6d2192e");

        public override Condition GetCondition()
        {
            return new Condition
            {
                Id = ID,
                Name = "Clumsy",
                ConditionCategoryId = ConditionCategories.Instances.LoweredAbilities.ID,
            };
        }

        public override IEnumerable<TextBlock> GetConditionDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9d44223c-e20f-49a7-b374-528d6c21e714"), Type = Utilities.Text.TextBlockType.Text, Text = "Your movements become clumsy and inexact. Clumsy always includes a value. You take a status penalty equal to the condition value to Dexterity-based checks and DCs, including AC, Reflex saves, ranged attack rolls, and skill checks using Acrobatics, Stealth, and Thievery." };
        }

        public override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b52512cc-bfab-429f-a40d-a0488043a296"),
                SourceId = CoreRulebook.ID,
                Page = 618
            };
        }
    }
}
