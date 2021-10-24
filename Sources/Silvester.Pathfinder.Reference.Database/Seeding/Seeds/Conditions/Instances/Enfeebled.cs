using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Conditions.Instances
{
    public class Enfeebled : Template
    {
        public static readonly Guid ID = Guid.Parse("f0366047-21ca-4f51-971e-4f7c72629b74");

        public override Condition GetCondition()
        {
            return new Condition
            {
                Id = ID,
                Name = "Enfeebled",
                ConditionCategoryId = ConditionCategories.Instances.LoweredAbilities.ID
            };
        }

        public override IEnumerable<TextBlock> GetConditionDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d07b32ec-d323-4126-a929-b8205acfdbb8"), Type = Utilities.Text.TextBlockType.Text, Text = "You’re physically weakened. Enfeebled always includes a value. When you are enfeebled, you take a status penalty equal to the condition value to Strength-based rolls and DCs, including Strength-based melee attack rolls, Strength-based damage rolls, and Athletics checks." };
        }

        public override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8014c08d-23c8-4525-8db4-79c4cef2f7e0"),
                SourceId = CoreRulebook.ID,
                Page = 619
            };
        }
    }
}
