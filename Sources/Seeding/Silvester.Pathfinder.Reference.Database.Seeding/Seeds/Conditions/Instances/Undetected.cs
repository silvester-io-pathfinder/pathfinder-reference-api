using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Conditions.Instances
{
    public class Undetected : Template
    {
        public static readonly Guid ID = Guid.Parse("d7416bc0-79b9-42c0-9335-e420dd3e0f50");

        public override Condition GetCondition()
        {
            return new Condition
            {
                Id = ID,
                Name = "Undetected",
                ConditionCategoryId = ConditionCategories.Instances.DegreesOfDetection.ID,
            };
        }

        public override IEnumerable<TextBlock> GetConditionDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("08040555-c8af-43ef-bd71-ba3500bf3ff4"), Type = Utilities.Text.TextBlockType.Text, Text = "When you are undetected by a creature, that creature cannot see you at all, has no idea what space you occupy, and can't target you, though you still can be affected by abilities that target an area. When you're undetected by a creature, that creature is flat-footed to you." };
            yield return new TextBlock { Id = Guid.Parse("379e4285-0155-4d1d-a2e3-5fb70df0a394"), Type = Utilities.Text.TextBlockType.Text, Text = "A creature you're undetected by can guess which square you're in to try targeting you. It must pick a square and attempt an attack. This works like targeting a hidden creature (requiring a DC 11 flat check, as described on page 466), but the flat check and attack roll are rolled in secret by the GM, who doesn't reveal whether the attack missed due to failing the flat check, failing the attack roll, or choosing the wrong square." };
            yield return new TextBlock { Id = Guid.Parse("a411f8ea-e37b-4cc7-a8c2-0dfb167537f7"), Type = Utilities.Text.TextBlockType.Text, Text = "A creature can use the Seek action to try to find you, as described on page 471." };
        }

        public override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8cbcb7fb-2032-4b91-a811-46753e66f848"),
                SourceId = CoreRulebook.ID,
                Page = 623
            };
        }
    }
}
