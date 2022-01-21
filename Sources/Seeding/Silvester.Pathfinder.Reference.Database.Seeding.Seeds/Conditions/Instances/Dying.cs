using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Conditions.Instances
{
    public class Dying : Template
    {
        public static readonly Guid ID = Guid.Parse("069fffa5-3fe0-4892-a04d-1bd28a6225a3");

        public override Condition GetCondition()
        {
            return new Condition
            {
                Id = ID,
                Name = "Dying",
                ConditionCategoryId = ConditionCategories.Instances.DeathAndDying.ID
            };
        }

        public override IEnumerable<TextBlock> GetConditionDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("cbf8d506-afc9-41c1-9d3f-22372c9a3bc3"), Type = Utilities.Text.TextBlockType.Text, Text = "You are bleeding out or otherwise at death's door. While you have this condition, you are unconscious. Dying always includes a value, and if it ever reaches dying 4, you die. If you're dying, you must attempt a recovery check (page 459) at the start of your turn each round to determine whether you get better or worse. Your dying condition increases by 1 if you take damage while dying, or by 2 if you take damage from an enemy's critical hit or a critical failure on your save." };
            yield return new TextBlock { Id = Guid.Parse("83f9a4be-3255-4103-a0f9-d5517de0b245"), Type = Utilities.Text.TextBlockType.Text, Text = "If you lose the dying condition by succeeding at a recovery check and are still at 0 Hit Points, you remain unconscious, but you can wake up as described in that condition. You lose the dying condition automatically and wake up if you ever have 1 Hit Point or more. Any time you lose the dying condition, you gain the wounded 1 condition, or increase your wounded condition value by 1 if you already have that condition." };
        }

        /*public override IEnumerable<TextBlock> GetConditionDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("522f0c99-e56b-4848-9adf-6579947713a2"), Type = TextBlockType.Heading, Text = "Death and Dying Rules"};
            yield return new TextBlock { Id = Guid.Parse("c4e5deec-51aa-4e93-92e1-9dda14f2d903"), Text = "The doomed, dying, unconscious, and wounded conditions all relate to the process of coming closer to death. The full rules are on pages 459–461. The most significant information not contained in the conditions themselves is this: When you're reduced to 0 Hit Points, you're knocked out with the following effects:", Type = TextBlockType.Text };
            yield return new TextBlock { Id = Guid.Parse("ee821b5c-04d4-4212-8f37-98b8a827cff5"), Text = "You immediately move your initiative position to directly before the turn in which you were reduced to 0 HP.”", Type = TextBlockType.Enumeration };
            yield return new TextBlock { Id = Guid.Parse("44052fce-df27-49bc-bc37-537fd6f0a7b0"), Text = "You gain the dying 1 condition. If the effect that knocked you out was a critical success from the attacker or the result of your critical failure, you gain the dying 2 condition instead. If you have the wounded condition, increase these values by your wounded value. If the damage came from a nonlethal attack or effect, you don't gain the dying condition— you are instead unconscious with 0 Hit Points.", Type = TextBlockType.Enumeration};
        }*/

        public override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e7e4aa12-dadc-426b-8b3c-24a60d4abb25"),
                SourceId = CoreRulebook.ID,
                Page = 619
            };
        }
    }
}
