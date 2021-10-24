using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Abilities.Instances
{
    public class NegativeHealing : Template
    {
        public static readonly Guid ID = Guid.Parse("8255f15e-44f2-4ad6-b80b-cf666e19e758");

        protected override Ability GetAbility()
        {
            return new Ability
            {
                Id = ID,
                Name = "Negative Healing",
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetEffects()
        {
            yield return new TextBlock { Id = Guid.Parse("1e4fa8b2-3c2e-44bc-bb0f-0aca582157f7"), Text = "A creature with negative healing draws health from negative energy rather than positive energy. It is damaged by positive damage and is not healed by positive healing effects. It does not take negative damage, and it is healed by negative effects that heal undead." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cf2c81c4-4b22-438b-9e43-2494d6dbe5fa"),
                SourceId = Sources.Instances.Bestiary2.ID,
                Page = 305
            };
        }
    }
}
