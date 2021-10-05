using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Conditions.Instances
{
    public class Deafened : Template
    {
        public static readonly Guid ID = Guid.Parse("31b26b64-2616-4d23-93de-f3dbc0c81b7d");

        public override Condition GetCondition()
        {
            return new Condition
            {
                Id = ID,
                Name = "Deafened",
                ConditionCategoryId = ConditionCategories.Instances.Senses.ID
            };
        }

        public override IEnumerable<TextBlock> GetConditionDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9403c4ab-8ecf-4cba-921d-33164c193893"), Type = Utilities.Text.TextBlockType.Text, Text = "You can’t hear. You automatically critically fail Perception checks that require you to be able to hear. You take a –2 status penalty to Perception checks for initiative and checks that involve sound but also rely on other senses. If you perform an action with the auditory trait, you must succeed at a DC 5 flat check or the action is lost; attempt the check after spending the action but before any effects are applied. You are immune to auditory effects." };
        }

        public override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("649223d0-1602-442a-8751-34c050b98392"),
                SourceId = CoreRulebook.ID,
                Page = 619
            };
        }
    }
}
