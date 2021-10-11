using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Abilities.Instances
{
    public class ShieldBlock : Template
    {
        public static readonly Guid ID = Guid.Parse("198dac8d-54c1-49f3-a0d9-48100e10d396");

        protected override Ability GetAbility()
        {
            return new Ability
            {
                Id = ID,
                Name = "Shield Block",
                Trigger = "The monster has its shield raised and takes damage from a physical attack.",
                ActionTypeId = ActionTypes.Instances.Reaction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetEffects()
        {
            yield return new TextBlock { Id = Guid.Parse("ad66e97c-6d09-4c8f-98d0-b8597812184a"), Text = " The monster snaps its shield into place to deflect a blow. The shield prevents the monster from taking an amount of damage up to the shield�s Hardness. The monster and the shield each take any remaining damage, possibly breaking or destroying the shield." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("556541b6-bc17-45dc-9760-0b967e5e5cd9"),
                SourceId = Sources.Instances.Bestiary.ID,
                Page = 344
            };
        }
    }
}
